using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public abstract void MakeTransaction();
    }
}
