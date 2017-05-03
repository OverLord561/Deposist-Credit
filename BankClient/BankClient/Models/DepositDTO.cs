using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models
{
    public class DepositDTO
    {
               
        public int RateID { get; set; }
        public string Name { get; set; }
      
        public string Description { get; set; }
       
        public string Type { get; set; }
        
        public string Partial { get; set; }

        public string RateName { get; set; }
        
        public int Percents { get; set; }
    }
}
