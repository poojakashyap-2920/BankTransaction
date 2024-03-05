using System;

namespace BankDetails_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial balance:");
            float initialBalance = float.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(initialBalance);

            while (true)
            {
                Console.WriteLine("1. Withdraw\n2. Deposit\n3. Check Balance\n4. Exit");
                Console.WriteLine("Enter option:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter amount to withdraw:");
                        float withdrawAmount = float.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to deposit:");
                        float depositAmount =  float.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 3:
                        account.CheckBalance();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
