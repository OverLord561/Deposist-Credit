using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models
{
    public class Deposit
    {
        
        public int DepositID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Partial { get; set; }
        public List<Rate> Rates { get; set; }

    }
}
