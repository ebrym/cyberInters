#pragma checksum "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200034eada7e6dad2771c098ab78e8fe5455f238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200034eada7e6dad2771c098ab78e8fe5455f238", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3f36e1caa5a8ac057f73f4a95ef59fb577cb5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 451, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-9 col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div>
                        <h3 class=""card-title m-b-5""><span class=""lstick""></span>Sales Overview </h3>
                    </div>
                    <div class=""ml-auto"">
                        <select class=""custom-select b-0"">
                            ");
            EndContext();
            BeginContext(496, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200034eada7e6dad2771c098ab78e8fe5455f2384916", async() => {
                BeginContext(516, 12, true);
                WriteLiteral("January 2017");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(537, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(567, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200034eada7e6dad2771c098ab78e8fe5455f2386186", async() => {
                BeginContext(585, 13, true);
                WriteLiteral("February 2017");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(607, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(637, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200034eada7e6dad2771c098ab78e8fe5455f2387574", async() => {
                BeginContext(655, 10, true);
                WriteLiteral("March 2017");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(674, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(704, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200034eada7e6dad2771c098ab78e8fe5455f2388959", async() => {
                BeginContext(722, 10, true);
                WriteLiteral("April 2017");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(741, 8241, true);
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div id=""sales-overview2"" class=""p-relative"" style=""height:360px;""></div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- visit charts-->
    <!-- ============================================================== -->
    <div class=""col-lg-3 col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title""><span class=""lstick""></span>Visit Separation</h4>
                <div id=""visitor"" style=""height:250px; width:100%;""></div>
                <table class=""table vm font-14"">
                    <tr>
                        <td class=""b-0"">Mobile</td>
                        <td class=""text-right font-medium b-0"">38.5%</td>
                    </tr>
                    <tr>
                        <td>Tablet</td>
                        <td class=""text-right fon");
            WriteLiteral(@"t-medium"">30.8%</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
<!-- ============================================================== -->
<!-- Projects of the month -->
<!-- ============================================================== -->
<div class=""row"">
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div>
                        <h4 class=""card-title""><span class=""lstick""></span>Projects of the Month</h4>
                    </div>
                </div>
                <div class=""table-responsive m-t-20"">
                    <table class=""table vm no-th-brd no-wrap pro-of-month"">
                        <thead>
                            <tr>
                                <th colspan=""2"">Assigned</th>
                                <th>Name</th>
                                <th>Priority</th>
             ");
            WriteLiteral(@"               </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style=""width:50px;""><span class=""round""><img src=""../assets/images/users/1.jpg"" alt=""user"" width=""50""></span></td>
                                <td>
                                    <h6>Sunil Joshi</h6><small class=""text-muted"">Web Designer</small>
                                </td>
                                <td>Elite Admin</td>
                                <td>Low</td>
                            </tr>
                            <tr class=""active"">
                                <td><span class=""round""><img src=""../assets/images/users/2.jpg"" alt=""user"" width=""50""></span></td>
                                <td>
                                    <h6>Andrew</h6><small class=""text-muted"">Project Manager</small>
                                </td>
                                <td>Real Homes</td>
                    ");
            WriteLiteral(@"            <td>Medium</td>
                            </tr>
                            <tr>
                                <td><span class=""round round-success""><img src=""../assets/images/users/3.jpg"" alt=""user"" width=""50""></span></td>
                                <td>
                                    <h6>Bhavesh patel</h6><small class=""text-muted"">Developer</small>
                                </td>
                                <td>MedicalPro Theme</td>
                                <td>High</td>
                            </tr>
                            <tr>
                                <td><span class=""round round-primary""><img src=""../assets/images/users/4.jpg"" alt=""user"" width=""50""></span></td>
                                <td>
                                    <h6>Nirav Joshi</h6><small class=""text-muted"">Frontend Eng</small>
                                </td>
                                <td>Elite Admin</td>
                                <td>Low</td>");
            WriteLiteral(@"
                            </tr>
                            <tr>
                                <td><span class=""round round-warning""><img src=""../assets/images/users/5.jpg"" alt=""user"" width=""50""></span></td>
                                <td>
                                    <h6>Micheal Doe</h6><small class=""text-muted"">Content Writer</small>
                                </td>
                                <td>Helping Hands</td>
                                <td>High</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- contact -->
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex"">
                    <h4 class=""card-title""><span class=""lstick""></span>My Contact</h4>
                </div>
                <div class=""message-box contact-box"">
                    ");
            WriteLiteral(@"<div class=""message-widget contact-widget"">
                        <!-- Message -->
                        <a href=""#"">
                            <div class=""user-img""> <img src=""../assets/images/users/1.jpg"" alt=""user"" class=""img-circle""> <span class=""profile-status online pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Pavan kumar</h5> <span class=""mail-desc"">info@wrappixel.com</span>
                            </div>
                        </a>
                        <!-- Message -->
                        <a href=""#"">
                            <div class=""user-img""> <img src=""../assets/images/users/2.jpg"" alt=""user"" class=""img-circle""> <span class=""profile-status busy pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Sonu Nigam</h5> <span class=""mail-desc"">pamela1987@gmail.com</span>
                            </div>
                        </a>");
            WriteLiteral(@"
                        <!-- Message -->
                        <a href=""#"">
                            <div class=""user-img""> <span class=""round"">A</span> <span class=""profile-status away pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Arijit Sinh</h5> <span class=""mail-desc"">cruise1298.fiplip@gmail.com</span>
                            </div>
                        </a>
                        <!-- Message -->
                        <a href=""#"">
                            <div class=""user-img""> <img src=""../assets/images/users/4.jpg"" alt=""user"" class=""img-circle""> <span class=""profile-status offline pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Pavan kumar</h5> <span class=""mail-desc"">kat@gmail.com</span>
                            </div>
                        </a>
                        <!-- Message -->
                        <a href=""#"">");
            WriteLiteral(@"
                            <div class=""user-img""> <img src=""../assets/images/users/5.jpg"" alt=""user"" class=""img-circle""> <span class=""profile-status offline pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Andrew</h5> <span class=""mail-desc"">and@gmail.com</span>
                            </div>
                        </a>
                        <!-- Message -->
                        <a href=""#"">
                            <div class=""user-img""> <img src=""../assets/images/users/6.jpg"" alt=""user"" class=""img-circle""> <span class=""profile-status offline pull-right""></span> </div>
                            <div class=""mail-contnet"">
                                <h5>Jonathan Jones</h5> <span class=""mail-desc"">jj@gmail.com</span>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- ===================");
            WriteLiteral("=========================================== -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
