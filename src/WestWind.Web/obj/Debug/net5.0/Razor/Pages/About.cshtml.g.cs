#pragma checksum "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349c7a2a21bb04b5645c07afd9195088e1401746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WestWindWeb.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace WestWindWeb.Pages
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
#line 1 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\_ViewImports.cshtml"
using WestWindWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349c7a2a21bb04b5645c07afd9195088e1401746", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb3f8a4f1562209b788c73dbb25dd79b2acbb03", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h5>About The Database Used for This Site</h5>\r\n\r\n");
#nullable restore
#line 7 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
 if(!string.IsNullOrEmpty(Model.ErrorMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:red; font-weight: bold;\">");
#nullable restore
#line 9 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
                                        Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
 if(!string.IsNullOrEmpty(Model.SuccessMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:green; font-weight: bold;\">");
#nullable restore
#line 14 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
                                          Write(Model.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>Database\'s Version</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\About.cshtml"
       Write(Model.DatabaseVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.AboutModel>)PageContext?.ViewData;
        public MyApp.Namespace.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591