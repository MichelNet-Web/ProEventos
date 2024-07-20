using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {

    public IEnumerable<Evento> _evento = new Evento[ ] { 
                new Evento{
                      EventoId = 1,
                      Tema = "Angular & .Net 5",
                      Local = "Rio de Janeiro",
                      Lote = "1 Lota",
                      QtdPessoas = 250,
                      DataEvento = DateTime.Now.AddDays(2).ToString(),
                      ImageUrl = "https://img.travessa.com.br/livro/BA/1f/1f888ecb-8fb5-4953-82a3-42a0d00e8a8b.jpg"
                  },
                new Evento{
                    EventoId = 2,
                    Tema = "Javascript",
                    Local = "Sao Paulo",
                    Lote = "3 Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(5).ToString(),
                    ImageUrl = "https://img.travessa.com.br/livro/BA/1f/1f888ecb-8fb5-4953-82a3-42a0d00e8a8b.jpg"
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
    public string Post()
    {
      return "Post";
    }
    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Put {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Delete {id}";
    }

    }
}
