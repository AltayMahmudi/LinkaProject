using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Linka.Models;
using LinkaRepository.Models;
using LinkaRepository.Repositories.BlogRepositories;
using LinkaRepository.Repositories.AuthRepositories;
using Repository.Models;

namespace Linka.Controllers
{
	public class HomeController : Controller
	{
		private IBlogRepository _blogRepository;
		private IAuthRepository _authRepository;
		public HomeController(IBlogRepository blogRepository,IAuthRepository authRepository)
		{
			_blogRepository = blogRepository;
			_authRepository = authRepository;
		}
		
		public IActionResult BlogPage(int id)
		{
			var blogs = _blogRepository.GetBlog(id);
			return View(blogs);
		}

		public IActionResult Index()
		{
			var blogs = _blogRepository.GetAllBlogs();
			return View(blogs);
		}

		[HttpGet]
		public IActionResult Edit(int? id)
		{
		
			if (id==null)

			return View(new Blog());
			else{
				var post = _blogRepository.GetBlog((int)id);
				return View(post);
			}
			
		}


		[HttpPost]
		public async Task<IActionResult> Edit(Blog blog)
		{
			if (blog.Id > 0)
				_blogRepository.UpdateBlog(blog);

			else
				_blogRepository.AddBlog(blog);
			if (await _blogRepository.SaveChangesAsync())
				return RedirectToAction("Index", "Home");
			else
				return View();
		}

		[HttpGet]
		public async Task<IActionResult> Remove(int id)
		{
			_blogRepository.RemoveBlog(id);
			await _blogRepository.SaveChangesAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
