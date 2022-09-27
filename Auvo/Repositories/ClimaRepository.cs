using API.Repositories;
using Auvo.Models;
using Microsoft.EntityFrameworkCore;

namespace Auvo.Repositories
{
    public class ClimaRepository : IClimaRepository
    {
        private AppDbContext _dataContext;

        public ClimaRepository(AppDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Cidade>> GetAllCidades()
        {
            var cidades = await _dataContext.Cidades
                .AsNoTracking()
                .ToListAsync();

            return cidades;
        }

        public async Task<IEnumerable<PrevisaoClima>> GetPrevisao7Dias(int cidadeId)
        {
            var previsoes = await _dataContext.PrevisaoClimas
                .Where(Clima => Clima.CidadeId == cidadeId &&
                                Clima.DataPrevisao > DateTime.UtcNow &&
                                Clima.DataPrevisao < DateTime.UtcNow.AddDays(7))
                .Include(Clima => Clima.Cidade)
                .AsNoTracking()
                .ToListAsync();

            return previsoes;
        }

        public async Task<IEnumerable<PrevisaoClima>> GetPrevisaoDataAtual()
        {
            var previsoes = await _dataContext.PrevisaoClimas
                .Where(Clima => Clima.DataPrevisao.Month == DateTime.Today.Month && 
                                Clima.DataPrevisao.Year == DateTime.Today.Year &&
                                Clima.DataPrevisao.Day == DateTime.Today.Day)
                .Include(Clima => Clima.Cidade)
                .AsNoTracking()
                .ToListAsync();

            return previsoes;
        }
    }
}


