#pragma checksum "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4eb506031c4cb07439478892749621b2a05b11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Create.cshtml", typeof(AspNetCore.Views_Clients_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4eb506031c4cb07439478892749621b2a05b11", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Claire.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 36, true);
            WriteLiteral("\n<div class=\"col-md-6 offset-md-3\">\n");
            EndContext();
#line 8 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(130, 56, true);
            WriteLiteral("        <div class=\"form-group\">\n        Client\'s Name: ");
            EndContext();
            BeginContext(187, 97, false);
#line 11 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"
                  Write(Html.TextBoxFor(model => model.ClientName, new { @class = "form-control", required = "required"}));

#line default
#line hidden
            EndContext();
            BeginContext(284, 76, true);
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n        Client\'s Cell 📱 : ");
            EndContext();
            BeginContext(361, 91, false);
#line 14 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"
                      Write(Html.TextBoxFor(model => model.Phone, new { @class = "form-control", required="required" }));

#line default
#line hidden
            EndContext();
            BeginContext(452, 87, true);
            WriteLiteral("\n        </div>\n        <div class=\"form-group\">\n        Add a stylist to this Client: ");
            EndContext();
            BeginContext(540, 30, false);
#line 17 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"
                                 Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(570, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
            BeginContext(587, 88, true);
            WriteLiteral("        <input type=\"submit\" value=\"➕Add\" class=\"btn btn-outline-success my-2 my-sm-0\">\n");
            EndContext();
#line 21 "/Users/dominiqueyoumans/Desktop/HairSalon.Solution/ClairesHair/Views/Clients/Create.cshtml"

    }

#line default
#line hidden
            BeginContext(682, 10, true);
            WriteLiteral("    </div>");
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
