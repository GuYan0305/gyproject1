using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class Notice
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入公告标题")]
        [StringLength(50, ErrorMessage = "新闻公告不能超过20个字")]
        public string Title { get; set; }//标题
        
        public DateTime CreateDateUTC { get; set; }

        [Required(ErrorMessage = "请输入公告正文")]
        [StringLength(4000, ErrorMessage = "公告不能超过2000个字")]
        public string Text { get; set; }//正文
    }

}
