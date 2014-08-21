using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Utility;
using Microsoft.Win32;

namespace FukjTabletSystem.Application.Boundary.Common
{
    /// <summary>
    /// 拡張フォルダ選択ダイアログ
    /// </summary>
    public partial class FolderDialog : Form
    {
        #region 定数(private)

        const MessageBoxButtons BTN_OK = MessageBoxButtons.OK;
        const MessageBoxIcon ICON_EXC = MessageBoxIcon.Exclamation;
        const string DEF_HEIGHT = "366";
        const string DEF_WIDTH = "398";
        const string ITEM_HEIGHT = "Height";
        const string ITEM_WIDTH = "Width";
        const string MSG_TTL = "フォルダー参照";
        const string SKEY = @"software\VB and VBA Program Settings\Clikington\FolderDlg";

        #endregion

        #region プロパティ

        /// <summary>
        /// 選択されたパス
        /// </summary>
        public string SelectedPath
        {
            get { return _path; }
            set { _path = value; }
        }

        #endregion
        
        #region フィールド(private)

        private enum ImageList
        {
            Floppy = 0,
            Drive = 1,
            Folder = 2,
            cd = 3
        };

        private bool _enableEvent = false;

        private string _path = String.Empty;

        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FolderDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region イベントハンドラ

        #region btnOK_Click(object sender, EventArgs e)
        /// <summary> [OK]ボタンクリックイベント </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // _path：[trView_AfterSelect]イベントで取得する
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Form_Load(object sender, EventArgs e)
        /// <summary> [Form_Load]イベント </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ImageList tempList = new System.Windows.Forms.ImageList();
            tempList.ImageSize = new Size((int)(imgList.ImageSize.Height * 2), (int)(imgList.ImageSize.Width * 2));

            for (int i = 0; i < imgList.Images.Count; i++)
            {
                // 高画質リサイズ
                int w = (int)((float)imgList.Images[i].Width * 2);
                int h = (int)((float)imgList.Images[i].Height * 2);
                Bitmap dest = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(dest);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgList.Images[i], 0, 0, w, h);

                tempList.Images.Add(dest);
            }

            imgList = tempList;

