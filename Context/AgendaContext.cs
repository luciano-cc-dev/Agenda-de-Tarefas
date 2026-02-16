using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendamentoTarefa.entitis;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoTarefa.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas {get; set;}
    }
}