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
    public partial class DepositCalculator : Form
    {
        string _type;
        Service1Client _bankService = new Service1Client();

        public DepositCalculator(string userEmail)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case "Простий": An(); break;
                case "Складний": De(); break;
                default: An(); break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _type = (sender as RadioButton).Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _type = (sender as RadioButton).Text;
        }

        private void An()
        {
            //Convert.ToInt32(textBox1.Text) +
            double first = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) * 31;
            var second = first / 365 * 0.01;
            double res = Convert.ToInt32(textBox1.Text) + second;


            List<Models.CreditGraph> data = new List<Models.CreditGraph>();


            for (int i = 1; i <= Convert.ToInt32(textBox2.Text); i++)
            {
                double first1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text) * i * 31;
                var second1 = first1 / 365 * 0.01;
                double res1 = Convert.ToInt32(textBox1.Text) + second1;

                Models.CreditGraph g = new Models.CreditGraph { Amount = Convert.ToInt32(res1), Month = i };
                data.Add(g);
            }
            dataGridView1.DataSource = data;

            chart1.Series["Виплати"].XValueMember = "Month";
            chart1.Series["Виплати"].YValueMembers = "Amount";
            chart1.DataSource = data;
            chart1.DataBind();



            UserCalculator c = new UserCalculator { Date = DateTime.Now, UserID = _bankService.GetUserIDByEmail(MainForm.UserEmail), OperationName = "Депозити" };
            _bankService.UpdateCalculator(c);
        }

        private void De()
        {
            double sum = 0;


            double first = Convert.ToInt32(textBox1.Text);
            var second = 1 + Convert.ToInt32(textBox3.Text) * 0.01 / Convert.ToInt32(textBox2.Text);
            double res = first * Math.Pow(second, Convert.ToInt32(textBox2.Text));


            List<Models.CreditGraph> data = new List<Models.CreditGraph>();
            for (int i = 1; i <= Convert.ToInt32(textBox2.Text); i++)
            {
                double first1 = Convert.ToInt32(textBox1.Text);
                var second1 = 1 + Convert.ToInt32(textBox3.Text) * 0.01 / i;
                double res1 = first1 * Math.Pow(second1, Convert.ToInt32(i));

                Models.CreditGraph g = new Models.CreditGraph { Amount = Convert.ToInt32(res1), Month = i };
                data.Add(g);
            }



            dataGridView1.DataSource = data;

            chart1.Series["Виплати"].XValueMember = "Month";
            chart1.Series["Виплати"].YValueMembers = "Amount";
            chart1.DataSource = data;
            chart1.DataBind();



            UserCalculator c = new UserCalculator { Date = DateTime.Now, UserID = _bankService.GetUserIDByEmail(MainForm.UserEmail), OperationName = "Депозити" };
            _bankService.UpdateCalculator(c);
        }

    }
}
