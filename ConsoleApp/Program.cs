using LibraryEFDapper.Data;

namespace practiceEFDapper;

class Program
{
    static AppDbContext db = new AppDbContext();

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        while (true)
        {
            Console.WriteLine("1 - Add Book");
            Console.WriteLine("2 - Show All Books");
            Console.WriteLine("3 - Search By Id");
            Console.WriteLine("4 - Search By Title");
            Console.WriteLine("5 - Search By Author");
            Console.WriteLine("6 - Delete Book");
            Console.WriteLine("7 - Update Book");
            Console.WriteLine("0 - Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;

                case "2":
                    ShowAll();
                    break;

                case "3":
                    SearchById();
                    break;

                case "4":
                    SearchByTitle();
                    break;

                case "5":
                    SearchByAuthor();
                    break;

                case "6":
                    DeleteBook();
                    break;

                case "7":
                    UpdateBook();
                    break;

                case "0":
                    return;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Title: ");
        var title = Console.ReadLine();

        Console.Write("Author: ");
        var author = Console.ReadLine();

        db.AddBook(title, author);
        Console.Clear();
    }

    static void ShowAll()
    {
        var books = db.GetAllBooks();

        foreach (var book in books)
            Console.WriteLine($"{book.Id} {book.Title} {book.Author}");
        Console.ReadKey();
        Console.Clear();
    }

    static void SearchById()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        var book = db.GetBookById(id);

        if (book != null)
            Console.WriteLine($"{book.Id} {book.Title} {book.Author}");
        Console.ReadKey();
        Console.Clear();
    }

    static void SearchByTitle()
    {
        Console.Write("Title: ");
        var title = Console.ReadLine();

        var books = db.GetBookByTitle(title);

        foreach (var book in books)
            Console.WriteLine($"{book.Id} {book.Title} {book.Author}");
        Console.ReadKey();
        Console.Clear();
    }

    static void SearchByAuthor()
    {
        Console.Write("Author: ");
        var author = Console.ReadLine();

        var books = db.GetBookByAuthor(author);

        foreach (var book in books)
            Console.WriteLine($"{book.Id} {book.Title} {book.Author}");
        Console.ReadKey();
        Console.Clear();
    }

    static void DeleteBook()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        db.DeleteBook(id);
        Console.Clear();
    }

    static void UpdateBook()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        var title = Console.ReadLine();

        Console.Write("Author: ");
        var author = Console.ReadLine();

        db.UpdateBook(id, title, author);
        Console.Clear();
    }
}