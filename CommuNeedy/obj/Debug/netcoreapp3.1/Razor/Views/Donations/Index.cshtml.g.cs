#pragma checksum "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b884d3fe31dc3c0e385f64b7a5e0c222d1600f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donations_Index), @"mvc.1.0.view", @"/Views/Donations/Index.cshtml")]
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
#line 1 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/_ViewImports.cshtml"
using CommuNeedy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/_ViewImports.cshtml"
using CommuNeedy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b884d3fe31dc3c0e385f64b7a5e0c222d1600f", @"/Views/Donations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ec3f62bb1078c3d50156e8c01be05162a17c10", @"/Views/_ViewImports.cshtml")]
    public class Views_Donations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommuNeedy.Models.DonationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\" style=\"margin-top: 80px;\">\r\n        <h1 class=\"need-head col-lg-6 col-md-8\">All Donations</h1>\r\n        <p class=\"col-lg-6 col-md-8\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60b884d3fe31dc3c0e385f64b7a5e0c222d1600f5214", async() => {
                WriteLiteral("<i class=\"fa plus fa-plus\"></i>Make donation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"row\" style=\"margin-bottom: 50px;\">\r\n");
#nullable restore
#line 17 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
         foreach (var item in Model.DonationswithNeeds)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
             if (item.DonationNeeds != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 24 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-date\">");
#nullable restore
#line 25 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.ReleasedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-btns\">\r\n");
#nullable restore
#line 28 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                             if (item.DonationNeeds != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p style=\"color: #3C79FF; font-weight: 600; float:left; margin-top:11px; margin-left: 20px;\"><i class=\"fa fa-credit-card\" style=\"margin-right: 5px;\"></i>R ");
#nullable restore
#line 30 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(",00</p>\r\n");
#nullable restore
#line 31 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60b884d3fe31dc3c0e385f64b7a5e0c222d1600f9259", async() => {
                WriteLiteral("<i class=\"fa fa-folder\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <h1 class=\"need-head\">My Donations</h1>\r\n    <div class=\"row\" style=\"margin-bottom: 50px;\">\r\n");
#nullable restore
#line 41 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
         foreach (var item in Model.UserDonations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 46 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-date\">");
#nullable restore
#line 47 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.ReleasedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"color: #3C79FF; font-weight: 600; float:left; margin-top:11px; margin-left: 20px;\"><i class=\"fa fa-credit-card\" style=\"margin-right: 5px;\"></i>R ");
#nullable restore
#line 48 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
                                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(",00</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 52 "/Users/CarmenSeesink/Documents/GitHub/CommuNeedy/CommuNeedy/CommuNeedy/Views/Donations/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommuNeedy.Models.DonationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
