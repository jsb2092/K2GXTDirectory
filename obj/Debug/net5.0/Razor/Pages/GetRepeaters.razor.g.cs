#pragma checksum "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec3f58e093fba540bd415eaba78b86ad07f0bd0a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Repeater Directory</h1>");
#nullable restore
#line 12 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
 if (repeaters == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.OpenElement(4, "thead");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                      async () => await sortAsync("CallSign")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "width", "12");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 22 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                          imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    Callsign\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "th");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                      async () => await sortAsync("TFreq")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "width", "12");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 26 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                                  imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            Transmit Frequency\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "th");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                      async () => await sortAsync("RFreq")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "width", "12");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 30 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                          imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    Receive Frequency\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        \r\n                ");
            __builder.OpenElement(30, "th");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                      async () => await sortAsync("CTCSS")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "width", "12");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 35 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                          imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    CTCSS\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                 ");
            __builder.OpenElement(38, "th");
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                       async () => await sortAsync("County")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(41, "img");
            __builder.AddAttribute(42, "width", "12");
            __builder.AddAttribute(43, "src", 
#nullable restore
#line 39 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                           imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    County\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "th");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                      async () => await sortAsync("Location")

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(49, "img");
            __builder.AddAttribute(50, "width", "12");
            __builder.AddAttribute(51, "src", 
#nullable restore
#line 43 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                           imageSortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    Location\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "tbody");
#nullable restore
#line 49 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
             foreach (var repeater in repeaters)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "href", "/repeaterDetails/" + (
#nullable restore
#line 52 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                                   repeater._id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, 
#nullable restore
#line 52 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                                                                  repeater.CallSign

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 53 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                         repeater.TFreq

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 54 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                         repeater.RFreq

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 56 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                         repeater.CTCSS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 57 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                         repeater.County

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 58 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
                         repeater.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\jsb\Dropbox\src\K2GXT Directory 2\Pages\GetRepeaters.razor"
}

#line default
#line hidden
#nullable disable
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
