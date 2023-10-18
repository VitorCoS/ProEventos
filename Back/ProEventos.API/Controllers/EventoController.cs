using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{


    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento{
           EventoId = 1,
           Tema = "Angular 11 e .NET 6",
           Local = "Belo Horizonte",
           Lote = "1º Lote",
           QtdPessoas = 250,
           DataEvento = DateTime.Now.AddDays(2).ToString(),
           ImagemURL = "foto.png"
       },
       new Evento{

           EventoId = 2,
           Tema = "Angular 11 e suas novidades",
           Local = "São Paulo",
           Lote = "2º Lote",
           QtdPessoas = 350,
           DataEvento = DateTime.Now.AddDays(3).ToString(),
           ImagemURL = "foto.png"
       }
    };



    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(e=>e.EventoId == id);
    }



}
