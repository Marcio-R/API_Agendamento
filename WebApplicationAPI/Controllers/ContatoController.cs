using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Data;
using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly WebApplicationAPIContext _context;

        public ContatoController(WebApplicationAPIContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contato.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, Contato contato)
        {
            if(id != contato.Id)
            {
                return BadRequest();
            }
            _context.Update(contato);
            _context.SaveChangesAsync();
            return Ok(contato);
        }
    }
}
