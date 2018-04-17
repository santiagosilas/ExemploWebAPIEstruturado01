using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ExemploLibrary.Entidades;
using ExemploLibrary.Repositorios;

namespace ExemploWebApi.Controllers
{
  //[Route("api/Contatos")]
  [Route("api/[controller]")]
  public class ContatosController : Controller
  {
      private readonly IContatoRepositorio _repositorio;

      public ContatosController(IContatoRepositorio repositorio)
      {
          _repositorio = repositorio;
          _repositorio.Add(new Contato { Nome = "Arthur Dent", Telefone = "(85) 8765-4321" });
      }

      [HttpGet]
      public IEnumerable<Contato> GetAll()
      {
          return _repositorio.GetAll();
      }

      [HttpGet("{id}", Name = "GetContato")]
      public IActionResult GetById(long id)
      {
          var item = _repositorio.Find(id);
          if (item == null)
          {
              return NotFound();
          }
          return new ObjectResult(item);
      }

        [HttpPost]
    public IActionResult Create([FromBody] Contato contato)
    {
      if (contato == null)
      {
        return BadRequest();
      }

      _repositorio.Add(contato);

      return CreatedAtRoute("GetContato", new { id = contato.Id }, contato);
    }

    [HttpPut("{id}")]
    public IActionResult Update(long id, [FromBody] Contato item)
    {
      if (item == null || item.Id != id)
      {
        return BadRequest();
      }

      var contato = _repositorio.Find(id);
      if (contato == null)
      {
        return NotFound();
      }

      contato.Nome = item.Nome;
      contato.Telefone = item.Telefone;

      _repositorio.Update(contato);
      return new NoContentResult();
    }

      [HttpDelete("{id}")]
      public IActionResult Delete(long id)
      {
          var contato = _repositorio.Find(id);
          if (contato == null)
          {
              return NotFound();
          }

          _repositorio.Remove(id);
          return new NoContentResult();
      }



    }
}