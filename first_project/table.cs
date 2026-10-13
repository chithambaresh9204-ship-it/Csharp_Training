using System;
public class Table
{
    public static void Main(String[] args)
    {
        //Printing table
        Console.Write("Enter a number for printing the Table: ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i+"*"+num+":"+num*i);
        }
    }
}