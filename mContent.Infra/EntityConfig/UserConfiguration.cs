namespace mContent.Infra.Data.EntityConfig
{
    using System.Data.Entity.ModelConfiguration;
    using System.Net;

    using mContent.Domain.Entities.Users;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {

        public UserConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.FirstName).IsRequired().HasMaxLength(64);

            this.Property(c => c.LastName).IsRequired().HasMaxLength(128);

            this.Property(c => c.Email).IsRequired().HasMaxLength(256);

            this.Property(c => c.UserName).IsRequired().HasMaxLength(32);

            this.Property(c => c.Password).IsRequired().HasMaxLength(32);
        }
         
    }
}