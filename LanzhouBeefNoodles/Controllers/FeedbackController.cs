using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;


namespace LanzhouBeefNoodles.Controllers
{

    public class FeedbackController : Controller
    {
        //42
        private IFeedbackRepository _feedbackRepository;
        //43,依赖注入
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        //39.右击创建提交反馈的视图->Views/Feedback/Index.cshtml
        public IActionResult Index()
        {
            return View();
        }
        //41
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            //50.启动数据验证->Feedback/Index.cshtml显示错误提示信息
            if (ModelState.IsValid){
                //44.调用添加函数
                _feedbackRepository.AddFeedback(feedback);
                //45.定向到评价完成页面
                return RedirectToAction("FeedbackComplete");
            }
            return View();//若验证不成功则继续留在上传页面Views/Index.cshtml
           
        }
        //46完成页面的action             47.右击创建视图Views/Feedback/FeedbackComplete.cshtml
        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}