using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public class TransactionExecuter : Transaction
    {
        public string? SenderUserOIB { get; set; }
        public string? ReciverUserOIB { get; set; }

        public override void MakeTransaction()
        {
            Console.WriteLine($"Transaction from: {SenderUserOIB} to {ReciverUserOIB}, Transaction amount is: {Amount}");
        }
    }
}
