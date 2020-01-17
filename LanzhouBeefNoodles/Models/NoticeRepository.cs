using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public class NoticeRepository : INoticeRepository
    {
        private readonly AppDbContext _context;
        public NoticeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void AddNotice(Notice notice)
        {
            _context.Notices.Add(notice);
            _context.SaveChanges();
        }
       
        //获取所有公告
        public IEnumerable<Notice> GetAllNotices()
        {
            return _context.Notices;
        }
        //通过ID获取
        public Notice GetNoticeById(int id)
        {
            return _context.Notices.FirstOrDefault(n => n.Id == id);
        }
        //删除
        public void DelNotice(int id)
        {
            try
            {
                _context.Notices.Remove(new Notice() { Id = id });//创建要删除的对象
                _context.SaveChanges();//更新数据库
            }
            catch(Exception ex)
            {
                Console.Write("删除失败" + ex);
            }
        }
    }
}
