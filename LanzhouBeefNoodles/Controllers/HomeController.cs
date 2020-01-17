using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    [Authorize]
   // [Route("[controller]/[action]")]//4
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        private readonly AppDbContext dbb;
        private readonly AppDbContext AN;
        

        public HomeController( AppDbContext appDbContext)
        {
            
            db = appDbContext;
            dbb = appDbContext;
            AN = appDbContext;
        }
        
        public ActionResult StudentIndex()
        {//进入学生服务中心
      
            return View();
        }
        [HttpGet]
        public ActionResult Classcenter()
        {
            //观看学习视频
    
            List<LearningVideo> vs;
            vs = db.LearningVideo.ToList();
            ViewBag.vs = vs;
            return View();
        }
        public IActionResult VideoDetail(int id)
        {
            return View(db.LearningVideo.FirstOrDefault(n => n.ID == id));
        }

        [HttpPost]
        public ActionResult Classcenter(LearningVideo Data)
        {//按条件搜索视频
           // var db = new AppDbContext();
            ViewBag.num = 1;
            if (Data.CourseID == null)
            {
                List<LearningVideo> vs;
                vs = db.LearningVideo.ToList();
                ViewBag.vs = vs;
            }
            else if (Data.CourseID.Length != 0)
            {
                var v = from b in db.LearningVideo
                        where b.CourseID.StartsWith(Data.CourseID)
                        select b;
                ViewBag.vs = v;
            }
            return View();
        }
        public ActionResult Trainingprogram()
        {
            
            var viewModel = new HomeViewModel()
            {
                Notes = db.Notes.ToList(),
                LearningVideos=db.LearningVideo.ToList()
                
            };
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult AddNotes()
        {//添加我的笔记
         
            var N = new Notes();
            N.Author = Request.Form["author"];
            N.FirstTime = Request.Form["firsttime"];
            N.CourseID = Request.Form["courseid"];
            //N.Author = ViewBag.Name;
            N.Content = Request.Form["content"];
            N.Good = 0;
            AN.Notes.Add(N);
            AN.SaveChanges();
            
            return View("StudentIndex");
        }
        
       // [HttpPost]
        public ActionResult ViewNotes()
        {
            ////查看我的笔记
            var viewModel=new HomeViewModel()
            {
                Notes=db.Notes.ToList()
            };
            return View(viewModel);
        }
        public ActionResult CourseNotes(Notes Data)
        {//按条件搜索笔记
            ViewBag.num = 1;
            if (Data.CourseID == null)
            {
                List<Notes> vs;
                vs = db.Notes.ToList();
                ViewBag.Note = vs;
            }
            else if (Data.CourseID.Length != 0)
            {
                var v = from b in db.Notes
                        where b.CourseID.StartsWith(Data.CourseID)
                        select b;
                ViewBag.Note = v;
            }
            return View("Trainingprogram");
        }

        public ActionResult myCourseNotes(Notes Data)
        {//按条件搜索我的笔记
            ViewBag.num = 1;
            if (Data.CourseID == null)
            {
                ViewBag.Name = "张莹";
                var name = ViewBag.Name;
                List<Notes> vs;
                vs = db.Notes.ToList();
                var n = from b in vs
                        where b.Author == name
                        select b;
                ViewBag.Note = n;
            }
            else if (Data.CourseID.Length != 0)
            {
                var v = from b in db.Notes
                        where b.CourseID.StartsWith(Data.CourseID)
                        select b;
                ViewBag.Note = v;
            }
            return View("ViewNotes");
        }
        public ActionResult ChangeNotes()
        {//修改我的笔记
           // var C = db.Notes.FirstOrDefault(n => n.Id == id);
            var ob = new Notes();
            ob.Author = Request.Form["author"];
            ob.FirstTime = Request.Form["firsttime"];
            ob.CourseID = Request.Form["courseid"];
            ob.Content = Request.Form["content"];
            var N = from b in db.Notes
                    where b.Author == ob.Author
                    select b;
            var B = from b in N
                    where b.FirstTime == ob.FirstTime
                    select b;
            var G = from b in B
                    where b.CourseID == ob.CourseID
                    select b;
            var C = G.FirstOrDefault(); //获取唯一匹配的值
            C.Content = ob.Content;//修改对象中的内容
            C.FirstTime = ob.FirstTime;
            C.CourseID = ob.CourseID;
            db.SaveChanges();//保存改变到数据库
           
            return RedirectToAction("ViewNotes");
        }
        public IActionResult UpdateComplete()
        {
            return View();
        }
        public ActionResult DelNotes(int id)
        {
            //获取唯一匹配的值
            dbb.Notes.Remove(new Notes(){ Id = id});
            //删除对象中的内容
            dbb.SaveChanges();//保存改变到数据库          
            return RedirectToAction("ViewNotes");
        }
        //查看笔记
        public IActionResult SelectNote(int id)
        {
            return View(db.Notes.FirstOrDefault(n => n.Id == id));
        }
        public IActionResult DelComplete()
        {
            return View();
        }
        
        public ActionResult VideoPlay()
        {
         
            return View();
        }
        

    }
}
