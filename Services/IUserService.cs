using BackUsernet6.Dtos;

namespace BackUsernet6.Services
{
    public interface IUserService
    {
         Task<ServiceResponse<List<GetUserDto>>> GetAllUsers();
    }
}