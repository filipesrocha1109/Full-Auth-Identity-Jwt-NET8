using FullAuthNET8.Core.DTOs;
using static FullAuthNET8.Application.Services.ServiceResponses;

namespace FullAuthNET8.Core.Intefaces
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}
