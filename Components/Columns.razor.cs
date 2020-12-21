using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoServerGridTestrApp9.Components
{
    public partial class Columns
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
