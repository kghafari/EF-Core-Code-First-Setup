#pragma checksum "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958f5dd35c4813cb196787b1e0162b38d62b5bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\_ViewImports.cshtml"
using Day28_EFCore_CodeFirst_Solo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\_ViewImports.cshtml"
using Day28_EFCore_CodeFirst_Solo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
using Day28_EFCore_CodeFirst_Solo.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958f5dd35c4813cb196787b1e0162b38d62b5bbd", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf38a2c0c50e10554dd579a1a6a0d551037a582a", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Dept. Name</th>\r\n        <th>Location</th>\r\n        <th>Type</th>\r\n        <th>Budget</th>\r\n");
            WriteLiteral("        <th>Edit</th>\r\n        <th>Delete</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
     foreach (Department department in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
           Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
           Write(department.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
           Write(department.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
           Write(department.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 666, 2);
            WriteAttributeValue("", 620, "../Department/EditDepartment?Id=", 620, 32, true);
#nullable restore
#line 29 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
WriteAttributeValue("", 652, department.Id, 652, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit ");
#nullable restore
#line 29 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
                                                                         Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 718, "\"", 773, 2);
            WriteAttributeValue("", 725, "../Department/DeleteDepartment?Id=", 725, 34, true);
#nullable restore
#line 30 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
WriteAttributeValue("", 759, department.Id, 759, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete ");
#nullable restore
#line 30 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
                                                                             Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Department\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"../Department/AddDepartment\">Add Department</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591