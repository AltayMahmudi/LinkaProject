using LinkaRepository.Repositories.AuthRepositories;
using LinkaRepository.Repositories.ShoppingRepositories;
using Microsoft.AspNetCore.Http;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linka.Libs
{
	public interface IAuth
	{ 
	User User { get; }
	}
	public class Auth:IAuth
	{
		private readonly IAuthRepository _authRepository;
		private readonly IHttpContextAccessor _httpContentAccessor;
		public Auth(IAuthRepository authRepository,
			IHttpContextAccessor httpContextAccessor)
		{
			
			_authRepository = authRepository;
			_httpContentAccessor = httpContextAccessor;
			
		}
		public User User 
		{
			get 
			{
				_httpContentAccessor.HttpContext.Request.Cookies.TryGetValue("token",out string token);

				return _authRepository.CheckByToken(token);
				
			}
		} 
	}
}
