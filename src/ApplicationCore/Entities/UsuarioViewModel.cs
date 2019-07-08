using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
   public class UsuarioViewModel :Base
    {
        public string Nome { get; set; }
        public string CodigoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Perfilid { get; set; }
        public bool Ativo { get; set; }
   }
}
