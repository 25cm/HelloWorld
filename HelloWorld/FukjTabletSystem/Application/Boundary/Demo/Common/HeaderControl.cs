using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            titleLabel.Text = title;
        }

        /// <summary>
        /// 現在画面のメインフォームがTabBaseFormの場合、取得する
        /// </summary>
        /// <returns>現在画面がTabBaseFormの場合その参照。TabBaseFormでない場合、null</returns>
        private TabBaseForm GetParentForm()
        {
            // TODO 現状、ヘッダ部の親がTabBaseFormの場合を想定例外的なコントロール構成も考慮できるとベター
            if (Parent is TabBaseForm)
            {
                return (Parent as TabBaseForm);
            }
            else if (Parent.Parent is TabBaseForm)
            {
                return (Parent.Parent as TabBaseForm);
            }
            else if (Parent.Parent.Parent is TabBaseForm)
            {
                return (Parent.Parent.Parent as TabBaseForm);
            }
            else
            {
                return null;
            }

            // NOTICE コントロール構成が異なるのが、少数の画面のみであれば、パッチコードの追加で対応する
        }

        /// <summary>
        /// 次画面ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            GetParentForm().ToNextForm();
        }

        /// <summary>
        /// 最終画面ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextAllButton_Click(object sender, EventArgs e)
        {
            GetParentForm().ToLastForm();
        }

        /// <summary>
        /// 前画面ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevButton_Click(object sender, EventArgs e)
        {
            GetParentForm().ToPrevForm();
        }

        /// <summary>
        /// 開始画面ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevAllButton_Click(object sender, EventArgs e)
        {
            GetParentForm().ToFirstForm();
        }

        /// <summary>
        /// 初期ロード
        /// </summary>
        /// <remarks>
        /// 現在画面がTabBaseFormの場合は、画面遷移ボタンを有効にする
        /// 前画面、次画面がない場合は該当の画面遷移ボタンを無効にする
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderControl_Load(object sender, EventArgs e)
        {
            // 現在画面のメインフォームを取得
            TabBaseForm parent = GetParentForm();

            // 現在画面がTabBaseFormでない場合
            if (parent == null)
            {
                // 画面遷移ボタンを全て無効化
                nextButton.Enabled = false;
                nextAllButton.Enabled = false;
                prevButton.Enabled = false;
                prevAllButton.Enabled = false;
            }
            else
            {
                // 次画面がない場合
                if (!parent.HasNextForm())
                {
                    // 次画面ボタンを無効化
                    nextButton.Enabled = false;
                    nextAllButton.Enabled = false;
                }

                // 前画面がない場合
                if (!parent.HasPrevForm())
                {
                    // 前画面ボタンを無効化
                    prevButton.Enabled = false;
                    prevAllButton.Enabled = false;
                }
            }
        }
    }
}
