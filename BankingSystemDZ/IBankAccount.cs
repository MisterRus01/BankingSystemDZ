using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public interface IBankAccount
    {
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        void ShowUserInfo();
    }
}
