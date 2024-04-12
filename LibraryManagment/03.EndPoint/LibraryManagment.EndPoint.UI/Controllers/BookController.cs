using LibraryManagment.Domain.Core.Books.Contracts;
using LibraryManagment.Domain.Core.Books.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.EndPoint.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepo;

        public BookController(IBookRepository bookRepository)
        {
            bookRepo = bookRepository;
        }
        public IActionResult Search()
        {
            var result = bookRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult Register(Book model)
        {
            return View();
        }
        public IActionResult Update(Book model)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
