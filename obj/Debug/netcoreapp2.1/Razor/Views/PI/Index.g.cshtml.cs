#pragma checksum "D:\bow\project\netka_pi\Views\PI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b51b68f2cfd0cc2ac6419a8e474eb2b9afa071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PI_Index), @"mvc.1.0.view", @"/Views/PI/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PI/Index.cshtml", typeof(AspNetCore.Views_PI_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b51b68f2cfd0cc2ac6419a8e474eb2b9afa071", @"/Views/PI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447b23fd5e703f0710c471778b1fcdc96653aefa", @"/Views/_ViewImports.cshtml")]
    public class Views_PI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\bow\project\netka_pi\Views\PI\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(47, 5575, true);
            WriteLiteral(@"

<div class=""page-header"">
    <div class=""pull-left"">
        <h1>Dashboard</h1>
    </div>
    <div class=""pull-right"">
        <ul class=""stats"">
            <li class='blue'>
                <i class=""icon-calendar""></i>
                <div class=""details"">
                    <span class=""big"">February 22, 2013</span>
                    <span>Wednesday, 13:56</span>
                </div>
            </li>
        </ul>
    </div>
</div>
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
                 ");
            WriteLiteral(@"   Issue Log
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
                            <th class='hidden-1024'>Category</th>
                            <th class='hidden-1024'>Severity</th>
                            <th class='hidden-1024'>Status</th>
                            <th class='hidden-1024'>Date Raised</th>
                            <th class='hidden-1024'>Date Resolved</th>
                            <th class='hidden-1024'>Issue Age</th>
                            <th class='hidden-1024'>Remark</th>
                        </tr>
                    </thead>
                    <tbody>
   ");
            WriteLiteral(@"                     <tr>
                            <td>Issue1</td>
                            <td> bug1 </td>
                            <td class='hidden-350'> bo </td>
                            <td class='hidden-1024'>5</td>
                            <td class='hidden-1024'>2</td>
                            <td class='hidden-1024'>medium</td>
                            <td class='hidden-1024'>new</td>
                            <td class='hidden-1024'>15/08/2019</td>
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
                           ");
            WriteLiteral(@" <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                        </tr>
                        <tr>
                            <td>Issue3</td>
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
                      ");
            WriteLiteral(@"  </tr>
                        <tr>
                            <td>Issue4</td>
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
                            <td>Issue5</td>
                            <td></td>
                            <td class='hidden-350'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024'></td>
                            <td class='hidden-1024");
            WriteLiteral(@"'></td>
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

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
