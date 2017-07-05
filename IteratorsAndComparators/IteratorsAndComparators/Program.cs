using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterators
            var books = new BooksCollection();
            books.Add(new Book {Title = "Ivan"});
            books.Add(new Book { Title = "Pesho" });
            books.Add(new Book { Title = "Gosho" });
            books.Add(new Book { Title = "Asparuh" });
            books.Add(new Book { Title = "Todor" });

            foreach (var book in books)
            {
                Console.WriteLine($"Book title: {book.Title}");   
            }

            // Comparators
            var sortedSet = new SortedSet<Book>();

            sortedSet.Add(new Book() { Title = "Dog", Author = "Maya" });
            sortedSet.Add(new Book() {Title = "Ivan", Author = "Gosho"});
            sortedSet.Add(new Book() {Title = "ABC", Author = "Ivan"});

            foreach (var book in sortedSet)
            {
                Console.WriteLine($"Book title: {book.Title}, Author: {book.Author}");
            }

            var anotherSet = new SortedSet<Book>(new BookComparer());
        }

        
    }

    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
}
