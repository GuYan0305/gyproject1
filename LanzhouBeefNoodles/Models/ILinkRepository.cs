using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public interface ILinkRepository
    {
        IEnumerable<Link> GetAllLinks();//获取所有链接

        Link GetLinkById(int id);//通过ID获取链接

        void AddLink(Link link);//添加链接

        void DelLink(int id);//删除链接
    }
}
