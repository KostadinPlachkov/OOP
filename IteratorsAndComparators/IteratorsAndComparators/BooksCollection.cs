using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    class BooksCollection : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public BooksCollection()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {

            for (int i = 0; i < this.books.Count; i += 2)
            {
                yield return this.books[i];
                // yield break; // stops the foreach
            }

            // return new BooksEnumerator(this.books);  // In case you are using the class BooksEnumerator #43
        }

        // Because .NET 1.1.....
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        // Custom Enumerator
//        private class BooksEnumerator : IEnumerator<Book>
//        {
//            private int currentIndex;
//            private readonly List<Book> books;
//
//            public BooksEnumerator(List<Book> books)
//            {
//                this.Reset();
//                this.books = books;
//            }
//
//            public void Dispose()
//            {
//                // For example when working with files here we can close them
//            }
//
//            public bool MoveNext()
//            {
//                this.currentIndex += 2;
//                if (this.currentIndex >= this.books.Count)
//                {
//                    return false;
//                }
//                return true;
//            } 
//
//
//            public void Reset() => this.currentIndex = -2;
//
//            public Book Current => this.books[this.currentIndex];
//
//            object IEnumerator.Current => this.Current;  //Legacy (.NET 1.1)
//        }


    }

    
}
