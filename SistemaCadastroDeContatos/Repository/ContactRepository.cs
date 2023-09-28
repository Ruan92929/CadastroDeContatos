using SistemaCadastroDeContatos.Data;
using SistemaCadastroDeContatos.Models;

namespace SistemaCadastroDeContatos.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }
    }
}
