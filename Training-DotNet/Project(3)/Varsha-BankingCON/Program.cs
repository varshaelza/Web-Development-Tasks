using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varsha_BankingLIB;

namespace Varsha_BankingCON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu Creation using only 1 Accounts class
            #region Accounts Objects
            //Accounts accObj1 = new Accounts();
            //accObj1.AccNo = 0001;
            //accObj1.AccName = "Varsha Elza Gikku";
            //accObj1.AccType = "Savings";
            //accObj1.AccBalance = 100560.56;
            //accObj1.AccIsactive = true;

            //Accounts accObj2 = new Accounts();
            //accObj2.AccNo = 0002;
            //accObj2.AccName = "Aleena John";
            //accObj2.AccType = "Current";
            //accObj2.AccBalance = 170890.78;
            //accObj2.AccIsactive = true;

            //Accounts accObj3 = new Accounts();
            //accObj3.AccNo = 0003;
            //accObj3.AccName = "Vinaya Elma";
            //accObj3.AccType = "PF";
            //accObj3.AccBalance = 99900.22;
            //accObj3.AccIsactive = true;

            //Accounts accObj4 = new Accounts();
            //accObj4.AccNo = 0004;
            //accObj4.AccName = "Vincy Mathew";
            //accObj4.AccType = "PF";
            //accObj4.AccBalance = 500500.22;
            //accObj4.AccIsactive = true;

            //Accounts accObj5 = new Accounts();
            //accObj5.AccNo = 0005;
            //accObj5.AccName = "Malavika M";
            //accObj5.AccType = "Savings";
            //accObj5.AccBalance = 150000.80;
            //accObj5.AccIsactive = true;

            //List<Accounts> accList = new List<Accounts>();
            //accList.Add(accObj1);
            //accList.Add(accObj2);
            //accList.Add(accObj3);
            //accList.Add(accObj4);
            //accList.Add(accObj5);
            #endregion
            #region Display Accounts
            //foreach (Accounts acc in accList)
            //{
            //    Console.WriteLine("Account no. - " + acc.AccNo);
            //    Console.WriteLine("Account Holder name - " + acc.AccName);
            //    Console.WriteLine("Account Type- " + acc.AccType);
            //    Console.WriteLine("Account Balance - " + acc.AccBalance);

            //    if (acc.AccIsactive == true)
            //    {

            //        Console.WriteLine("Is this account active - yes\n\n" );

            //        acc.Withdraw(1000);
            //        Console.WriteLine("Account Balance after withdrawing 1000- " + acc.AccBalance);
            //        acc.Deposit(2000);
            //        Console.WriteLine("Account Balance after depositing 2000- " + acc.AccBalance);

            //    }
            //    else

            //        Console.WriteLine("Is this account active - no");

            //    Console.WriteLine("\n-----------------------------------------\n");
            //    Console.WriteLine("Press enter to proceed");
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            #endregion
            #region Accounts Banking Menu

            //bool continue_banking = true;
            //while (continue_banking == true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Welcome to Banking Application\n----------------------------------------------\n");
            //    Console.WriteLine("Options");
            //    Console.WriteLine("1.View all Accounts");
            //    Console.WriteLine("2.Add Account");
            //    Console.WriteLine("3.View an Account");
            //    Console.WriteLine("4.Deposit Amount");
            //    Console.WriteLine("5.Withdraw Amount");
            //    Console.WriteLine("6.Transfer Amount");
            //    Console.WriteLine("7.View Active Accounts");
            //    Console.WriteLine("8.View Inactive Accounts");
            //    Console.WriteLine("9.Exit");

            //    Console.WriteLine("Enter your choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("View all Accounts\n-----------------------------\n");
            //            foreach (Accounts acc in accList)
            //            {
            //                Console.WriteLine("Account no. - " + acc.AccNo);
            //                Console.WriteLine("Account Holder name - " + acc.AccName);
            //                Console.WriteLine("Account Type- " + acc.AccType);
            //                Console.WriteLine("Account Balance - " + acc.AccBalance);

            //                if (acc.AccIsactive == true)
            //                {
            //                    Console.WriteLine("Is this account active - yes\n\n");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Is this account active - no");
            //                }
            //                Console.WriteLine("-------------------------------------------------------\n");


            //            }
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if(Console.ReadLine()=="N")
            //                continue_banking=false;
            //            break;
            //        case 2:
            //            Console.WriteLine("Add Account\n-----------------------------\n");
            //            Accounts accObj = new Accounts();
            //            Console.WriteLine("Enter Account no.");
            //            accObj.AccNo = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Account Holder's name");
            //            accObj.AccName = Console.ReadLine();
            //            Console.WriteLine("Enter Account Type");
            //            accObj.AccType = Console.ReadLine();
            //            Console.WriteLine("Enter Initial Deposit Amount");
            //            accObj.AccBalance = Convert.ToDouble(Console.ReadLine()); ;
            //            Console.WriteLine("Is Account active (Y-Yes/N-No");
            //            if (Console.ReadLine() == "Y")
            //                accObj.AccIsactive = true;
            //            else
            //                accObj.AccIsactive = false;
            //            accList.Add(accObj);
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 3:
            //            Console.WriteLine("View Account\n-----------------------------\n");
            //            Console.WriteLine("Enter Account number to view");
            //            int accNo = Convert.ToInt32(Console.ReadLine());
            //            int flag = 0;
            //            foreach (Accounts acc in accList)
            //            {
            //                if (accNo == acc.AccNo)
            //                {
            //                    Console.WriteLine("Account no. - " + acc.AccNo);
            //                    Console.WriteLine("Account Holder name - " + acc.AccName);
            //                    Console.WriteLine("Account Type- " + acc.AccType);
            //                    Console.WriteLine("Account Balance - " + acc.AccBalance);

            //                    if (acc.AccIsactive == true)
            //                    {
            //                        Console.WriteLine("Is this account active - yes\n\n");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Is this account active - no");
            //                    }
            //                    Console.WriteLine("-------------------------------------------------------\n");
            //                    flag = 1;
            //                    break;
            //                }
            //            }
            //            if (flag == 0)
            //            {
            //                Console.WriteLine("Account Not Found");
            //            }

            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 4:
            //            Console.WriteLine("Deposit Amount\n-----------------------------\n");
            //            Console.WriteLine("Enter Account no.");
            //            accNo = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Amount to be deposited");
            //            double depositAmount = Convert.ToDouble(Console.ReadLine());
            //            flag = 0;
            //            foreach (Accounts acc in accList)
            //            {
            //                if (acc.AccNo == accNo)
            //                {
            //                    acc.Deposit(depositAmount);
            //                    Console.WriteLine("Amount Deposited.New balance is "+acc.AccBalance);
            //                    flag = 1;
            //                    break;
            //                }
            //            }
            //            if (flag == 0)
            //            {
            //                Console.WriteLine("Account Not Found");
            //            }
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 5:
            //            Console.WriteLine("Withdraw Amount\n-----------------------------\n");
            //            Console.WriteLine("Enter Account no.");
            //            accNo = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Amount to be withdrawn");
            //            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            //            flag = 0;
            //            foreach (Accounts acc in accList)
            //            {
            //                if (acc.AccNo == accNo)
            //                {
            //                    acc.Deposit(withdrawAmount);
            //                    Console.WriteLine("Amount Withdrawn.New balance is " + acc.AccBalance);
            //                    flag = 1;
            //                    break;
            //                }
            //            }
            //            if (flag == 0)
            //            {
            //                Console.WriteLine("Account Not Found");
            //            }
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 6:
            //            Console.WriteLine("Transfer Amount\n-----------------------------\n");
            //            Console.WriteLine("Enter Account no. of Sender");
            //            int senderaccNo = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Account no. of Receiver");
            //            int receiveraccNo = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Amount to be transferred");
            //            double transferAmount = Convert.ToDouble(Console.ReadLine());
            //            flag = 0;
            //            foreach (Accounts acc in accList)
            //            {
            //                if (acc.AccNo == receiveraccNo)
            //                {
            //                    acc.Deposit(transferAmount);
            //                    if (flag == 1)
            //                        break;
            //                    else
            //                        flag = 1;
            //                }
            //                if (acc.AccNo == senderaccNo)
            //                {
            //                    acc.Withdraw(transferAmount);
            //                    if (flag == 1)
            //                        break;
            //                    else
            //                        flag = 1;
            //                }
            //            }

            //            Console.WriteLine("Amount Transferred.\nDo you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 7:
            //            Console.WriteLine("Active Accounts\n----------------------\n");
            //            foreach (Accounts acc in accList)
            //            {
            //                if (acc.AccIsactive == true)
            //                {
            //                    Console.WriteLine("Account no. - " + acc.AccNo);
            //                    Console.WriteLine("Account Holder name - " + acc.AccName);
            //                    Console.WriteLine("Account Type- " + acc.AccType);
            //                    Console.WriteLine("Account Balance - " + acc.AccBalance);
            //                    Console.WriteLine("-------------------------------------------------------\n");
            //                }
            //            }
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 8:
            //            Console.WriteLine("Inactive Accounts\n----------------------\n");
            //            foreach (Accounts acc in accList)
            //            {
            //                if (acc.AccIsactive != true)
            //                {
            //                    Console.WriteLine("Account no. - " + acc.AccNo);
            //                    Console.WriteLine("Account Holder name - " + acc.AccName);
            //                    Console.WriteLine("Account Type- " + acc.AccType);
            //                    Console.WriteLine("Account Balance - " + acc.AccBalance);
            //                    Console.WriteLine("-------------------------------------------------------\n");
            //                }

            //            }
            //            Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
            //            if (Console.ReadLine() == "N")
            //                continue_banking = false;
            //            break;
            //        case 9:
            //            continue_banking = false;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid option.\n Press Enter to Continue");
            //            Console.ReadLine();
            //            break;
            //    }


            //}
            //Console.Clear();
            //Console.WriteLine("Thankyou for using this application!");
            #endregion

            //Menu Creation using Accounts SubClasses
            #region Accounts Subclass Objects
            List<Savings> savList = new List<Savings>();
            List<Current> curList = new List<Current>();
            List<PF> pfList = new List<PF>();
            #endregion

            #region Accounts(Subclass) Banking Menu
            bool continue_banking = true;
            while (continue_banking == true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Banking Application\n----------------------------------------------\n");
                Console.WriteLine("Options");
                Console.WriteLine("1.View all Accounts");
                Console.WriteLine("2.Add Account");
                Console.WriteLine("3.View an Account");
                Console.WriteLine("4.Deposit Amount");
                Console.WriteLine("5.Withdraw Amount");
                Console.WriteLine("6.Transfer Amount");
                Console.WriteLine("7.View Active Accounts");
                Console.WriteLine("8.View Inactive Accounts");
                Console.WriteLine("9.Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("View all Accounts\n-----------------------------\n");
                            
                        foreach (Savings acc in savList)
                        {
                            Console.WriteLine("Account no. - " + acc.AccNo);
                            Console.WriteLine("Account Holder name - " + acc.AccName);
                            Console.WriteLine("Account Type -  Savings");
                            Console.WriteLine("Account Balance - " + acc.AccBalance);

                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Is this account active - yes\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Is this account active - no");
                            }
                            Console.WriteLine("-------------------------------------------------------\n");


                        }
                        foreach (Current acc in curList)
                        {
                            Console.WriteLine("Account no. - " + acc.AccNo);
                            Console.WriteLine("Account Holder name - " + acc.AccName);
                            Console.WriteLine("Account Type -  Current");
                            Console.WriteLine("Account Balance - " + acc.AccBalance);

                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Is this account active - yes\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Is this account active - no");
                            }
                            Console.WriteLine("-------------------------------------------------------\n");


                        }
                        foreach (PF acc in pfList)
                        {
                            Console.WriteLine("Account no. - " + acc.AccNo);
                            Console.WriteLine("Account Holder name - " + acc.AccName);
                            Console.WriteLine("Account Type -  PF");
                            Console.WriteLine("Account Balance - " + acc.AccBalance);

                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Is this account active - yes\n\n");
                            }
                            else
                            {
                                Console.WriteLine("Is this account active - no");
                            }
                            Console.WriteLine("-------------------------------------------------------\n");


                        }

                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                        {
                            continue_banking = false;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Add Account\n-----------------------------\n");
                        //Console.WriteLine("Enter Account no.");
                        //int accNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Account Holder's name");
                        string accName = Console.ReadLine();
                        Console.WriteLine("Choose Account Type\n1.Savings\n2.Current\n3.PF\nEnter your choice ");
                        int accType = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Initial Deposit Amount");
                        double accBalance = Convert.ToDouble(Console.ReadLine()); ;
                        Console.WriteLine("Is Account active (Y-Yes/N-No");
                        bool accIsactive;
                        if(Console.ReadLine()=="Y")
                        {
                            accIsactive = true;
                        }
                        else
                        {
                            accIsactive = false;
                        }
                        switch(accType)
                        {
                            case 1:
                                Savings savObj = new Savings( accName, accBalance, accIsactive);
                                savList.Add(savObj);
                                break;
                            case 2:
                                Current curObj = new Current(accName, accBalance, accIsactive);
                                curList.Add(curObj);
                                break;
                            case 3:
                                PF pfObj = new PF(accName, accBalance, accIsactive);
                                pfList.Add(pfObj);
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                        {
                            continue_banking = false;
                        }
                        break;
                    case 3:
                        Console.WriteLine("View Account\n-----------------------------\n");
                        Console.WriteLine("Enter Account number to view");
                        string accNo = Console.ReadLine();
                        bool found =false;
                        if (accNo.Length > 3)
                        {
                            if (accNo.Substring(0, 3) == "SAV")
                            {

                                foreach (Savings acc in savList)
                                {
                                    if (accNo == acc.AccNo)
                                    {
                                        Console.WriteLine("Account no. - " + acc.AccNo);
                                        Console.WriteLine("Account Holder name - " + acc.AccName);
                                        Console.WriteLine("Account Type- Savings");
                                        Console.WriteLine("Account Balance - " + acc.AccBalance);

                                        if (acc.AccIsactive == true)
                                        {
                                            Console.WriteLine("Is this account active - yes\n\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Is this account active - no");
                                        }
                                        Console.WriteLine("-------------------------------------------------------\n");
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            else if (accNo.Substring(0, 3) == "CUR")
                            {
                                foreach (Current acc in curList)
                                {
                                    if (accNo == acc.AccNo)
                                    {
                                        Console.WriteLine("Account no. - " + acc.AccNo);
                                        Console.WriteLine("Account Holder name - " + acc.AccName);
                                        Console.WriteLine("Account Type- Current");
                                        Console.WriteLine("Account Balance - " + acc.AccBalance);

                                        if (acc.AccIsactive == true)
                                        {
                                            Console.WriteLine("Is this account active - yes\n\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Is this account active - no");
                                        }
                                        Console.WriteLine("-------------------------------------------------------\n");
                                        found = true;
                                        break;
                                    }
                                }
                            }

                            else if (accNo.Substring(0, 2) == "PF")
                            {
                                foreach (PF acc in pfList)
                                {
                                    if (accNo == acc.AccNo)
                                    {
                                        Console.WriteLine("Account no. - " + acc.AccNo);
                                        Console.WriteLine("Account Holder name - " + acc.AccName);
                                        Console.WriteLine("Account Type- PF");
                                        Console.WriteLine("Account Balance - " + acc.AccBalance);

                                        if (acc.AccIsactive == true)
                                        {
                                            Console.WriteLine("Is this account active - yes\n\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Is this account active - no");
                                        }
                                        Console.WriteLine("-------------------------------------------------------\n");
                                        found = true;
                                        break;
                                    }
                                }

                            }
                        }   
                        if (found==false)
                        {
                            Console.WriteLine("Account Not Found");
                        }

                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 4:
                        Console.WriteLine("Deposit Amount\n-----------------------------\n");
                        Console.WriteLine("Enter Account no.");
                        accNo = Console.ReadLine();
                        double depositAmount;
                        found = false;
                        bool deposited=false;
                        if (accNo.Length > 3)
                        {
                            if (accNo.Substring(0, 3) == "SAV")
                            {
                                foreach (Savings acc in savList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be deposited");
                                        depositAmount = Convert.ToDouble(Console.ReadLine());
                                        deposited = acc.Deposit(depositAmount);
                                        if (deposited == true)
                                        {
                                            Console.WriteLine("\nAmount Deposited. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            else if (accNo.Substring(0, 3) == "CUR")
                            {
                                foreach (Current acc in curList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be deposited");
                                        depositAmount = Convert.ToDouble(Console.ReadLine());
                                        deposited = acc.Deposit(depositAmount);
                                        if (deposited == true)
                                        {
                                            Console.WriteLine("\nAmount Deposited. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            else if (accNo.Substring(0, 2) == "PF")
                            {
                                foreach (PF acc in pfList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be deposited");
                                        depositAmount = Convert.ToDouble(Console.ReadLine());
                                        deposited = acc.Deposit(depositAmount);
                                        if (deposited == true)
                                        {
                                            Console.WriteLine("\nAmount Deposited. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                        }
                        
                        if (found == false)
                        {
                            Console.WriteLine("Account Not Found");
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 5:
                        Console.WriteLine("Withdraw Amount\n-----------------------------\n");
                        Console.WriteLine("Enter Account no.");
                        accNo = Console.ReadLine();
                        double withdrawAmount;
                        found = false;
                        bool withdrawn=false;
                        if (accNo.Length > 3)
                        {
                            if (accNo.Substring(0, 3) == "SAV")
                            {
                                foreach (Savings acc in savList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be withdrawn");
                                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                        withdrawn = acc.Withdraw(withdrawAmount);
                                        if (withdrawn == true)
                                        {
                                            Console.WriteLine("\nAmount withdrawn. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            else if (accNo.Substring(0, 3) == "CUR")
                            {
                                foreach (Current acc in curList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be withdrawn");
                                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                        withdrawn = acc.Withdraw(withdrawAmount);
                                        if (withdrawn == true)
                                        {
                                            Console.WriteLine("\nAmount withdrawn. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            else if (accNo.Substring(0, 2) == "PF")
                            {
                                foreach (PF acc in pfList)
                                {
                                    if (acc.AccNo == accNo)
                                    {
                                        Console.WriteLine("Enter Amount to be withdrawn");
                                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                                        withdrawn = acc.Withdraw(withdrawAmount);
                                        if (withdrawn == true)
                                        {
                                            Console.WriteLine("\nAmount withdrawn. New balance is " + acc.AccBalance);
                                        }
                                        found = true;
                                        break;
                                    }
                                }
                            }
                        }
                        
                        if (found == false)
                        {
                            Console.WriteLine("Account Not Found");
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 6:
                        Console.WriteLine("Transfer Amount\n-----------------------------\n");
                        Console.WriteLine("Enter Account no. of Sender");
                        string senderaccNo = Console.ReadLine();
                        Console.WriteLine("Enter Account no. of Receiver");
                        string receiveraccNo =Console.ReadLine();
                        Console.WriteLine("Enter Amount to be transferred");
                        double transferAmount = Convert.ToDouble(Console.ReadLine());
                        bool receiverFound = false;
                        bool senderFound = false;
                        withdrawn = false;
                        deposited = false;
                        if (receiveraccNo.Length > 3)
                        {
                            if (senderaccNo.Substring(0, 3) == "SAV")
                            {
                                foreach (Savings acc in savList)
                                {
                                    if (acc.AccNo == senderaccNo)
                                    {
                                        withdrawn = acc.Withdraw(transferAmount);
                                        senderFound = true;
                                    }
                                    if (senderFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (senderaccNo.Substring(0, 3) == "CUR")
                            {
                                foreach (Current acc in curList)
                                {

                                    if (acc.AccNo == senderaccNo)
                                    {
                                        withdrawn = acc.Withdraw(transferAmount);
                                        senderFound = true;
                                    }
                                    if (senderFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (senderaccNo.Substring(0, 2) == "PF")
                            {
                                foreach (PF acc in pfList)
                                {

                                    if (acc.AccNo == senderaccNo)
                                    {
                                        withdrawn = acc.Withdraw(transferAmount);
                                        senderFound = true;
                                    }
                                    if (senderFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        
                        if (senderFound == true&&withdrawn==true&&receiveraccNo.Length>3)
                        {
                            if (receiveraccNo.Substring(0, 3) == "SAV")
                            {
                                foreach (Savings acc in savList)
                                {
                                    if (acc.AccNo == receiveraccNo)
                                    {
                                        deposited = acc.Deposit(transferAmount);
                                        receiverFound = true;
                                    }
                                    if (receiverFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (receiveraccNo.Substring(0, 3) == "CUR")
                            {
                                foreach (Current acc in curList)
                                {

                                    if (acc.AccNo == receiveraccNo)
                                    {
                                        deposited = acc.Deposit(transferAmount);
                                        receiverFound = true;
                                    }
                                    if (receiverFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (receiveraccNo.Substring(0,2)=="PF")
                            {
                                foreach (PF acc in pfList)
                                {

                                    if (acc.AccNo == receiveraccNo)
                                    {
                                        deposited=acc.Deposit(transferAmount);
                                        receiverFound = true;
                                    }
                                    if (receiverFound == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            
                        }
                        if (withdrawn && deposited)
                        {
                            Console.WriteLine("Amount Transferred");
                        }
                        else if(!senderFound)
                        {
                            Console.WriteLine("Sender's Account not Found");
                        }
                        else if(withdrawn&&!receiverFound)
                        {
                            Console.WriteLine("Receiver's Account not Found");
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)"); 
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 7:
                        Console.WriteLine("Active Accounts\n----------------------\n");
                        foreach (Savings acc in savList)
                        {
                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- Savings");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        foreach (Current acc in curList)
                        {
                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- Current");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        foreach (PF acc in pfList)
                        {
                            if (acc.AccIsactive == true)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- PF");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 8:
                        Console.WriteLine("Inactive Accounts\n----------------------\n");
                        foreach (Savings acc in savList)
                        {
                            if (acc.AccIsactive == false)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- Savings");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        foreach (Current acc in curList)
                        {
                            if (acc.AccIsactive == false)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- Current");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        foreach (PF acc in pfList)
                        {
                            if (acc.AccIsactive == false)
                            {
                                Console.WriteLine("Account no. - " + acc.AccNo);
                                Console.WriteLine("Account Holder name - " + acc.AccName);
                                Console.WriteLine("Account Type- PF");
                                Console.WriteLine("Account Balance - " + acc.AccBalance);
                                Console.WriteLine("-------------------------------------------------------\n");
                            }
                        }
                        Console.WriteLine("Do you wish to continue (Y-Yes/N-No)");
                        if (Console.ReadLine() == "N")
                            continue_banking = false;
                        break;
                    case 9:
                        continue_banking = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.\n Press Enter to Continue");
                        Console.ReadLine();
                        break;
                }


            }
            Console.Clear();
            Console.WriteLine("Thankyou for using this application!");
            #endregion
        }

    }
}
