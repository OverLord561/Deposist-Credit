using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankService.Models
{
    public class DepositDTO
    {
        public class Deposit
        {      
            public string Name { get; set; }
            
            public string Description { get; set; }
            
            public string Type { get; set; }
            
            public string Partial { get; set; }
            
            List<Rate> Rates { get; set; }

        }
    }
}