using System;
using System.ComponentModel;
public abstract class Arithemeticoperations
{
    public abstract int Add(int n1,int n2);
    public abstract int sub(int n1,int n2);
    public int mul(int n1,int n2)
    {
        return n1*n2;
    }
     public double div(double n1,double n2)
    {
        return n1/n2;
    }
}
class Childclass : Arithemeticoperations
{
     public override int Add(int n1,int n2)
    {
        return n1+n2;
    }
    public override int sub(int n1,int n2)
    {
        return n1-n2;
    }

}
public class Mainprogram
{
    public static void Main(String[] args)
    {
        Childclass c=new Childclass();
        Console.WriteLine("Addition: "+c.Add(35,40));
        Console.WriteLine("Subtraction: "+c.sub(50,32));
        Console.WriteLine("Multiplication: "+c.mul(5,4));
        Console.WriteLine("Division: "+c.div(40,4));
    }
}