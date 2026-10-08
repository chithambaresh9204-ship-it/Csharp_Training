using System;
public class Quadrant
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the x-co-ordinates");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the y-co-ordinates");
        int y=Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point lies on the first quadrant!");
        }else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point lies on the second quadrant!");
        }else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point lies on the third quadrant!");
        }else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point lies on the fouth quadrant!");
        }
    }
}