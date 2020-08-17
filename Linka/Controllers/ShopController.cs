using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Linka.Models;
using LinkaRepository.Repositories.ShoppingRepositories;
using AutoMapper;
using LinkaRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace Linka.Controllers
{
    public class ShopController : Controller
    {

        public  IActionResult Index()
        {

            return View();
        }
    }
}