using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LanzhouBeefNoodles.Models
{
    //53.上下文关系对象
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
     

        //54.注入依赖
       public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        //55.指明哪些模型要注入数据库中->startup.cs将AppDbContext依赖注入系统
        public DbSet<Noodle> Noodles { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<New> News { get; set; }//新闻
        public DbSet<Notice> Notices { get; set; }//公告

        public DbSet<Link> Links { get; set; }//链接


        public DbSet<Notes> Notes { get; set; }//操作笔记
        public DbSet<LearningVideo> LearningVideo { get; set; }//操作学习视频

    }
}
