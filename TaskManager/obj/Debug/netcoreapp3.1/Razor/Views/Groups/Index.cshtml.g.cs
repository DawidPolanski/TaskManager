#pragma checksum "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b55e4291b924edcaf083741b098a89ee775b787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_Index), @"mvc.1.0.view", @"/Views/Groups/Index.cshtml")]
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
#line 1 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\_ViewImports.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b55e4291b924edcaf083741b098a89ee775b787", @"/Views/Groups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManager.Models.GroupsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""display-4"">Lista grup</h1>


<div class=""btn-group"">
    <div class=""shadow-lg p-3 mb-5 bg-white rounded"">
        <table class=""table"">
            <thead>
                <tr>
                    <th></th>
                    <th>
                        ");
#nullable restore
#line 17 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NameOfGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"width:auto\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NameOfGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"float:left\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                       Write(Html.ActionLink("Edytuj", "Edit", new { id = item.GroupID }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 31 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                       Write(Html.ActionLink("Usuń", "Delete", new { id = item.GroupID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Dawid\source\repos\TaskManager\TaskManager\Views\Groups\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManager.Models.GroupsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
