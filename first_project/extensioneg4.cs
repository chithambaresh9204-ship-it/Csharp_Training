using System;
 public static class FULLNAME
{
    public static void fullllname(this string Fname, string Mname,string Lname){
        Console.WriteLine( Fname+" "+Mname+" "+ Lname);
    }
}
public class MAinFunc
{
    public static void Main()
    {
        string Fname="Mahendra";
        string Mname="Shingh";
        string Lname="Dhoni";
        Fname.fullllname(Mname,Lname);
        
    }
}