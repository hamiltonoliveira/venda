using System;

namespace ApplicationCore.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string cnpjcpf { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool? Ativo { get; set; }

        public Cliente()
        {
            this.Ativo = true;
            this.DataCadastro = DateTime.Now;
        }
   }

}