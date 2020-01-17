using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class MockNewRepository : INewRepository
    {
        private List<New> _news;

        public MockNewRepository()
        {
            if (_news == null)
            {
                InitializeNew();
            }
        }

        private void InitializeNew()
        {
            _news = new List<New>
            {
                new New { Id = 1, Title = "阿莱克斯",  Text = "真的好细好细好细啊", CreateDateUTC = DateTime.UtcNow},
                new New { Id = 2, Title = "莱克斯",  Text = "还是挺细的", CreateDateUTC = DateTime.UtcNow},
                new New { Id = 3, Title = "克斯",  Text = "比细的粗点，比二细细点", CreateDateUTC = DateTime.UtcNow},
                new New { Id = 4, Title = "克斯", Text = "粗的才有嚼劲", CreateDateUTC = DateTime.UtcNow},
            };
        }
        //获取所有新闻
        public IEnumerable<New> GetAllNews()
        {
            return _news;
        }
        //通过ID获取
        public New GetNewById(int id)
        {
            return _news.FirstOrDefault(n => n.Id == id);
        }
        //添加新闻
        public void AddNew(New news)
        {
            _news.Add(news);
        }

        public void DelNew(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(New news)
        {
            throw new NotImplementedException();
        }
    }
}
