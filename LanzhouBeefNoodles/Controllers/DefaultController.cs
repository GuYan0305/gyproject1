using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;


namespace LanzhouBeefNoodles.Controllers
{
    //首页
    public class DefaultController : Controller
    {  
        //33
        private IFeedbackRepository _feedbackRepository;
        private INewRepository _newRepository;
        private INoticeRepository _noticeRepository;
        private ILinkRepository _linkRepository;
        public DefaultController(IFeedbackRepository feedbackRepository, INewRepository newRepository, INoticeRepository noticeRepository, ILinkRepository linkRepository)
        {
            

            _feedbackRepository = feedbackRepository;
            _newRepository = newRepository;
            _noticeRepository = noticeRepository;
            _linkRepository = linkRepository;
           
        }
        //反馈详情界面
        public IActionResult Index()
        {
            //34->Views/Home/Index.cshtml
            var viewModel = new HomeViewModel()
            { 
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                News = _newRepository.GetAllNews().ToList(),
                Notices = _noticeRepository.GetAllNotices().ToList(),
                Links = _linkRepository.GetAllLinks().ToList()
            };
            return View(viewModel);
        }
        //网站首页Views/Home/One.cshtml
        public IActionResult One()
        {
            var viewModel = new HomeViewModel()
            {
                News = _newRepository.GetAllNews().ToList(),
                Notices = _noticeRepository.GetAllNotices().ToList()
            };
            return View(viewModel);
        }
        //专业介绍/Views/Home/Marjor.cshtml
        public IActionResult Major()
        {
            var viewModel = new HomeViewModel()
            {
                Links = _linkRepository.GetAllLinks().ToList()
            };
            return View(viewModel);
        }
        //学院介绍/Views/Home/Academy.cshtml
        public IActionResult Academy()
        {
            return View();
        }
        //管理员界面：对新闻/公告的增删改查
        public IActionResult Admin()
        {
            return View();
        }
    }
}