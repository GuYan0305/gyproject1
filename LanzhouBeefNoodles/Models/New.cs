using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class New
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入新闻标题")]
        [StringLength(50, ErrorMessage = "新闻标题不能超过20个字")]
        public string Title { get; set; }

        public string PictureUrl { get; set; }//图片
        public DateTime CreateDateUTC { get; set; }//发表时间

        [Required(ErrorMessage = "请输入新闻正文")]
        [StringLength(4000, ErrorMessage = "新闻不能超过2000个字")]
        public string Text { get; set; }//正文
    }
}
