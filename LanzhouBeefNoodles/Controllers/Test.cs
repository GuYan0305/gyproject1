using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Controllers
{
    [Controller]
    public class Test: Controller//11
    {
        //10     12
        public ActionResult Index()
        {
            return Content("Hello from text index");
        }

        public String About()
        {
            return "hello from test about";
        }
        //13                14.右击建立视图
        public ActionResult Contact()
        {
            return View();
        }
    }
}
