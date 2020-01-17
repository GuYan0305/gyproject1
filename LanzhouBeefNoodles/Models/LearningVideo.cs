using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
//using System.Data.Entity.Spatial;

namespace LanzhouBeefNoodles.Models
{
    [Table("LearningVideo")]
    public class LearningVideo
    {
        [BindNever]
        public int ID { get; set; }
  
        [StringLength(200, ErrorMessage = "课程名不能为空且不能超过100个字")]
        public string CourseID { get; set; }//课程名
 
        [StringLength(100,ErrorMessage = "教师姓名不能为空且不能超过50个字")]
        public string Teacher { get; set; }//教师

        public string Duration { get; set; }//总课时

        [StringLength(100, ErrorMessage = "请输入更新时间")]
        public string UpdateTime { get; set; }//更新时间

        
        [StringLength(300,ErrorMessage ="请输入视频URL")]
        public string Url { get; set; }//视频
    }
}
