#pragma checksum "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d37be0ce6bda2af90ec520abae964c4e461b7270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\lenovo\Desktop\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC;

#line default
#line hidden
#line 2 "C:\Users\lenovo\Desktop\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d37be0ce6bda2af90ec520abae964c4e461b7270", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f3640992204b1ab1edab80a3d884ce08f2b2b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "VTCA";

#line default
#line hidden
            BeginContext(40, 139, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <div class=\"container\">\r\n            <div class=\"row\">\r\n                <h3>\r\n                    Xin chào, ");
            EndContext();
            BeginContext(180, 16, false);
#line 8 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(196, 917, true);
            WriteLiteral(@"
                </h3>
                <input type=""button"" class=""btn btn-primary ml-auto"" value=""Đăng xuất"" onclick=""window.location.href = '/Home/Logout'"">
            </div>
    </div>
    <div class=""row"">
        <div class=""col-3"">
            <ul class=""nav nav-pills flex-column"">
                <li class=""nav-item"">
                    <a class=""nav-link active "" data-toggle=""tab"" href=""#home"">Gửi thư</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""tab"" href=""#menu1"">Đã gửi</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""tab"" href=""#menu2"">Đã nhận</a>
                </li>
            </ul>
      </div>

    <div class=""col-9"">
        <div class=""tab-content"">
          <div id=""home"" class=""container tab-pane active""><br>
            ");
            EndContext();
            BeginContext(1113, 823, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d37be0ce6bda2af90ec520abae964c4e461b72705454", async() => {
                BeginContext(1153, 776, true);
                WriteLiteral(@"
              <div class=""form-group"">
                <label >Người nhận</label>
                <input type=""text"" class=""form-control"" name=""receiver"" placeholder=""Nhập tên người nhận"" required>
              </div>
              <div class=""form-group"">
                <label >Tiêu đề</label>
                <input type=""text"" class=""form-control"" name=""title"" placeholder=""Nhập tiêu đề"" required>
              </div>
              <div>
                 <label>Nội dung</label>
                 <br>
                <textarea id=""subject"" class=""form-control"" name=""content"" placeholder=""Nhập nội dung ...."" style=""height:200px"" required></textarea>
              </div>
              <button class=""btn btn-primary"" id=""send"">Gửi</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1936, 94, true);
            WriteLiteral("\r\n          </div>\r\n          <div id=\"menu1\" class=\"container tab-pane fade\"><br>\r\n          ");
            EndContext();
            BeginContext(2030, 1029, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d37be0ce6bda2af90ec520abae964c4e461b72708097", async() => {
                BeginContext(2071, 342, true);
                WriteLiteral(@"
            <div class=""row"">
              <table class=""table table-hover"">
                <thead>
                  <tr>
                    <th scope=""col-4"">Người nhận</th>
                    <th scope=""col-4"">Tiêu đề</th>
                    <th scope=""col-4"">Nội dung</th>
                  </tr>
                </thead>
");
                EndContext();
#line 59 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                   if(ViewBag.ListMailSend != null)
                  {
                    

#line default
#line hidden
#line 61 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                     foreach (var item in ViewBag.ListMailSend)
                    {

#line default
#line hidden
                BeginContext(2575, 95, true);
                WriteLiteral("                          <tbody>\r\n                        <tr>\r\n                          <td>");
                EndContext();
                BeginContext(2671, 19, false);
#line 65 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(item.Users.Username);

#line default
#line hidden
                EndContext();
                BeginContext(2690, 37, true);
                WriteLiteral("</td>\r\n                          <td>");
                EndContext();
                BeginContext(2728, 15, false);
#line 66 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2743, 100, true);
                WriteLiteral("</td>\r\n                          <td class=\"d-inline-block text-truncate\" style=\"max-width: 150px;\">");
                EndContext();
                BeginContext(2844, 17, false);
#line 67 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                        Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(2861, 71, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                      </tbody> \r\n");
                EndContext();
#line 70 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                      
                    }

#line default
#line hidden
#line 71 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                     
                  }

#line default
#line hidden
                BeginContext(3000, 52, true);
                WriteLiteral("              </table>\r\n          </div>\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3059, 425, true);
            WriteLiteral(@"
          </div>
          <div id=""menu2"" class=""container tab-pane fade""><br>
            <div class=""row"">
              <table class=""table table-hover"">
                <thead>
                  <tr>
                    <th scope=""col-4"">Người gửi</th>
                    <th scope=""col-4"">Tiêu đề</th>
                    <th scope=""col-4"">Nội dung</th>
                  </tr>
                  </thead>
");
            EndContext();
#line 87 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                   if(ViewBag.ListMailReceiver != null)
                  {
                    

#line default
#line hidden
#line 89 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                     foreach (var item in ViewBag.ListMailReceiver)
                    {

#line default
#line hidden
            BeginContext(3654, 95, true);
            WriteLiteral("                          <tbody>\r\n                        <tr>\r\n                          <td>");
            EndContext();
            BeginContext(3750, 19, false);
#line 93 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(item.Users.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3769, 37, true);
            WriteLiteral("</td>\r\n                          <td>");
            EndContext();
            BeginContext(3807, 15, false);
#line 94 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(item.Mail.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3822, 100, true);
            WriteLiteral("</td>\r\n                          <td class=\"d-inline-block text-truncate\" style=\"max-width: 150px;\">");
            EndContext();
            BeginContext(3923, 17, false);
#line 95 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                        Write(item.Mail.Content);

#line default
#line hidden
            EndContext();
            BeginContext(3940, 37, true);
            WriteLiteral("</td>\r\n                          <td>");
            EndContext();
            BeginContext(3978, 69, false);
#line 96 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(Html.ActionLink("Edit", "Edit", new { id=item.MailDetails_Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(4047, 34, true);
            WriteLiteral(" |\r\n                              ");
            EndContext();
            BeginContext(4082, 75, false);
#line 97 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(Html.ActionLink("Details", "Details", new { id=item.MailDetails_Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(4157, 34, true);
            WriteLiteral(" |\r\n                              ");
            EndContext();
            BeginContext(4192, 73, false);
#line 98 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                         Write(Html.ActionLink("Delete", "Delete", new { id=item.MailDetails_Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(4265, 85, true);
            WriteLiteral("\r\n            </td>\r\n                        </tr>\r\n                      </tbody> \r\n");
            EndContext();
#line 102 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                      
                    }

#line default
#line hidden
#line 103 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                     
                  }

#line default
#line hidden
            BeginContext(4418, 94, true);
            WriteLiteral("              </table>\r\n          </div>\r\n          </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
