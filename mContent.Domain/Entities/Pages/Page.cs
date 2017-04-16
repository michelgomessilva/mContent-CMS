namespace mContent.Domain.Entities.Pages
{
    using System;
    using System.Collections;

    using Interfaces.Entities.Pages;
    using System.Collections.Generic;
    using System.Runtime.Serialization.Formatters;

    public class Page : IPage
    {
        public Page()
        {
            this.Published = false;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int SeoId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Published { get; set; }

        public virtual Seo Seo { get; set; }

        //public virtual IEnumerable<Block> Blocks { get; set; }
    }
}