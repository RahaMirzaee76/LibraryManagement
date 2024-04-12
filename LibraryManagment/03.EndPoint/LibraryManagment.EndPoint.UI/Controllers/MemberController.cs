
using LibraryManagment.Domain.Core.Members.Contracts;
using LibraryManagment.Domain.Core.Members.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.EndPoint.UI.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberRepository memberRepo;

        public MemberController(IMemberRepository memberRepository)
        {
            memberRepo = memberRepository;
        }
        public IActionResult Search()
        {
            var result = memberRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult Register(Member model)
        {
            return View();
        }
        public IActionResult Update(Member model)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
