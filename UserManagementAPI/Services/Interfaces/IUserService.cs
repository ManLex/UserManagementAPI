using UserManagementAPI.DTOs;

namespace UserManagementAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDto>> GetAllUsersAsync();
        Task<UserResponseDto?> GetUserByIdAsync(int id);
        Task<UserResponseDto> CreateUserAsync(UserCreateDto dto);
        Task<UserResponseDto?> UpdateUserAsync(int id, UserUpdateDto dto);
        Task<bool> DeleteUserAsync(int id);
        Task<PagedResult<UserResponseDto>> GetUsersPagedAsync(int page, int pageSize);
    }
}
