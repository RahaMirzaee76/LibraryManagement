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
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Book book = bookRepo.Add(model);
            return View();
        }
        public IActionResult Update(Book model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Book book = bookRepo.Update(model);
            return View();
        }
        public IActionResult Delete(int id)
        {
            Book book = bookRepo.Delete(id);
            return View();
        }

        public void ChangeActivity(int id)
        {
            Book book=bookRepo.GetById(id);
            book.IsActive = !book.IsActive;
          Book newBook=  bookRepo.Update(book);
        }
    }
}
