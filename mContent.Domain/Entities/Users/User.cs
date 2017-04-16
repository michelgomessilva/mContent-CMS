namespace mContent.Domain.Entities.Users
{
    using System;

    using mContent.Domain.Interfaces.Entities.Users;

    public class User : IUser
    {
        public User()
        {
            this.Activated = true;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Activated { get; set; }
    }
}