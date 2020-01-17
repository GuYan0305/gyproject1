using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext appDbContext)
        {
            _context = appDbContext;//创建数据库上下文对象
        }
        //管理课程中心
        //上传课程视频
        public IActionResult Index()
        {

            return View();
        }
        //执行提交
        [HttpPost]
        public IActionResult Index(LearningVideo video)
        {
            if (ModelState.IsValid)
            {
                _context.LearningVideo.Add(video);
                _context.SaveChanges();
                return RedirectToAction("AddVideoComplete");
            }
            return View();
        }
        //上传完成视图
        public IActionResult AddVideoComplete()//Views/New/AddNewComplete.cshtml
        {
            return View();
        }
    }
}