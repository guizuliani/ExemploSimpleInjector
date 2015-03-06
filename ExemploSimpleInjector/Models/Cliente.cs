using System;

namespace ExemploSimpleInjector.Models
{
    public class Cliente
    {

        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }
}