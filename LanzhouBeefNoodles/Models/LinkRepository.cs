using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    //连接数据库的
    public class LinkRepository : ILinkRepository
    {
        private readonly AppDbContext _context;
        public LinkRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        //添加
        public void AddLink(Link link)
        {
            _context.Links.Add(link);
            _context.SaveChanges();
        }
        //删除
        public void DelLink(int id)
        {
            try
            {
                _context.Links.Remove(new Link() { Id = id });//实体对象参数
                _context.SaveChanges();//更新数据库
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        //获取所有
        public IEnumerable<Link> GetAllLinks()
        {
            return _context.Links;
        }
        //通过ID
        public Link GetLinkById(int id)
        {
            return _context.Links.FirstOrDefault(n => n.Id == id);
        }
    }
}
