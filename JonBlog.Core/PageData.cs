using System;

namespace JonBlog.Core
{
    public class PageData
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Html { get; set; }
        public string Css { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
