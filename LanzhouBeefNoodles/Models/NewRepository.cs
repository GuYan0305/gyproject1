using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Controllers;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public class NewRepository : INewRepository
    {
        private readonly AppDbContext _context;
        public NewRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        //添加新闻
        public void AddNew(New news)
        {
            _context.News.Add(news);
            _context.SaveChanges();
        }
        //获取所有新闻
        public IEnumerable<New> GetAllNews()
        {
            return _context.News;
        }
        //通过ID获取新闻
        public New GetNewById(int id)
        {
            return _context.News.FirstOrDefault(n => n.Id == id);
        }
        //删除新闻
        public void DelNew(int id)
        {
            try
            {
                _context.News.Remove(new New() { Id = id });//实体对象参数
                _context.SaveChanges();//更新数据库
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        
        ////修改新闻
        //public void Update(New news)
        //{
        //      _context.Entry(news).State =EntityState.Modified;
        //      _context.SaveChanges(); 

        //}
    }
}
