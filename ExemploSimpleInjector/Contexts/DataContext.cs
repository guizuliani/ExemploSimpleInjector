using ExemploSimpleInjector.Models;
using System.Data.Entity;

namespace ExemploSimpleInjector.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext()
            : base("DefaultConnectionString")
        {

        }

        public IDbSet<Cliente> Clientes { get; set; }

    }
}