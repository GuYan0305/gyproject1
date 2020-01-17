using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Controllers
{
    public class NewController : Controller
    {
        private INewRepository _newRepository;
        //依赖注入
        public NewController(INewRepository newRepository)
        {
            _newRepository = newRepository;
        }
        //上传视图
        public IActionResult Index()
        {
            return View();
        }
        //执行提交
        [HttpPost]
        public IActionResult Index(New news)
        {
            if (ModelState.IsValid)
            {
                _newRepository.AddNew(news);
                return RedirectToAction("AddNewComplete");
            }
            return View();
        }
        //上传完成视图
        public IActionResult AddNewComplete()//Views/New/AddNewComplete.cshtml
        {
            return View();
        }
        //获取详情页面
        public IActionResult Detail(int id)
        {
            return View(_newRepository.GetNewById(id));
        }

    }
}