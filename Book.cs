using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public Book() { }
        public Book(string aTitle, string aAuthor, int aPage)
        {
            Console.WriteLine("Creating Book...");
            this.title = aTitle;
            this.author = aAuthor;
            this.pages = aPage;
        }
    }
}
