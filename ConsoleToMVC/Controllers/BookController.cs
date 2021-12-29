using ConsoleToMVC.Models;
using ConsoleToMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
            //return "Get all Books";
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
            //return $"Book: {id}";
        }

        public List<BookModel> Search(string title, string author)
        {
            return _bookRepository.SearchBook(title, author);
            //return $"BookName: {bookname}, Author: {author}";
        }

        public string tp()
        {
            return _bookRepository.tp();
            
        }
    }
}
