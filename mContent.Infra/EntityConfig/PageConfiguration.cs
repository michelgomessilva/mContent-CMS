namespace mContent.Infra.Data.EntityConfig
{
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    using mContent.Domain.Entities.Pages;

    public class PageConfiguration : EntityTypeConfiguration<Page>
    {
        public PageConfiguration()
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Name).IsRequired().HasMaxLength(32);

            this.Property(p => p.Published).IsRequired();

            this.HasRequired(p => p.Seo).WithOptional(p => p.Page);

            //this.HasMany<Page>(p => p.Blocks).WithMany(p => new List<Page>());
        }
    }
}