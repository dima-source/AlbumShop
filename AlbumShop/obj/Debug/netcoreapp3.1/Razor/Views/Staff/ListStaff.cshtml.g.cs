#pragma checksum "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225d9192cff217824c61e0bde2536650aa3bc504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_ListStaff), @"mvc.1.0.view", @"/Views/Staff/ListStaff.cshtml")]
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
#line 1 "D:\Projects\GIT\AlbumShop\Views\_ViewImports.cshtml"
using AlbumShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml"
using AlbumShop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"225d9192cff217824c61e0bde2536650aa3bc504", @"/Views/Staff/ListStaff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d7fb24ca3797e8a10848b1bf48bf625b1bcda5", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_ListStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все сотрудники</h1>\r\n<h3>");
#nullable restore
#line 3 "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml"
Write(Model.currStaff);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 7 "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml"
      
        foreach (Staff staff in Model.GetAllStaffs)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml"
       Write(Html.Partial("AllStaff", staff));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\GIT\AlbumShop\Views\Staff\ListStaff.cshtml"
                                            
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
