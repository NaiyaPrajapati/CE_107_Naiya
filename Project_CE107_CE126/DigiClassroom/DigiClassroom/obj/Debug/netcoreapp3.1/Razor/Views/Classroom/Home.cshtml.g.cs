#pragma checksum "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e55304de268a27694b77abc18ae18953954a296b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom_Home), @"mvc.1.0.view", @"/Views/Classroom/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/Home.cshtml", typeof(AspNetCore.Views_Classroom_Home))]
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
#line 1 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\_ViewImports.cshtml"
using DigiClassroom;

#line default
#line hidden
#line 2 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\_ViewImports.cshtml"
using DigiClassroom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e55304de268a27694b77abc18ae18953954a296b", @"/Views/Classroom/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75eeeec46ac66f1c2b806d7de44ad732c331b9ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigiClassroom.ViewModels.ClassroomHomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LeaveClassroom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BlackBoardIndexPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AssignmentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PeoplePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
  
    ViewData["Title"] = "Home";
    ViewData["ClassId"] = Model.Classroom.ID;

#line default
#line hidden
            BeginContext(147, 91, true);
            WriteLiteral("<div class=\"row light-grey-display h-100 w-100\">\r\n    <div class=\"col-md-12\">\r\n        <h2>");
            EndContext();
            BeginContext(239, 47, false);
#line 10 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
       Write(Html.DisplayFor(model => model.Classroom.title));

#line default
#line hidden
            EndContext();
            BeginContext(286, 18, true);
            WriteLiteral("</h2>\r\n        <p>");
            EndContext();
            BeginContext(305, 62, false);
#line 11 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
      Write(CustomHelpers.DisplayWithLinksFor(Model.Classroom.description));

#line default
#line hidden
            EndContext();
            BeginContext(367, 1244, true);
            WriteLiteral(@"</p>
    </div>
</div>
<div class=""row"">
    <nav class=""col-md-2 d-none d-md-block bg-light sidebar"">
        <div class=""sidebar-sticky"">
            <h6 class=""sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted"">
                <span>Room</span>
            </h6>
            <ul class=""nav flex-column"">
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewBoard"">
                        Black Board
                    </button>
                </li>
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewAssignments"">
                        Assignments
                    </button>
                </li>
                <li class=""nav-item"">
                    <button class=""nav-link btn test btn-custom"" id=""ViewPeople"">
                        People
                    </button>
                </li>
            </ul>

     ");
            WriteLiteral("       <h6 class=\"sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted\">\r\n                <span>Settings</span>\r\n            </h6>\r\n\r\n            <ul class=\"nav flex-column mb-2\">\r\n");
            EndContext();
#line 43 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
                 if (Model.ClassroomUserRole == "Mentor")
                {

#line default
#line hidden
            BeginContext(1689, 67, true);
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
            EndContext();
            BeginContext(1756, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55304de268a27694b77abc18ae18953954a296b8557", async() => {
                BeginContext(1829, 66, true);
                WriteLiteral("\r\n                            Edit Class\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
                                                                WriteLiteral(Model.Classroom.ID);

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
            BeginContext(1899, 1057, true);
            WriteLiteral(@"
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-danger"" data-toggle=""modal"" data-target=""#DeleteModal"">
                            Delete Class
                        </a>
                    </li>
                    <div class=""modal fade"" id=""DeleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"">Hold Up!</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
   ");
            WriteLiteral("                                 ");
            EndContext();
            BeginContext(2956, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e55304de268a27694b77abc18ae18953954a296b12209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 65 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3003, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 70 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3201, 1025, true);
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a class=""nav-link text-danger"" data-toggle=""modal"" data-target=""#LeaveModal"">
                            Leave Class
                        </a>
                    </li>
                    <div class=""modal fade"" id=""LeaveModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"">Hold Up!</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                   ");
            WriteLiteral(" ");
            EndContext();
            BeginContext(4226, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e55304de268a27694b77abc18ae18953954a296b15443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 88 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4281, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 93 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
                }

#line default
#line hidden
            BeginContext(4438, 126, true);
            WriteLiteral("            </ul>\r\n\r\n        </div>\r\n    </nav>\r\n    <div class=\"mt-3 col-md-10\">\r\n        <div id=\"BlackBoard\">\r\n            ");
            EndContext();
            BeginContext(4564, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e55304de268a27694b77abc18ae18953954a296b17678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 100 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4627, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div id=\"Assignments\">\r\n            ");
            EndContext();
            BeginContext(4689, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e55304de268a27694b77abc18ae18953954a296b19439", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 103 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4747, 57, true);
            WriteLiteral("\r\n        </div>\r\n        <div id=\"People\">\r\n            ");
            EndContext();
            BeginContext(4804, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e55304de268a27694b77abc18ae18953954a296b21195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 106 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4858, 200, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n\r\n        $(\"#BlackBoard\").hide();\r\n        $(\"#People\").hide();\r\n        $(\"#Assignments\").hide();\r\n        $(\"#");
            EndContext();
            BeginContext(5059, 23, false);
#line 117 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\Home.cshtml"
       Write(ViewData["loadPartial"]);

#line default
#line hidden
            EndContext();
            BeginContext(5082, 1650, true);
            WriteLiteral(@""").show();
        $(""#ViewBoard"").click(function () {
            $(""#BlackBoard"").show();
            $(""#People"").hide();
            $(""#Assignments"").hide();
        });

        $(""#ViewAssignments"").click(function () {
            $(""#BlackBoard"").hide();
            $(""#People"").hide();
            $(""#Assignments"").show();
        });

        $(""#ViewPeople"").click(function () {
            $(""#BlackBoard"").hide();
            $(""#People"").show();
            $(""#Assignments"").hide();
        });
    });
</script>

<style>
    .btn.active.focus, .btn.active:focus, .btn.focus, .btn.focus:active, .btn:active:focus, .btn:focus {
        outline: thin dotted;
        outline-offset: -2px;
    }

    .test:focus {
        outline: none !important;
        border-color: transparent !important;
    }

    .btn-custom {
        color: #000;
        background-color: #f8f9fa;
    }

        .btn-custom:hover {
            color: #fff;
            background-color: #1b6e");
            WriteLiteral(@"c2;
        }

        .btn-custom:focus, .btn-custom.focus {
            color: #fff;
            background-color: #1b6ec2;
        }

    body .btn {
        outline: 0;
    }

    .btn.active.focus,
    .btn.active:focus,
    .btn.focus,
    .btn.focus:active,
    .btn:active:focus,
    .btn:focus {
        outline: 0;
        outline-offset: 0;
        background-image: none;
        -webkit-box-shadow: none;
        box-shadow: none;
    }

    .light-grey-display {
        background-color: #eeeeee !important;
        padding: 10px;
        border-radius: 5px;
    }
</style>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiClassroom.ViewModels.ClassroomHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591