using System;
using System.Runtime.CompilerServices;
public class Banking
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Your Room Type(1]Normal rs2000/day \n 2] Suit rs5000/day \n 3] Delux rs3500/day): ");
        string Type=Console.ReadLine();
        Console.Write("How many days you want to stay: ");
        int Days=Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you have Membership: ");
        string Membership=Console.ReadLine();
        Console.Write("How many days you want food: ");
        int food_count=Convert.ToInt32(Console.ReadLine());
        double total=0;
        int foodamt=0;
        switch (Type)
        {
            case("Normal"):
                total=2000*Days;
                break;
            case("Delux"):
                total=3500*Days;
                break;
            case("Suit"):
                total=5000*Days;
                break;
            default:
                Console.WriteLine("Enter a Valid Room Type");
                break;
        }
        if (food_count > 0)
        {
            foodamt=500*food_count;
            total=total+foodamt;
        }
        if (Membership == "YES")
        {
            total -= total * 0.05;
        }
        double gstamt=total*0.12;
        total+=gstamt;
        Console.WriteLine("Hi "+name+", You Have Choosen the room type "+Type+" and the total amount including food and gst will be "+total);
    }
}