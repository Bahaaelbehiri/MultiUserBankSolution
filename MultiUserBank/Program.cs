
       namespace MultiUserBank
    {
        // Elbehiri
        // IT112
        class Program
        {
            static void Main(string[] args)
            {

                // variable to Search for users & passwords in Array
                Boolean found;
                //postion customer for array
                int j = 0;
                //create  object using Array for 4 customes 
                MultiUserBank[] customer = new MultiUserBank[4];

                MultiUserBank b = new MultiUserBank();

                //store customers data in Array   
                customer[0] = new MultiUserBank("jlennon", "johnny", 1250m);
                customer[1] = new MultiUserBank("pmccartney", "pauly", 2500m);
                customer[2] = new MultiUserBank("gharrison", "georgy", 3000m);
                customer[3] = new MultiUserBank("rstarr", "ringoy", 1000m);

                Console.Clear();

            ineligible:
                //Enter and verify user data and password
                b.EnterUser();

                //   
                found = false;
                for (int i = 0; i <= 3; i++)
                {

                    if (b.enteryUsername == customer[i].userName && b.enterypassword == customer[i].passWord)
                    {
                        b._balance = customer[i]._balance;
                        j = i;
                        found = true;
                        break;
                    }

                }

                if (found == false)
                {
                    Console.WriteLine("error username or password");
                    Console.ReadLine();
                    b.EnterUser();
                    //Re-enter and verify the user data and password
                    goto ineligible;
                }

                else
                {
                    do
                    {
                        // View the bank's list of withdrawals and deposits
                        b.enterMenu();

                        b.no = int.Parse(Console.ReadLine());
                        switch (b.no)
                        {
                            case 1:
                                // methods withdraw
                                b.withdraw();
                                customer[j]._balance = b._balance;
                                Console.WriteLine("your Balance After withdraw is : " + string.Format("${0:0;'neg: '-0$;zero}", customer[j]._balance));

                                Console.ReadLine();
                                break;
                            case 2:
                                //  methods deposite
                                b.deposite();
                                customer[j]._balance = b._balance;
                                Console.WriteLine("your Balance After deposite is : " + string.Format("${0:0;'neg: '-0$;zero}", customer[j]._balance));

                                Console.ReadLine();
                                break;
                            case 3:
                                // methods check balance
                                b.check_balance();
                                Console.ReadLine();
                                break;

                        }
                    } while (b.no != 0 || b.no > 3);
                    //  Console.ReadLine();
                }
            }
        }
    }
