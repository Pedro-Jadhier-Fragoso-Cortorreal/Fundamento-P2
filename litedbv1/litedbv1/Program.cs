using litedbv1;
using LiteDB;

using (var db = new LiteDatabase(@"MyData.db"))
{
    var authors = db.GetCollection<Author>("authors");
    var books = db.GetCollection<Book>("books");

    var author = new Author { Name = "J.K. Rowling" };
    authors.Insert(author);

    var book = new Book
    {
        Title = "Harry Potter and the Sorcerer's Stone",
        Year = 1997,
        Author = author
    };
    books.Insert(book);

    var bookWithAuthor = books
        .Include(b => b.Author)
        .FindOne(b => b.Title.StartsWith("Harry Potter"));

    Console.WriteLine($"Title: {bookWithAuthor.Title}");
    Console.WriteLine($"Author: {bookWithAuthor.Author.Name}");
    Console.WriteLine($"Year: {bookWithAuthor.Year}");
}