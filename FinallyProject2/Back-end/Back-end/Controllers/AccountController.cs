using Back_end.Helpers.Enums;
using Back_end.Models;
using Back_end.Services.Interfaces;
using Back_end.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IFileService _fileService;

        public AccountController
            (UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IEmailService emailService,
            IFileService fileService,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _fileService = fileService;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser user = new AppUser
            {
                Name = registerVM.Name,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(user, Roles.Member.ToString());

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            string link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token },
                Request.Scheme, Request.Host.ToString());

            string path = "wwwroot/assets/templates/confirm.html";
            string body = string.Empty;
            string subject = "Confirm Email";

            body = _fileService.ReadFile(path, body);

            body = body.Replace("{{link}}", link);
            body = body.Replace("{{name}}", user.Name);

            _emailService.Send(user.Email, subject, body);

            return RedirectToAction(nameof(VerifyEmail));
        }

        public IActionResult VerifyEmail()
        {
            return View();
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId is null || token is null) return BadRequest();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user is null) return NotFound();

            await _userManager.ConfirmEmailAsync(user, token);
            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Shop");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            AppUser user = await _userManager.FindByEmailAsync(loginVM.EmailOrUsername);

            if (user is null)
            {
                user = await _userManager.FindByNameAsync(loginVM.EmailOrUsername);
            }

            if (user is null)
            {
                ModelState.AddModelError("", "Email or username is wrong!");

                return View(loginVM);
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or username is wrong!");

                return View(loginVM);
            }

            return RedirectToAction("Index", "Shop");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Shop");
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(forgetPasswordVM);
            }

            AppUser existUser = await _userManager.FindByEmailAsync(forgetPasswordVM.Email);

            if (existUser is null)
            {
                ModelState.AddModelError("Email", "User not found!");

                return View();
            }

            string token = await _userManager.GeneratePasswordResetTokenAsync(existUser);

            string link = Url.Action(nameof(ResetPassword), "Account", new { userId = existUser.Id, token },
                Request.Scheme, Request.Host.ToString());

            string path = "wwwroot/assets/templates/confirm.html";
            string body = string.Empty;
            string subject = "Confirm Email for reset Password";

            body = _fileService.ReadFile(path, body);

            body = body.Replace("{{link}}", link);
            body = body.Replace("{{name}}", existUser.Name);

            _emailService.Send(existUser.Email, subject, body);

            return RedirectToAction(nameof(VerifyEmail));
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            return View(new ResetPasswordVM { Token = token, UserId = userId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordVM);
            }

            AppUser existUser = await _userManager.FindByIdAsync(resetPasswordVM.UserId);

            if (existUser is null)
            {
                return NotFound();
            }

            if (await _userManager.CheckPasswordAsync(existUser, resetPasswordVM.Password))
            {
                ModelState.AddModelError("", "This password already exist!");

                return View(resetPasswordVM);
            }

            await _userManager.ResetPasswordAsync(existUser, resetPasswordVM.Token, resetPasswordVM.Password);

            return RedirectToAction(nameof(Login));
        }

        [Authorize(Roles = "SuperAdmin")]
        public async Task CreateRoles()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
                }
            }
        }
    }
}