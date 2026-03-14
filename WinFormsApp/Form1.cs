using LibraryEFDapper.Data;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            db.AddBook(txtTitle.Text, txtAuthor.Text);
            buttonShowAll_Click(null, null);
            MessageBox.Show("Book added");
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            var books = db.GetAllBooks();
            BookBox.Items.Clear();
            foreach (var book in books)
            {
                BookBox.Items.Add($"{book.Id} {book.Title} {book.Author}");
            }
            MessageBox.Show("All books displayed");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            int id = int.Parse(txtId.Text);
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            db.UpdateBook(id, title, author);
            buttonShowAll_Click(null, null);
            MessageBox.Show("Updated book");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            string title = txtTitle.Text;
            var books = db.GetBookByTitle(title);
            BookBox.Items.Clear();
            foreach (var book in books)
            {
                BookBox.Items.Add($"{book.Id} {book.Title} {book.Author}");
            }
            MessageBox.Show("Search completed");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            int id = int.Parse(txtId.Text);
            db.DeleteBook(id);
            buttonShowAll_Click(null, null);
            MessageBox.Show("Deleted book");
        }
    }
}
