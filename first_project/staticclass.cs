using System;

static class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void SUB(int a,int b)
    {
        Console.WriteLine(a - b);
    }
}

class program
{
    static void Main()
    {
        Calculator.Add(10, 20);
        Calculator.SUB(20,10);
    }
}
