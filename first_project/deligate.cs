using System;
using System.Collections.Generic;
public class Deligateprgm
{
    static int Add(int a,int b)
    {
        return a+b;
    }
    static int Sub(int a,int b)
    {
        return a-b;
    }
    static int Mul(int a,int b)
    {
        return a*b;
    }
    static int Div(int a,int b)
    {
        return a/b;
    }
    public delegate int myde(int n1,int n2);
    static void Main()
    {
        myde d = new myde(Add);
        Console.WriteLine("Addition: " + d(5, 6));

        d = Sub;
        Console.WriteLine("Subtraction: " + d(10, 6));

        d = Mul;
        Console.WriteLine("Multiplication: " + d(5, 6));
        d = Div;
        Console.WriteLine("Multiplication: " + d(5, 6));
    }
}