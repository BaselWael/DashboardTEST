#pragma checksum "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b229c5a616659e107ec498d1718b3c7ea9f6b19c"
// <auto-generated/>
#pragma warning disable 1591
namespace DashboardTEST.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using DashboardTEST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\_Imports.razor"
using DashboardTEST.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-06j1lub4zf");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-06j1lub4zf>DashboardTEST</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-06j1lub4zf");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-06j1lub4zf></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-06j1lub4zf");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-06j1lub4zf");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Roles", "Admin");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddAttribute(22, "b-06j1lub4zf");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-06j1lub4zf></span> Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "li");
                __builder2.AddAttribute(31, "class", "nav-item px-3");
                __builder2.AddAttribute(32, "b-06j1lub4zf");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
                __builder2.AddAttribute(34, "class", "nav-link");
                __builder2.AddAttribute(35, "href", "counter");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-06j1lub4zf></span> Counter\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(39);
            __builder.AddAttribute(40, "Roles", "Normal");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.AddAttribute(44, "b-06j1lub4zf");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link");
                __builder2.AddAttribute(47, "href", "fetchdata");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-06j1lub4zf></span> Fetch data\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "li");
                __builder2.AddAttribute(52, "class", "nav-item px-3");
                __builder2.AddAttribute(53, "b-06j1lub4zf");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link");
                __builder2.AddAttribute(56, "href", "fetchdata");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-06j1lub4zf></span> data test\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\bslwa\source\repos\DashboardTEST\DashboardTEST\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
