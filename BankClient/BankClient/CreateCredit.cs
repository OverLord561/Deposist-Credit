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
    public partial class CreateCredit : Form
    {
        public CreateCredit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client _bankService = new Service1Client();
            Credit cr = new Credit { Name = textBox1.Text, nLink = textBox2.Text };
            _bankService.CreateCredit(cr);
            MessageBox.Show("Кредитну інформацію внесено");
            this.Close();
            
        }
    }
}
