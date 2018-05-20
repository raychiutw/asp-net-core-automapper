using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapperSample.Models;
using AutoMapper;
using AutoMapperSample.Service;

namespace AutoMapperSample.Controllers
{
    public class HomeController : Controller
    {
        private IMapper _mapper;
        private IUserService _userService;

        public HomeController(IMapper mapper,
                              IUserService userService)
        {
            this._mapper = mapper;
            this._userService = userService;
        }

        public IActionResult Index()
        {
            // 取得 user
            var user = this._userService.Get();

            // 將 user 置換成 ViewModel
            var userViewModel = _mapper.Map<IEnumerable<UserViewModel>>(user);

            ViewData["User"] = userViewModel;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}