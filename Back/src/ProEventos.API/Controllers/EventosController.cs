using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext context;
        public EventosController(ProEventosContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Evento> Get()
        {
            return context.Eventos.ToList();
        }

        [HttpPost]
        public string Post()
        {
            return "retorna post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"retorna put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"retorna Delete {id}";
        }
    }
}