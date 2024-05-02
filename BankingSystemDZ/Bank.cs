using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDZ
{
    public class Bank
    {
        public List<User> users = new List<User>();
        public List<Transaction> transactions = new List<Transaction>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
        public User ShowUserByOIB(string OIB)
        {
            foreach(User user in users)
            {
                if(user.OIB == OIB)
                {
                    return user;
                }
            }
            return new User();
        }
        public void MakeTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            transaction.MakeTransaction();
        }
    }
}
