#pragma checksum "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19b75ac44cce9edf657868ab58ac34c28cf90b1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NSAnnualFeeStructure_Details), @"mvc.1.0.view", @"/Views/NSAnnualFeeStructure/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NSAnnualFeeStructure/Details.cshtml", typeof(AspNetCore.Views_NSAnnualFeeStructure_Details))]
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
#line 1 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail;

#line default
#line hidden
#line 2 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b75ac44cce9edf657868ab58ac34c28cf90b1d", @"/Views/NSAnnualFeeStructure/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7208f39407c4b0b1d659c0433583c4bbe9e6a12e", @"/Views/_ViewImports.cshtml")]
    public class Views_NSAnnualFeeStructure_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSSail.Models.AnnualFeeStructure>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
  
    ViewData["Title"] = "Fee Details";

#line default
#line hidden
            BeginContext(90, 139, true);
            WriteLiteral("\r\n<h2>Fee Details</h2>\r\n\r\n<div>\r\n    <h4>Fee Structure Details</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 45, false);
#line 14 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AnnualFee));

#line default
#line hidden
            EndContext();
            BeginContext(275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(319, 41, false);
#line 17 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.AnnualFee));

#line default
#line hidden
            EndContext();
            BeginContext(360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(404, 54, false);
#line 20 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyDiscountedFee));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(502, 50, false);
#line 23 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.EarlyDiscountedFee));

#line default
#line hidden
            EndContext();
            BeginContext(552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(596, 56, false);
#line 26 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EarlyDiscountEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(696, 52, false);
#line 29 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.EarlyDiscountEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(792, 53, false);
#line 32 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RenewDeadlineDate));

#line default
#line hidden
            EndContext();
            BeginContext(845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(889, 49, false);
#line 35 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.RenewDeadlineDate));

#line default
#line hidden
            EndContext();
            BeginContext(938, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(982, 52, false);
#line 38 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExemptionFee));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1078, 48, false);
#line 41 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskExemptionFee));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1170, 49, false);
#line 44 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1263, 45, false);
#line 47 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecondBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1352, 48, false);
#line 50 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThirdBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1444, 44, false);
#line 53 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThirdBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1532, 61, false);
#line 56 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ForthAndSubsequentBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1637, 57, false);
#line 59 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.ForthAndSubsequentBoatFee));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1738, 46, false);
#line 62 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NonSailFee));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1828, 42, false);
#line 65 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.NonSailFee));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1914, 59, false);
#line 68 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember25DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2017, 55, false);
#line 71 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewMember25DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2116, 59, false);
#line 74 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember50DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2219, 55, false);
#line 77 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewMember50DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2318, 59, false);
#line 80 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewMember75DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2421, 55, false);
#line 83 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewMember75DiscountDate));

#line default
#line hidden
            EndContext();
            BeginContext(2476, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2523, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "199f8fbd619b4d08b8a90d5f6d510a2e", async() => {
                BeginContext(2571, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part A\NSSail\NSSail\Views\NSAnnualFeeStructure\Details.cshtml"
                           WriteLiteral(Model.Year);

#line default
#line hidden
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
            EndContext();
            BeginContext(2579, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2587, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883aa63886e34f2ea270d835cbb6734d", async() => {
                BeginContext(2609, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2625, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSSail.Models.AnnualFeeStructure> Html { get; private set; }
    }
}
#pragma warning restore 1591
