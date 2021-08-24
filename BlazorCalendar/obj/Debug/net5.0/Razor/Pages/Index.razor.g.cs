#pragma checksum "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6ebf2490564c41ac66843407beca0ee1e9ef371"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCalendar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddMarkupContent(1, "<h3 class=\"ms-fontSize-42 ms-fontweight-Regular\">Welcome to Blazor Calendar</h3>\r\n\r\n        \r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "<a href=\"#\" class=\"microsoft-login-button shadow-effect\"><img src=\"Assets/Images/Windows-Logo-PNG-Free-Image.png\" alt>Sign In</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-12 col-md-12 col-lg-9");
            __builder.OpenComponent<BlazorCalendar.Components.Calendar>(10);
            __builder.AddAttribute(11, "DayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorCalendar.Models.CalendarDay>)((day) => (__builder2) => {
#nullable restore
#line 22 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\Pages\Index.razor"
                      
                        string currentDayClass = day.Date == DateTime.Now.Date ? "current-day" : "";
                    

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(12, "                    \r\n                    if(!day.IsEmpty)\r\n                    {\r\n                        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "day" + " shadow-effect" + " " + (
#nullable restore
#line 28 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\Pages\Index.razor"
                                                       currentDayClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(15, "h3");
                __builder2.AddAttribute(16, "calss", "ms-fontsize-24 ms-fontwieght-regular");
                __builder2.AddContent(17, 
#nullable restore
#line 29 "C:\Users\kattc\source\repos\Admin Preview\Admin Preview-1\BlazorCalendar\Pages\Index.razor"
                                                                              day.DayNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                    }\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
