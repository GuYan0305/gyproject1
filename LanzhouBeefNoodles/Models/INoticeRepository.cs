using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public interface INoticeRepository
    {
        //（已完成）
        IEnumerable<Notice> GetAllNotices();
        //（已完成）
        Notice GetNoticeById(int id);
        //添加（已完成）
        void AddNotice(Notice notice);
        //删除（已完成）
        void DelNotice(int id);

    }
}
