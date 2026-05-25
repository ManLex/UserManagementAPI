using AutoMapper;
using UserManagementAPI.DTOs;
using UserManagementAPI.Models;
using UserManagementAPI.Repositories.Interfaces;
using UserManagementAPI.Services.Interfaces;

namespace UserManagementAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
        {
            var users = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<UserResponseDto>>(users);
        }

        public async Task<UserResponseDto?> GetUserByIdAsync(int id)
        {
            var user = await _repo.GetByIdAsync(id);
            return user == null ? null : _mapper.Map<UserResponseDto>(user);
        }

        public async Task<UserResponseDto> CreateUserAsync(UserCreateDto dto)
        {
            var user = _mapper.Map<User>(dto);
            var created = await _repo.CreateAsync(user);
            return _mapper.Map<UserResponseDto>(created);
        }

        public async Task<UserResponseDto?> UpdateUserAsync(int id, UserUpdateDto dto)
        {
            var user = _mapper.Map<User>(dto);
            user.Id = id;

            var updated = await _repo.UpdateAsync(user);
            return updated == null ? null : _mapper.Map<UserResponseDto>(updated);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<PagedResult<UserResponseDto>> GetUsersPagedAsync(int page, int pageSize)
        {
            var users = await _repo.GetPagedAsync(page, pageSize);
            var total = await _repo.GetTotalCountAsync();

            return new PagedResult<UserResponseDto>
            {
                Items = _mapper.Map<IEnumerable<UserResponseDto>>(users),
                TotalCount = total,
                Page = page,
                PageSize = pageSize
            };
        }

    }
}
