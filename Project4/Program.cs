using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{ // My program functions as an ATM machine, tutorial source: https://www.youtube.com/watch?v=qBI7Qnz9Zho&t=116s. I attempted
// this code using a class file, but could not figure it out in time.
    internal class Program
    {
        public class cardHolder
        {
            string firstName, lastName, cardNum;
            int pin;
            double balance;
            // Variables
            public cardHolder(string firstName, string lastName, string cardNum, int pin, double balance)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.cardNum = cardNum;
                this.pin = pin;
                this.balance = balance;
                // Constructor
            }



            public string getNum()
            { return cardNum; }

            public int getPin()
            { return pin; }

            public string getFirstName()
            { return firstName; }

            public string getLastName()
            { return lastName; }

            public double getBalance()
            { return balance; }
            // get Methods
            public void setNum(string newCardNum)
            { cardNum = newCardNum; }

            public void setPin(int newPin)
            { pin = newPin; }

            public void setFirstName(string newFirstName)
            { firstName = newFirstName; }

            public void setLastName(string newLastName)
            { lastName = newLastName; }

            public void setBalance(double newBalance)
            { balance = newBalance; }
            // set Methods
            public static void Main(string[] args)
            {
                void printOptions()
                {
                    Console.WriteLine("Please choose from one of the following options.");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Show Balance");
                    Console.WriteLine("4. Exit");
                    // Function that gives the user a set of options after logging in

                }
                void deposit(cardHolder currentUser)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    double Deposit = Double.Parse(Console.ReadLine());
                    currentUser.setBalance(Deposit);
                    Console.WriteLine("Thank you, your new balance is " + currentUser.getBalance());
                    // Function that handles deposits
                }

                void withdraw(cardHolder currentUser)
                {
                    Console.WriteLine("How much money would you like to withdraw?");
                    double withdrawal = Double.Parse(Console.ReadLine());
                    if (currentUser.getBalance() < withdrawal)
                    {
                        Console.WriteLine("Insufficient balance."); // Error statement
                    }
                    else
                    {
                        currentUser.setBalance(currentUser.getBalance() - withdrawal);
                        Console.WriteLine("Your money has been withdrawn, thank you.");
                        // Function that handles withdraws, if else loop checks if user has enough money
                    }

                }
                void balance(cardHolder Currentuser)
                {
                    Console.WriteLine("Current Balance:" + Currentuser.getBalance());
                    // Function that allows the user to view their balance
                }

                List<cardHolder> cardHolders = new List<cardHolder>();
                cardHolders.Add(new cardHolder("Eliose", "Miki", "4865395114140718", 2321, 760.21));
                cardHolders.Add(new cardHolder("Lotta", "Christie", "4865392428962572", 4159, 980.10));
                cardHolders.Add(new cardHolder("Aleksandra", "Totland", "4865395372780692", 9450, 865.00));
                cardHolders.Add(new cardHolder("Peter", "Mattila", "4865396042080265", 3759, 600.85));
                cardHolders.Add(new cardHolder("Carla", "Shikikawa", "4865395610294555", 2255, 903.64));
                // Default list of users using fake card numbers and pins

                {   // Prompt user
                    Console.WriteLine("Welcome to EZATM!");
                    Console.WriteLine("Please insert your debit card.");
                    String debitCardNum = "";
                    cardHolder currentUser;

                    while (true)
                    {
                        try 
                        {     // User validation loop for debit card number
                            debitCardNum = Console.ReadLine();
                            currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                            if (currentUser != null) { break; }
                            else { Console.WriteLine("Card not recognized, please try again."); }

                        }
                        catch { Console.WriteLine("Card not recognized, please try again."); } // Error statement
                    }

                    Console.WriteLine("Please enter your pin.");
                    int userPin = 0;
                    while (true)
                    {
                        try
                        {     // User validation loop for pin number
                            userPin = int.Parse(Console.ReadLine());
                            if (currentUser.getPin() == userPin) { break; }
                            else { Console.WriteLine("Incorrect pin, please try again."); }


                        }
                        catch { Console.WriteLine("Incorrect pin, please try again."); } // Error statement


                    }

                    Console.WriteLine("Welcome " + currentUser.getFirstName());
                    int option = 0;
                    do
                    {
                        printOptions();
                        try
                        {
                            option = int.Parse(Console.ReadLine());
                        }
                        catch { }
                        if (option == 1) { deposit(currentUser); }
                        else if (option == 2) { withdraw(currentUser); }
                        else if (option == 3) { balance(currentUser); }
                        else if (option == 4) { break; }
                        else { option = 0; }
                        // if and else if loops to process user input
                    }
                    while (option != 4);
                    Console.WriteLine("Thank you, have a nice day!"); // Exit message




                }

            }
        }
    }
}
    
