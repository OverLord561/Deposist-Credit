using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClient.Models;

namespace BankClient
{
   public class Dal
    {
        Models.BankContext db = new Models.BankContext(); 

        public List<Models.Deposit> GetAllDeposits()
        {
            
            List<Deposit> res = new List<Deposit>();
                        
            foreach (Deposit _deposit in db.Deposits.ToList())
            {
                _deposit.Rates = db.Rates.Where(x => x.DepositID == _deposit.DepositID).ToList();

                res.Add(_deposit);
            }

            return res;
        }
    }
}
