public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    // Other properties of Author
    public List<Book> Books { get; set; } // Navigation property
}