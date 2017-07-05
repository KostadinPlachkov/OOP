using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int CompareTo(Book other)
        {
            // Compares by author
            var authorCompare = this.Author.CompareTo(other.Author);

            if (authorCompare != 0)
            {
                return authorCompare;
            }

            return this.Title.CompareTo(other.Title);
        }
    }
}
