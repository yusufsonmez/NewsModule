#pragma checksum "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2652f6d35cfa19ec1f91ced7c255f7a17215659f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2652f6d35cfa19ec1f91ced7c255f7a17215659f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e415b9c79abfeb471c2c85b1aa93f3971927b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewsModule.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <header class=""masthead"" style=""background-image: url('/img/news.png')"">
            <div class=""container position-relative px-4 px-lg-5"">
                <div class=""row gx-4 gx-lg-5 justify-content-center"">
                    <div class=""col-md-10 col-lg-8 col-xl-7"">
                        <div class=""site-heading"">
                            <div class=""page-heading"">
                              <h1>Haber Mod??l??</h1>
                            </div>
                            <span class=""subheading"">En Yeni Haberleri G??r??nt??leyin</span>
                        </div>
                    </div>
                </div>
            </div>
        </header>

<div class=""container"">
    <!-- Main Content-->
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5 justify-content-center"">
                <div class=""col-md-10 col-lg-8 col-xl-7"">
");
#nullable restore
#line 25 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                   foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <!-- Post preview-->\r\n                        <div class=\"post-preview\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2652f6d35cfa19ec1f91ced7c255f7a17215659f4904", async() => {
                WriteLiteral("\r\n                                <h2 class=\"post-title\">\r\n                                    ");
#nullable restore
#line 31 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h2>\r\n                                <h3 class=\"post-subtitle\">\r\n                                    ");
#nullable restore
#line 34 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                               Write(item.Subtitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h3>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <p class=\"post-meta\">\r\n                                Posted by\r\n                                ");
#nullable restore
#line 39 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                           Write(item.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 40 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                           Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tarihinde yay??nland??\r\n                            </p>\r\n                        </div>\r\n                        <!-- Divider-->\r\n                        <hr class=\"my-4\" />\r\n");
#nullable restore
#line 45 "C:\Users\yusuf\source\repos\NewsModule\NewsModule\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                    <!-- Pager-->
                    <div class=""d-flex justify-content-end mb-4""><a class=""btn btn-primary text-uppercase"" href=""#!"">Older Posts ???</a></div>
                </div>
            </div>
        </div>
        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewsModule.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
