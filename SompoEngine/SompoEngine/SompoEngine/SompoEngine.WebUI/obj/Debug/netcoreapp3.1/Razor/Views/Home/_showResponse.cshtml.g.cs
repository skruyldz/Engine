#pragma checksum "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3892458e43a21d1c8c0ce98af23fa25de863824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__showResponse), @"mvc.1.0.view", @"/Views/Home/_showResponse.cshtml")]
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
#line 3 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\_ViewImports.cshtml"
using SompoEngine.Common.BaseTypes.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\_ViewImports.cshtml"
using SompoEngine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\_ViewImports.cshtml"
using SompoEngine.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\_ViewImports.cshtml"
using SompoEngine.Entites;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3892458e43a21d1c8c0ce98af23fa25de863824", @"/Views/Home/_showResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"350884c194b594d78076670f7c24d9f3bb230320", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__showResponse : BaseViewPage<ServiceCall>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
   
    var dataList = Model.Results.Results;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-4"">
    <div class=""card card-success"">
        <div class=""card-header"">
            <h3 class=""card-title"">Olumlu</h3>
        </div>
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Kod</th>
                            <th>Açıklama</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 19 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                         if (dataList.Count > 0)
                        {
                            foreach (var item in dataList.Where(x=>x.Status.Value == (int)StatusValue.Success))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 24 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                                   Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 25 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                Bilgi Bulunamadı\r\n                            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
    </div>
</div>
<div class=""col-md-4"">
    <div class=""card card-info"">
        <div class=""card-header"">
            <h3 class=""card-title"">Bilgi</h3>
        </div>
        <div class=""card-body"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Kod</th>
                        <th>Açıklama</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 54 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                     if (dataList.Count > 0)
                    {
                        foreach (var item in dataList.Where(x => x.Status.Value == (int)StatusValue.Information))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                               Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>Bilgi Bulunamadı</tr>\r\n");
#nullable restore
#line 67 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<div class=""col-md-4"">
    <div class=""card card-danger"">
        <div class=""card-header"">
            <h3 class=""card-title"">Olumsuz</h3>
        </div>
        <div class=""card-body"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Kod</th>
                        <th>Açıklama</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 87 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                     if (dataList.Count > 0)
                    {
                        foreach (var item in dataList.Where(x => x.Status.Value == (int)StatusValue.Rejected))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 92 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                               Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 93 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            Bilgi Bulunamadı\r\n                        </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Misos\Desktop\Test\SompoEngine\SompoEngine.WebUI\Views\Home\_showResponse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceCall> Html { get; private set; }
    }
}
#pragma warning restore 1591