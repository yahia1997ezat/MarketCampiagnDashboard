using System;

namespace BlazorApp.Data
{
    public class Publisher
    {
        public long Id;
        public string Name;
        public Channel[] Channels;
        public long[] ChannelsIds;
        public MarketingCampaign[] MarketingCampaigns;
        public long[] MarketingCampaignIds;
    }
}