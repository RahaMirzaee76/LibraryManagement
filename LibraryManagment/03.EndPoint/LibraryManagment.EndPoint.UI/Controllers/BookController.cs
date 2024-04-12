﻿using LibraryManagment.Domain.Core.Personels.Contracts;
using LibraryManagment.Domain.Core.Personels.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.EndPoint.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IPersonelRepository bookRepo;

        public BookController(IPersonelRepository bookRepository)
        {
            bookRepo = bookRepository;
        }
        public IActionResult Search()
        {
            var result = bookRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult Register(Personel model)
        {
            return View();
        }
        public IActionResult Update(Personel model)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
