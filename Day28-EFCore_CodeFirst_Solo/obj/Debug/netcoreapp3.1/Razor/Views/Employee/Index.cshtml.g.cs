#pragma checksum "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b560767e024c6f3417412e3d8b8da78dd46c32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 6 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
using Day28_EFCore_CodeFirst_Solo.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18b560767e024c6f3417412e3d8b8da78dd46c32", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf38a2c0c50e10554dd579a1a6a0d551037a582a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>First Name</th>\r\n        <th>Last Name</th>\r\n        <th>Email</th>\r\n        <th>Department</th>\r\n        <th>Edit Employee</th>\r\n        <th>Delete Employee</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
     foreach (Employee employee in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
           Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
           Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
           Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>heck</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 587, "\"", 634, 2);
            WriteAttributeValue("", 594, "../Employee/EditEmployee?Id=", 594, 28, true);
#nullable restore
#line 29 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
WriteAttributeValue("", 622, employee.Id, 622, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit ");
#nullable restore
#line 29 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
                                                                   Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 689, "\"", 738, 2);
            WriteAttributeValue("", 696, "../Employee/DeleteEmployee?Id=", 696, 30, true);
#nullable restore
#line 30 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
WriteAttributeValue("", 726, employee.Id, 726, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete ");
#nullable restore
#line 30 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
                                                                       Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\kyleg\source\repos\Day28-EFCore_CodeFirst_Solo\Day28-EFCore_CodeFirst_Solo\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"../Employee/AddEmployee\">Add New Employee</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
