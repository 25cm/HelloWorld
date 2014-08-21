using System;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;
using FukjTabletSystem.Controls;

namespace FukjTabletSystem.Application.Boundary.Demo
{
    public partial class MonitoringForm : TabBaseFormHoriz
    {
        #region フォームデータ定義

        public class MonitoringFormData : FormData
        {
            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);
            }
        }

        #endregion

        public MonitoringForm()
        {
            InitializeComponent();
        }

        public override FormData InitFormData()
        {
            FormData ret = new MonitoringFormData();
            ret.TransitionDispName = "";

            return ret;
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("モニタリング");
        }

        private void MonitoringForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
                {
                    // 表示候補取得
                    FormData formData = InitFormData();

                    WindowState = FormWindowState.Maximized;

                    SetTitle();
                });

            #region リストビューアイテムの設定

            monitorItemsView.SuspendLayout();

            TriStateTreeNode rootNode = new TriStateTreeNode("法定検査に関する事");
            rootNode.CheckboxVisible = false;
            rootNode.IsContainer = true;
            {
                TriStateTreeNode subNode = new TriStateTreeNode("質問", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("法定検査の内容について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("法定検査の内容について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("法定検査と保守点検の違いについて", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("福岡方式について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("検査手数料について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("検査結果について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("不具合があった場合の対処について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("検査身受験による罰則規定について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("点検記録等の保存期間について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }

                subNode = new TriStateTreeNode("不満", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("法定検査に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("検査院の接遇に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("検査案内に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("検査（作業）時間に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("身受験者に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
            }

            monitorItemsView.Nodes.Add(rootNode);

            rootNode = new TriStateTreeNode("保守点検、清掃に関する事");
            rootNode.CheckboxVisible = false;
            rootNode.IsContainer = true;
            {
                TriStateTreeNode subNode = new TriStateTreeNode("質問", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("維持管理費用について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("保守点検の内容について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("保守点検の委託先について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("保守点検の規定回数について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("保守点検の自主管理について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("清掃の内容について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("清掃の規定回数について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
                
                subNode = new TriStateTreeNode("不満", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("維持管理費用に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("保守点検の回数に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("点検担当者の接遇に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("点検（作業）時間に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("清掃回数に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("清掃担当者の接遇に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
            }
            
            monitorItemsView.Nodes.Add(rootNode);

            rootNode = new TriStateTreeNode("協会に関する事");
            rootNode.CheckboxVisible = false;
            rootNode.IsContainer = true;
            {
                TriStateTreeNode subNode = new TriStateTreeNode("質問", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("協会の組織について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("協会の所在地について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
                
                subNode = new TriStateTreeNode("不満", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("協会に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("天下りに対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
            }
            
            monitorItemsView.Nodes.Add(rootNode);
            
            rootNode = new TriStateTreeNode("浄化槽に関する事");
            rootNode.CheckboxVisible = false;
            rootNode.IsContainer = true;
            {
                TriStateTreeNode subNode = new TriStateTreeNode("質問", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("浄化槽の電気費用について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("浄化槽使用上の注意について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("単独から合併への切り換えについて", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("浄化槽の耐久性について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("補助金制度について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("浄化槽を廃止する場合について", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
                
                subNode = new TriStateTreeNode("不満", 0, 1);
                rootNode.CheckboxVisible = false;
                subNode.IsContainer = true;
                rootNode.Nodes.Add(subNode);
                {
                    TriStateTreeNode itemNode = new TriStateTreeNode("臭気に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("送風機等の騒音に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("衛生害虫に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("近隣の浄化槽に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("メーカーに対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("工事業者に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);

                    itemNode = new TriStateTreeNode("浄化槽規模の算定に対する不満", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                    
                    itemNode = new TriStateTreeNode("その他", 2, 2);
                    itemNode.CheckboxVisible = true;
                    subNode.Nodes.Add(itemNode);
                }
            }
            
            monitorItemsView.Nodes.Add(rootNode);
            
            monitorItemsView.ResumeLayout();

            #endregion

        }

        #region cameraButton_Click(object sender, EventArgs e)
        /// <summary>
        /// カメラボタン（アイコン）クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraButton_Click(object sender, EventArgs e)
        {
            //using (CaptureDialog frm = new CaptureDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            //{
            //    frm.ShowDialog();
            //}

            using (GetPhotoDialog frm = new GetPhotoDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            {
                frm.ShowDialog();
            }
        }
        #endregion

        #region inputButton_Click(object sender, EventArgs e)
        /// <summary>
        /// 手書きメモボタン（アイコン）クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputButton_Click(object sender, EventArgs e)
        {
            using (InkCanvasDialog frm = new InkCanvasDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            {
                frm.ShowDialog();
            }
        }
        #endregion

        private void kakuteiButton_Click(object sender, EventArgs e)
        {
            TabMessageBox.Show2("機能説明：\n端末内に検査結果を登録します。");
            
            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(typeof(JokasoMenuForm));
            objNextForm.Show();

            // 次画面を閉じる
            Close();
        }
    }
}
