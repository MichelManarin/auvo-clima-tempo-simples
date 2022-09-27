using Auvo.Models;

namespace API.Repositories
{
    public interface IClimaRepository
    {
        Task<IEnumerable<PrevisaoClima>> GetPrevisaoDataAtual();
        Task<IEnumerable<PrevisaoClima>> GetPrevisao7Dias(int cidadeId);
        Task<IEnumerable<Cidade>> GetAllCidades();

    }
}