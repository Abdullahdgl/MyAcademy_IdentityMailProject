using IdentityMail.Web.DTOs.UserDtos;
using IdentityMail.Web.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityMail.Web.Controllers
{
	public class AuthController(UserManager<AppUser> _userManager,
								SignInManager<AppUser> _signInManager) : Controller //primary constractor
	{
		//private readonly UserManager<AppUser> _userManager;

		//public AuthController(UserManager<AppUser> userManager)
		//{
		//	_userManager = userManager;
		//}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Register(RegisterDto registerDto)
		{
			if(registerDto.Password != registerDto.ConfirmPassword)
			{
				ModelState.AddModelError(string.Empty, "Şifrede uyumsuzluk var düzelt lütfen");
				return View();
			}

			var user = new AppUser
			{
				Email = registerDto.Email,
				FirstName = registerDto.FirsName,
				LastName = registerDto.FirsName,
				UserName = registerDto.FirsName,
			};

			var result = await _userManager.CreateAsync(user, registerDto.Password);

			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.Code, error.Description);
				}
				return View(registerDto);
			}
			return RedirectToAction("Login");
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Login(LoginDto loginDto)
		{

			var user = await _userManager.FindByEmailAsync(loginDto.Email); 
			if (user == null)
			{
				ModelState.AddModelError(string.Empty, "Bu Email Sistemde kayıtlı değildir.");
				return View(loginDto);
			}

			var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password,false,false);
			if(!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Email veya şifre hatalı");
				return View(loginDto);
			}

			return RedirectToAction("Index", "Message");
		}


		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Logout");
		}

	}
}


