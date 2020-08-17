using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models.Account;
using LinkaRepository.Repositories.AdminRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAdminRepository _adminRepository;
        public AccountController(IAdminRepository adminrRepository)
        {
            _adminRepository = adminrRepository;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var admin = _adminRepository.Login(model.Email, model.Password);
                if (admin != null)
                {
                    admin.Token = Guid.NewGuid().ToString();
                    _adminRepository.UpdateToken(admin.Id, admin.Token);
                    Response.Cookies.Append("admin-token", admin.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires = model.RememberMe? DateTime.Now.AddYears(1):DateTime.Now.AddDays(1)
                    });
                    return RedirectToAction("Index", "dashboard");
                }
                ModelState.AddModelError("Password", "Email");
            }
            return View(model);
        }
        
    }
}