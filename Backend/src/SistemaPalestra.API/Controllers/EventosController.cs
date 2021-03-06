using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaPalestra.Persistence;
using SistemaPalestra.Domain;



namespace SistemaPalestra.API.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
       
        private readonly SistemaPalestraContext _context;
        public EventosController(SistemaPalestraContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);

        }
        [HttpPost]
        public string Post()
        {
            return "POST VALUE";
        }
    }
}
