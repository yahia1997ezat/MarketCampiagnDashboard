using System;

namespace BlazorApp.Data
{
    public class MarketingCampaign
    {
        public Guid Id;
        public string Name;
        public DateTime StartDate;
        public DateTime EndTime;
        public Media Media;
    }
}