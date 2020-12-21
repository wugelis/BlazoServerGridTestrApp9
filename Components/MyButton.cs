using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoServerGridTestrApp9.Components
{
    public class MyButton: ComponentBase
    {
        [Parameter] public string ButtonText { get; set; }

        [Parameter] public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            //builder.AddMarkupContent(0, $"<button class=\"btn btn-primary\">我是按鈕</button>");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", OnClickCallback);
            //builder.AddAttribute(7, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Button_Click));
            builder.AddContent(8, ButtonText);
            builder.CloseElement();
        }
    }
}
