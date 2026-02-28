using Microsoft.Data.SqlClient;
using System;
using System.Text;
using practiceEFDapper.Entities;
using System.Linq;

namespace practiceEFDapper;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1 - Create student");
            Console.WriteLine("2 - Create teacher");
            Console.WriteLine("3 - Show students");
            Console.WriteLine("4 - Show teachers");
            Console.WriteLine("0 - Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
                CreateStudent();

            if (choice == "2")
                CreateTeacher();

            if (choice == "3")
                ShowStudents();

            if (choice == "4")
                ShowTeachers();

            if (choice == "0")
                break;
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void CreateStudent()
    {
        using var db = new AppDbContext();

        Console.Write("Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Surname: ");
        string lastName = Console.ReadLine();

        Console.Write("Birthdate (yyyy-MM-dd): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());

        Console.Write("Email: ");
        string email = Console.ReadLine()?? $"{firstName.ToLower()}.{lastName.ToLower()}@gmail.com";

        var student = new Student
        {
            FirstName = firstName,
            LastName = lastName,
            BirthDate = birthdate,
            Email = email
        };

        db.Students.Add(student);
        db.SaveChanges();
    }

    static void CreateTeacher()
    {
        using var db = new AppDbContext();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Salary: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        var teacher = new Teacher
        {
            FullName = name,
            Age = age,
            Salary = salary
        };

        db.Teachers.Add(teacher);
        db.SaveChanges();
    }

    static void ShowStudents()
    {
        using var db = new AppDbContext();

        var students = db.Students.ToList();

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} {s.FirstName} {s.LastName} {s.BirthDate:yyyy-MM-dd}");
        }
    }

    static void ShowTeachers()
    {
        using var db = new AppDbContext();

        var teachers = db.Teachers.ToList();

        foreach (var t in teachers)
        {
            Console.WriteLine($"{t.Id} {t.FullName} {t.Age} {t.Salary}");
        }
    }
}