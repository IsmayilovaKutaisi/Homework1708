using System;
namespace Homework1708
{
	public class User
	{
		public string UserName { get; private set; }
		public string Password { get; private set; }

		public User(string username,string password)
		{
			if(username.Length<6||username.Length>25)
			{
				Console.WriteLine("İstifadəçi adı minimum 6,maxsimum 25 simvoldan ibarət olmalıdır.");
			}
			else
			{
				this.UserName = username;
			}
			if(password.Length<8||password.Length>25||!ContainsUpperCase(password)||!ContainsLowerCase(password)||!ContainsDigit(password))
			{
				Console.WriteLine("şifrə minimum 8,maxsimum 25 simvoldan ibarət olmalıdır və ən azı bir böyük hərf,bir kiçik hərf,bir rəqəmdən istifadə olunmalıdır.");
			}
			else
			{
				this.Password = password;
			}
		}
		public bool HasDigit()
		{
			return
				ContainsDigit(this.Password);
		}
		public bool HasUpper()
		{
			return ContainsUpperCase(this.Password);
		}
		public bool HasLower()
		{
			return ContainsLowerCase(this.Password);
		}
		private bool ContainsDigit(string value)
		{
			return value.Any(char.IsDigit);
		}
		private bool ContainsUpperCase(string value)
		{
			return value.Any(char.IsUpper);
		}
		private bool ContainsLowerCase(string value)
		{
            return value.Any(char.IsLower);
		}

	}
}

