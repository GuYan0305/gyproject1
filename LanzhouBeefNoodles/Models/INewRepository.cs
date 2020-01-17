using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public interface INewRepository
    {
        IEnumerable<New> GetAllNews();

        New GetNewById(int id);//做成详情页
        //增加
        void AddNew(New news);
        //删除
        void DelNew(int id);
        //修改
        //void Update(New news);

    }
}
