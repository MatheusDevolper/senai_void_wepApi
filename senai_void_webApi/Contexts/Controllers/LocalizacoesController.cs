using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_void_webApi.Interfaces;
using senai_void_webApi.Repositories;
using senai_void_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_void_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizacoesController : ControllerBase
    {
        private ILocalizacaoRepository _localizacaoRepository { get; set; }

        public LocalizacoesController()
        {
            _localizacaoRepository = new LocalizacaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_localizacaoRepository.ListarTodas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Localizacao novaLocalizacao)
        {
            try
            {
                _localizacaoRepository.Cadastrar(novaLocalizacao);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
