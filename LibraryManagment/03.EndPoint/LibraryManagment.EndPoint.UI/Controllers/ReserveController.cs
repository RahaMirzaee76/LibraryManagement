using LibraryManagment.Domain.Core.Books.Contracts;
using LibraryManagment.Domain.Core.Books.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.EndPoint.UI.Controllers
{
    public class ReserveController : Controller
    {
        private readonly IReserveRepository reserveRepo;
        private readonly IBookRepository bookRepo;

        public ReserveController(IReserveRepository reserveRepository, IBookRepository bookRepository)
        {
            reserveRepo = reserveRepository;
            bookRepo = bookRepository;
        }
        public IActionResult Search()
        {
            var result = reserveRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult Reservation(Reserve model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Book book=bookRepo.GetById(model.BookId);
            if (book.IsReserved)
            {
                throw new Exception("this book is reserved!"); 
            }

            book.ChangeState();
            bookRepo.Update(book);
            Reserve reserve = reserveRepo.Add(model);

            return View();
        }
        public IActionResult Rechaiming(Reserve model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            Book book = bookRepo.GetById(model.BookId);
            book.ChangeState();
            bookRepo.Update(book);
            Reserve reserve = reserveRepo.Update(model);

            return View();
        }
       
    }
}