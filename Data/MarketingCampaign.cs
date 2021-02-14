using System;

namespace BlazorApp.Data
{
    public class MarketingCampaign
    {
        public long Id;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public long MediaId;
        public Media Media;
        public float Budget;
        public Advertiser Advertiser;
        public long AdvertiserId;
        public Publisher Publisher;
        public long PublisherId;
    }
}