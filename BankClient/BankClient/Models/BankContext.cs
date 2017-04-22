using System;
using BankClient.ServiceReference1;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models
{
    public class BankContext : DbContext
    {
        public BankContext() : base("BankContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Rate> Rates { get; set; }
    }
}
