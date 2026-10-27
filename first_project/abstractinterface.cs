using System;

interface Iinterface1{
        int add(int n1,int n2);
        int sub(int n1,int n2); 
}
interface Iinterface2{
        int mul(int n1,int n2);
        int div(int n1,int n2); 
}

public class Child : Iinterface1,Iinterface2
{
    public int add(int n1,int n2)
    {
        return n1+n2;
    }
    public int sub(int n1,int n2)
    {
        return n1-n2;;
    }
    public int mul(int n1,int n2)
    {
        return n1*n2;
    }
    public int div(int n1,int n2)
    {
        return n1/n2;
    }
}
public class MainPrgm
{
    public static void Main(String[] args)
    {
        Child c=new Child();
        Console.WriteLine("Addition: "+ c.add(5,3));
        Console.WriteLine("Subtraction: "+ c.sub(5,3));
        Console.WriteLine("Multiplication: "+ c.mul(5,3));
        Console.WriteLine("Division: "+ c.div(15,3));
    }
}