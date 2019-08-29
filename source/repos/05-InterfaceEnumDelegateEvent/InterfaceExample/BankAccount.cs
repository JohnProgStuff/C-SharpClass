using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class BankAccount : IComparable<BankAccount>, IMyComparable
    {
        private int balance;
        private string ownerName;

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public BankAccount(int balance, string name)
        {
            this.balance = balance;
            this.ownerName = name;
        }

        public override string ToString()
        {

            return "name: " + this.ownerName + ", Balance = " + this.balance;
                
        }

        int IComparable<BankAccount>.CompareTo(BankAccount other)
        {
            /*if (balance == other.balance) {
                return ownerName.CompareTo(other.ownerName);
            }*/
            return balance.CompareTo(other.balance);
        }

        int IMyComparable.CompareTo(BankAccount other)
        {
            /*if (balance == other.balance) {
                return ownerName.CompareTo(other.ownerName);
            }*/
            return balance.CompareTo(other.balance);
        }

    }
}
