using LinkaRepository.Data;
using LinkaRepository.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkaRepository.Repositories.BlogRepositories
{
	public interface IBlogRepository
	{
		Blog GetBlog(int id);
		List<Blog> GetAllBlogs();
		void AddBlog(Blog blog);
		void UpdateBlog(Blog blog);
		void RemoveBlog(int id);
		Task<bool> SaveChangesAsync();
		
	}
	public class BlogRepository :IBlogRepository
	{
		private readonly LinkaDbContext _context;

		public BlogRepository(LinkaDbContext context)
		{
			_context = context;
			
		}

		public void AddBlog(Blog blog)
		{
			
			_context.Blogs.Add(blog);
		

		}

		public List<Blog> GetAllBlogs()
		{
			return _context.Blogs.Include("user").ToList();
		}

		public Blog GetBlog(int id)
		{
			return _context.Blogs.Include("user").FirstOrDefault(p=>p.Id==id);
		}

		public void RemoveBlog(int id)
		{
			_context.Blogs.Remove(GetBlog(id));
		}
		public void UpdateBlog(Blog blog)
		{
			_context.Blogs.Update(blog);
		}
		public async Task<bool> SaveChangesAsync()
		{

			if (await _context.SaveChangesAsync()>0) 
			{
				return true;
			}
			return false;

		}


	}
}
