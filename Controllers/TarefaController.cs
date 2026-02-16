using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgendamentoTarefa.Context;
using AgendamentoTarefa.entitis;

namespace AgendamentoTarefa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly AgendaContext _context;
        public TarefaController(AgendaContext context)
        {
            _context = context;

        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

        [HttpGet("{id}")]  
        public IActionResult ObeterPorId(int id)
        {
            var TarefaSelecionada = _context.Tarefas.Find(id);

            if(TarefaSelecionada == null)
            {
                return NotFound();
            }

            return Ok(TarefaSelecionada);
        }

        [HttpGet("ObeterPorTitulo")]
        public IActionResult ObeterPorTitulo(string titulo)
        {
            var tituloSelecionado = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));
            return Ok(tituloSelecionado);
        }
        [HttpGet("ObeterTodos")]
        public IActionResult ObeterTodos()
        {
            var todos = _context.Tarefas.Select(x => x);
            return Ok(todos);
        }
        [HttpGet("ObterPordata")]
        public IActionResult ObeterPorData(DateTime data)
        {
            var TodosDessaData = _context.Tarefas
        .Where(x => x.Data.Date == data.Date)
        .ToList();
            
            return Ok(TodosDessaData);
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var TarefaBanco = _context.Tarefas.Find(id);

            if( TarefaBanco == null)
            {
                return NotFound();
            }

            TarefaBanco.Titulo = tarefa.Titulo;
            TarefaBanco.Descricao = tarefa.Descricao;
            TarefaBanco.Data = tarefa.Data;
            TarefaBanco.Estado = tarefa.Estado;


            _context.Tarefas.Update(TarefaBanco);
            _context.SaveChanges();


            return Ok(TarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var TarefaRemove = _context.Tarefas.Find(id);

            if(TarefaRemove == null)
            {
                return NotFound();
            }

            _context.Tarefas.Remove(TarefaRemove);
            _context.SaveChanges();

            return NoContent(); // não tem mais
        }


    }
}