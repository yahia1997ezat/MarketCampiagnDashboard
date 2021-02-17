using System;

namespace BlazorApp.Data
{
    public class Publisher
    {
        public long Id;
        public string Name;
        public string Email;
        public Channel[] Channels;
        public long[] ChannelsIds;
        public MarketingCampaign[] MarketingCampaigns;
        public long[] MarketingCampaignIds;
    }
}