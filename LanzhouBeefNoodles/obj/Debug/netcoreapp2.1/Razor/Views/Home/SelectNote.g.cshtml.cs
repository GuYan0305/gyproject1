#pragma checksum "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Home\SelectNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a565d162f6c4cdf77ad7ff222d3d7209fd96197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectNote), @"mvc.1.0.view", @"/Views/Home/SelectNote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SelectNote.cshtml", typeof(AspNetCore.Views_Home_SelectNote))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a565d162f6c4cdf77ad7ff222d3d7209fd96197", @"/Views/Home/SelectNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LanzhouBeefNoodles.Models.Notes>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Home\SelectNote.cshtml"
  
    ViewData["Title"] = "SelectNote";

#line default
#line hidden
            BeginContext(86, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(94, 752, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b8f0d75b2ad4164809220d98c2a81fa", async() => {
                BeginContext(100, 739, true);
                WriteLiteral(@"
    <meta http-equiv=""content-type"" content=""text/html;charset=utf-8"" />
    <style type=""text/css"">
        h2{
            margin-top:20px;
            float:left;
        }
        #gyDiv {
            width: 80%;
            background-color: rgba(210, 234, 246, 0.21);
            background-size:100% 100%;
            position:absolute;
            left:10%;
            margin-top:70px;
        }
        #gyDiv p{
            text-indent:2em;
            font-size:20px;
            padding:20px 0;
        }
        .gya{
            display:inline-block;
            margin-left:20px;
            margin-top:20px;
            text-decoration:none;
            font-size:20px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(848, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5126bea366094eaa9637a581fa66decb", async() => {
                BeginContext(854, 37, true);
                WriteLiteral("\r\n    <h2 style=\"margin-left:100px;\">");
                EndContext();
                BeginContext(892, 12, false);
#line 36 "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Home\SelectNote.cshtml"
                              Write(Model.Author);

#line default
#line hidden
                EndContext();
                BeginContext(904, 206, true);
                WriteLiteral("</h2><h2>的笔记</h2>\r\n    <a class=\"gya\" href=\"https://localhost:5001/Home/Trainingprogram\">所有笔记</a>\r\n    <a class=\"gya\" href=\"https://localhost:5001/Home/ViewNotes\">我的笔记</a>\r\n    <div id=\"gyDiv\">\r\n        <p>");
                EndContext();
                BeginContext(1111, 13, false);
#line 40 "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Home\SelectNote.cshtml"
      Write(Model.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1124, 18, true);
                WriteLiteral("</p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1149, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanzhouBeefNoodles.Models.Notes> Html { get; private set; }
    }
}
#pragma warning restore 1591