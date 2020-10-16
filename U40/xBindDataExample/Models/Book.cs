using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBindDataExample.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImange { get; set; }
    }

    public class Bookmanager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Neo2018", Author = "Tet Holiday", CoverImange = "Assets/neo-2018.jpg" });
            books.Add(new Book { BookId = 2, Title = "Neo2019", Author = "Tet Holiday", CoverImange = "Assets/neo-2019.jpg" });
            books.Add(new Book { BookId = 3, Title = "Neo2020", Author = "...", CoverImange = "Assets/neo-cartoon.jpg" });

            books.Add(new Book { BookId = 1, Title = "Neo2018", Author = "Tet Holiday", CoverImange = "Assets/neo-2018.jpg" });
            books.Add(new Book { BookId = 2, Title = "Neo2019", Author = "Tet Holiday", CoverImange = "Assets/neo-2019.jpg" });
            books.Add(new Book { BookId = 3, Title = "Neo2020", Author = "...", CoverImange = "Assets/neo-cartoon.jpg" });

            books.Add(new Book { BookId = 1, Title = "Neo2018", Author = "Tet Holiday", CoverImange = "Assets/neo-2018.jpg" });
            books.Add(new Book { BookId = 2, Title = "Neo2019", Author = "Tet Holiday", CoverImange = "Assets/neo-2019.jpg" });
            books.Add(new Book { BookId = 1, Title = "Neo2018", Author = "Tet Holiday", CoverImange = "Assets/neo-cartoon.jpg" });

            return books;
        }
    }
}
