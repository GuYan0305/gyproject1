using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.Controllers
{
    public class SelectNoticeController : Controller
    {
        private INoticeRepository _noticeRepository;
        private readonly AppDbContext _context;
        public SelectNoticeController(INoticeRepository noticeRepository,AppDbContext appDbContext)
        {
            _noticeRepository = noticeRepository;
            _context = appDbContext;
        }

        //完成公告的查询及详情
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                Notices = _noticeRepository.GetAllNotices().ToList()
            };
            return View(viewModel);
        }
        //删除
        public IActionResult Del(int id)
        {
            _noticeRepository.DelNotice(id);
            return RedirectToAction("Index", "SelectNotice");
        }
        //修改,id是从Index.cshtml的修改链接那儿传递过来的
        public IActionResult Update(int id)
        {
            return View(_noticeRepository.GetNoticeById(id));
        }
        public IActionResult UpdateNotice()
        {
            //定义公告对象
            var obj = new Notice();
            //传入表单内容
            obj.Title=Request.Form["noticeTitle"];
            obj.Text = Request.Form["noticeText"];
            //通过Title从数据中找到对应条目
            var gyNotice = from b in _context.Notices
                        where b.Title == obj.Title
                        select b;
            //获取第一个匹配的值
            var C = gyNotice.FirstOrDefault();
            //修改
            C.Title = obj.Title;
            C.Text = obj.Text;
            //保存修改
            _context.SaveChanges();
            //返回到列表视图
            return RedirectToAction("Index", "SelectNotice");

        }

    }
}