using BankClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClient.Models;

namespace BankClient
{
    public partial class RegisterForm : Form
    {

        public Service1Client _bankService = new Service1Client();
        //Service1 _bankService = new Service1();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void regSend_Click(object sender, EventArgs e)
        {

            if (regName.Text == "" || regSecName.Text == "" || regPassword.Text == "" || regTelephone.Text == "" || regEmail.Text == "")
            {
                MessageBox.Show("Усі поля обов'язкові для заповнення","Помилка реєстрації");
                return;
            }

            if (regPassword.Text.Length < 5)
            {
                MessageBox.Show("Вкажіть шестизначний пароль", "Помилка реєстрації");
                return;
            }

            ServiceReference1.User _user = new ServiceReference1.User
            {
                Name = regName.Text,
                SecondName = regSecName.Text,
                Password = regPassword.Text,
                Telephone = regTelephone.Text,
                Email = regEmail.Text
            };

           string res = _bankService.RegisterUser(_user);
            if (res != "")
            {
                this.Close();
                MainForm main = new MainForm(_user.Email, _user.Name);
                main.Show();
            }
            else
            {
                MessageBox.Show("Змініть адрес електронної адреси!", "Помилка реєстрації");
                return;
            }

        }
    }
}
