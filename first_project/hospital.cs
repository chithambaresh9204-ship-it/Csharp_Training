using System;
public class Hospital
{
    public static void Main(String [] args)
    {
        Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Your Room Type \n 1]General rs500/day \n 2]Private rs2000/day \n 3]ICU rs5000/day: ");
        string Type=Console.ReadLine();
        Console.Write("How many days you want to stay: ");
        int Days=Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you have Insurance: ");
        string Insurance=Console.ReadLine();
        Console.Write("Enter your age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        int consoultancyfees=800;
        double total=0;
        switch (Type)
        {
            case("General"):
                total=500*Days;
                break;
            case("Private"):
                total=2000*Days;
                break;
            case("ICU"):
                total=5000*Days;
                break;
            default:
                Console.WriteLine("Enter a Valid Room Type");
                break;
        }
        if (Insurance == "YES")
        {
            total -= total * 0.10;
        }
        if (age > 60)
        {
            total -= total * 0.05;
        }
        total+=consoultancyfees;
        Console.WriteLine("Hi "+name+", You Have Choosen the room type "+Type+" and the total amount including consoultancy fees will be "+total);
    }
}