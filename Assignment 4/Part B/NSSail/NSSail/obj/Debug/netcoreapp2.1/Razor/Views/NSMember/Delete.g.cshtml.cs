#pragma checksum "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0503c6f6d4550e5ad6de72375da5b14bb35da0cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NSMember_Delete), @"mvc.1.0.view", @"/Views/NSMember/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NSMember/Delete.cshtml", typeof(AspNetCore.Views_NSMember_Delete))]
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
#line 1 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail;

#line default
#line hidden
#line 2 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0503c6f6d4550e5ad6de72375da5b14bb35da0cf", @"/Views/NSMember/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7208f39407c4b0b1d659c0433583c4bbe9e6a12e", @"/Views/_ViewImports.cshtml")]
    public class Views_NSMember_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSSail.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(73, 167, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(241, 44, false);
#line 15 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 40, false);
#line 18 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 45, false);
#line 21 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(502, 41, false);
#line 24 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(543, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(587, 44, false);
#line 27 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 40, false);
#line 30 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(759, 51, false);
#line 33 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(854, 47, false);
#line 36 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(945, 50, false);
#line 39 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(995, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1039, 46, false);
#line 42 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 42, false);
#line 45 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1215, 38, false);
#line 48 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1297, 40, false);
#line 51 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1381, 36, false);
#line 54 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1461, 46, false);
#line 57 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1551, 42, false);
#line 60 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1637, 45, false);
#line 63 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1726, 41, false);
#line 66 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1811, 41, false);
#line 69 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1896, 37, false);
#line 72 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1977, 46, false);
#line 75 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2067, 42, false);
#line 78 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2153, 43, false);
#line 81 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2240, 39, false);
#line 84 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2279, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2323, 46, false);
#line 87 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2413, 42, false);
#line 90 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2455, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2499, 49, false);
#line 93 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2592, 45, false);
#line 96 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2681, 58, false);
#line 99 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2783, 67, false);
#line 102 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2850, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2888, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7cac5da944140439e52805fdc58a97b", async() => {
                BeginContext(2914, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2924, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af539e329dc54e378024e5cc6988068d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "C:\Users\natha\Documents\School\Fall 2018\PROG2230 - Programming Microsoft Web Technologies\Assignment 4\Part B\NSSail\NSSail\Views\NSMember\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MemberId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2966, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3050, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb82999878874b70b2dcb4591b2ecdb7", async() => {
                    BeginContext(3072, 12, true);
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
                BeginContext(3088, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3101, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSSail.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591