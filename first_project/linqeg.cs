using System;
using System.Collections.Generic;
using System.Linq;

// Student Class
class Students
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class PRogram
{
    static void Main()
    {
        // Student Collection
        List<Students> students = new List<Students>
        {
            new Students { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
            new Students { Id = 2, Name = "Priya", Department = "IT", Marks = 90 },
            new Students { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
            new Students { Id = 4, Name = "Divya", Department = "ECE", Marks = 75 },
            new Students { Id = 5, Name = "Ravi", Department = "IT", Marks = 29 }
        };

        Console.WriteLine("\n1. WHERE - Marks Above 30");

        var result1 = students.Where(s => s.Marks < 30);

        foreach (var s in result1)
        {
            Console.WriteLine(s.Marks);
        }

    var result2 = students.Where(s => s.Marks >80);

        foreach (var s in result2)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }
    var result3= students.GroupBy(s=>s.Department);
         foreach (var group in result3)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }
        Console.Write("Result4");
    var result4 = students.Where(s=>s.Marks>80).GroupBy(s=>s.Department);
         foreach (var group in result4)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }
        int result5=students.Max(s=>s.Marks);
            Console.WriteLine(result5);
         int result6=students.Min(s=>s.Marks);
            Console.WriteLine(result6);
        var result = students.GroupBy(s => s.Department);

        foreach (var group in result)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Maximum Mark: " + group.Max(s => s.Marks));
        }
        var result7 = students.GroupBy(s => s.Department);

    foreach (var group in result7)
    {
        Console.WriteLine("Department: " + group.Key);
        Console.WriteLine("Minimum Mark: " + group.Min(s => s.Marks));
    }
        
    }
}