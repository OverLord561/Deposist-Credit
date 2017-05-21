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
    public partial class DepositInfoForm : Form
    {
        string name;
        public DepositInfoForm( Models.DepositDTO _info)
        {
            InitializeComponent();

            groupBox2.Text = _info.Name;
            richTextBox1.Text = _info.Description;
            textBox2.Text = _info.Type;
            textBox3.Text = _info.Partial;
            textBox4.Text = _info.RateName;
            textBox5.Text = _info.Percents.ToString();
            this.name = _info.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.SendNeedHelp(MainForm.UserEmail, "Потрібна консультація за депозитами. " + name +"." );
            MessageBox.Show("Заявку надіслано!","Зворотній зв'язок");
        }
    }
}
