using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    //61.创建真正数据仓库连接数据库
    public class NoodleRepository : INoodleRepository
    {
        //62.用数据库连接对象AppDbContext连接数据库->
        private readonly AppDbContext _context;
        public NoodleRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;//数据库与仓库的连接就完成了
        }
        //63.实现方法->startup.cs注入依赖
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _context.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _context.Noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
