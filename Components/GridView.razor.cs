using BlazoServerGridTestrApp9.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoServerGridTestrApp9.Components
{
    public partial class GridView
    {
        public Employee[] employees;

        [Parameter] public Employee[] DataSource { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        protected override void OnParametersSet()
        {
            employees = DataSource;

            base.OnParametersSet();
        }
    }
}
