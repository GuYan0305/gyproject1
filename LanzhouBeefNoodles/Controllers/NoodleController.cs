using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    public class NoodleController : Controller
    {
        // GET: /<controller>/
        //7
        public IList<String> Index()
        {
            return new List<String> { "beef", "egg", "veg" };
        }
    }
}
