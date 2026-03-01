using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using practiceEFDapper.Entities;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace practiceEFDapper;

class Program
{
    static void Main()
    {
        SeedData();
        using AppDbContext db = new AppDbContext();
        while (true)
        {
            Console.WriteLine("1 - Create student");
            Console.WriteLine("2 - Create teacher");
            Console.WriteLine("3 - Show students");
            Console.WriteLine("4 - Show teachers");
            Console.WriteLine("5 - new");
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

            if (choice == "5")
                ChangeStudent(db);

            if (choice == "0")
                break;
            Console.ReadKey();
            Console.Clear();
        }
    }



    static void ChangeStudent(AppDbContext context)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Console.Write("Enter student id: ");
        int id = int.Parse(Console.ReadLine());

        Student? student = context.Students.FirstOrDefault(x => x.Id == id);

        if (student != null)
        {
            Console.WriteLine("Enter new first name: ");

            string? temp = Console.ReadLine();
            student.FirstName = temp.IsNullOrEmpty() ? student.FirstName : temp;

            Console.WriteLine("Enter new last name: ");
            temp = Console.ReadLine();
            student.LastName = temp.IsNullOrEmpty() ? student.LastName : temp;

            Console.WriteLine("Enter new email: ");
            temp = Console.ReadLine();
            student.Email = temp.IsNullOrEmpty() ? student.Email : temp;

            Console.WriteLine("Enter new birth date: ");
            string? newBirthDate = Console.ReadLine();
            if (!newBirthDate.IsNullOrEmpty())
            {
                student.BirthDate = DateTime.Parse(newBirthDate);
            }
            context.SaveChanges();
        }
        stopwatch.Stop();
        Console.WriteLine($"===============Time: {stopwatch.ElapsedMilliseconds}");
    }

    static void SeedData()
    {
        using var context = new AppDbContext();

        // 1. Уточняем имя класса, чтобы не было конфликта с Regex (используем Entities.Group)
        // Проверяем наличие данных через контекст
        if (context.Groups.Any()) return;

        // 2. Создаем группы (явно указываем пространство имен из-за конфликта)
        var group1 = new practiceEFDapper.Entities.Group { Name = "Продвинутая разработка" };
        var group2 = new practiceEFDapper.Entities.Group { Name = "Основы баз данных" };

        // 3. Создаем предметы
        var subject1 = new Subject { Name = "C# Professional", Description = "Deep dive into .NET" };
        var subject2 = new Subject { Name = "SQL Server", Description = "T-SQL and optimization" };

        // 4. Создаем преподавателей (инициализируем список предметов)
        var teacher1 = new Teacher
        {
            FullName = "Иван Иванов",
            Age = 35,
            Salary = 50000,
            Subjects = new List<Subject> { subject1, subject2 }
        };

        // 5. Создаем студентов
        var student1 = new Student
        {
            FirstName = "Алексей",
            LastName = "Петров",
            Email = "alex@mail.com",
            BirthDate = new DateTime(2000, 5, 15),
            Group = group1
        };
        var student2 = new Student
        {
            FirstName = "Мария",
            LastName = "Сидорова",
            Email = "maria@mail.com",
            BirthDate = new DateTime(2001, 10, 20),
            Group = group2
        };

        // 6. Обращаемся к таблицам через объект context
        context.Groups.AddRange(group1, group2);
        context.Teachers.Add(teacher1);
        context.Students.AddRange(student1, student2);

        // 7. Сохраняем изменения в БД
        context.SaveChanges();

        Console.WriteLine("Данные успешно добавлены!");
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