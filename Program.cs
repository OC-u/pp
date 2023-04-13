using System;

namespace FinancialManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Financial Management System!");

            // Create a user with a default password
            User user = new User("Tecla", "664445");

            bool loggedIn = false;

            while (!loggedIn)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Login to your account");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        user.CreateAccount();
                        break;
                    case "2":
                        loggedIn = user.Login();
                        if (loggedIn)
                        {
                            Console.WriteLine("Choose an option:");
                            Console.WriteLine("1. Save money");
                            Console.WriteLine("2. Invest money");

                            string investChoice = Console.ReadLine();

                            switch (investChoice)
                            {
                                case "1":
                                    user.SaveMoney();
                                    break;
                                case "2":
                                    user.InvestMoney();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again.");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Logged in successfully!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void CreateAccount()
        {
            Console.WriteLine("Enter account number:");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter account type:");
            string accountType = Console.ReadLine();

            Console.WriteLine($"Account created successfully!\nAccount Number: {accountNumber}\nUsername: {username}\nAccount Type: {accountType}");
        }

        public bool Login()
        {
            Console.WriteLine("Enter your password:");
            string inputPassword = Console.ReadLine();

            if (inputPassword == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid password. Please try again.");
                return false;
            }
        }

        public void SaveMoney()
        {
            Console.WriteLine("How much money would you like to save?");
            string amountToSave = Console.ReadLine();

            if (Int32.TryParse(amountToSave, out int amount))
            {
                if (amount >= 1000 && amount <= 100000)
                {
                    Console.WriteLine($"You have saved {amount} successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter an amount between 1000 and 100000.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void InvestMoney()
        {
            Console.WriteLine("How much money would you like to invest?");
            string amountToInvest = Console.ReadLine();
            Console.WriteLine($"You have invested {amountToInvest} successfully!");
        }
    }
}
