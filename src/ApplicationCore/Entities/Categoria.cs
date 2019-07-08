using System;

namespace ApplicationCore.Entities
{
    public class Categoria : Base
    {
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }

        public Categoria()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
