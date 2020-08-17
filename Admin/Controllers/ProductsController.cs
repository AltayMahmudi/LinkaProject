using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Libs;
using Admin.Models.Shopping;
using AutoMapper;
using LinkaRepository.Models;
using LinkaRepository.Repositories.ShoppingRepositories;
using LinkaRepository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{

    [TypeFilter(typeof(Auth))]
    public class ProductsController : Controller
    {
        private LinkaRepository.Models.Admin _admin => RouteData.Values["Admin"] as LinkaRepository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        private readonly IProductRepository _productRepository;
        public readonly ICloudinaryService _cloudinaryService;
        public ProductsController(IMapper mapper, IProductRepository productRepository, ICloudinaryService cloudinaryService,IFileManager fileManager)
        {
            _fileManager = fileManager;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();

            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(model);
        }

        public IActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = _mapper.Map<ProductViewModel, Product>(model);
                product.AddedBy = _admin.FullName;
                _productRepository.CreateProduct(product);
                return RedirectToAction("Index");
            }
          
            return View(model);
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            var filename=_fileManager.Upload(file);
            var publicId=_cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            return Ok(publicId);
        }
    }
}