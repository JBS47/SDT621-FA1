using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        double balance, withdrawal;

        // Ask for name
        Console.WriteLine
            ("HI, WHAT IS YOUR NAME? ");
        name = Console.ReadLine();

        Console.WriteLine("\nWELCOME " + name.ToUpper() + "!");

        // Enter balance
        Console.Write("Enter Account Balance: ");
        while (!double.TryParse(Console.ReadLine(), out balance) || balance < 0)
        {
            Console.Write("Invalid input. Enter a valid balance: ");
        }

        // Enter withdrawal amount
        Console.Write("Enter Withdrawal amount: ");
        while (!double.TryParse(Console.ReadLine(), out withdrawal) || withdrawal < 0)
        {
            Console.Write("Invalid input. Enter a valid amount: ");
        }

        // Check funds
        if (withdrawal > balance)
        {
            Console.WriteLine("\nInsufficient funds! Transaction cancelled.");
        }
        else
        {
            balance -= withdrawal;

            Console.WriteLine("\nWithdrawal successful!");
            Console.WriteLine("Updated Balance: " + balance);
            Console.WriteLine("Transaction Time: " + DateTime.Now);
        }

        Console.ReadLine();
    }
}