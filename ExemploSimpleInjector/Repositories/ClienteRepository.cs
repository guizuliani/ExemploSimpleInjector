using ExemploSimpleInjector.Contexts;
using ExemploSimpleInjector.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExemploSimpleInjector.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _context.Clientes.ToList();
        }

        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

    }
}