using System;
using System.Transactions;
public class ATM
{
    public static void Main(String[] args)
    {
        int Pin =100705;
        double Balance=10000;
        Console.Write("Enter the Mode: ");
        string Mode=Console.ReadLine();
        Console.Write("Enter your PIN: ");
        int pin=Convert.ToInt32(Console.ReadLine());
        if (pin == Pin)
        {
            switch (Mode)
            {
                case "Withdraw":
                    Console.Write("Enter the Amount to Withdraw: ");
                    double Withdraw = Convert.ToDouble(Console.ReadLine());
                    if (Withdraw > Balance)
                    {
                        Console.WriteLine("INSUFFICIENT BALANCE");
                    }
                    else
                    {
                        Balance = Balance - Withdraw;
                        Console.WriteLine("You have Successfully Withdrawed the amount of: " + Withdraw);
                        Console.WriteLine("Your Available Balance is: " + Balance);
                    }
                    break;
                case "Deposit":
                    Console.Write("Enter the amount to Deposit: ");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the Mode for Deposit CASH/NETBANKING: ");
                    string mode = Console.ReadLine();
                    Balance= Balance+amt;
                    Console.WriteLine("Your Available Balance is: " + Balance);
                    Console.WriteLine("You have successfully deposited and amount of:"+amt+" using the mode of: "+mode);
                    break;
                default:
                    Console.WriteLine("Invalid mode");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Enter the Correct Pin");
        }
        

        
    }
}