using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Username = "Leo";
            user.Lastname = "Ugr";
            user.OIB = "12345";
            user.Balance = 2000;

            User user2 = new User();
            user2.Username = "Leo";
            user2.Lastname = "Adr";
            user2.OIB = "23121";
            user2.Balance = 1000;

            Bank bank = new Bank();
            bank.AddUser(user);
            bank.AddUser(user2);

            user.ShowUserInfo();
            user2.ShowUserInfo();         

            user = bank.ShowUserByOIB("12345");
            user.ShowUserInfo();

            Console.WriteLine(user.Balance);
            Console.WriteLine(user2.Balance);

            user.Withdraw(500);
            user2.Withdraw(500);

            Console.WriteLine(user.Balance);
            Console.WriteLine(user2.Balance);

            TransactionExecuter transaction = new TransactionExecuter();
            transaction.ReciverUserOIB = user.OIB;
            transaction.SenderUserOIB = user2.OIB;
            transaction.Amount = 200;

            bank.MakeTransaction(transaction);
            Console.WriteLine(user.Balance);
            Console.WriteLine(user2.Balance);
        }
    }
}

