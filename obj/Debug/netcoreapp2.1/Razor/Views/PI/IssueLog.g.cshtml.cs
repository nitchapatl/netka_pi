#pragma checksum "D:\bow\project\netka_pi\Views\PI\IssueLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2157bf5f6850f763fbeafe60ab4eb365d3ce6b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PI_IssueLog), @"mvc.1.0.view", @"/Views/PI/IssueLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PI/IssueLog.cshtml", typeof(AspNetCore.Views_PI_IssueLog))]
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
#line 1 "D:\bow\project\netka_pi\Views\_ViewImports.cshtml"
using netka_pi;

#line default
#line hidden
#line 2 "D:\bow\project\netka_pi\Views\_ViewImports.cshtml"
using netka_pi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2157bf5f6850f763fbeafe60ab4eb365d3ce6b0", @"/Views/PI/IssueLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447b23fd5e703f0710c471778b1fcdc96653aefa", @"/Views/_ViewImports.cshtml")]
    public class Views_PI_IssueLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<netka_pi.Models.IssueLogData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\bow\project\netka_pi\Views\PI\IssueLog.cshtml"
  
    ViewData["Title"] = "IssueLog";

#line default
#line hidden
            BeginContext(96, 32, true);
            WriteLiteral("\r\n<h2>IssueLog</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edfab717552f4eeb8387e56ec6960f22", async() => {
                BeginContext(151, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(165, 5123, true);
            WriteLiteral(@"
</p>
<div class=""breadcrumbs"">
    <ul>
        <li>
            <a href=""#"">Home</a>
            <i class=""icon-angle-right""></i>
        </li>
        <li>
            <a href=""#"">Dashboard</a>
        </li>
    </ul>
    <div class=""close-bread"">
        <a href=""#""><i class=""icon-remove""></i></a>
    </div>
</div>
<div class=""row-fluid"">
    <div class=""span12"">

        <div class=""box box-color box-bordered"">
            <div class=""box-title"">
                <h3>
                    <i class=""icon-table""></i>
                    Issue Log
                </h3>
            </div>
            <div class=""box-content nopadding"">
                <table class=""table table-hover table-nomargin"">
                    <thead>
                        <tr>
                            <th>Issue No.</th>
                            <th>Title</th>
                            <th class='hidden-350'>Originator</th>
                            <th class='hidden-1024'>Process</th>
   ");
            WriteLiteral(@"                         <th class='hidden-1024'>Category</th>
                            <th class='hidden-1024'>Severity</th>
                            <th class='hidden-1024'>Status</th>
                            <th class='hidden-1024'>Date Raised</th>
                            <th class='hidden-1024'>Date Resolved</th>
                            <th class='hidden-1024'>Issue Age</th>
                            <th class='hidden-1024'>Remark</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Issue1</td>
                            <td> bug1 </td>
                            <td class='hidden-350'> bo </td>
                            <td class='hidden-1024'>5</td>
                            <td class='hidden-1024'>2</td>
                            <td class='hidden-1024'>medium</td>
                            <td class='hidden-1024'>new</td>
                            <td cl");
            WriteLiteral(@"ass='hidden-1024'>15/08/2019</td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'>test</td>
                        </tr>
                        <tr>
                            <td>Issue2</td>
                            <td></td>
                            <td class='hidden-350'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                        </tr>
                        <tr>
                            <td>Issue3</td>
                           ");
            WriteLiteral(@" <td></td>
                            <td class='hidden-350'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                        </tr>
                        <tr>
                            <td>Issue4</td>
                            <td></td>
                            <td class='hidden-350'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidd");
            WriteLiteral(@"en-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                        </tr>
                        <tr>
                            <td>Issue5</td>
                            <td></td>
                            <td class='hidden-350'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

    </div>
</div>

Time Stam");
            WriteLiteral("p: ");
            EndContext();
            BeginContext(5289, 17, false);
#line 127 "D:\bow\project\netka_pi\Views\PI\IssueLog.cshtml"
       Write(ViewBag.timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(5306, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<netka_pi.Models.IssueLogData>> Html { get; private set; }
    }
}
#pragma warning restore 1591