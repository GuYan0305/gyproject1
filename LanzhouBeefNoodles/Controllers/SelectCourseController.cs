using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.Controllers
{
    public class SelectCourseController : Controller
    {
        private readonly AppDbContext _context;
        public SelectCourseController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        //获取课程列表
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                LearningVideos = _context.LearningVideo.ToList()
            };
            return View(viewModel);
            
        }
        //删除
        public IActionResult DeleteCourse(int id)
        {
            _context.LearningVideo.Remove(new LearningVideo() { ID = id });//实体对象参数
            _context.SaveChanges();//更新数据库
            return RedirectToAction("Index", "SelectCourse");
        }
        //修改
        //通过Index()中遍历得到的Id获取当前选择的课程
        public IActionResult Update(int id)//修改视图update.cshtml
        {
            return View(_context.LearningVideo.FirstOrDefault(n => n.ID == id));
        }
        //update视图中的表单提交到该函数来处理
        public IActionResult UpdateCourse()
        {
            var courseobj = new LearningVideo();
            courseobj.CourseID = Request.Form["coursename"];
            courseobj.Teacher = Request.Form["teacher"];
            courseobj.Duration = Request.Form["duration"];
            courseobj.UpdateTime = Request.Form["updatetime"];
            courseobj.Url = Request.Form["video"];
            var gyCourse = from b in _context.LearningVideo
                        where b.CourseID == courseobj.CourseID
                        select b;
            var C = gyCourse.FirstOrDefault(); //获取唯一匹配的值
            C.CourseID = courseobj.CourseID;//修改对象中的内容
            C.Teacher = courseobj.Teacher;
            C.Duration = courseobj.Duration;
            C.UpdateTime = courseobj.UpdateTime;
            C.Url = courseobj.Url;
            _context.SaveChanges();//保存改变到数据库

            return RedirectToAction("Index", "SelectCourse");
        }
    }
}