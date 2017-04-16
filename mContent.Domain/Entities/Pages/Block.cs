namespace mContent.Domain.Entities.Pages
{
    using System;
    using System.Collections.Generic;

    using mContent.Domain.Interfaces.Entities.Pages;

    public class Block : Interfaces.Entities.Pages.IBlock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public IEnumerable<Page> Pages { get; set; }
    }
}