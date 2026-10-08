using System;
public class calci
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first num: ");
        int num1=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the second num: ");
        int num2=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the Opertaions to be performed ");
        string operations =Console.ReadLine();
        switch(operations){
            case "add":
                Console.WriteLine(num1+num2);
                break;
            case "sub":
                Console.WriteLine(num1-num2);
                break;
            case "mul":
                Console.WriteLine(num1*num2);
                break;
            case "div":
                Console.WriteLine(num1/num2);
                break;
            default:
                Console.WriteLine("End");
                break;
        }
    }

}