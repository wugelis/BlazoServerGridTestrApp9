// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\Index.razor"
using BlazoServerGridTestrApp9.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Gelis Documents\教育訓練課程\Blazor Component 元件設計\Samples\BlazoServerGridTestrApp9\BlazoServerGridTestrApp9\Pages\Index.razor"
       

    int current;
    string _buttonText = "我是按鈕";
    //string ButtonText { get; set; }

    public void Button_Click()
    {
        current++;

        _buttonText = "我是按鈕";

        string buttonText = $"{_buttonText} {current}";

        _buttonText = buttonText;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
