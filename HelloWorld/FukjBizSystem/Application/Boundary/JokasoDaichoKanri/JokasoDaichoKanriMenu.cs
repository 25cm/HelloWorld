using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjBizSystem.Application.Boundary.JokasoDaichoKanri
{
    public partial class JokasoDaichoKanriMenu : Form
    {
        public JokasoDaichoKanriMenu()
        {
            InitializeComponent();
        }

        private void jokasoDaichoIchiranButton_Click(object sender, EventArgs e)
        {
            JokasoDaichoList frm = new JokasoDaichoList();
            Program.mForm.ShowForm(frm);
        }
    }
}
