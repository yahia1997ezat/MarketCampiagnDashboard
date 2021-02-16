using System;

namespace BlazorApp.Data
{
    public class Media
    {
        public long Id;
        public string Name;
        public DateTime CreatedAt;
        public string MediaFile;
        public Channel[] Channels;
        public long[] ChannelIds;
        public Advertiser Advertiser;
        public long AdvertiserId;
    }
}