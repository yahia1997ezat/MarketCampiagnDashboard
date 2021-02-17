using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class MarketingCampaignService
    {
        public static IList<Channel> Channels = new List<Channel>()
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

        public static IList<Advertiser> Advertisers = new List<Advertiser>()
        {
            new Advertiser()
            {
                Id = 1,
                Name = "Apple",
                Email = "marketing@apple.com"
            },
            new Advertiser()
            {
                Id = 2,
                Name = "Samsung",
                Email = "marketing@samsung.com"
            },
        };

        public static IList<Publisher> Publishers = new List<Publisher>()
        {
            new Publisher()
            {
                Id = 1,
                Name = "All3Media",
                Email = "marketing@all3media.com",
                Channels = new Channel[]
                {
                    Channels[1]
                },
                MarketingCampaigns = Array.Empty<MarketingCampaign>(),
            },
            new Publisher()
            {
                Id = 2,
                Name = "Shine Group",
                Email = "info@shinegroup.com",
                Channels = new Channel[]
                {
                    Channels[0]
                },
                MarketingCampaigns = Array.Empty<MarketingCampaign>(),
            },
        };

        public static IList<Media> Medias = new List<Media>()
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
            },
        };

        public static IList<MarketingCampaign> MarketingCampaigns = new List<MarketingCampaign>()
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
            new MarketingCampaign()
            {
                Media = Medias[1],
                MediaId = 2,
                Budget = 5000,
                Name = "Cambridge market campaign",
                Advertiser = Advertisers[0],
                AdvertiserId = 1,
                Id = 2,
                EndDate = new DateTime(2021, 4, 1),
                StartDate = new DateTime(2021, 2, 1)
            },
            new MarketingCampaign()
            {
                Media = Medias[0],
                MediaId = 1,
                Budget = 5500,
                Name = "Bristol market campaign",
                Advertiser = Advertisers[1],
                AdvertiserId = 1,
                Id = 3,
                EndDate = new DateTime(2021, 4, 1),
                StartDate = new DateTime(2021, 2, 1)
            },
            new MarketingCampaign()
            {
                Media = Medias[1],
                MediaId = 2,
                Budget = 30000,
                Name = "Birmingham market campaign",
                Advertiser = Advertisers[1],
                AdvertiserId = 2,
                Id = 4,
                EndDate = new DateTime(2021, 4, 1),
                StartDate = new DateTime(2021, 2, 1)
            }
        };

        public Task<IList<MarketingCampaign>> GetMarketCampaignAsync()
        {
            var rng = new Random();
            return Task.FromResult(MarketingCampaigns);
        }

        public Task<IList<Media>> GetMediasAsync()
        {
            return Task.FromResult(Medias);
        }

        public Task<IList<Publisher>> GetPublishersAsync()
        {
            return Task.FromResult(Publishers);
        }

        public async Task<IList<Advertiser>> GetAdvertisersAsync()
        {
            return await Task.FromResult(Advertisers);
        }

        public void Add(Data.MarketingCampaign marketingCampaign)
        {
            ((IList) MarketingCampaigns).Add(marketingCampaign);
        }
    }
}