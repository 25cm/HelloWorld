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
    public partial class DummyForm : Form
    {
        public static DummyForm _instanse = null;

        public DummyForm()
        {
            InitializeComponent();

            if (_instanse == null)
            {
                _instanse = this;
            }
        }

        private void DummyForm_Load(object sender, EventArgs e)
        {
            // 自分は非表示になる
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;

            MenuForm frm = new MenuForm();
            frm.Show(this);
        }
    }
}
