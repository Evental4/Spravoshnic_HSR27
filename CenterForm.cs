using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravoshnic_HSR
{
    public partial class CenterForm : System.Windows.Forms.Form
    {
        public CenterForm()
        {
            InitializeComponent();
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void Enterbutton_Click(object sender, EventArgs e)
        {
            MainForm spr = new  MainForm();
            spr.ShowDialog();
        }
    }
}
