﻿namespace TakeAway.Catalog.Entities
{
    public class DailyDiscount
    {
        public string DailyDiscountId { get; set; }
        public string MailTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
