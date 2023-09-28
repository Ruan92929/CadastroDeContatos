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
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contactRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
