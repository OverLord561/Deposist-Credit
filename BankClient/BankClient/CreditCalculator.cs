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
    public partial class CreditCalculator : Form
    {
        string _type;
        Service1Client _bankService = new Service1Client();
        public CreditCalculator(string userEmail)
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _type = (sender as RadioButton).Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _type = (sender as RadioButton).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case "Рівними частинами":An(); break;
                case "Диференційований":De(); break;
                default: An(); break;
            }



            
        }
        private void An()
        {
            double v_mes = Convert.ToInt32(textBox1.Text) *
                            (
                            Convert.ToInt32(textBox3.Text) * 0.01 * Math.Pow(1 + Convert.ToInt32(textBox3.Text) * 0.01, Convert.ToInt32(textBox2.Text))
                               /
                               (Math.Pow(1 + Convert.ToInt32(textBox3.Text) * 0.01, Convert.ToInt32(textBox2.Text)) - 1));


            List<Models.CreditGraph> data = new List<Models.CreditGraph>();


            for (int i = 1; i <= Convert.ToInt32(textBox2.Text); i++)
            {
                Models.CreditGraph g = new Models.CreditGraph { Amount = Convert.ToInt32(v_mes * i), Month = i };
                data.Add(g);
            }
            dataGridView1.DataSource = data;

            chart1.Series["Виплати"].XValueMember = "Month";
            chart1.Series["Виплати"].YValueMembers = "Amount";
            chart1.DataSource = data;
            chart1.DataBind();
          


            UserCalculator c = new UserCalculator { Date = DateTime.Now, UserID = _bankService.GetUserIDByEmail(MainForm.UserEmail), OperationName = "Кредити" };
            _bankService.UpdateCalculator(c);
            label5.Text = data[data.Count -1].Amount.ToString();
        }

        private void De()
        {
            double sum = 0;
            double total = 0;
           
            List<Models.CreditGraph> data = new List<Models.CreditGraph>();
            for (int i = 1; i <= Convert.ToInt32(textBox2.Text); i++)
            {
                double che = Convert.ToInt32(textBox1.Text) / (Convert.ToInt32(textBox2.Text));
                sum = che
                    + ((Convert.ToInt32(textBox1.Text) -( che* i))*0.1/12);
                Models.CreditGraph g = new Models.CreditGraph { Amount = Convert.ToInt32(sum ), Month = i };
                data.Add(g);
                total += sum;
            }


            
            dataGridView1.DataSource = data;

            chart1.Series["Виплати"].XValueMember = "Month";
            chart1.Series["Виплати"].YValueMembers = "Amount";
            chart1.DataSource = data;
            chart1.DataBind();

            

            UserCalculator c = new UserCalculator { Date = DateTime.Now, UserID = _bankService.GetUserIDByEmail(MainForm.UserEmail), OperationName = "Кредити" };
            _bankService.UpdateCalculator(c);
            label5.Text = total.ToString();
        }
    }
}
