namespace mContent.Domain.Interfaces.Entities.Pages
{
    using System.Collections;
    using System.Collections.Generic;

    public interface IPage : Base.IEntityBase
    {
        string Name { get; set; }

        bool Published { get; set; }

        int SeoId { get; set; }
    }
}