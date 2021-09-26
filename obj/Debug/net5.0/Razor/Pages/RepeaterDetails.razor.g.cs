#pragma checksum "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5134836705427a31d46e8323c335082f907eed69"
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
#line 1 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using K2GXT_Directory_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jsb/Dropbox/src/K2GXT Directory 2/_Imports.razor"
using K2GXT_Directory_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
using K2GXT_Directory_2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/repeaterDetails/{id}")]
    public partial class RepeaterDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/getRepeaters\"><img width=\"16\" src=\"/images/back.png\"> Back</a>");
#nullable restore
#line 9 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
 if (repeater == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Repeater Details for: ");
            __builder.AddContent(5, 
#nullable restore
#line 15 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                   repeater.CallSign

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "id", "repeaterDetails");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "<td style=\"width:150px\">Callsign: </td>");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 17 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                                        repeater.CallSign

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<td>Rx Frequency: </td> ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 18 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                         repeater.RxFreq

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<td>Tx Frequency: </td>");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 19 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                        repeater.TxFreq

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n        ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "<td>Offset: </td>");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 21 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                  repeater.Offset

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        \n        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<td>Tx Tone: </td>");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 23 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                   repeater.CTCSS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
         if (repeater.RxCTCSS != null && repeater.Tone == "T SQL") {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td>Rx Tone: </td>");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 25 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                       repeater.RxCTCSS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "<td>Tone: </td>");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 27 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                repeater.Tone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "<td>Location: </td>");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 28 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
                                    repeater.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/jsb/Dropbox/src/K2GXT Directory 2/Pages/RepeaterDetails.razor"
       
    [Parameter]
    public string id { get; set; }
    
    private Repeater repeater;


   protected override async Task OnInitializedAsync()
    {
       
       repeater = await RepeaterService.GetRepeaterAsync(id);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RepeaterDirectoryService RepeaterService { get; set; }
    }
}
#pragma warning restore 1591
