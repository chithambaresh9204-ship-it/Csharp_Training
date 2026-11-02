using System;
using System.Transactions;
public class Dictionary
{
    public static void Main(String[] args)
    {
        Dictionary<int,int>num=new Dictionary<int, int>();
        Console.WriteLine("Enter the numbers of Value need to be added: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter "+n+" numbers One by One");
        for(int i=0;i<n ;i++)
        {
            num.Add(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Printing");
        foreach(KeyValuePair<int,int>i in num)
        {
            Console.WriteLine(i);
        }
    }
}