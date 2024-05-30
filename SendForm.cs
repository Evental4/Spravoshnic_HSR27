using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravoshnic_HSR
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void sendbutton_Click_1(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("evecrid@mail.ru");

            if (AdresstextBox.Text == "")
            {
                MessageBox.Show("Видите адрес электроной почты");
            }
            else
            {
                MailAddress to = new MailAddress(AdresstextBox.Text);

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = "Ваш список ";
                    message.Body = "Здаствуйте." + Environment.NewLine +
                        "Мы прислали Вам список вибраных персонажей в нашем приложении";
                    message.IsBodyHtml = true;

                    File.AppendAllText("Избраное.csv", "Наименование;Путь;Стихия;Роль в отряде");

                    foreach (KeyValuePair<Pers, int> my_pers in SelectForm.my_pers_list)
                    {
                        Pers per = my_pers.Key;
                        File.AppendAllText("Избраное.csv", Environment.NewLine +
                            per.name + ";" + per.pyte + ";" + per.tip + ";" + per.role);
                    }

                    message.Attachments.Add(new Attachment("Избраное.csv"));

                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "rXgpckwnNw8SfuzJ6t84");
                    client.Send(message);
                }

                MessageBox.Show("Сообщение отправлено");
                Close();
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
