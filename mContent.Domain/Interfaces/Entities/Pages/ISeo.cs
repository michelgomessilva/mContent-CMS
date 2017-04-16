namespace mContent.Domain.Interfaces.Entities.Pages
{
    public interface ISeo : Base.IEntityBase
    {
        string Title { get; set; }

        string MetaDescription { get; set; }

        int PageId { get; set; }
    }
}