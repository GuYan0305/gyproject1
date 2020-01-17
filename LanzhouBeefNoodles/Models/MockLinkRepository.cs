using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class MockLinkRepository : ILinkRepository
    {
        private List<Link> _link;
        public MockLinkRepository()
        {
            if (_link == null)
            {
                InitializeLink();
            }
        }
        private void InitializeLink()
        {
            _link = new List<Link>
            {
                new Link { Id = 1, Title = "阿莱克斯", Url="http://www.immoc.com" },
                new Link { Id = 2, Title = "莱克斯",  Url="http://www.immoc.com"  },
                new Link { Id = 3, Title = "克斯", Url="http://www.immoc.com"  },
            };
        }
        //添加
        public void AddLink(Link link)
        {
            _link.Add(link);
        }
        //删除
        public void DelLink(int id)
        {
            throw new NotImplementedException();
        }
        //获取所有
        public IEnumerable<Link> GetAllLinks()
        {
            return _link;
        }
        //通过ID获取
        public Link GetLinkById(int id)
        {
            return _link.FirstOrDefault(n => n.Id == id);
        }
    }
}
