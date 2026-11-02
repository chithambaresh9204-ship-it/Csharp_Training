using System;
using System.Transactions;
public class List
{
    public static void Main(String[] args)
    {
        List<int>num=new List<int>();
        Console.WriteLine("Enter the numbers of Value need to be added: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter "+n+" numbers One by One");
        for(int i=0;i<n ;i++)
        {
            num.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Printing");
        foreach(int i in num)
        {
            Console.WriteLine(i);
        }
    }
}