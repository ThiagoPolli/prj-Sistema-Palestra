using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaPalestra.API.Models;

namespace SistemaPalestra.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                    Tema = "Angular",
                    Local= "MT",
                    Lote = "1 lote",
                    QtdPessoas = 100,
                    DateEnvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUTL= "kasksdksednskndksnkdns"
            },
             new Evento(){
                EventoId = 2,
                    Tema = "Angular-2",
                    Local= "MG",
                    Lote = "2 lote",
                    QtdPessoas = 30,
                    DateEnvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUTL= "kasksdksednskndksnkdns"
            }


        };
    
        public EventoController()
        {           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
           
        }

           [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
           
        }
        [HttpPost]
        public string Post(){
            return "POST VALUE";
        }
    }
}
