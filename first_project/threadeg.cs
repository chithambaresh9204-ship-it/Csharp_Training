using System;
using System.Threading;

public class AddProgram
{
     public static void ADD(int num1, int num2)
    {
        Console.WriteLine(" Addition Process Started");
        Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(3000);

        Console.WriteLine(num1+num2);
    }
}
class SubProgram{
    public static void SUB(int num1,int num2)
    {
        Console.WriteLine("Subtraction Process Started");
        Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(2000);

        Console.WriteLine(num1-num2);
    }
}
class MultiplyProgram{
    public void MUL(int num1, int num2)
    {
        Console.WriteLine("Multiplication Process Started");
        Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(1000);

        Console.WriteLine(num1*num2);
    }
}
class DivProgram{
    public void DIV(int num1, int num2)
    {
        Console.WriteLine("Division Process Started");
        Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(1500);

        Console.WriteLine(num1/num2);
    }
}
class ExProgram{
    static void Main(String[]args)
    {
       MultiplyProgram m= new MultiplyProgram();
       DivProgram d= new DivProgram();
        Thread t1 = new Thread(()=>AddProgram.ADD(2,5));
        t1.Name="Addition-Thread";
        Thread t2 = new Thread(()=>SubProgram.SUB(3,2));
        t2.Name="Subtraction-Thread";
        Thread t3 = new Thread(()=>m.MUL(3,5));
        t3.Name="Multiplication-Thread";
        Thread t4 = new Thread(()=>d.DIV(15,5));
        t4.Name="Division-Thread";

        t1.Start();
        t1.Join(3000);
        t2.Start();
        t2.Join(3000);
        t3.Start();
        t3.Join(3000);
        t4.Start();
        t4.Join(3000);

        Console.WriteLine("Main thread is also running");
    }
}
