#pragma checksum "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fbb90e3ca38aa15772f1cff86d88b9b202ae039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fbb90e3ca38aa15772f1cff86d88b9b202ae039", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3f36e1caa5a8ac057f73f4a95ef59fb577cb5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
  
    ViewData["Title"] = "Book";

#line default
#line hidden
            BeginContext(83, 777, true);
            WriteLiteral(@"<!-- ============================================================== -->
<div class=""row page-titles"">
    <div class=""col-md-5 align-self-center"">
        <h3 class=""text-themecolor"">Book</h3>
    </div>
  <!--<div class=""col-md-7 align-self-center"">
       <a href=""https://wrappixel.com/templates/adminpro/"" class=""btn waves-effect waves-light btn-danger pull-right hidden-sm-down""> Upgrade to Pro</a>
    </div>-->
</div>

<div class=""row"">
    <!-- column -->
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">List</h4>
                <!-- <h6 class=""card-subtitle"">Add New Author</h6>-->
                <div class=""col-md-12 col-12 align-self-center"">
                    ");
            EndContext();
            BeginContext(860, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fbb90e3ca38aa15772f1cff86d88b9b202ae0395983", async() => {
                BeginContext(956, 43, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1003, 874, true);
            WriteLiteral(@"
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Title</th>
                                <th>Genre</th>
                                <th>Author</th>
                                <th>ISBN</th>
                                <th>Rating</th>
                                <th>Summary</th>
                                <th>Year Published</th>
                                <th>Created By</th>
                                <th>Date Created</th>
                                <th> </th>
                                <th> </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 44 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                             foreach (var book in Model)
                            {

#line default
#line hidden
            BeginContext(1966, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2037, 7, false);
#line 47 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2044, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2088, 10, false);
#line 48 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2098, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(2143, 15, false);
#line 49 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2158, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2204, 16, false);
#line 50 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2266, 9, false);
#line 51 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(2275, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2321, 11, false);
#line 52 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(2332, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2378, 12, false);
#line 53 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(2390, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2436, 16, false);
#line 54 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.YearPublish);

#line default
#line hidden
            EndContext();
            BeginContext(2452, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2498, 14, false);
#line 55 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2512, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(2558, 16, false);
#line 56 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                               Write(book.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(2574, 47, true);
            WriteLiteral("    </td>\r\n                                <td>");
            EndContext();
            BeginContext(2621, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fbb90e3ca38aa15772f1cff86d88b9b202ae03912668", async() => {
                BeginContext(2677, 54, true);
                WriteLiteral("<i class=\"fa fa-pencil m-r-10\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                                                           WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2735, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(2779, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fbb90e3ca38aa15772f1cff86d88b9b202ae03915152", async() => {
                BeginContext(2826, 66, true);
                WriteLiteral("<i class=\"fa fa-trash-o btn-danger m-r-10\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                                                             WriteLiteral(book.Id);

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
            BeginContext(2896, 43, true);
            WriteLiteral(" </td>\r\n                            </tr>\r\n");
            EndContext();
#line 60 "/Users/abdullahi/Projects/cyberinterns/BookWeb/Views/Book/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2970, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
