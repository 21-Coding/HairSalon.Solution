#pragma checksum "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec077e78cfdad8361e174720f63dbd5b8f2948d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 5 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
using Claire.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec077e78cfdad8361e174720f63dbd5b8f2948d6", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Claire.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(87, 70, true);
            WriteLiteral("\n<div class=\"col-md-8 offset-md-2\">\n    <h3>Clients</h3>\n</div>\n<br>\n\n");
            EndContext();
#line 13 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(183, 25, true);
            WriteLiteral("    <h3>No clients.</h3>\n");
            EndContext();
#line 16 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"

}

#line default
#line hidden
            BeginContext(211, 35, true);
            WriteLiteral("<div class=\"col-md-8 offset-md-2\">\n");
            EndContext();
#line 19 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
     foreach (Client client in Model)
    {

#line default
#line hidden
            BeginContext(290, 92, true);
            WriteLiteral("        <li>Html.ActionLink($\"{client.ClientName}\", \"Info\", new { id = client.ClientId }) : ");
            EndContext();
            BeginContext(383, 12, false);
#line 21 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
                                                                                       Write(client.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(395, 28, true);
            WriteLiteral("\n        </li>\n        <br>\n");
            EndContext();
#line 24 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(430, 18, true);
            WriteLiteral("    </div>\n    <p>");
            EndContext();
            BeginContext(449, 40, false);
#line 27 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Index.cshtml"
  Write(Html.ActionLink("Main", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(489, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Claire.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591