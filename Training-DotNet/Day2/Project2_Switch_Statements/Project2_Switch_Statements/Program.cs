using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK1
            //bool continue_banking = true;
            //while (continue_banking)
            //{
            //    Console.Clear();
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~Welcome to Banking~~~~~~~~~~~~~~~~~~~~");
            //    Console.WriteLine("1. Create New Account");
            //    Console.WriteLine("2. View Account List ");
            //    Console.WriteLine("3. Check Account Details");
            //    Console.WriteLine("4. Transfer Funds ");
            //    Console.WriteLine("5. Cheque Book Applied");
            //    Console.WriteLine("6. Loan Application Accepted");
            //    Console.WriteLine("7. Exit ");
            //    Console.WriteLine("\nEnter your choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Clear();
            //            Console.WriteLine("Enter type of Account");
            //            Console.WriteLine("1. Savings");
            //            Console.WriteLine("2. Current");
            //            Console.WriteLine("3. PF");
            //            Console.WriteLine("\nEnter your choice");
            //            int account_choice = Convert.ToInt32(Console.ReadLine());
            //            switch (account_choice)
            //            {
            //                case 1:
            //                    Console.WriteLine("Savings Account Created");
            //                    Console.WriteLine("Press Enter to continue");
            //                    Console.ReadLine();
            //                    break;
            //                case 2:
            //                    Console.WriteLine("Current Account Created");
            //                    Console.WriteLine("Press Enter to continue");
            //                    Console.ReadLine();
            //                    break;
            //                case 3:
            //                    Console.WriteLine("PF Account Created");
            //                    Console.WriteLine("Press Enter to continue");
            //                    Console.ReadLine();
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid Choice");
            //                    Console.WriteLine("Press Enter to continue");
            //                    Console.ReadLine();
            //                    break;
            //            }
            //            break;
            //        case 2:
            //            Console.Clear();
            //            Console.WriteLine("Account List is below");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;
            //        case 3:
            //            Console.Clear();
            //            Console.WriteLine("Account details are below");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;
            //        case 4:
            //            Console.Clear();
            //            Console.WriteLine("Transfer Funds below");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;
            //        case 5:
            //            Console.Clear();
            //            Console.WriteLine("Cheque Book Applied");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;
            //        case 6:
            //            Console.Clear();
            //            Console.WriteLine("Enter type of Loan");
            //            Console.WriteLine("1. Automobile");
            //            Console.WriteLine("2. Personal");
            //            Console.WriteLine("3. Educational");
            //            Console.WriteLine("\nEnter your choice");
            //            int loan_choice = Convert.ToInt32(Console.ReadLine());
            //                    switch (loan_choice)
            //                    {
            //                        case 1:
            //                            Console.WriteLine("Enter type of Vehicle");
            //                            Console.WriteLine("1. Car");
            //                            Console.WriteLine("2. Bike");
            //                            Console.WriteLine("3. Truck");
            //                            Console.WriteLine("\nEnter your choice");
            //                            int auto_choice = Convert.ToInt32(Console.ReadLine());
            //                            switch (auto_choice)
            //                            {
            //                                case 1:
            //                                    Console.WriteLine("Car Loan Approved");
            //                                    Console.WriteLine("Press Enter to continue");
            //                                    Console.ReadLine();
            //                                    break;
            //                                case 2:
            //                                    Console.WriteLine("Bike Loan Approved");
            //                                    Console.WriteLine("Press Enter to continue");
            //                                    Console.ReadLine();
            //                                    break;
            //                                case 3:
            //                                    Console.WriteLine("Truck Loan Approved");
            //                                    Console.WriteLine("Press Enter to continue");
            //                                    Console.ReadLine();
            //                                    break;
            //                                default:
            //                                    Console.WriteLine("Invalid Choice");
            //                                    Console.WriteLine("Press Enter to continue");
            //                                    Console.ReadLine();
            //                                    break;
            //                            }

            //                            break;
            //                        case 2:
            //                            Console.WriteLine("Personal Loan Approved");
            //                            Console.WriteLine("Press Enter to continue");
            //                            Console.ReadLine();
            //                            break;
            //                        case 3:
            //                            Console.WriteLine("Educational Loan Approved");
            //                            Console.WriteLine("Press Enter to continue");
            //                            Console.ReadLine();
            //                            break;
            //                        default:
            //                            Console.WriteLine("Invalid Choice");
            //                            Console.WriteLine("Press Enter to continue");
            //                            Console.ReadLine();
            //                            break;
            //                    }
            //            break;
            //        case 7:
            //            continue_banking = false;
            //            Console.WriteLine("Thankyou for Banking with us!");
            //            break;
            //        default:
            //            break;
            //    }
            //    if (continue_banking == true)
            //    {
            //        Console.WriteLine("Do you wish to continue banking? 1.Yes / 2.No");
            //        choice = Convert.ToInt32(Console.ReadLine());
            //        if (choice != 1)
            //        {
            //            continue_banking = false;
            //            Console.Clear();
            //            Console.WriteLine("Thankyou for Banking with us!");
            //        }
            //    }
            //}
            #endregion
            #region Arrays
            //string[] participants = new string[5];
            //int i = 0;
            //for(i=0;i<5; i++)
            //{
            //    Console.WriteLine("Enter Participant name");
            //    participants[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Participant"+(i+1)+" - "+participants[i]);

            //}
            #endregion
            #region TASK2
            //Console.Clear();
            //Console.WriteLine("Enter number");
            //int[] oddNumbers = new int[1];
            //int[] evenNumbers = new int[1];
            //int[] NegativeNumbers = new int[1];
            //int[] PositiveNumbers = new int[1];
            //int[] MultiplesofFive = new int[1];

            //int num = Convert.ToInt32(Console.ReadLine());

            //while (num != 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Array.Resize(ref evenNumbers, evenNumbers.Length + 1);
            //        evenNumbers[evenNumbers.Length - 2] = num;
            //    }
            //    else
            //    {
            //        Array.Resize(ref oddNumbers, oddNumbers.Length + 1);
            //        oddNumbers[oddNumbers.Length - 2] = num;
            //    }
            //    if (num < 0)
            //    {
            //        Array.Resize(ref NegativeNumbers, NegativeNumbers.Length + 1);
            //        NegativeNumbers[NegativeNumbers.Length - 2] = num;
            //    }
            //    else
            //    {
            //        Array.Resize(ref PositiveNumbers, PositiveNumbers.Length + 1);
            //        PositiveNumbers[PositiveNumbers.Length - 2] = num;
            //    }
            //    if (num % 5 == 0)
            //    {
            //        Array.Resize(ref MultiplesofFive, MultiplesofFive.Length + 1);
            //        MultiplesofFive[MultiplesofFive.Length - 2] = num;
            //    }


            //    num = Convert.ToInt32(Console.ReadLine());

            //}
            //bool continueloop = true;
            //while (continueloop == true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Options");
            //    Console.WriteLine("1.Display odd numbers");
            //    Console.WriteLine("2.Display even numbers");
            //    Console.WriteLine("3.Display negative numbers");
            //    Console.WriteLine("4.Display positive numbers");
            //    Console.WriteLine("5.Display multiples of 5");
            //    Console.WriteLine("Enter your Choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            int i = 0;
            //            Console.WriteLine("Odd Numbers are");
            //            for (i = 0; i < (oddNumbers.Length - 1); i++)
            //            {
            //                Console.WriteLine(oddNumbers[i]);
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Even Numbers are");
            //            for (i = 0; i < (evenNumbers.Length - 1); i++)
            //            {
            //                Console.WriteLine(evenNumbers[i]);
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine(" Negative Numbers are");
            //            for (i = 0; i < (NegativeNumbers.Length - 1); i++)
            //            {
            //                Console.WriteLine(NegativeNumbers[i]);
            //            }
            //            break;
            //        case 4:
            //            Console.WriteLine("Positive Numbers are");
            //            for (i = 0; i < (PositiveNumbers.Length - 1); i++)
            //            {
            //                Console.WriteLine(PositiveNumbers[i]);
            //            }
            //            break;
            //        case 5:
            //            Console.WriteLine("Multiples of 5 are");
            //            for (i = 0; i < (MultiplesofFive.Length - 1); i++)
            //            {
            //                Console.WriteLine(MultiplesofFive[i]);
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }
            //    Console.WriteLine("Do you wish to Continue? 1.Yes /  2.No");
            //    int more = Convert.ToInt32(Console.ReadLine());
            //    if (more == 2)
            //        continueloop = false;
            //}
            #endregion
            #region ArrayList

            //Console.Clear();
            //Console.WriteLine("Enter number");
            //ArrayList oddNumbers = new ArrayList();
            //ArrayList evenNumbers = new ArrayList();
            //ArrayList NegativeNumbers = new ArrayList();
            //ArrayList PositiveNumbers = new ArrayList();
            //ArrayList MultiplesofFive = new ArrayList();

            //int num = Convert.ToInt32(Console.ReadLine());

            //while (num != 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evenNumbers.Add(num);
            //    }
            //    else
            //    {
            //        oddNumbers.Add(num);
            //    }
            //    if (num < 0)
            //    {

            //        NegativeNumbers.Add(num);
            //    }
            //    else
            //    {

            //        PositiveNumbers.Add(num);
            //    }
            //    if (num % 5 == 0)
            //    {

            //        MultiplesofFive.Add(num);
            //    }


            //    num = Convert.ToInt32(Console.ReadLine());

            //}
            //bool continueloop = true;
            //while (continueloop == true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Options");
            //    Console.WriteLine("1.Display odd numbers");
            //    Console.WriteLine("2.Display even numbers");
            //    Console.WriteLine("3.Display negative numbers");
            //    Console.WriteLine("4.Display positive numbers");
            //    Console.WriteLine("5.Display multiples of 5");
            //    Console.WriteLine("Enter your Choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            int i = 0;
            //            Console.WriteLine("Odd Numbers are");
            //            for (i = 0; i < (oddNumbers.Count); i++)
            //            {
            //                Console.WriteLine(oddNumbers[i]);
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Even Numbers are");
            //            for (i = 0; i < (evenNumbers.Count); i++)
            //            {
            //                Console.WriteLine(evenNumbers[i]);
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine(" Negative Numbers are");
            //            for (i = 0; i < (NegativeNumbers.Count); i++)
            //            {
            //                Console.WriteLine(NegativeNumbers[i]);
            //            }
            //            break;
            //        case 4:
            //            Console.WriteLine("Positive Numbers are");
            //            for (i = 0; i < (PositiveNumbers.Count); i++)
            //            {
            //                Console.WriteLine(PositiveNumbers[i]);
            //            }
            //            break;
            //        case 5:
            //            Console.WriteLine("Multiples of 5 are");
            //            for (i = 0; i < (MultiplesofFive.Count); i++)
            //            {
            //                Console.WriteLine(MultiplesofFive[i]);
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }
            //    Console.WriteLine("Do you wish to Continue? 1.Yes /  2.No");
            //    int more = Convert.ToInt32(Console.ReadLine());
            //    if (more == 2)
            //        continueloop = false;
            //}
            #endregion

            #region HashTable
            //Hashtable table = new Hashtable();
            //table[101] = "one hundred one";
            //table[102] = "one hundred two";
            //table[103] = "one hundred three";
            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            #endregion

            #region Lists
            //List<String> students = new List<String>();
            //students.Add("Namitha");
            //students.Add("Divya");
            //students.Add("Varsha");
            //foreach (String item in students)
            //{
            //    Console.WriteLine(item);
            //}
            //students.Remove("Namitha");
            //Console.WriteLine("After deletion");
            //foreach (String item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict[101] = "one hundred one";
            dict[102] = "one hundred two";
            dict[103] = "one hundred three";
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
           
            
            #endregion

        }

    }
}