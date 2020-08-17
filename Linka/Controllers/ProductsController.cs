using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Linka.Libs;
using Linka.Models;
using LinkaRepository.Models;
using LinkaRepository.Repositories.ShoppingRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Linka.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IAuth _auth;

        public ProductsController(IMapper mapper, IProductRepository productRepository,IAuth auth)
        {

            _mapper = mapper;
            _auth = auth;
            _productRepository = productRepository;
            

        }

        public IActionResult Index(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();
            var model = _mapper.Map<Product, ProductViewModel>(product);
            return View(model);
        }

        public IActionResult Review(int id)
        {
            if (_auth.User == null) return NotFound();
            //var product = _productRepository.GetProductOnlyById(id);
            //if (product == null) return NotFound();
            //ViewBag.ProductId = product.İd;
            //ViewBag.ProductName = product.Name;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Review(LeaveReviewViewModel model)
        {
            if (_auth.User == null) return NotFound();
            if(ModelState.IsValid)
            {
                ProductReview productReview = new ProductReview()
                {
                    Status=true,
                    ProductId = model.ProductId,
                    UserId = _auth.User.Id,
                    Star = model.Star,
                    Title = model.Title,
                    Review = model.Review,
                    AddedDate=DateTime.Now,
                    ModifiedDate=DateTime.Now,
                    AddedBy=_auth.User.UserName,
                    ModifiedBy = _auth.User.UserName

                };

                _productRepository.CreateReview(productReview);
                return RedirectToAction("Home", "Index");
            };

            //var product = _productRepository.GetProductOnlyById(model.ProductId);

            //if (product == null) return NotFound();
            //ViewBag.ProductId = product.İd;
            //ViewBag.ProductName = product.Name;

            return View(model);
        }

    }
}