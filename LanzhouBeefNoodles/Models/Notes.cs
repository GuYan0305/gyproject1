using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LanzhouBeefNoodles.Models
{
    [Table("Notes")]

    public class Notes
    {
        [Key]
        [BindNever]
        public int Id { get; set; }


        
        [StringLength(100)]
        public string FirstTime { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseID { get; set; }


      
        [StringLength(200)]
        public string Author { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public int? Good { get; set; }
    }
}
