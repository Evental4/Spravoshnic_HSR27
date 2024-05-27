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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Spravoshnic_HSR
{
    public partial class AddPersForm : Form
    {
        public AddPersForm()
        {
            InitializeComponent();
        }

        private void Sevebutton_Click_1(object sender, EventArgs e)
        {
            int a;

            if (NameTextBox.Text == "" || RoleComboBox.Text == "" || TipComboBox.Text == "" || HpTextBox.Text == "" || DefTextBox.Text == "" || AtcTextBox.Text == "" || SpidTextBox.Text == "" || RancsTextBox.Text == "")
            {
                MessageBox.Show("поля с * обезательном заполнение");
                return;
            }
            if (!Int32.TryParse(HpTextBox.Text, out a))
            {
                MessageBox.Show("Hp не цисло");
                return;
            }
            if (!Int32.TryParse(DefTextBox.Text, out a))
            {
                MessageBox.Show("Def не цисло");
                return;
            }
            if (!Int32.TryParse(AtcTextBox.Text, out a))
            {
                MessageBox.Show("Atc не цисло");
                return;
            }
            if (!Int32.TryParse(SpidTextBox.Text, out a))
            {
                MessageBox.Show("Spid не цисло");
                return;
            }

            File.AppendAllText("Pers.txt",
                                                       Environment.NewLine +
                                                       NameTextBox.Text + ", " +
                                                       RoleComboBox.Text + ", " +
                                                       TipComboBox.Text + ", " +
                                                       PythComboBox.Text + ", " +
                                                       HpTextBox.Text + ", " +
                                                       DefTextBox.Text + ", " +
                                                       AtcTextBox.Text + ", " +
                                                       SpidTextBox.Text + ", " +
                                                       RancsTextBox.Text + ", " +
                                                       WebTextBox.Text);

            File.AppendAllText("../../Pictures/" + NameTextBox.Text + ".txt", InfoTextBox.Text);


            if (FileName != "")
            {
                File.Copy(FileName, "../../Pictures/" + NameTextBox.Text + ".png");
            }
            else

                MessageBox.Show("Объект загружен");
            Close();
        }
        string FileName = "";

        
        

        private void PersPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PicButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                PersPictureBox.Load(FileName);
            }
        }
    }
}

