#pragma checksum "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Admin0\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be7dc3da13940b6723eb664cf09408ba025658e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin0_Index), @"mvc.1.0.view", @"/Views/Admin0/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin0/Index.cshtml", typeof(AspNetCore.Views_Admin0_Index))]
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
#line 1 "E:\GYLC\大四\LanzhouBeefNoodles\LanzhouBeefNoodles\Views\Admin0\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be7dc3da13940b6723eb664cf09408ba025658e", @"/Views/Admin0/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin0_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/wwwroot/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(161, 4050, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c02c29db294a878b9392d813db5861", async() => {
                BeginContext(167, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>管理员主界面</title>\r\n    ");
                EndContext();
                BeginContext(259, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d08bf3b663e44680ac4d8305b77147b2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(337, 3867, true);
                WriteLiteral(@"
    <style type=""text/css"">
        * {
            box-sizing: border-box;
        }

        .col-1 {
            width: 8.33%;
        }

        .col-2 {
            width: 16.66%;
        }

        .col-3 {
            width: 25%;
        }

        .col-4 {
            width: 33.33%;
        }

        .col-5 {
            width: 41.66%;
        }

        .col-6 {
            width: 50%;
        }

        .col-7 {
            width: 58.33%;
        }

        .col-8 {
            width: 66.66%;
        }

        .col-9 {
            width: 75%;
        }

        .col-10 {
            width: 83.33%;
        }

        .col-11 {
            width: 91.66%;
        }

        .col-12 {
            width: 100%;
        }
        /*每一列左浮动，内边距15*/
        [class|=""col""] {
            float: left;
            padding: 15px;
        }
        /*每一行清除浮动，显示为块状*/
        .gyrow:after {
            content: """";
            clear: both;
            d");
                WriteLiteral(@"isplay: block;
        }
        /*头部样式*/
        .gyheader {
            max-width: 100%;
            height: 170px;
            background-image: linear-gradient(to bottom right,#00b8a9,#e3fdfd);
            padding-left: 520px;
            padding-top: 45px;
        }

            .gyheader p {
                font-size: 35px;
                font-weight: bold;
                font-style: italic;
                text-shadow: 6px 6px 3px #666;
                position: absolute;
                letter-spacing: 0.5em;
                color: #40514e;
            }


        /*水平导航栏*/
        .topnav {
            box-sizing: border-box;
            background-color: #6BA8A9;
            height: 30px;
        }
        /*设置导航栏dropdown*/
        .dropdown {
            display: inline-block;
            width: 100px;
            text-align: center;
            padding: 5px 0;
            position: relative;
        }
        /*导航按钮dropbtn*/
        .dropbtn {
            te");
                WriteLiteral(@"xt-decoration: none;
            color: #000;
            font-size: 16px;
            width: 100px;
        }
            /*鼠标滑过效果*/
            .dropbtn:hover {
                color: white;
            }
        /*下拉内容*/
        .dropdown-content {
            display: none;
            position: absolute;
            width: 160px;
            box-shadow: 6px 6px 3px #666;
            background-color: #FFF;
        }
            /*下拉内容下的链接样式*/
            .dropdown-content a {
                text-decoration: none;
                display: block;
                text-align: center;
                color: #000;
            }

                .dropdown-content a:hover {
                    background-color: #666;
                    color: white;
                }
        /*显示下拉菜单*/
        .dropdown:hover .dropdown-content {
            display: block;
        }
        /*下拉菜单显示后改变按钮背景色*/
        .dropdown:hover {
            background-color: #036;
        }
        /*");
                WriteLiteral(@"功能介绍和注意事项*/
        .gyDiv {
            margin-top: 30px;
            margin-left: 150px;
            
        }

            .gyDiv p {
                width: 100%;
                border-bottom: 1px solid #666;
                font-size: 17px;
            }

        .div1 {
            border-right: 1px solid #666;
            padding-right: 50px;
            
        }

        .div2 {
            padding-left: 30px;
        }
        /*底部*/
        .gybtm {
            background-color: #808080;
            opacity: 0.6;
            text-align: center;
            padding-top: 35px;
            font-weight: bold;
            font-size: 17px;
            height: 78px;
            position: absolute;
            bottom: 0; 
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
            BeginContext(4211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4213, 2790, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3119cc1113f943e0ac35b7400a0fdde9", async() => {
                BeginContext(4219, 230, true);
                WriteLiteral("\r\n    <!--头部-->\r\n    <div class=\"gyrow col-12 gyheader\">\r\n        <p class=\"col-7\">网站管理系统</p>\r\n    </div>\r\n    <!--水平导航栏-->\r\n    <div class=\"row\">\r\n        <div class=\"topnav\">\r\n            <div class=\"dropdown\">\r\n                ");
                EndContext();
                BeginContext(4449, 114, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b084b9a46b04e2d8b18c070532b9aaa", async() => {
                    BeginContext(4511, 48, true);
                    WriteLiteral("<span class=\"glyphicon glyphicon-home\"></span>主页");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4563, 1284, true);
                WriteLiteral(@"
            </div>


            <div class=""dropdown"">
                <a class=""dropbtn"" href=""#"">新闻管理<b class=""caret""></b></a>
                <div class=""dropdown-content"">
                    <a href=""https://localhost:5001/New/Index"">添加新闻</a>
                    <a href=""https://localhost:5001/SelectNew/Index"">新闻详情</a>
                </div>
            </div>

            <div class=""dropdown"">
                <a class=""dropbtn"" href=""#"">通告管理<b class=""caret""></b></a>
                <div class=""dropdown-content"">
                    <a href=""https://localhost:5001/Notice/Index"">添加通告</a>
                    <a href=""https://localhost:5001/SelectNotice/Index"">通告详情</a>
                </div>
            </div>

            <div class=""dropdown"">
                <a class=""dropbtn"" href=""#"">链接管理<b class=""caret""></b></a>
                <div class=""dropdown-content"">
                    <a href=""https://localhost:5001/Link/Index"">添加链接</a>
                    <a href=""https://localhos");
                WriteLiteral(@"t:5001/SelectLink/Index"">已有链接</a>
                </div>
            </div>

            <div class=""dropdown"">
                <a class=""dropbtn"" href=""#"">用户管理<b class=""caret""></b></a>
                <div class=""dropdown-content"">
                    ");
                EndContext();
                BeginContext(5847, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "477039d867a34457ae64a3f9a8761504", async() => {
                    BeginContext(5894, 4, true);
                    WriteLiteral("用户反馈");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5902, 1094, true);
                WriteLiteral(@"
                </div>
            </div>

            <div class=""dropdown"">
                <a class=""dropbtn"" href=""#"">课程中心<b class=""caret""></b></a>
                <div class=""dropdown-content"">
                    <a href=""https://localhost:5001/Course/Index"">课程管理</a>
                    <a href=""https://localhost:5001/SelectCourse/Index"">已有课程</a>
                </div>
            </div>

        </div>
    </div>
    <!--主页内容-->
    <div class=""gyrow gyDiv"">
        <div class=""col-5 div1"">
            <h2>功能介绍：</h2>
            <hr />
            <p>1.可以对网站首页的新闻、公告进行添加、删除及修改。</p>
            <p>2.可以更换专业介绍页面的链接。</p>
            <p>3.可以接收用户的意见反馈。</p>
            <p>4.可以添加、删除、修改课程中心的课程及视频。</p>
            <p>5.点击导航栏本人的账号即可管理账号信息。</p>
        </div>
        <div class=""col-5 div2"">
            <h2>注意事项：</h2>
            <hr />
            <p>1.新闻的图片应上传为图片的本地地址或网址。</p>
            <p>2.课程中心的视频应上传为URL。</p>
        </div>
    </div>
    <!--底部-->
    <div class=""gyrow col-12");
                WriteLiteral(" gybtm\">\r\n        <p>Copyright 2019-12-14 GuYan 版权所有</p>\r\n    </div>\r\n");
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
            BeginContext(7003, 17, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
