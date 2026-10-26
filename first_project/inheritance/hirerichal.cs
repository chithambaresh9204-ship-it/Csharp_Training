using System;
class University
{
    public string cname = "Kalasalingam Academy of Research and Education, Krishnankovil";
}

class Student : University
{
    public void GetStudentDetails()
    {
        Console.WriteLine("Enter the number of students:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int[] roll = new int[num1];
        string[] sname = new string[num1];
        string[] domain = new string[num1];

        for (int i = 0; i < num1; i++)
        {
            Console.WriteLine("Enter the name of student:");
            sname[i] = Console.ReadLine();

            Console.WriteLine("Enter the roll number of student:");
            roll[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the domain of student:");
            domain[i] = Console.ReadLine();
        }

        DisplayStudentDetails(sname, roll, domain);
    }

    public void DisplayStudentDetails(string[] n, int[] r, string[] d)
    {
        for (int i = 0; i < n.Length; i++)
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Name: " + n[i]);
            Console.WriteLine("Roll Number: " + r[i]);
            Console.WriteLine("Domain: " + d[i]);
        }
        Console.WriteLine("\nUniversity: " + cname);
    }
}

class Staff : University
{
    public void GetStaffDetails()
    {
        Console.WriteLine("Enter the number of staff:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        string[] staffname = new string[num2];
        string[] domain1 = new string[num2];
        for (int i = 0; i < num2; i++)
        {
            Console.WriteLine("Enter the name of staff:");
            staffname[i] = Console.ReadLine();
            Console.WriteLine("Enter the domain of staff:");
            domain1[i] = Console.ReadLine();
        }
        DisplayStaffDetails(staffname, domain1);
    }
    public void DisplayStaffDetails(string[] ns, string[] ds)
    {
        for (int i = 0; i < ns.Length; i++)
        {
            Console.WriteLine("\nStaff Details");
            Console.WriteLine("Staff Name: " + ns[i]);
            Console.WriteLine("Domain: " + ds[i]);
        }
        Console.WriteLine("University: " + cname);
    }
}
class UnivSystem
{
    static void Main()
    {
        Console.WriteLine("Enter 1 if you are a student and 2 if you are staff:");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Student obj1 = new Student();
            obj1.GetStudentDetails();
        }
        else if (choice == 2)
        {
            Staff obj1 = new Staff();
            obj1.GetStaffDetails();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}