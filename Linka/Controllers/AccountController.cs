using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Linka.Models.Account;
using LinkaRepository.Repositories.AuthRepositories;
using LinkaRepository.Repositories.ShoppingRepositories;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace Linka.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;

        public AccountController(IMapper mapper, IAuthRepository authRepository,IBasketRepository basketRepository) 
        {
            _mapper = mapper;
            _authRepository = authRepository;
            _basketRepository = basketRepository;
        }


        public IActionResult SignIn(RegisterViewModel register) 
        {
            bool checkUser = _authRepository.CheckEmail(register.Email);
            if (checkUser) 
            {
                ModelState.AddModelError("Email", "Email Already in use!");
            }
            if (ModelState.IsValid) 
            {
                var user = _mapper.Map<RegisterViewModel, User>(register);
                user.Token = Guid.NewGuid().ToString();
                user.Status = true;
                _authRepository.Register(user);
                Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });
                Request.Cookies.TryGetValue("token", out string token);
                _basketRepository.UpdateBasketsToken(token, user.Token);
                return RedirectToAction("Index", "home");
            }
            return View("~/Views/Account/SignIn.cshtml", new AccountViewModel 
            { Register = register });
          
        }

        public IActionResult LogIn(LogInViewModel logIn)
        {
            if (ModelState.IsValid) 
            {
                var user = _authRepository.Login(logIn.Email, logIn.Password);
                user.Status = true;
                if (user != null) 
                {
                    user.Token = Guid.NewGuid().ToString();
                    _authRepository.UpdateToken(user.Id, user.Token);
                    Response.Cookies.Delete("token");
                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1)
                    });
                    Request.Cookies.TryGetValue("token", out string token);
                    _basketRepository.UpdateBasketsToken(token, user.Token);
                    return RedirectToAction("Index","home");
                }
                ModelState.AddModelError("Login.Password", "Wrong Email or Password");
            }
            return View("~/Views/Account/LogIn.cshtml", new AccountViewModel{ LogIn = logIn });
        }
        public IActionResult PasswordRecovery()
        {
            return View();
        }
        public IActionResult Logout()
        {
            Request.Cookies.TryGetValue("token", out string token);
            User user = _authRepository.CheckByToken(token);
            _authRepository.UpdateToken(user.Id, null);
            return RedirectToAction("Index", "home");
        }

        public IActionResult Profile() 
        {
            return View();
        }
    }
}