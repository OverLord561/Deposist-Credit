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
    public partial class DepositsForm : Form
    {
        Service1Client _bankService = new Service1Client();
        List<Models.DepositDTO> dtoLIST = new List<Models.DepositDTO>();

        public DepositsForm()
        {
            InitializeComponent();
            //  GetAllDeposits();
            dataGridView1.DataSource = GetAllDeposits();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns["RateID"].Visible = false;

            dataGridView1.Columns["Description"].Visible = false;



        }

        public List<Models.DepositDTO> GetAllDeposits()
        {
            List<Deposit> deposits = _bankService.GetAllDeposits();

            List<Rate> rates = _bankService.GetAllDepositsRates();
            foreach (Deposit deposit in deposits)
            {
                deposit.Rates = rates.Where(x => x.DepositID == deposit.DepositID).ToList();
            }
           
            foreach (Deposit deposit in deposits)
            {
                foreach (Rate _rate in deposit.Rates)
                {
                    Models.DepositDTO dto = new Models.DepositDTO
                    {
                        Name = deposit.Name,
                        Description = deposit.Description,
                        RateID = _rate.RateID,
                        Partial = deposit.Partial,
                        Type = deposit.Type,
                        Percents = _rate.Percents,
                        RateName = _rate.Name
                    };
                    dtoLIST.Add(dto);
                }
            }

            return dtoLIST;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           DepositInfoForm info = new DepositInfoForm( dtoLIST[e.RowIndex]);
            info.Show();
        }
    }
}
