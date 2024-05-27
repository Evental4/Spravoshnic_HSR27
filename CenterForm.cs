using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Spravoshnic_HSR
{
    public partial class CenterForm : System.Windows.Forms.Form
    {
        public CenterForm()
        {
            InitializeComponent();
           pictureBox.Load("../../Pictures/fon.png");
        }
        //справка
        private void Helpbutton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }
        //вход в справочник
        private void Enterbutton_Click(object sender, EventArgs e)
        {
            MainForm spr = new  MainForm();
            spr.ShowDialog();
            Close();
        }
        //выход
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
