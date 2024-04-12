
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
        public void ChangeActivity(int id)
        {
            Member member = memberRepo.GetById(id);
            member.IsActive = !member.IsActive;
            Member newMember = memberRepo.Update(member);
        }
        public IActionResult Search()
        {
            var result = memberRepo.GetAll().ToList();
            return View(result);
        }
        public IActionResult MemberShip(Member model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Member member = memberRepo.Add(model);
            return View();
        }
        public IActionResult UpdateInfo(Member model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            Member member = memberRepo.Update(model);
            return View();
        }
        public IActionResult Delete(int id)
        {
            Member member = memberRepo.Delete(id);
            return View();
        }
    }
}
