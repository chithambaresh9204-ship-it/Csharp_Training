using System;
namespace ATMSystem
{
    public class ATM
    {
        private string accountHolder;
        private int pin;
        private double balance;
        private int failedAttempts;
        private const int MaxFailedAttempts = 3;
        public string AccountHolder
        {
            get => accountHolder;
            set => accountHolder = value;
        }
        public double Balance => balance;
        public ATM(string accountHolder, int initialPin, double initialBalance)
        {
            if (!IsValidFourDigitPin(initialPin))
                throw new ArgumentException("Initial PIN must contain exactly 4 digits.");
            this.accountHolder = accountHolder;
            this.pin = initialPin;
            this.balance = initialBalance;
            this.failedAttempts = 0;
        }
        private bool IsValidFourDigitPin(int pinToValidate)
        {
            return pinToValidate >= 1000 && pinToValidate <= 9999;
        }
        public bool ValidatePIN(int enteredPin)
        {
            if (failedAttempts >= MaxFailedAttempts)
            {
                Console.WriteLine("Account Locked");
                return false;
            }
            if (enteredPin == pin)
            {
                failedAttempts = 0;
                Console.WriteLine("PIN Verified Successfully");
                return true;
            }
            failedAttempts++;
            Console.WriteLine("Incorrect PIN");
            if (failedAttempts >= MaxFailedAttempts)
                Console.WriteLine("Account Locked");
            return false;
        }
        public bool ChangePIN(int oldPin, int newPin)
        {
            if (failedAttempts >= MaxFailedAttempts)
            {
                Console.WriteLine("Account Locked. Cannot change PIN.");
                return false;
            }
            if (!ValidatePIN(oldPin))
                return false;
            if (!IsValidFourDigitPin(newPin))
            {
                Console.WriteLine("New PIN must contain exactly 4 digits.");
                return false;
            }
            if (oldPin == newPin)
            {
                Console.WriteLine("New PIN must be different from the old PIN.");
                return false;
            }
            pin = newPin;
            Console.WriteLine("PIN Changed Successfully.");
            return true;
        }
        public bool Withdraw(int enteredPin, double amount)
        {
            if (!ValidatePIN(enteredPin))
                return false;
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return false;
            }
            if (amount > balance)
            {
                Console.WriteLine("Withdrawal exceeds available balance.");
                return false;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawal Amount: {amount}");
            Console.WriteLine($"Remaining Balance: {balance}");
            return true;
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Remaining Balance: {Balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ATM userAtm = new ATM("Arun", 1234, 10000);
            Console.WriteLine($"Account Holder: {userAtm.AccountHolder}");
            userAtm.Withdraw(1234, 2000);
            userAtm.ValidatePIN(1111);
            userAtm.ValidatePIN(2222);
            userAtm.ValidatePIN(3333);
        }
    }
}