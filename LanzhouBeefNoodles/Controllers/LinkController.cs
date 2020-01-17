using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;


namespace LanzhouBeefNoodles.Controllers
{
    //管理专业介绍的链接
    public class LinkController : Controller
    {
        private ILinkRepository _linkRepository;
        //依赖注入
        public LinkController(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }
        //上传页面
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Link link)
        {
            if (ModelState.IsValid)
            {
                _linkRepository.AddLink(link);
                return RedirectToAction("LinkComplete");
            }
            return View();
        }
        //上传完成
        public IActionResult LinkComplete()
        {
            return View();
        }
    }
}