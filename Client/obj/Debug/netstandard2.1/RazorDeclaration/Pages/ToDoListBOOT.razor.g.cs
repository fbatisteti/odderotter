#pragma checksum "D:\Projetos\OdderOtter\client\Pages\ToDoListBOOT.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43bfbd72bc89db0a1f6013e99a82216d7209e88a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OdderOtter.Client.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projetos\OdderOtter\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\OdderOtter\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projetos\OdderOtter\client\_Imports.razor"
using OdderOtter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projetos\OdderOtter\client\_Imports.razor"
using OdderOtter.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projetos\OdderOtter\client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projetos\OdderOtter\client\_Imports.razor"
using OdderOtter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projetos\OdderOtter\client\_Imports.razor"
using OdderOtter.Shared.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projetos\OdderOtter\client\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projetos\OdderOtter\client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todolistboot")]
    public partial class ToDoListBOOT : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Projetos\OdderOtter\client\Pages\ToDoListBOOT.razor"
 
    private string task;
    private Boolean jobDone;

    private IList<ToDoThing> list = new List<ToDoThing>()
    {
        new ToDoThing
        (
            DateTime.Now,
            "Start a \"To do\" list",
            true
        )
    };

    private void addEntry()
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            list.Add(new ToDoThing(DateTime.Now, task));

            task = string.Empty;
        }
    }

    private void completed() => jobDone = !jobDone;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
