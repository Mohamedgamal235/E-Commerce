using E_Commerce.Models;
using E_Commerce.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class AccountController : Controller
    {
        UserManager<User> _userManager;
        SignInManager<User> _SignInManager;

        public AccountController(SignInManager<User> SignInManager, UserManager<User> userManager)
        {
            _SignInManager = SignInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(UserViewModel NewUser)
        {
            User user = new User();
            if (ModelState.IsValid)
            {

                user.UserName = NewUser.UserName;
                // user.PasswordHash = NewUser.Password;
                user.Email = NewUser.Email;


                IdentityResult result = await _userManager.CreateAsync(user, NewUser.Password);

                // IdentityResult result = await  _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, NewUser.Role);
                    //login
                    await _SignInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }

            }

            return View(NewUser);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(login.UserName);
                if (user != null)
                {
                    //login if name found in database
                    Microsoft.AspNetCore.Identity.SignInResult result = await _SignInManager.PasswordSignInAsync(login.UserName , login.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid Password");

                    }
                }
                else
                {
                    ModelState.AddModelError("", "User Name Is Not Found");
                }
            }

            return View(login);
        }
        public async Task<IActionResult> Logout()
        {
            await _SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
