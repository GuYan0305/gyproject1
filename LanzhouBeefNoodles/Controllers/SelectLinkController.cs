using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.Controllers
{
    public class SelectLinkController : Controller
    {
        private ILinkRepository _linkRepository;
        public SelectLinkController(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }

        //获取链接列表并删除
        public IActionResult Index()
        {
            var linksView = new HomeViewModel()
            {
                Links = _linkRepository.GetAllLinks().ToList()
            };
            return View(linksView);
        }
        //删除
        public IActionResult Del(int id)
        {
            _linkRepository.DelLink(id);
            return RedirectToAction("Index", "SelectLink");
        }
        
    }
}