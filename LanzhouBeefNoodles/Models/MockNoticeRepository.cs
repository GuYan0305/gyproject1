using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class MockNoticeRepository : INoticeRepository
    {
        private List<Notice> _notice;

        public MockNoticeRepository()
        {
            if (_notice == null)
            {
                InitializeNotice();
            }
        }

        private void InitializeNotice()
        {
            _notice = new List<Notice>
            {
                new Notice { Id = 1, Title = "阿莱克斯",  Text = "真的好细好细好细啊", CreateDateUTC = DateTime.UtcNow},
                new Notice { Id = 2, Title = "莱克斯",  Text = "还是挺细的", CreateDateUTC = DateTime.UtcNow},
                new Notice { Id = 3, Title = "克斯",  Text = "比细的粗点，比二细细点", CreateDateUTC = DateTime.UtcNow},
                new Notice { Id = 4, Title = "克斯", Text = "粗的才有嚼劲", CreateDateUTC = DateTime.UtcNow},
            };
        }
        public IEnumerable<Notice> GetAllNotices()
        {
            return _notice;
        }

        public Notice GetNoticeById(int id)
        {
            return _notice.FirstOrDefault(n => n.Id == id);
        }

        public void AddNotice(Notice notice)
        {
            _notice.Add(notice);
        }

        public void DelNotice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
