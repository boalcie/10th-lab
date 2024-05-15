using ConsoleApp2.Data;
using ConsoleApp2.Models;

using (var db = new LibraryContext())
{
    // Створення
    Console.WriteLine("Added new book");
    db.Add(new Book { Title = "Harry Potter and the Philosopher's Stone" });
    db.SaveChanges();

    // Читання
    Console.WriteLine("Querying for a book");
    var book = db.Books
        .OrderBy(b => b.Id)
        .First();

    // Оновлення
    Console.WriteLine("Updating the book and adding new one");
    book.Title = "Updated Title";
    db.Add(new Book { Title = "Harry Potter and the Chamber of Secrets" });
    db.SaveChanges();

    // Видалення
    Console.WriteLine("Deleting the book");
    db.Remove(book);
    db.SaveChanges();
}