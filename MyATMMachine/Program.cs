using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM Machine";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.Clear();
                       
            int amount = 2034, deposit, withdraw;
            int choice = 0, x = 0;
                        
            Console.WriteLine("Hello User! Please enter your 4 digit pin!");
            RequestPin();
            while(true){
                Console.WriteLine("\n WELCOME TO ATM SERVICE \n");
                Console.WriteLine("1. Current Balance \n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("*************** \n\n");
                Console.Write("Enter your choice: \n");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Your current balance is £{0}", amount);
                        break;
                    case 2: Console.WriteLine("Enter your withdraw");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 10 != 0)
                        {
                            Console.WriteLine("\n Please enter the amount in above 10");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n Sorry! Insufficient balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n Please collect your cash");
                            Console.WriteLine("\n Current balance is £{0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Enter the deposit amount");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Your amount has been deposited successfully!");
                        Console.WriteLine("Your total balance is £{0}", amount);
                        break;
                    case 4: Console.WriteLine("\n Thank you!"); 
                        break;
                }
            }
        }

         private static string RequestPin()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
            {
                return sb.ToString();
            }          
        } 
    }
}
