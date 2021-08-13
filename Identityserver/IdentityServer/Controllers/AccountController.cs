﻿using IdentityModel;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager,UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl});
        }

        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
            return View(new RegisterViewModel { ReturnUrl = returnUrl });
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Username, vm.Password, false, false);
            
                if (result.Succeeded)
                {
                    if (vm.ReturnUrl != null)
                    {
                        return Redirect(vm.ReturnUrl);
                    }
                    return Redirect("/");
                }
                else if (result.IsLockedOut)
                {

                }
                ModelState.AddModelError(string.Empty, "Invalid credentials");
            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var user = new ApplicationUser
            {
                UserName = vm.Email,
                Email = vm.Email,
                EmailConfirmed = true,
            };

            var result = await _userManager.CreateAsync(user,vm.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            if (result.Succeeded)
            {
                result = await _userManager.AddClaimsAsync(user, new Claim[]{
                            new Claim(JwtClaimTypes.Email, vm.Email)
                        });

                await _signInManager.SignInAsync(user, false);
                if (string.IsNullOrEmpty(vm.ReturnUrl))
                {
                    return Redirect("/");
                }
                return Redirect(vm.ReturnUrl);
            }

            return View(vm);
        }

    }
}
