using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.ViewModels
{
    public class HomeViewModel//32->HomeController.cs
    {

        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }//反馈
        public IList<New> News { get; set; }//新闻
        public IList<Notice> Notices { get; set; }//公告
        public IList<Link> Links { get; set; }//链接
        public IList<LearningVideo> LearningVideos { get; set; }//课程
        public IList<Notes> Notes { get; set; }//笔记
    }
}