            InitializeForm();
        }
        #endregion

        #region Form_Resize(object sender, EventArgs e)
        /// <summary> [Form_Resize]イベント </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Resize(object sender, EventArgs e)
        {
            RegUtils.SetRegistry(SKEY, ITEM_HEIGHT, this.Height.ToString());
            RegUtils.SetRegistry(SKEY, ITEM_WIDTH, this.Width.ToString());
        }
        #endregion

        #region trView_AfterSelect(object sender, TreeViewEventArgs e)
        /// <summary> [trView_AfterSelect]イベント 
        /// このイベントで選択されたノードのフルパスを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_enableEvent)
                _path = e.Node.FullPath.Replace(@"\\", @"\");
        }
        #endregion

        #region trView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        /// <summary> [trView_BeforeExpand]イベント </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            SetChildNode(e.Node);
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region GetChildNode(TreeNode vnode, string vtext)
        /// <summary> [GetChildNode]引数文字列のノードを取得して展開するメソッド
        /// [SelectNode]から呼出し
        /// </summary>
        /// <param name="vnode"></param>
        /// <param name="vtext"></param>
        /// <returns></returns>
        private TreeNode GetChildNode(TreeNode vnode, string vtext)
        {
            SetChildNode(vnode);
            foreach (TreeNode node in vnode.Nodes)
            {
                if (node.Text == vtext)
                {
                    node.Expand();
                    return node;
                }
            }
            return null;
        }
        #endregion

        #region InitializeForm()
        /// <summary> [InitializeForm]メソッド
        /// [Form_Load]から呼出し
        /// </summary>
        private void InitializeForm()
        {
            this.Height = Int32.Parse(RegUtils.GetRegistry(SKEY, ITEM_HEIGHT, DEF_HEIGHT));
            this.Width = Int32.Parse(RegUtils.GetRegistry(SKEY, ITEM_WIDTH, DEF_WIDTH));
            trView.ImageList = imgList;
            _enableEvent = false;          // [trView_AfterSelect]イベントを無効化
            SetDrives();                   // ドライブのNode作成
            SelectNode();                  // 指定パスのフォルダーを選択
            _enableEvent = true;           // [trView_AfterSelect]イベントを有効化
        }
        #endregion

        #region SelectNode()
        /// <summary> [SelectNode]：[Form_Load]時に指定されたパスのNodeを選択するメソッド
        /// [InitializeForm]から呼出し
        /// </summary>
        private void SelectNode()
        {
            if (_path.Length == 0) return;
            if (!Directory.Exists(_path)) return;

            try
            {
                string[] snodes = _path.Split('\\');
                var tn = new TreeNode();
                // 対象パスのルートノードを取得する
                foreach (TreeNode node in trView.Nodes)
                {
                    if (node.Text == snodes[0] + @"\")
                    {
                        tn = node;
                        tn.Expand();
                        break;
                    }
                }
                if (tn.Text.Length == 0)  // ルートノードが見つからなかった場合は、return                
                    return;
                

                // 子ノードを取得する
                for (int i = 1; i < snodes.Length; i++)
                {
                    tn = GetChildNode(tn, snodes[i]);
                    if (tn == null)   // 通常、この事態(パスが存在しない状態)は発生しない
                    {
                        //MessageBox.Show("このノードは存在しません。", MSG_TTL,
                        //    BTN_OK, ICON_EXC);
                        break;
                    }
                }

                trView.SelectedNode = tn;  // ここでNodeが選択される
                trView.Focus();
            }
            catch { }
        }
        #endregion

        #region SetChildNode(TreeNode vnode)
        /// <summary> [SetChildNode]メソッド
        /// [trView_BeforeExpand],[GetChildNode]から呼出し
        /// </summary>
        /// <param name="vnode"></param>
        private void SetChildNode(TreeNode vnode)
        {
            try
            {                
                vnode.Nodes.Clear();    // ダミーノードをクリア
                DirectoryInfo dinfo = new DirectoryInfo(vnode.FullPath);
                if (dinfo.Exists)
                {
                    DirectoryInfo[] sinfos = dinfo.GetDirectories();
                    foreach (DirectoryInfo sinfo in sinfos)
                    {
                        // サブディレクトリをノードに追加
                        TreeNode tn = vnode.Nodes.Add(sinfo.Name);
                        // ImageListの画像指定
                        tn.ImageIndex = (int)ImageList.Folder;
                        tn.SelectedImageIndex = (int)ImageList.Folder;
                        // ダミーノード追加
                        try
                        {
                            DirectoryInfo[] ssinfos = sinfo.GetDirectories();
                            if (ssinfos.Length > 0)
                                tn.Nodes.Add("dummy");
                        }
                        catch 
                        { }
                    }
                }
                //else
                //{
                //    string msg = dinfo.Root.Name + "にディスクを挿入してください。";
                //    MessageBox.Show(msg, MSG_TTL, BTN_OK, ICON_EXC);
                //}
            }
            catch (Exception ex)
            {
                TabMessageBox.Show2(TabMessageBox.Type.Warn, MSG_TTL, ex.Message);
            }
        }
        #endregion

        #region SetDrives()
        /// <summary> [SetDrives]：ドライブのNodeを作成する
        /// [InitializeForm]から呼出し
        /// </summary>
        private void SetDrives()
        {
            trView.Nodes.Clear();

            DriveInfo[] dinfos = DriveInfo.GetDrives();
            
            foreach (DriveInfo dinfo in dinfos)
            {
                TreeNode node = this.trView.Nodes.Add(dinfo.Name);
                if (dinfo.Name == @"A:\")
                {
                    node.ImageIndex = (int)ImageList.Floppy;
                    node.SelectedImageIndex = (int)ImageList.Floppy;
                }
                else if (dinfo.DriveType == DriveType.CDRom)
                {
                    node.ImageIndex = (int)ImageList.cd;
                    node.SelectedImageIndex = (int)ImageList.cd;
                }
                else
                {
                    node.ImageIndex = (int)ImageList.Drive;
                    node.SelectedImageIndex = (int)ImageList.Drive;
                }
                DirectoryInfo subInfo = dinfo.RootDirectory;
                if (subInfo.Exists)
                    node.Nodes.Add("dummy");
            }
        }
        #endregion

        #endregion
    }

    /// <summary>
    /// レジストリ操作クラス（仮）※使うならApplication.Utilityに移動する
    /// </summary>
    class RegUtils
    {
        #region GetRegistry(string vkey, string vitem, string vdef)
        /// <summary> [GetRegistry]メソッド </summary>
        /// <param name="vkey"></param>
        /// <param name="vitem"></param>
        /// <param name="vdef">既定値</param>
        /// <returns></returns>
        public static string GetRegistry(string vkey, string vitem, string vdef)
        {
            string data = vdef;
            try
            {
                RegistryKey skey = Registry.CurrentUser.OpenSubKey(vkey);
                if (skey == null)
                    skey = Registry.CurrentUser.CreateSubKey(vkey);
                try
                {
                    data = (string)skey.GetValue(vitem);
                }
                catch { }
                skey.Close();
            }
            catch { }

            if (data == null) data = vdef;
            return data;
        }
        #endregion

        #region SetRegistry(string vkey, string vitem, string vdata)
        /// <summary> [SetRegistry]メソッド </summary>
        /// <param name="vkey"></param>
        /// <param name="vitem"></param>
        /// <param name="vdata"></param>
        public static void SetRegistry(string vkey, string vitem, string vdata)
        {
            if (vkey.Length * vitem.Length != 0)
            {
                RegistryKey skey = Registry.CurrentUser.CreateSubKey(vkey);
                skey.SetValue(vitem, vdata);
                skey.Close();
            }
        }
        #endregion
    }
}
