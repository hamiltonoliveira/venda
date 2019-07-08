using System;
using FluentValidation;

namespace ApplicationCore.Entities
{
    public class Usuario :Base
    {
        public int PerfilId { get; set; }
        public string Nome { get; set; }
        public string CodigoUsuario { get; set; }
        public string Email { get; set; }
        public string CnpjCpf { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimoLog { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        {
            this.DataCadastro = DateTime.Now;
            this.DataUltimoLog = DateTime.Now;
        }
    }

  
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(x => x.Nome).Length(0, 80).NotNull().WithMessage("Nome não pode estar em branco.");
            RuleFor(x => x.CodigoUsuario).Length(0, 15).NotNull().WithMessage("Digite código Usuário");
            RuleFor(x => x.Senha).NotNull().WithMessage("Digite a senha");
            RuleFor(x => x.Email).Length(0, 40).NotNull();
            RuleFor(x => x.CnpjCpf).Length(0, 15).NotNull();
        }
    }
}



