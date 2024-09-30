using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public ActionResult Apresentar(string nome)
        {
            var mensagem = $"Ola {nome} seja bem vindo";
            return Ok(new {mensagem});
        }
    }
}