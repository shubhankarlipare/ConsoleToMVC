using ConsoleToMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author == authorName).ToList();
        }

        public string tp()
        {
            return "Hello from tp";

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Author="Shubh", Title= "Science"},
                new BookModel(){Id=2, Author="Shubhankar", Title= "Maths"},
                new BookModel(){Id=3, Author="Obama", Title= "Politics"},
            };
        }
    }
}
