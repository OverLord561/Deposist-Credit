using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClient.ServiceReference1;
namespace BankClient
{
    public partial class CreateDeposit : Form
    {
        public CreateDeposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client _bankService = new Service1Client();
            Deposit d = new Deposit { Name = textBox1.Text, Description = textBox6.Text,
                Partial = textBox3.Text,Rates = new List<Rate>()
            };
            d.Type = textBox2.Text;
            Rate r = new Rate { Name = textBox4.Text, Percents = Convert.ToInt32(textBox5.Text) };
            d.Rates.Add(r);

            _bankService.CreateDeposit(d);
            MessageBox.Show("Депозитну інформацію внесено");
            this.Close();

        }
    }
}
