﻿using Hospital.Models.Hospital.RequestDto.Account;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient http;

        public AccountController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendLogin(LoginRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("account/admin/login", request);
                if (response.IsSuccessStatusCode)
                {
                    var token = response.Content.ReadAsStringAsync().Result;
                    HttpContext.Response.Cookies.Append("hospitalUserToken", token);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Invalid = true;
                    return View("Login");
                }
            }
            return RedirectToAction("Login");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendRegister(RegisterRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("account/admin/register", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    ViewBag.ErrorMessage = errorObject?.message;
                    return View("Register");
                }
            }
            return RedirectToAction("Register");
        }
        public async Task<IActionResult> Logout()
        {
            var response = await http.PostAsync("account/admin/logout",null);
            if (response.IsSuccessStatusCode)
            {
                HttpContext.Response.Cookies.Delete("hospitalUserToken");
                return RedirectToAction("Login");
            }
            return RedirectToAction();
        }
    }
}
