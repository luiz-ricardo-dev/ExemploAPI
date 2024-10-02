using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAPI.Context;
using ExemploAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        //Conexão com o banco
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        //Criação dos Endpoints
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}