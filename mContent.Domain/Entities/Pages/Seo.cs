namespace mContent.Domain.Entities.Pages
{
    using System;

    using mContent.Domain.Interfaces.Entities.Pages;

    public class Seo : Interfaces.Entities.Pages.ISeo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public int PageId { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Page Page { get; set; }
    }
}