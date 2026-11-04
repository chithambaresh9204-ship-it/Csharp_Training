using System;
 public static class FULLName
{
    public static string fulllname(this string Fname, string Mname,string Lname){
        return Fname+" "+Mname+" "+ Lname;
    }
}
public class UMainFunc
{
    public static void Main()
    {
        string Fname="Mahendra";
        string Mname="Shingh";
        string Lname="Dhoni";
        string Funame=Fname.fulllname(Mname,Lname);
        Console.WriteLine(Funame);
    }
}