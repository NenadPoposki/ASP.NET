#pragma checksum "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\Home\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0897d14cdbcd15d547194cc5081ce2bb4451c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Orders), @"mvc.1.0.view", @"/Views/Home/Orders.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0897d14cdbcd15d547194cc5081ce2bb4451c0", @"/Views/Home/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc15dd9ac112cec217320a8152f12002a6eb2028", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaApp.Models.Domain.Orders>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("List<>\r\n<h2>This is Orders</h2>\r\n\r\n\r\n<ul>\r\n    <li>Order number: ");
#nullable restore
#line 7 "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\Home\Orders.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Name: ");
#nullable restore
#line 8 "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\Home\Orders.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Description: ");
#nullable restore
#line 9 "C:\Users\User\Desktop\Exam\asp.net\second\PizzaApp\Views\Home\Orders.cshtml"
                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n\r\n\r\n<h2>List of Orders</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaApp.Models.Domain.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
