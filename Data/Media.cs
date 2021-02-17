using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Media
    {
        public long Id;
        public string Name;
        public DateTime CreatedAt;
        public string MediaFile;
        public IList<Channel> Channels;
        public Advertiser Advertiser;
    }
}