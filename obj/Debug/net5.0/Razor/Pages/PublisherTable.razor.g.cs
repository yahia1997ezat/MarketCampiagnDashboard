#pragma checksum "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d83a40982b3046db63ae0bcff126d56c922bcc33"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\blazor\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\blazor\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projects\blazor\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\blazor\BlazorApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publishers")]
    public partial class PublisherTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-header d-flex justify-content-between align-items-center flex-wrap");
            __builder.AddMarkupContent(4, "<div><b>\r\n                Publishers Campaigns<br>\r\n                <small>This component demonstrates fetching data from a service.</small></b></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-info text-capitalize");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                                                                     () => ShowEditPublisher(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "<i class=\"fa fa-add\"></i> add\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
#nullable restore
#line 21 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
         if (MarketingCampaignService.Publishers == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 26 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "<thead><tr><th>No.</th>\r\n                    <th>Name</th>\r\n                    <th>Supported Channels</th>\r\n                    <th>Market Campaign</th>\r\n                    <th>Actions</th></tr></thead>\r\n                ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 40 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                 foreach (var publisher in MarketingCampaignService.Publishers)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 43 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                             publisher.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 44 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                             publisher.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "th");
#nullable restore
#line 46 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                             foreach (var channel in publisher.Channels)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "mr-2");
            __builder.AddContent(28, 
#nullable restore
#line 48 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                                                    channel?.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, ",");
            __builder.CloseElement();
#nullable restore
#line 49 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "th");
#nullable restore
#line 53 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                             foreach (var marketingCampaign in publisher.MarketingCampaigns)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "mr-2");
            __builder.AddContent(34, 
#nullable restore
#line 55 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                                                    marketingCampaign?.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, ",");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                                                () => ShowEditPublisher(@publisher.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-light ");
            __builder.AddMarkupContent(41, "<i class=\"fa fa-edit text-primary\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\projects\blazor\BlazorApp\Pages\PublisherTable.razor"
       

    [CascadingParameter]
    public IModalService Modal { get; set; }

    async void ShowEditPublisher(long id)
    {
        var parameters = new ModalParameters();
        parameters.Add("EditPublisher", id > 0 ? MarketingCampaignService.Publishers.FirstOrDefault((publisher) => publisher.Id == id) : null);
        var formModal = Modal.Show<AddPublisher>("Add Publisher", parameters);
        var result = await formModal.Result;
        if (result.Cancelled)
        {
            Console.WriteLine("Modal was cancelled");
        }
        else
        {
            MarketingCampaignService.MarketingCampaigns.Add((MarketingCampaign) result.Data);
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MarketingCampaignService MarketingCampaignService { get; set; }
    }
}
#pragma warning restore 1591
