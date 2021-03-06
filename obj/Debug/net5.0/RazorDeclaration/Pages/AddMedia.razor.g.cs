// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\projects\blazor\BlazorApp\Pages\AddMedia.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\blazor\BlazorApp\Pages\AddMedia.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    public partial class AddMedia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\projects\blazor\BlazorApp\Pages\AddMedia.razor"
       

    private string fieldLayoutClass = "col-12 ";
    private string status = "";

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public MarketingCampaign EditMarketCampaign { get; set; }

    private Media Media { get; set; }

    private long MediaAdvertiserId { get; set; }

    bool IsSelected(Channel channel)
    {
        var cha = Media.Channels.FirstOrDefault(element => element.Id == channel.Id);
        return cha != null ? true : false;
    }

    protected override void OnInitialized()
    {
        Media = new Media()
        {
            Channels = new List<Channel>()
        };
    }

    void SubmitForm()
    {
        if (MediaAdvertiserId > 0)
        {
            Media.Advertiser = MarketingCampaignService.Advertisers.FirstOrDefault((advertiser) => advertiser.Id == MediaAdvertiserId);
        }
        else
        {
            status = "Advertiser Required";
            StateHasChanged();
            return;
        }
        Media.CreatedAt = DateTime.Now;
        ModalInstance.CloseAsync(ModalResult.Ok(Media));
    }

    void OnChannelChange(bool result, Channel channel)
    {
        if (!result)
        {
            Media.Channels.Add(channel);
        }
        else
        {
            Media.Channels.Remove(channel);
        }
        StateHasChanged();
    }

    void Cancel()
    {
        ModalInstance.CancelAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MarketingCampaignService MarketingCampaignService { get; set; }
    }
}
#pragma warning restore 1591
