using System;
 public static class FullName
{
    public static string fullname(this string Fname, string Lname){
        return Fname+" "+Lname;
    }
}
public class MainFunc
{
    public static void Main()
    {
        string Fname="Mahendra Shingh";
        string Lname="Dhoni";
        string Funame=Fname.fullname(Lname);
        Console.WriteLine(Funame);
    }
}