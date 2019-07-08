using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string cnpjcpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
   }
}