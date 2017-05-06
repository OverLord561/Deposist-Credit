using BankClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class MainForm : Form
    {
        public static string UserEmail;
        Service1Client _bankService = new Service1Client();
        string operationType = "Депозити";



        public MainForm(string email, string name)
        {
            UserEmail = email;
            InitializeComponent();
            if (UserEmail == "obiivan@mail.ru")
            {
                ForAdminToolStripMenuItem.Visible = true;
                
                адмініструванняToolStripMenuItem.Visible = true;
            }
            else
            {
                ForAdminToolStripMenuItem.Visible = false;
            }
            label1.Text = email;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void розрахунокКредитівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditCalculator _credit = new CreditCalculator(UserEmail);
            
            _credit.Show();
        }

        private void розрахунокДепозитівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositCalculator _deposit = new DepositCalculator(UserEmail);
            _deposit.Show();
        }

        private void надіслатиАкціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifGroupBox.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.operationType = (sender as RadioButton).Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.operationType = (sender as RadioButton).Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            List<string> request = _bankService.GetEmailsByOperationType(this.operationType);


            foreach (string mail in request)
            {
                switch (this.operationType)
                {
                    case "Депозити": SendMails(mail, "Вас цікавлять депозити? Ми обов'язково вам допоможемо. Замовте зворотній зв'язок!"); break;
                    case "Кредити": SendMails(mail, "Вас цікавлять кредити? Ми обов'язково вам допоможемо. Замовте зворотній зв'язок!"); break;
                    default: break;
                }

            }


            MessageBox.Show("Успішно надіслано " + request.Count + " повідомлень", "Розсилка");


        }

        public static Task SendMails(string mail, string details)
        {
            return Task.Factory.StartNew(() =>
           {
               var fromAddress = new MailAddress("obivan561@gmail.com", "Kutz-Soft");

               System.Net.Mail.MailAddress toAddress = new MailAddress(mail);
               //var toAddress = new MailAddress("yurapuk452@mail.ru", "Yurii Puk");



               const string fromPassword = "89ZXcvbNM";
               const string subject = "Депозити!";
               string body = details;

               var smtp = new SmtpClient
               {
                   Host = "smtp.gmail.com",
                   Port = 587,
                   EnableSsl = true,
                   DeliveryMethod = SmtpDeliveryMethod.Network,
                   UseDefaultCredentials = false,
                   Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
               };
               using (var message = new MailMessage(fromAddress, toAddress)
               {
                   Subject = subject,
                   Body = body
               })
               {
                   smtp.Send(message);

               }

           });
        }

        private void депозитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositsForm deposits = new DepositsForm();
            deposits.Show();
        }

        private void кредитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm credform = new CreditsForm();
            credform.Show();
        }

        private void депозитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateDeposit form = new CreateDeposit();
            form.Show();
        }

        private void кредитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateCredit form = new CreateCredit();
            form.Show();

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
