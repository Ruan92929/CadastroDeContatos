using Microsoft.AspNetCore.Mvc;
using SistemaCadastroDeContatos.Models;
using SistemaCadastroDeContatos.Repository;

namespace SistemaCadastroDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContatoController(IContactRepository contactRepository) 
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contato = _contactRepository.BuscarTodos();
            return View(contato);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            //Busca a informação e devolve o dado pra View ( Forma de exibir o ID do item clicado).
            ContatoModel contato = _contactRepository.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            //Busca a informação e devolve o dado pra View ( Forma de exibir o ID do item clicado).
            ContatoModel contato = _contactRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _contactRepository.Apagar(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contactRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contactRepository.Atualizar(contato);
            return RedirectToAction("Index");
        }

    }
}
