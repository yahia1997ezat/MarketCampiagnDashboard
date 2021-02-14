using System;

namespace BlazorApp.Data
{
    public class Publisher
    {
        public Guid Id;
        public string Name;
        public Channel[] Channels;
        public MarketingCampaign[] MarketingCampaigns;
    }
}