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
    public partial class RegForm : System.Windows.Forms.Form
    {
        public RegForm()
        {
            InitializeComponent();
            Text = "Регистрация нового пользователя";
        }
        //кнопка для регистр
        private void RegButton_Click_1(object sender, EventArgs e)
        {
            if (PassTB.Text == RePassTB.Text)
            {
                File.AppendAllText("users.txt", NameTB.Text + ", " + FamilyTB.Text + ", " +
                                            LoginTB.Text + ", " + PassTB.Text + ", " + "0" +
                                            Environment.NewLine);
                MessageBox.Show("Регистрация пользователя прошла успешно");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
        }
    }
}
