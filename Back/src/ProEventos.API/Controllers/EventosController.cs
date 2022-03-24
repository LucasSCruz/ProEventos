using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

        private readonly ILogger<EventosController> _logger;

        public EventosController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] {
                new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .net 5",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString()

                }
            };
        }
        private readonly DataContext context;

        public EventosController(DataContext context)
        {
            this.context = context;

        }
    }
}
