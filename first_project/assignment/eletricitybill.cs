using System;

class ElectricityBillSystem
{
    static void Main()
    {
        int totalCustomers = 0;
        double totalRevenue = 0.0;
        bool keepRunning = true;

        Console.WriteLine("=== Electricity Bill Management System ===");

        while (keepRunning)
        {
            Console.WriteLine("\n--- Enter Customer Details ---");

            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            double units;
            while (!double.TryParse(Console.ReadLine(), out units) || units < 0)
            {
                Console.Write("Invalid input. Enter positive units: ");
            }

            // Slab calculation:
            // 0 - 100 units : $1.50 per unit
            // 101 - 300 units: $2.50 per unit
            // 301+ units : $4.00 per unit
            double energyCharges = 0;

            if (units <= 100)
            {
                energyCharges = units * 1.50;
            }
            else if (units <= 300)
            {
                energyCharges = (100 * 1.50) + ((units - 100) * 2.50);
            }
            else
            {
                energyCharges = (100 * 1.50) + (200 * 2.50) + ((units - 300) * 4.00);
            }

            double fixedCharge = 50.00;
            double surcharge = 0.00;

            // Apply 10% surcharge if energy charges exceed $500
            if (energyCharges > 500)
            {
                surcharge = energyCharges * 0.10;
            }

            double totalBill = energyCharges + fixedCharge + surcharge;

            // Payment category
            string category;
            if (totalBill < 200)
                category = "Low Usage (Standard)";
            else if (totalBill <= 800)
                category = "Moderate Usage (Commercial/Regular)";
            else
                category = "High Usage (Industrial/Heavy)";

            // Display Bill
            Console.WriteLine("\n---------------- BILL SUMMARY ----------------");
            Console.WriteLine($"Customer ID : {customerId}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Units Consumed : {units}");
            Console.WriteLine($"Energy Charges : ${energyCharges:F2}");
            Console.WriteLine($"Fixed Charges : ${fixedCharge:F2}");
            Console.WriteLine($"Surcharge : ${surcharge:F2}");
            Console.WriteLine($"Total Bill : ${totalBill:F2}");
            Console.WriteLine($"Category : {category}");
            Console.WriteLine("----------------------------------------------");

            totalCustomers++;
            totalRevenue += totalBill;

            Console.Write("\nProcess another customer? (y/n): ");
            string choice = Console.ReadLine().Trim().ToLower();
            keepRunning = (choice == "y" || choice == "yes");
        }

        Console.WriteLine("\n================ DAILY SUMMARY ================");
        Console.WriteLine($"Total Customers Processed : {totalCustomers}");
        Console.WriteLine($"Total Revenue Generated : ${totalRevenue:F2}");
        Console.WriteLine("===============================================");
    }
}