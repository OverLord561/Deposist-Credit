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

namespace BankClient
{
    public partial class LogIn : Form
    {
        Service1Client _bankService = new Service1Client();
        Dal manager = new Dal();
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string pass = textBoxPassword.Text;

           // manager.GetAllDeposits();


            //email = "obiivan@mail.ru";
            //pass = "admin";

            if (email == "" || pass == "")
            {
                MessageBox.Show("Усі поля обов'язкові для заповнення!", "Помилка при вході");
                return;
            }
            User _user = _bankService.LogIn(email, pass);

            if (_user != null)
            {
               
                MainForm mf = new MainForm(_user.Email, _user.Name);

                mf.Show();
            }
            else
            {
                MessageBox.Show("Введено некоректні дані!", "Помилка при вході");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}
