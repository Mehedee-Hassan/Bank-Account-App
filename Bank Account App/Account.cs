using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_App
{
    class Account
    {
        //has
        public string number;
        public string name;
        public double balance;

        public Account()
        {
            balance = 0;
        }


        //does
        public void Depsit(double amount)
        {
            balance += amount;

        }

        public void Widthdraw(double amount)
        {
            balance -= amount;
        }

        public string GetReport()
        {
            string message = name +
                ", your account number is : " + 
                number + 
                "\nand it's balance is : " + 
                balance;
            
            
            return message;
        }

    }
}
