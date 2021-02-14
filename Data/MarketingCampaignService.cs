using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class MarketingCampaignService
    {
        private static readonly Channel[] Channels = new[]
        {
            new Channel()
            {
                Id = 1,
                Name = "TV"
            },
            new Channel()
            {
                Id = 2,
                Name = "Social Media"
            },
            new Channel()
            {
                Id = 3,
                Name = "Radio"
            },
        };

        private static readonly Advertiser[] Advertisers = new[]
        {
            new Advertiser()
            {
                Id = 1,
                Name = "Yahia"
            },
            new Advertiser()
            {
                Id = 2,
                Name = "Andrew"
            },
        };
        private static readonly Publisher[] Publishers = new[]
        {
            new Publisher()
            {
                Id = 1,
                Name = "Yahia"
            },
            new Publisher()
            {
                Id = 2,
                Name = "Andrew"
            },
        };
        private static readonly Media[] Medias = new[]
        {
            new Media()
            {
                Id = 1,
                Name = "Shampoo X&Y",
                MediaFile = "https://www.videvo.net/video/pouring-water-into-glass-1/3540/",
                Channels = new[]
                {
                    Channels[0],
                    Channels[1]
                },
                ChannelIds = new long[] {1, 2}
            },
            new Media()
            {
                Id = 2,
                Name = "Coffee",
                MediaFile = "https://www.videvo.net/video/pouring-water-into-glass-1/3540/",
                Channels = new[]
                {
                    Channels[1]
                },
                ChannelIds = new long[] {1}
            },
        };

        private List<MarketingCampaign> _items = new List<MarketingCampaign>()
        {
            new MarketingCampaign()
            {
                Media = Medias[0],
                MediaId = 1,
                Budget = 10000,
                Name = "London market campaign",
                Advertiser = Advertisers[0],
                AdvertiserId = 1,
                Id = 1,
                EndDate = new DateTime(2021, 4, 1),
                StartDate = new DateTime(2021, 2, 1),
                PublisherId = 1,
                Publisher = Publishers[0]
            },
            // new MarketingCampaign()
            // {
            //     Media = Medias[1],
            //     MediaId = 2,
            //     Budget = 5000,
            //     Name = "Cambridge market campaign",
            //     Advertiser = Advertisers[0],
            //     AdvertiserId = 1,
            //     Id = 2,
            //     EndDate = new DateTime(2021, 4, 1),
            //     StartDate = new DateTime(2021, 2, 1)
            // },
            // new MarketingCampaign()
            // {
            //     Media = Medias[0],
            //     MediaId = 1,
            //     Budget = 5500,
            //     Name = "Bristol market campaign",
            //     Advertiser = Advertisers[1],
            //     AdvertiserId = 1,
            //     Id = 3,
            //     EndDate = new DateTime(2021, 4, 1),
            //     StartDate = new DateTime(2021, 2, 1)
            // },
            // new MarketingCampaign()
            // {
            //     Media = Medias[1],
            //     MediaId = 2,
            //     Budget = 30000,
            //     Name = "Birmingham market campaign",
            //     Advertiser = Advertisers[1],
            //     AdvertiserId = 2,
            //     Id = 4,
            //     EndDate = new DateTime(2021, 4, 1),
            //     StartDate = new DateTime(2021, 2, 1)
            // }
        };

        public Task<MarketingCampaign[]> GetMarketCampaignAsync()
        {
            var rng = new Random();
            return Task.FromResult(_items.ToArray());
        }

        public Task<Media[]> GetMediasAsync()
        {
            return Task.FromResult(Medias);
        }

        public Task<Publisher[]> GetPublishersAsync()
        {
            return Task.FromResult(Publishers);
        }
        public async Task<Advertiser[]> GetAdvertisersAsync()
        {
            return await Task.FromResult(Advertisers);
        }
        public void Add(Data.MarketingCampaign marketingCampaign)
        {
            ((IList) _items).Add(marketingCampaign);
        }

        public void Edit(Pages.MarketingCampaign marketingCampaign)
        {
        }

     
    }
}