#pragma checksum "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2b7c79062189ea712a162e80f8287212230d6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ReturnProduct), @"mvc.1.0.view", @"/Views/Product/ReturnProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ReturnProduct.cshtml", typeof(AspNetCore.Views_Product_ReturnProduct))]
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
#line 1 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
using Tema3_ProductApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2b7c79062189ea712a162e80f8287212230d6e", @"/Views/Product/ReturnProduct.cshtml")]
    public class Views_Product_ReturnProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
  
    ViewData["Title"] = "ReturnProduct";

#line default
#line hidden
            BeginContext(81, 26, true);
            WriteLiteral("<h1>ReturnProduct</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
     using (Html.BeginForm())
    {
        var id = 1;
        ProductRepository repo = new ProductRepository();
        Product item = repo.GetById(id);
        /*<p>
            <@Html.TextBoxFor(i)/>
            <button type="submit">Find</button>/>
        </p>*/

#line default
#line hidden
            BeginContext(389, 88, true);
            WriteLiteral("        <p>\r\n            Product has been found\r\n        </p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(478, 7, false);
#line 21 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(485, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(500, 9, false);
#line 22 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(509, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(524, 16, false);
#line 23 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(540, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 25 "C:\Users\ST073494\Learning\C#\Workspace\Tema3-ProductApp\Tema3-ProductApp\Views\Product\ReturnProduct.cshtml"
    }

#line default
#line hidden
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
