using ExemploSimpleInjector.Models;
using System.Collections.Generic;

namespace ExemploSimpleInjector.Repositories
{
    public interface IClienteRepository
    {

        IEnumerable<Cliente> ObterTodos();
        void Adicionar(Cliente cliente);

    }
}
