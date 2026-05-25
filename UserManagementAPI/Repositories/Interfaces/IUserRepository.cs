using UserManagementAPI.Models;

namespace UserManagementAPI.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User> CreateAsync(User user);
        Task<User?> UpdateAsync(User user);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<User>> GetPagedAsync(int page, int pageSize);
        Task<int> GetTotalCountAsync();

    }
}
