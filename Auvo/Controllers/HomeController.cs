using API.Repositories;
using Auvo.Models;
using Auvo.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;

namespace Auvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClimaRepository _climaRepository;

        public HomeController(IClimaRepository climaRepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _climaRepository = climaRepository;
        }

        public async Task<IActionResult> IndexAsync(int? cidadeSelecionada)
        {
            var previsaoDataAtual = await _climaRepository.GetPrevisaoDataAtual();

            var cidades = await _climaRepository.GetAllCidades();

            int? cidadeId = cidadeSelecionada ?? cidades?.FirstOrDefault()?.Id;

            var previsaoFutura = cidadeId.HasValue ? await _climaRepository.GetPrevisao7Dias(cidadeId.Value) : null;

            var selectList = new SelectList(cidades, "Id", "Nome", cidadeId);

            var viewModel = new ConsultaPrevisao(previsaoDataAtual, previsaoFutura, cidades, cidadeId);

            ViewBag.CidadeNome = cidades?.Where(cid => cid.Id == cidadeId).FirstOrDefault()?.Nome;

            ViewBag.ListaCidades = selectList;

            return View(viewModel);
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}