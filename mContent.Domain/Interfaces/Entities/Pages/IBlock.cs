namespace mContent.Domain.Interfaces.Entities.Pages
{
    using System.Collections;
    using System.Collections.Generic;

    public interface IBlock : Base.IEntityBase
    {
        string Name { get; set; } 
    }
}