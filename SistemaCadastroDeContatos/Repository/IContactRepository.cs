using SistemaCadastroDeContatos.Models;

namespace SistemaCadastroDeContatos.Repository
{
    public interface IContactRepository
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);


    }
}
