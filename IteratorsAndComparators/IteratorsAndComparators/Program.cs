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
            var books = new BooksCollection();
            books.Add(new Book {Title = "Ivan"});
            books.Add(new Book { Title = "Pesho" });
            books.Add(new Book { Title = "Gosho" });
            books.Add(new Book { Title = "Asparuh" });
            books.Add(new Book { Title = "Todor" });

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);   
            }
        }
    }
}
