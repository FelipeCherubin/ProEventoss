using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }


        [HttpGet]
        public Evento Get()
        {
            return new Evento(){
                EventoId = 1,
                Tema = "angular",
                Local = "taubate",
                Lote = "1",
                QtdPessoas = 24,
                DataEvento = DateTime.Now.AddDays(2).ToString()
            };
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