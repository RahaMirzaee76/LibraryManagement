using LibraryManagment.Domain.Core.Personels.Contracts;
using LibraryManagment.Domain.Core.Personels.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.EndPoint.UI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelRepository personelRepo;

        public PersonelController(IPersonelRepository personelRepository)
        {
            personelRepo = personelRepository;
        }
        public IActionResult Search()
        {
            var result = personelRepo.GetAll().ToList();
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
