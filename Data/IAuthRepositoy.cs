using System.Threading.Tasks;
using dotnet_rpg.models;

namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user , string password);
        Task<ServiceResponse<string>> Login(string username , string password);
        Task<bool> UserExsits(string username);
    }
}