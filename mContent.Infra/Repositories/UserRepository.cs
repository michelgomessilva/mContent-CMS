namespace mContent.Infra.Data.Repositories
{
    using mContent.Domain.Entities.Users;
    using mContent.Domain.Interfaces.Repositories;

    public class UserRepository : Repositories.RepositoryBase<User>, IUserRepository
    {
         
    }
}