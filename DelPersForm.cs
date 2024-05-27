using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravoshnic_HSR
{
    public partial class DelPersForm : System.Windows.Forms.Form
    {
        public DelPersForm()
        {
            InitializeComponent();
            for (int i = 0; i < MainForm.Pers_list.Count; i++)
            {
                ComboBox.Items.Add(MainForm.Pers_list[i].name);
            }
        }

        private void DelButton_Click_1(object sender, EventArgs e)
        {
            var rezalt = DialogResult.No;

            if (ComboBox.Text != "")
            {
                rezalt = MessageBox.Show("Вы действително хотите удалить выбраный объект?",
                                             "Удаление объектаа",
                                              MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("Вы нечего не выбрали");
                return;
            }

            if (rezalt == DialogResult.Yes)
            {


                File.Delete("Pers.txt");
                for (int i = 0; i < MainForm.Pers_list.Count; i++)
                {
                    if (ComboBox.Text == MainForm.Pers_list[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("Pers.txt",
                             MainForm.Pers_list[i].name + ", " +
                             MainForm.Pers_list[i].role + ", " +
                             MainForm.Pers_list[i].tip + ", " +
                             MainForm.Pers_list[i].pyte + ", " +
                             MainForm.Pers_list[i].Hp + ", " +
                             MainForm.Pers_list[i].Def + ", " +
                             MainForm.Pers_list[i].Atc + ", " +
                             MainForm.Pers_list[i].Spid + ", " +
                             MainForm.Pers_list[i].Rancs_pop + ", " +
                             MainForm.Pers_list[i].Web + ", " +
                             Environment.NewLine);
                    }

                }

                MessageBox.Show("Удаление прошло успешно");
                Close();
            }
        }
    }
}
