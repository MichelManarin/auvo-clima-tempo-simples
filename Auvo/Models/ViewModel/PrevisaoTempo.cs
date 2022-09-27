namespace Auvo.Models.ViewModel
{
    public class ConsultaPrevisao
    {
        public IEnumerable<PrevisaoClima>? previsaoClimaHoje;

        public IEnumerable<PrevisaoClima>? previsaoFutura;

        public IEnumerable<Cidade>? cidades;

        public int? cidadeSelecionada;

        public ConsultaPrevisao(IEnumerable<PrevisaoClima>? previsaoClimaHoje, IEnumerable<PrevisaoClima>? previsaoFutura, IEnumerable<Cidade>? cidades, int? cidadeSelecionada)
        {
            this.previsaoClimaHoje = previsaoClimaHoje;
            this.previsaoFutura = previsaoFutura;
            this.cidades = cidades;
            this.cidadeSelecionada = cidadeSelecionada;
        }
    }
}
