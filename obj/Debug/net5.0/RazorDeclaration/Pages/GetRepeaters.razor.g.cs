// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace K2GXT_Directory_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using K2GXT_Directory_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\_Imports.razor"
using K2GXT_Directory_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
using K2GXT_Directory_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/getRepeaters")]
    public partial class GetRepeaters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
       
    private Repeater[] repeaters;
    private string currentSort;
    private string currentOrder;
    private string imageSortName;

    protected override async Task OnInitializedAsync()
    {
        currentSort = "RFreq";
        currentOrder = "asc";
        imageSortName = "images/sort-asc.png";
        repeaters = await RepeaterService.GetRepeaterListAsync();
    }

    private async Task sortAsync(string sortData)
    {
        if (currentSort == sortData)
        {
            currentOrder = currentOrder == "asc" ? "desc" : "asc";
            imageSortName = "images/sort-" + currentOrder + ".png";
        }
        currentSort = sortData;
        repeaters = repeaters.AsQueryable().OrderBy(sortData + " "+ currentOrder).ToArray();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RepeaterDirectoryService RepeaterService { get; set; }
    }
}
#pragma warning restore 1591
