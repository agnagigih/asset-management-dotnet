﻿namespace Asset_Management.ViewModel
{
    public class RequestAssetResponse
    {
        public long Id { get; set; }
        public long PicId { get; set; }
        public string FullName { get; set; }
        public string Specification { get; set; }
        public DateTime RequestDate { get; set; }

    }
}
