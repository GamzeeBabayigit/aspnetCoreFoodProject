#pragma checksum "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033f76b45f67438a8f14abbbad82508617a2bbef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodGet), @"mvc.1.0.view", @"/Views/Food/FoodGet.cshtml")]
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
#line 1 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\_ViewImports.cshtml"
using coreFoodProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\_ViewImports.cshtml"
using coreFoodProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033f76b45f67438a8f14abbbad82508617a2bbef", @"/Views/Food/FoodGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840d0455076dfa54c21eeb835da520ae6aa6ca3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_FoodGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coreFoodProject.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
  
    ViewData["Title"] = "FoodGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Get Food Page</h2>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
 using (Html.BeginForm("FoodUpdate", "Food", FormMethod.Post))

{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.FoodID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Image URL"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 33 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Update</button>\r\n");
#nullable restore
#line 37 "C:\Users\Hp\source\repos\coreFoodProject\coreFoodProject\Views\Food\FoodGet.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreFoodProject.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591