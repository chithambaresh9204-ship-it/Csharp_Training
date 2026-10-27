using System;
public class Polymorphism{
    public int ADD(int a,int b)
    {   
        return a+b;
        
    }
    public double ADD(double a,double b)
    {     
        return a+b;
        
    }
    public string ADD(string a,string b)
    {   
        
        return a+b;
    }
    public static void Main(String[] args)
    {
        Polymorphism p = new Polymorphism();

        Console.WriteLine(p.ADD(3, 5));
        Console.WriteLine(p.ADD(3.5, 5.5));
        Console.WriteLine(p.ADD("3", "5"));
    }
}