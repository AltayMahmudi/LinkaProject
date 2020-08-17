using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkaRepository.Repositories.AuthRepositories
{
	public interface IAuthRepository
	{
		User Register(User user);

		User Login(string email, string password);
		bool UserExist(string email);
		User CheckByToken(string token);
		void UpdateToken(int id, string token);
		bool CheckEmail(string email);
		User CheckName(string username);
	}
}
