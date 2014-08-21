using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public class TabBaseFormHoriz : TabBaseForm
    {
        // TODO 必要に応じて、プロパティ類にデフォルトを設定する

        // TODO 
        protected new int dispWidth = 1280;
        protected new int dispHeight = 760;

        public TabBaseFormHoriz()
            : base()
        {
            //this.Location = new System.Drawing.Point(0, 0);
            //this.ClientSize = new System.Drawing.Size(1280, 760);
        }

    }
}
