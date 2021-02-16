#pragma checksum "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0dc7613554349e0a314f2d9c1b2370b97bf833"
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
#line 1 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    public partial class AddPublisher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "simple-form");
            __builder.OpenElement(2, "form");
            __builder.AddAttribute(3, "class", "form");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-0");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 7 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "<label for=\"movie-name\">Movie Name</label>\r\n                    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "movie-name");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                   MarketingCampaign.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.Name = __value, MarketingCampaign.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", 
#nullable restore
#line 13 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "<label for=\"start-date\">Start Date</label>\r\n                    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "date");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "id", "start-date");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                   MarketingCampaign.StartDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.StartDate = __value, MarketingCampaign.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", 
#nullable restore
#line 19 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "<label for=\"end-date\">End Date</label>\r\n                    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "date");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "id", "end-date");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                   MarketingCampaign.EndDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.EndDate = __value, MarketingCampaign.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", 
#nullable restore
#line 25 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.AddMarkupContent(46, "<label for=\"end-date\">Media</label>\r\n                    ");
            __builder.OpenElement(47, "select");
            __builder.AddAttribute(48, "class", "form-select d-block w-100 p-3 py-1 border");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                                                                      MarketingCampaign.MediaId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.MediaId = __value, MarketingCampaign.MediaId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 29 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         foreach (var media in  MarketingCampaignService.Medias)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", 
#nullable restore
#line 31 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                            media.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, 
#nullable restore
#line 32 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                 media.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", 
#nullable restore
#line 38 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group");
            __builder.AddMarkupContent(59, "<label for=\"end-date\">Choose Advertiser</label>\r\n                    ");
            __builder.OpenElement(60, "select");
            __builder.AddAttribute(61, "class", "form-select d-block w-100 p-3 py-1 border");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                                                                      MarketingCampaign.AdvertiserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.AdvertiserId = __value, MarketingCampaign.AdvertiserId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 42 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         foreach (var advertiser in MarketingCampaignService.Advertisers)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", 
#nullable restore
#line 44 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                            advertiser.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, 
#nullable restore
#line 45 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                 advertiser.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", 
#nullable restore
#line 51 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         fieldLayoutClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "form-group");
            __builder.AddMarkupContent(72, "<label for=\"end-date\">Choose Publisher</label>\r\n                    ");
            __builder.OpenElement(73, "select");
            __builder.AddAttribute(74, "class", "form-select d-block w-100 p-3 py-1 border");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                                                                      MarketingCampaign.PublisherId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MarketingCampaign.PublisherId = __value, MarketingCampaign.PublisherId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 55 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                         foreach (var publisher in MarketingCampaignService.Publishers)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "value", 
#nullable restore
#line 57 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                            publisher.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, 
#nullable restore
#line 58 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                                 publisher.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 60 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                      SubmitForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "class", "btn btn-primary");
            __builder.AddContent(84, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "class", "btn btn-secondary");
            __builder.AddContent(89, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\projects\blazor\BlazorApp\Pages\AddPublisher.razor"
       

    private string fieldLayoutClass = "col-12 ";

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public MarketingCampaign EditMarketCampaign { get; set; }

    private MarketingCampaign MarketingCampaign { get; set; }


    protected override void OnInitialized()
    {
        MarketingCampaign = new MarketingCampaign()
        {
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.Add(new TimeSpan(5))
        };
    }

    void SubmitForm()
    {
        ModalInstance.CloseAsync(ModalResult.Ok(MarketingCampaign));
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
