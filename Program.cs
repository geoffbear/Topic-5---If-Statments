using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Topic_5___If_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Welcome to Automatic Teller Machine! To use the ATM (type '1'), to pay for your parking ticket (type '2'), to exit (type '3')");
            int response = Convert.ToInt32(Console.ReadLine());

            switch (response)
            {
                case (1):
                    BankingMachine();
                    break;

                case (2):
                    Parking();
                    break;
            }


        }




        static void BankingMachine()
        {
                double balance = 150;
                Console.WriteLine("Would you like to deposit (type '1'), withdrawl (type '2'), pay a bill (type '3') or check your account balance (type '4') exit (type '5')");
                int atm = Convert.ToInt32(Console.ReadLine());

                if (atm == 1)
                {
                    balance = balance - 0.75;
                    Console.WriteLine("You have chosen deposit, how much would you like to deposit? (type just a number)");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your new balance is: ${deposit + balance}");

                }

                if (atm == 2)
                {
                    balance = balance - 0.75;
                    Console.WriteLine("You have chosen withdrawl, how much would you like to withdraw? (just type a number, you currently have $149.25)");
                    double withdrawl = Convert.ToInt32(Console.ReadLine());
                    if (withdrawl >= 149.25)
                    {
                    withdrawl = 149.25;
                    }
                    else if (withdrawl <= 0)
                    {
                    withdrawl = 0;
                    }
                    Console.WriteLine($"Your new balance is: ${balance - withdrawl}");

                }

                if (atm == 3)
                {
                balance = balance - 0.75;
                Console.WriteLine("You have chosen to pay a bill, how much would you like to pay? (just type a number, you currently have $149.25)");
                double withdrawl = Convert.ToInt32(Console.ReadLine());
                    if (withdrawl >= 149.25)
                    {
                    withdrawl = 149.25;
                    }
                    else if (withdrawl <= 0)
                    {
                    withdrawl = 0;
                    }
                Console.WriteLine($"Your new balance is: ${balance - withdrawl}");

                }

                if (atm == 4)
                {
                    balance = balance - 0.75;
                    Console.WriteLine($"You current balance is ${balance}");
                }
            }

        static void Parking()
        {
            Console.WriteLine("Thank you for parking, how long will you be parking? (just a number, in mins)");
            int time = Convert.ToInt32(Console.ReadLine());
            int hours = time / 60;
            double charge;

            charge = hours * 2 + 4;

            if (time % 60 != 0) 
            {
                hours++;
            }

            if (charge >= 20)
            {
                charge = 20;
            }

            Console.WriteLine($"This will cost you {charge}.00");
        }

    }
}
