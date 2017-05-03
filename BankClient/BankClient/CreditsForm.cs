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
    public partial class CreditsForm : Form
    {
        Service1Client _bankService = new Service1Client();
        List<Credit> list = new List<Credit>();
        public CreditsForm()
        {
            InitializeComponent();
            
            
                list  = _bankService.GetAllCredits("1");
            dataGridView1.DataSource = list;
            dataGridView1.Columns["CreditID"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.SendMails(MainForm.UserEmail, "Потрібна консультація за кредитами.");
            MessageBox.Show("Заявку надіслано!", "Зворотній зв'язок");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            System.Diagnostics.Process.Start(list[e.RowIndex].Link);
        }
    }
}
