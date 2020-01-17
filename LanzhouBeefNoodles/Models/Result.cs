//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.IO;
////using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;


//namespace LanzhouBeefNoodles.Models
//{

//    public class Result : ActionResult
//    {
//        public string FilePhysicalPath { private get; set; }
//        public override void ExecuteResult(ActionContext context)
//        {
//            var file = new FileInfo(FilePhysicalPath);
//            if (file.Exists)
//            {
//                context.HttpContext.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
//                FileStream fs = new FileStream(FilePhysicalPath, FileMode.Open, FileAccess.Read);
//                BinaryReader br = new BinaryReader(fs);
//                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
//                br.Close();
//                fs.Close();
//                context.HttpContext.Response.OutputStream.Write(bytes, 0, bytes.Length);
//                //throw new NotImplementedException();
//            }

//        }
//    }
//}