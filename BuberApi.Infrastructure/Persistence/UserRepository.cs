using BuberApi.Application.services.Persistence;
using BuberApi.Domain.Entities;

namespace BuberApi.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> users = new List<User>();        // static - use users for every request , not create new for every request in scoped
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return users.FirstOrDefault(x => x.Email.Equals(email));
        }
    }
}