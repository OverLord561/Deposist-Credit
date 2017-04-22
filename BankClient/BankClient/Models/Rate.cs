using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models
{
    public class Rate
    {
        public int RateID { get; set; }
        public int DepositID { get; set; }
        public Deposit Deposit { get; set; }
        public string Name { get; set; }
        public int Percents { get; set; }

    }
    
}
