#pragma checksum "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84bfa4337b6c8b991465e79a9384702afb0cf10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 1 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/_ViewImports.cshtml"
using SchoolMvc;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/_ViewImports.cshtml"
using SchoolMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84bfa4337b6c8b991465e79a9384702afb0cf10", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a1671dae5b634b359cac68238ad4af86e9b787", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolMvc.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Students/Index.cshtml"
  
    ViewData["Title"] = "Student Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(92, 35, true);
            WriteLiteral("\n<h2>All Students</h2>\n<hr />\n<ol>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Students/Index.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
            BeginContext(169, 74, true);
            WriteLiteral("        <li>\n            <ul>\n                <p class=\"alert alert-info\">");
            EndContext();
            BeginContext(244, 106, false);
#line 15 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Students/Index.cshtml"
                                       Write(Html.ActionLink($"{student.FirstName + " " + student.LastName}", "Details", new { id = student.StudentId}));

#line default
#line hidden
            EndContext();
            BeginContext(350, 62, true);
            WriteLiteral("</p class=\"alert alert-info\">\n            </ul>\n        </li>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Students/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(418, 101, true);
            WriteLiteral("</ol>\n\n<button class=\"btn btn-outline-success\"><a href=\"/Students/Create\">Create Student</a></button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolMvc.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591