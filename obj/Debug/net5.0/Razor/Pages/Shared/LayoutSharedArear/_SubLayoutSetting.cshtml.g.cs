#pragma checksum "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4a09f6052fa7706b6cb2e2635bc8a5689abf80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Paging.Services.NavbarServices.Pages_Shared_LayoutSharedArear__SubLayoutSetting), @"mvc.1.0.view", @"/Pages/Shared/LayoutSharedArear/_SubLayoutSetting.cshtml")]
namespace Paging.Services.NavbarServices
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
#line 1 "D:\C#\ProjectPage\paging\Pages\_ViewImports.cshtml"
using Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
using Paging.Services.NavbarServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4a09f6052fa7706b6cb2e2635bc8a5689abf80", @"/Pages/Shared/LayoutSharedArear/_SubLayoutSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a449d83d1eec7c666a6e9717dbe46d18ed49f9b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_LayoutSharedArear__SubLayoutSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-black "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
  
    Layout = "/Pages/Shared/_Layout.cshtml";

    var listItems = items.GetItem();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1></h1>
<div class=""row p-0"">
    <div class=""col-sm-3"">
        <div class=""container p-0 d-sm-block collapse bg-dark"">
            <h3 class=""bg-light my-0 p-2 text-dark border-bottom""><i class=""fas fa-cogs""></i> Setting</h3>
            <ul class=""list-unstyled bg-light p-2"">
");
#nullable restore
#line 18 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                 foreach (var item in listItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"show-collapse nav-link dropdown-toggle text-black\" data-bs-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 726, "\"", 744, 2);
            WriteAttributeValue("", 733, "#", 733, 1, true);
#nullable restore
#line 21 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
WriteAttributeValue("", 734, item.Name, 734, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 781, "\"", 807, 1);
#nullable restore
#line 21 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
WriteAttributeValue("", 797, item.Name, 797, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 811, "\"", 829, 1);
#nullable restore
#line 21 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
WriteAttributeValue("", 819, item.Icon, 819, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 21 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                                                                                                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 897, "\"", 912, 1);
#nullable restore
#line 22 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
WriteAttributeValue("", 902, item.Name, 902, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"container\">\r\n                                <ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 25 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                     foreach (var itemChildrens in item.itemsChildrens)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"color nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4a09f6052fa7706b6cb2e2635bc8a5689abf808091", async() => {
#nullable restore
#line 27 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                                                                                                                                                   Write(itemChildrens.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                                                    WriteLiteral(itemChildrens.UrlArea);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                                                                                      WriteLiteral(itemChildrens.UrlPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 33 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div> \r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n        <div class=\"container mt-3\">\r\n            ");
#nullable restore
#line 39 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4a09f6052fa7706b6cb2e2635bc8a5689abf8011903", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4a09f6052fa7706b6cb2e2635bc8a5689abf8012943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {

        $('.show-collapse').click(function () {
            alert(window.location)
        });
        
        //}

        //$('.show-collapse').click(function () {
        //    //store the id of the collapsible element
        //    if (collapseItem == $(this).attr('href')) {

        //        localStorage.removeItem('collapseItem')
        //        return;
        //    }
        //    if (collapseItem) {
        //        conllapseItemFlag = collapseItem;

        //        $(conllapseItemFlag).collapse('hide');
        //    }

        //    collapseItem = localStorage.setItem('collapseItem', $(this).attr('href'))
        //    collapseItem = localStorage.getItem('collapseItem');

        //});
        //collapseItem = localStorage.getItem('collapseItem');
        //if (collapseItem) {
        //    $(collapseItem).collapse('show');

        //}

       

        
    })

    

</script>

");
#nullable restore
#line 89 "D:\C#\ProjectPage\paging\Pages\Shared\LayoutSharedArear\_SubLayoutSetting.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IShowItems items { get; private set; }
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
