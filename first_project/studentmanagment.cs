using System;
/*class StudentManagementSystem
{
    static void ShowStudentDetails(double rollNo, string name)
    {
        Console.WriteLine("STUDENT DETAILS");
        Console.WriteLine("Roll Number : " + rollNo);
        Console.WriteLine("Name        : " + name);
    }
    static int CalculateTotal(int mark1, int mark2, int mark3)
    {
        return mark1 + mark2 + mark3;
    }
    static double CalculateAverage(double total, int count)
    {
        return total / count;
    }
    static char DisplayGrade(double average)
    {
        char grade;
        if (average >= 75)
        {
            grade = 'A';
        }
        else if (average >= 50)
        {
            grade = 'B';
        }
        else
        {
            grade = 'C';
        }
        Console.WriteLine("Grade       : " + grade);
        return grade;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter Roll Number: ");
        double rollNo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Mark 1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Mark 2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Mark 3: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());
        ShowStudentDetails(rollNo, name);
        double total= CalculateTotal(mark1, mark2, mark3);
        Console.WriteLine("Total Marks : " + total);
        double average = CalculateAverage(total, 3);
        Console.WriteLine("Average     : " + average);
        DisplayGrade(average);
        Console.ReadLine();
    }
}*/
class Methodsystem
{
    public int students;
    public string[] name;
    public int[] roll, eng, mat, phy, chem, bio;
    public int[] total;
    public double[] avg;
    public char[] grade;

     public void GetDetails(int totalStudents)
    {
        students = totalStudents;
        name = new string[students];
        roll = new int[students];
        eng = new int[students];
        mat = new int[students];
        phy = new int[students];
        chem = new int[students];
        bio = new int[students];
        total = new int[students];
        avg = new double[students];
        grade = new char[students];

        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\n Enter details for Student" +i + 1);
            Console.Write("Enter student name: ");
            name[i] = Console.ReadLine();

            Console.Write("Enter roll number: ");
            roll[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter English marks: ");
            eng[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            mat[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics marks: ");
            phy[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            chem[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Biology marks: ");
            bio[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

class B : Methodsystem
{
    public int CalculateTotal(int e, int m, int p, int c, int b)
    {
        return e + m + p + c + b;
    }
}

class C : B
{
    public double CalculateAverage(int tot, int subjectCount)
    {
        return (double)tot / subjectCount;
    }

    public char CalculateGrade(double average)
    {
        if (average >= 90)
            return 'S';
        else if (average >= 80)
            return 'A';
        else if (average >= 70)
            return 'B';
        else if (average >= 60)
            return 'C';
        else if (average >= 40)
            return 'D';
        else
            return 'U';
    }
}

class D : C
{
    public string DisplayDetails(int r, string n, int e, int m, int p, int c, int b, int tot, double a, char g)
    {
        Console.WriteLine($"Roll Number : {r}");
        Console.WriteLine($"Name        : {n}");
        Console.WriteLine($"English     : {e}");
        Console.WriteLine($"Maths       : {m}");
        Console.WriteLine($"Physics     : {p}");
        Console.WriteLine($"Chemistry   : {c}");
        Console.WriteLine($"Biology     : {b}");
        Console.WriteLine($"Total Marks : {tot} / 500");
        Console.WriteLine($"Average     : {a:F2}%");
        Console.WriteLine($"Grade       : {g}");
        return "Displayed successfully.";
    }
}

class StudentSystem2
{
    static void Main()
    {
        D obj = new D();

        Console.Write("Enter number of students: ");
        int count = Convert.ToInt32(Console.ReadLine());
        obj.GetDetails(count);

        for (int i = 0; i < obj.students; i++)
        {
            obj.total[i] = obj.CalculateTotal(obj.eng[i], obj.mat[i], obj.phy[i], obj.chem[i], obj.bio[i]);
            obj.avg[i] = obj.CalculateAverage(obj.total[i], 5);
            obj.grade[i] = obj.CalculateGrade(obj.avg[i]);
            obj.DisplayDetails(obj.roll[i], obj.name[i], obj.eng[i], obj.mat[i], obj.phy[i], obj.chem[i], obj.bio[i], obj.total[i], obj.avg[i], obj.grade[i]);
        }
        Console.ReadLine();
    }
}