#pragma checksum "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed635e13cc60e7d5fa95d296f9e5e6d6a0095cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed635e13cc60e7d5fa95d296f9e5e6d6a0095cd8", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Claire.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 19, true);
            WriteLiteral("\n<h3>Edit Details: ");
            EndContext();
            BeginContext(78, 42, false);
#line 7 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
             Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(120, 41, true);
            WriteLiteral("<h3>\n\n<div class=\"col-md-6 offset-md-3\">\n");
            EndContext();
#line 10 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(189, 29, true);
            WriteLiteral("    <div class=\"form-group\"> ");
            EndContext();
            BeginContext(219, 39, false);
#line 12 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
                        Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(258, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(271, 55, true);
            WriteLiteral("    <div class=\"form-group\">\n    Assigned Stylist:\n    ");
            EndContext();
            BeginContext(327, 30, false);
#line 17 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(357, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(372, 43, true);
            WriteLiteral("    <div class=\"form-group\">\n    Name:\n    ");
            EndContext();
            BeginContext(416, 73, false);
#line 22 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.ClientName, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(489, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(502, 45, true);
            WriteLiteral("    <div class=\"form-group\">\n    📱Cell:\n    ");
            EndContext();
            BeginContext(548, 68, false);
#line 27 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.Phone, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(616, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(629, 63, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"btn btn-success\">\n");
            EndContext();
#line 31 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
    

}

#line default
#line hidden
            BeginContext(700, 10, true);
            WriteLiteral("</div>\n<p>");
            EndContext();
            BeginContext(711, 39, false);
#line 35 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("All Clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(750, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(759, 40, false);
#line 36 "/Users/dominiqueyoumans/Desktop/ClairesHair.Solution/ClairesHair/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("Main", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(799, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Claire.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
