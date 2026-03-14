using Dapper;
using LibraryEFDapper.Data.Entities;

namespace LibraryEFDapper.Data;
public class AppDbContext
{
    public void AddBook(string title, string author)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "INSERT INTO Books (Title, Author) VALUES (@Title, @Author)";

        connection.Execute(sql, new { Title = title, Author = author });
    }

    public List<Book> GetAllBooks()
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "SELECT * FROM Books";

        return connection.Query<Book>(sql).ToList();
    }

    public Book GetBookById(int id)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "SELECT * FROM Books WHERE Id = @Id";

        return connection.QueryFirstOrDefault<Book>(sql, new { Id = id });
    }

    public List<Book> GetBookByTitle(string title)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "SELECT * FROM Books WHERE Title LIKE @Title";

        return connection.Query<Book>(sql, new { Title = "%" + title + "%" }).ToList();
    }

    public List<Book> GetBookByAuthor(string author)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "SELECT * FROM Books WHERE Author LIKE @Author";

        return connection.Query<Book>(sql, new { Author = "%" + author + "%" }).ToList();
    }

    public void DeleteBook(int id)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql = "DELETE FROM Books WHERE Id = @Id";

        connection.Execute(sql, new { Id = id });
    }

    public void UpdateBook(int id, string title, string author)
    {
        using var connection = DatabaseConn.GetConnection();

        string sql =
        "UPDATE Books SET Title=@Title, Author=@Author WHERE Id=@Id";

        connection.Execute(sql, new { Id = id, Title = title, Author = author });
    }
}