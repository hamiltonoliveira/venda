using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities
{
   public class Perfil :Base 
    {
        public string Nome { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public Perfil()
        {
            this.DataCadastro = DateTime.Now;
            this.Ativo = true;
        }
    }
}
