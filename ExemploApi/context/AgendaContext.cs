using ExemploApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExemploApi.context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options) : base(options)
        {

        }
        
        public DbSet<Contato> Contatos { get; set; }
    }
}
