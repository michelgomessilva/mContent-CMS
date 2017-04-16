namespace mContent.Domain.Interfaces.Entities.Users
{
    using mContent.Domain.Interfaces.Entities.Base;

    public interface IUser : IEntityBase
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        string Email { get; set; }
    }
}