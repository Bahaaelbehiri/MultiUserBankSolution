using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserBank
{
    internal class MultiUserBank
    {
        decimal balance;
        public string userName;
        public string passWord;
        decimal initialbalance = 10000;

        public string enteryUsername { get; set; }
        public string enterypassword { get; set; }
        public int no { get; set; }
        public Decimal money { get; set; }
        public MultiUserBank(string userName, string passWord, decimal balance)
        {
            this.balance = balance;
            this.userName = userName;
            this.passWord = passWord;

        }
        public MultiUserBank()
        {

        }
        public decimal _balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public decimal _initialbalance
        {
            get { return initialbalance; }
            set { initialbalance = value; }
        }
        public void EnterUser()
        {
            Console.Clear();
            Console.WriteLine(" MultiUsersList ");
            Console.WriteLine(" ======== ");
            Console.WriteLine(" ENTER User Name: ");
            enteryUsername = Console.ReadLine();
            Console.WriteLine(" ENTER Password : ");
            enterypassword = Console.ReadLine();
        }
        public void enterMenu()
        {

            Console.Clear();
            Console.WriteLine("... Main Menu ....");
            Console.WriteLine("===================");
            Console.WriteLine("(1) withdraw");
            Console.WriteLine("(2) deposite");
            Console.WriteLine("(3) check your balance");
            Console.WriteLine("(0) for EXIT");
            Console.WriteLine("===================");

        }
        public void withdraw()
        {
            Console.Clear();
            Console.WriteLine("your current Balance is : " + string.Format("${0:0.00$;'neg: $'-0.00;zero}", _balance));
            Console.WriteLine("Enter withdraw money  : ");
            money = decimal.Parse(Console.ReadLine());
            if (money > 500) { money = 500; }
            if (money > _balance) { money = _balance; }
            Console.WriteLine("The amount withdrawn is  : " + string.Format("${0:0.00$;'neg: $'-0.00;zero}", money));

            _balance -= money;
            _initialbalance -= money;
        }

        public void deposite()
        {
            Console.Clear();
            Console.WriteLine("your current Balance  : " + string.Format("${0:0;'neg: $'-0;zero}", _balance));
            Console.WriteLine("Enter deposite money  : ");
            money = decimal.Parse(Console.ReadLine());

            _balance += money;
            _initialbalance += money;
        }
        public void check_balance()
        {
            Console.Clear();
            Console.WriteLine("your current Balance is : " + string.Format("${0:0;'neg: $'-0;zero}", _balance));
        }


    }
}

