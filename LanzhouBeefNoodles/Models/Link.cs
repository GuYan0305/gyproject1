using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class Link
    {
        [BindNever]
        public int Id { get; set; }//id

        [Required(ErrorMessage = "输入链接名称")]
        [StringLength(50, ErrorMessage = "名称不能超过20个字")]
        public string Title { get; set; }//链接名

        [Required(ErrorMessage = "输入链接URL")]
        public string Url { get; set; }//链接url
    }
}
