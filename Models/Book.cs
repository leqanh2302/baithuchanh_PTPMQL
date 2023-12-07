public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; } // Foreign key
    // Other properties of Book
    public Author Author { get; set; } // Navigation property
}