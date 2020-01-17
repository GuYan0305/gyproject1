using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace LanzhouBeefNoodles.Controllers
{
    [Authorize]
    public class Admin0Controller : Controller
    {
        public IActionResult Login()
        {
            return View(); 
        }
        //管理员首页
        public IActionResult Index()
        {
            return View();
        }
    }
}