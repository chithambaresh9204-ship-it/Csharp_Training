using System;
public class VehicleRental
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Your Vehicle Type(1]Bike rs300/day \n 2]Car rs1000/day): ");
        string Type=Console.ReadLine();
        Console.Write("How many days you want to rent: ");
        int Days=Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you have Driving License: ");
        string DrivingLicense=Console.ReadLine();
        Console.Write("Enter your age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        double total=0;
        if (DrivingLicense == "YES"&& age >= 20 && age <= 45)
        {
            switch (Type)
            {
                case("Bike"):
                    total=300*Days;
                    break;
                case("Car"):
                    total=1000*Days;
                    break;
                default:
                    Console.WriteLine("Enter a Valid Vehicle Type");
                    break;
            }
        }
        else
        {
            Console.WriteLine("You are not eligible to rent a vehicle");
        }
        Console.WriteLine("Hi "+name+", You Have Choosen the vehicle type "+Type+" and the total amount including gst will be "+total);
    }
}