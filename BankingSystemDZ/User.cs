using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public class User : Person, IBankAccount
    {
        public decimal Balance { get; set; }
        public void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Not enought balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Successfull withdraw of: {amount} \n New balance status is: {Balance}");
            }
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Amount balanced: {amount} \n New balance status is: {Balance}");
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Username: {Username} \n Lastname: {Lastname} \n OIB: {OIB}");
        }
    }
}
