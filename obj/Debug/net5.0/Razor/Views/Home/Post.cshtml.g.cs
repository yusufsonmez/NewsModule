#pragma checksum "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09089014ac120db03b3b1bdafa169667b85bfba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#nullable restore
#line 1 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\_ViewImports.cshtml"
using NewsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\_ViewImports.cshtml"
using NewsModule.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09089014ac120db03b3b1bdafa169667b85bfba3", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e415b9c79abfeb471c2c85b1aa93f3971927b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsModule.Models.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Page Header-->\r\n<header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 76, "\"", 125, 4);
            WriteAttributeValue("", 84, "background-image:", 84, 17, true);
            WriteAttributeValue(" ", 101, "url(\'", 102, 6, true);
#nullable restore
#line 3 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
WriteAttributeValue("", 107, Model.ImagePath, 107, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 123, "\')", 123, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container position-relative px-4 px-lg-5\">\r\n        <div class=\"row gx-4 gx-lg-5 justify-content-center\">\r\n            <div class=\"col-md-10 col-lg-8 col-xl-7\">\r\n                <div class=\"post-heading\">\r\n                    <h1>");
#nullable restore
#line 8 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h2 class=\"subheading\">");
#nullable restore
#line 9 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <span class=\"meta\">\r\n                        Posted by\r\n                        ");
#nullable restore
#line 12 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
                   Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        on ");
#nullable restore
#line 13 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
                      Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span>
                </div>
            </div>
        </div>
    </div>
</header>
<div class=""container"">
    <!-- Post Content-->
    <article class=""mb-4"">
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5 justify-content-center"">
                <div class=""col-md-10 col-lg-8 col-xl-7"">
                    ");
#nullable restore
#line 26 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Post.cshtml"
               Write(Html.Raw(@Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </article>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsModule.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
