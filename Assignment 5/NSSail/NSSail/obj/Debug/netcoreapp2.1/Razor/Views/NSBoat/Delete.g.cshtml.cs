#pragma checksum "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67632159542b82ddd9a163f571736c7daba2b511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NSBoat_Delete), @"mvc.1.0.view", @"/Views/NSBoat/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NSBoat/Delete.cshtml", typeof(AspNetCore.Views_NSBoat_Delete))]
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
#line 1 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail;

#line default
#line hidden
#line 2 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\_ViewImports.cshtml"
using NSSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67632159542b82ddd9a163f571736c7daba2b511", @"/Views/NSBoat/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7208f39407c4b0b1d659c0433583c4bbe9e6a12e", @"/Views/_ViewImports.cshtml")]
    public class Views_NSBoat_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSSail.Models.Boat>
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
  
    ViewData["Title"] = "Delete " + @ViewData["name"]+"'s Boat";

#line default
#line hidden
            BeginContext(102, 13, true);
            WriteLiteral("\r\n<h2>Delete ");
            EndContext();
            BeginContext(116, 16, false);
#line 7 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
      Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 160, true);
            WriteLiteral("\'s Boat</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Boat</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(293, 45, false);
#line 15 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoatClass));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(382, 41, false);
#line 18 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoatClass));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(467, 46, false);
#line 21 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HullColour));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(557, 42, false);
#line 24 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HullColour));

#line default
#line hidden
            EndContext();
            BeginContext(599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(643, 46, false);
#line 27 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(733, 42, false);
#line 30 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(775, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(819, 46, false);
#line 33 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HullLength));

#line default
#line hidden
            EndContext();
            BeginContext(865, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(909, 42, false);
#line 36 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HullLength));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(995, 44, false);
#line 39 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoatType));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1083, 45, false);
#line 42 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoatType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1172, 42, false);
#line 45 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1258, 48, false);
#line 48 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Member.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1350, 57, false);
#line 51 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkingCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1451, 65, false);
#line 54 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ParkingCodeNavigation.ParkingCode));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1554, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93593ef1900243f3a95fdfa12548a5fe", async() => {
                BeginContext(1580, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1590, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3448b229230c4d8ebf7443de78da4533", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\natha\Documents\School 2018 Fall\PROG2230 - Programming Microsoft Web Technologies\Assignment 5\NSSail\NSSail\Views\NSBoat\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BoatId);

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
                BeginContext(1630, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1714, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e07d0f088b48b2a8e02564593f92fe", async() => {
                    BeginContext(1736, 12, true);
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
                BeginContext(1752, 6, true);
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
            BeginContext(1765, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSSail.Models.Boat> Html { get; private set; }
    }
}
#pragma warning restore 1591
