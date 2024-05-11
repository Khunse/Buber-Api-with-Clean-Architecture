using BuberApi.Domain.Entities;

namespace BuberApi.Application.services.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void AddUser(User user);
    }
}