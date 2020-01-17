using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    [Route("admin/[controller]/[action]")]//9
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IList<string> Index()//8
        {
            return new List<String> { "sue", "bob", "hah" };
        }
    }
}
