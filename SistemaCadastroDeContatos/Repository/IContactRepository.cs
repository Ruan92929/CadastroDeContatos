using SistemaCadastroDeContatos.Models;

namespace SistemaCadastroDeContatos.Repository
{
    public interface IContactRepository
    {
        ContatoModel Adicionar(ContatoModel contato);

    }
}
