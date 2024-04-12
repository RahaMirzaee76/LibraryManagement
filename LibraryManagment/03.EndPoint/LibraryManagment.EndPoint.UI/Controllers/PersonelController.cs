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

        public void ChangeActivity(int id)
        {
            Personel personel = personelRepo.GetById(id);
            personel.IsActive = !personel.IsActive;
            Personel newPersonel = personelRepo.Update(personel);
        }
        public IActionResult Search()
        {
            var result = personelRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult Register(Personel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Personel personel = personelRepo.Add(model);
            return View();
        }
        public IActionResult Update(Personel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Personel personel = personelRepo.Update(model);
            return View();
        }
        public IActionResult Delete(int id)
        {
            Personel personel = personelRepo.Delete(id);
            return View();
        }
    }
}
