using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<object> FindByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email)) //verifica se a entrada é válida
            {
                return await _repository.FindByLogin(user.Email); //procura o user no db
            }
            else
            {
                return null;
            }
        }
    }
}
