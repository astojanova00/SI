


//Задача 2, Задача за банкомат

using System;

namespace Bankomatt
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 15000, rest, current, pin = 2320, pin1, pin2;

            Console.WriteLine("Enter the pin");
            pin1 = int.Parse(Console.ReadLine());

            if (pin1 == pin)
            {
                Console.WriteLine("1. Press 1 if you want to Withdraw cash");
                Console.WriteLine("2. Press 2 if you want to Deposit cash");
                Console.WriteLine("3. Press 3 if you want to Check balance");
                Console.WriteLine("4. Press 4 if you want to Change pin");
                

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The current balance on your account is" + total);
                        break;

                    case 2:
                        Console.WriteLine("Enter the sum you want to withdraw");
                        {
                            rest = int.Parse(Console.ReadLine());


                                if (total >= rest)
                            {
                                if (rest % 100 == 0)
                                {
                                    Console.WriteLine("Please collect the cash" + rest);
                                    current = total - rest;
                                    Console.WriteLine("The current balance is now" + current);
                                }

                                else
                                    Console.WriteLine("Please enter the amount to withdrow that multiplies with 100");

                            }

                            else
                                Console.WriteLine("You don't have enough money in your account");

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount you want to deposit");
                        rest = int.Parse(Console.ReadLine());
                        current = total + rest;
                        Console.WriteLine("The current balance in the account is" + current);
                        break;

                    case 4:
                        Console.WriteLine("If you want to change your pin");
                        Console.WriteLine("Enter your previous pin");
                        int prepin = int.Parse(Console.ReadLine());
                        if (prepin == pin)
                        {
                            Console.WriteLine("Enter your new pin");
                            pin2 = int.Parse(Console.ReadLine());
                            pin1 = pin2;
                            Console.WriteLine("Your pin is changed");
                        }
                        else
                            Console.WriteLine("Enter your correct pin");
                        break;

                    default:
                        Console.WriteLine("Please select correct option");
                        break;
                }

            }

            else
                Console.WriteLine("The pin is wrong");

        }
    }
}
