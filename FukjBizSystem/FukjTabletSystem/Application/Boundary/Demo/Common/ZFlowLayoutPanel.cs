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
    public partial class ZFlowLayoutPanel : FlowLayoutPanel
    {
        #region ZFlowLayoutPanel
        /// <summary>
        /// 
        /// </summary>
        public ZFlowLayoutPanel()
        {
            InitializeComponent();
        }
        #endregion

        #region OnPaint
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        #endregion

        #region CalcCenterAlignPadding
        /// <summary>
        /// 
        /// </summary>
        private void CalcCenterAlignPadding()
        {
            // 中央表示されるようにPaddingを調整する
            // TODO 表示が2列になるケース等があれば、処理を見直す
            if (!WrapContents)
            {
                if (FlowDirection == System.Windows.Forms.FlowDirection.TopDown)
                {
                    int maxWidth = 0;
                    foreach (System.Windows.Forms.Control con in Controls)
                    {
                        int layoutWidth = con.Width + con.Margin.Left + con.Margin.Right;
                        if (layoutWidth > maxWidth)
                        {
                            maxWidth = layoutWidth;
                        }
                    }
                    
                    this.Padding = new Padding(
                        (this.ClientSize.Width - maxWidth) / 2
                        , 0
                        , (this.ClientSize.Width - maxWidth) / 2
                        , 0);
                }
            }
        }
        #endregion

        #region OnControlAdded
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            CalcCenterAlignPadding();
        }
        #endregion

        #region OnControlRemoved
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);

            CalcCenterAlignPadding();
        }
        #endregion

        #region OnLayout
        /// <summary>
        /// フォームデザイナで配置された場合初期化順が異なるので、ここでも再度レイアウト調整を行う
        /// </summary>
        /// <param name="levent"></param>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            CalcCenterAlignPadding();
        }
        #endregion

    }
}
