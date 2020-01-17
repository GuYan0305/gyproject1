using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
namespace LanzhouBeefNoodles.Controllers
{
    public class NoticeController : Controller
    {
        private INoticeRepository _noticeRepository;
        public NoticeController(INoticeRepository noticeRepository)
        {
            _noticeRepository = noticeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        //上传完成
        [HttpPost]
        public IActionResult Index(Notice notice)
        {
            if (ModelState.IsValid)
            {
                _noticeRepository.AddNotice(notice);
                return RedirectToAction("AddNoticeComplete");
            }
            return View();
        }
        public IActionResult AddNoticeComplete()//对应Views/Notice/AddNoticeComplete.cshtml
        {
            return View();
        }
        //获取详情页面
        public IActionResult Detail(int id)
        {
            return View(_noticeRepository.GetNoticeById(id));
        }

    }
}