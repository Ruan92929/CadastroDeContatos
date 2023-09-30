﻿using SistemaCadastroDeContatos.Data;
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

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB == null) throw new System.Exception("Houve um erro ao apagar o contato");
            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();
            return true;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            contatoDB.Name = contato.Name;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;

        }

        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }
    }
}
