#pragma checksum "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f397b3a3bb08ae6f5e23418fa8589a5b05f9d0cd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazoServerGridTestrApp9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using BlazoServerGridTestrApp9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\_Imports.razor"
using BlazoServerGridTestrApp9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor"
using BlazoServerGridTestrApp9.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor"
using BlazoServerGridTestrApp9.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gridtest")]
    public partial class GridTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GridTest</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor"
                       GetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "取得資料");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<BlazoServerGridTestrApp9.Components.GridView>(6);
            __builder.AddAttribute(7, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazoServerGridTestrApp9.Data.Employee[]>(
#nullable restore
#line 12 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor"
                      employees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazoServerGridTestrApp9.Components.Columns>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazoServerGridTestrApp9.Components.GridViewItem>(11);
                    __builder3.AddAttribute(12, "ColumnName", "員工編號");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<BlazoServerGridTestrApp9.Components.GridViewItem>(14);
                    __builder3.AddAttribute(15, "ColumnName", "姓名");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<BlazoServerGridTestrApp9.Components.GridViewItem>(17);
                    __builder3.AddAttribute(18, "ColumnName", "職稱");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\GridTest.razor"
       
    Employee[] employees;

    protected async Task GetData()
    {
        employees = await empServices.GetEmployees();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService empServices { get; set; }
    }
}
#pragma warning restore 1591