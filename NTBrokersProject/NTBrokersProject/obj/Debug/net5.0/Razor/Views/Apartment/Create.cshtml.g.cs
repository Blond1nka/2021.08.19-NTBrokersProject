#pragma checksum "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b04a1cad56124b082fffa3bf945b96ab883826d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apartment_Create), @"mvc.1.0.view", @"/Views/Apartment/Create.cshtml")]
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
#line 1 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\_ViewImports.cshtml"
using NTBrokersProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\_ViewImports.cshtml"
using NTBrokersProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b04a1cad56124b082fffa3bf945b96ab883826d", @"/Views/Apartment/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1338f92225a140e1d4827ed184448e92fde7b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Apartment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NTBrokersProject.Models.ApartmentCreateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h5>Create new apartment</h5>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
 using (Html.BeginForm("Submit", "Apartment", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-full\" style=\"background-color:aliceblue\">\r\n        <div class=\"container\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 12 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 15 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 18 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.FlatFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.FlatFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 21 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.BuildingFloors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.BuildingFloors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 24 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.LabelFor(x => x.Apartments.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Apartments.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 27 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
       Write(Html.DropDownListFor(x => x.Apartments.CompanyId, new SelectList(Model.Companies, "Id", "Name")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Submit\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Users\Šmara\Desktop\Po\2021.08.19 NTBrokersProject\NTBrokersProject\NTBrokersProject\Views\Apartment\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NTBrokersProject.Models.ApartmentCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
