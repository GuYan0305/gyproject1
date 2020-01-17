using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.Controllers
{
    public class SelectNewController : Controller
    {
        private INewRepository _newRepository;
        private readonly AppDbContext db;

        public SelectNewController(INewRepository newRepository,AppDbContext appDbContext)
        {
            _newRepository = newRepository;
            db = appDbContext;//数据库上下文对象
        }

        //这里要完成对新闻的查询（包括连接到详情页面）和删除、修改
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                News = _newRepository.GetAllNews().ToList()
            };
            return View(viewModel);
        }
        //删除
        public IActionResult Del(int id)
        {
            _newRepository.DelNew(id);
            return RedirectToAction("Index","SelectNew");
        }
        //修改
        //通过Index()中遍历得到的Id获取当前选择的新闻的详情
        public IActionResult Update(int id)//修改视图update.cshtml
        {
            return View(_newRepository.GetNewById(id));
        }
        //update视图中的表单提交到该函数来处理
        public IActionResult UpdateNew()
        {
            var newobj = new New();
            newobj.Title = Request.Form["newTitle"];
            newobj.Text = Request.Form["newText"];
            newobj.PictureUrl = Request.Form["newImg"];
            var gyNew = from b in db.News
                    where b.Title == newobj.Title
                    select b;
            var C = gyNew.FirstOrDefault(); //获取唯一匹配的值
            C. Title= newobj.Title;//修改对象中的内容
            C.Text = newobj.Text;
            C.PictureUrl = newobj.PictureUrl;
            db.SaveChanges();//保存改变到数据库
      
            return RedirectToAction("Index", "SelectNew");
        }
    }
}