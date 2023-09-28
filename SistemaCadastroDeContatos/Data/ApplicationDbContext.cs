using Microsoft.EntityFrameworkCore;
using SistemaCadastroDeContatos.Models;

namespace SistemaCadastroDeContatos.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
