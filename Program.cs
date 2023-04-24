using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    public class Program
    {
        public class client
        {
            string fName;
            string lName;
            string cardNum;
            int pin;
            double balance;
            public client(string fName, string lName, string cardNum, int pin, double balance)
            {
                this.fName = fName;
                this.lName = lName;
                this.cardNum = cardNum;
                this.pin = pin;
                this.balance = balance;
            }
            public string getFirstName()
            {
                return fName;
            }
            public string getLastName()
            {
                return lName;
            }
            public string getCardNumber()
            {
                return cardNum;
            }
            public int getPin()
            {
                return pin;
            }
            public double getBalance()
            {
                return balance;
            }
            public void setFirstName(string newFirstName)
            {
                fName = newFirstName;
            }
            public void setLastName(string newLastName)
            {
                lName = newLastName;
            }
            public void setCardNumber(string newCardNumber)
            {
                cardNum = newCardNumber;
            }
            public void setPin(int newPin)
            {
                pin = newPin;
            }
            public void setBalance(double newBalance)
            {
                balance = newBalance;
            }

            public static void Main(String[] args)
            {
                void printOptions()
                {
                    Console.WriteLine("please choose one of the following options: ");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Show");
                    Console.WriteLine("4. Exit");
                }
                void deposit(client currentClient1)
                {
                    Console.WriteLine("How much $ do you want to deposit : ");
                    double Deposit = double.Parse(Console.ReadLine());
                    currentClient1.setBalance(Deposit + currentClient1.balance);
                    Console.WriteLine("        Thank you , Your new balance is " + currentClient1.getBalance());
                }
                void withdraw(client currentClient1)
                {
                    Console.WriteLine("How much $ do you want to withdraw : ");
                    double Withdraw = double.Parse(Console.ReadLine());
                    if (currentClient1.getBalance() < Withdraw)
                    {
                        Console.WriteLine("Sorry, Insufficient balance");
                    }
                    else
                    {
                        currentClient1.setBalance(currentClient1.balance - Withdraw);
                        Console.WriteLine("     Thank you , Your new balance is " + currentClient1.getBalance());
                    }
                }
                void show(client currentClient1)
                {
                    Console.WriteLine("         Your current balance is " + currentClient1.getBalance());
                }
                List<client> client = new List<client>();
                client.Add(new client("Asmaa", "Khamis", "1191120021", 1, 100000));
                client.Add(new client("Hayam", "Mahmoud", "291220012", 2, 200000));
                client.Add(new client("Ashley", "Jack", "311920043", 3, 90000));
                Console.WriteLine("                       ********************                         \n");
                Console.WriteLine("**********       *     Welcome to SimpleATM      *          **********\n");
                Console.WriteLine("                       ********************                         \n");
                Console.WriteLine("-Please enter your depit card number : ");
                string depitCardNumber = "";
                client user;
                while (true)
                {
                    try
                    {
                        depitCardNumber = Console.ReadLine();
                        user = client.FirstOrDefault(a => a.cardNum == depitCardNumber);
                        if (user != null) { break; }
                        else { Console.WriteLine("Card not found, Please try again "); }
                    }
                    catch { Console.WriteLine("Card not found, Please try again "); }
                }

                Console.WriteLine("-Please enter your pin number : ");
                int pinNumber = 0;
                while (true)
                {
                    try
                    {
                        pinNumber = int.Parse(Console.ReadLine());
                        if (user.getPin() == pinNumber) { break; }
                        else { Console.WriteLine("Incorrect pin, Please try again "); }
                    }
                    catch { Console.WriteLine("Incorrect pin, Please try again "); }
                }

                Console.WriteLine("Welcome " + user.getFirstName() + " <. .>");
                int option = 0;
                
                    printOptions();
                    option = int.Parse(Console.ReadLine());
                    
                        if (option == 1) { deposit(user); }
                        else if (option == 2) { withdraw(user); }
                        else if (option == 3) { show(user); }
                        else  { option = 0; }

     
                    Console.WriteLine("\n\n*****************  Thank you,Have a good day <..>  *****************\n");
            }

        }

    }
}
