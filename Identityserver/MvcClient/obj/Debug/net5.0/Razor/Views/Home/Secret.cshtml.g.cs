#pragma checksum "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d698173ab31814974a3171cb582c3b2119a24153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MvcClient.Views.Home.Views_Home_Secret), @"mvc.1.0.view", @"/Views/Home/Secret.cshtml")]
namespace MvcClient.Views.Home
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
#line 1 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d698173ab31814974a3171cb582c3b2119a24153", @"/Views/Home/Secret.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248966d021c9cf382167c1d81669171a02da5319", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secret : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Secret Page</h1>\r\n\r\n");
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 8 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 10 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 11 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 12 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 18 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 20 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 21 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 22 "C:\Users\apurv\Desktop\IdentityServer4\IdentityServer\MvcClient\Views\Home\Secret.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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
