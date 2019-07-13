using FluentValidation;
using System;

namespace ApplicationCore.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public string CodigoBarra { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataSaida { get; set; }
        public string Volume { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCompra { get; set; }
        public int Categoria { get; set; }
        public int Fornecedor { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }

        public Produto()
        {
            this.DataCadastro= DateTime.Now;
        }
    }

    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.Nome).Length(0, 100).NotNull().WithMessage("Nome não pode estar em branco.");
            RuleFor(x => x.Categoria).NotNull().WithMessage("Informe a Categoria.");
            RuleFor(x => x.Volume).Length(0, 20).NotNull().WithMessage("Volume não pode estar em branco.");
            RuleFor(x => x.Fornecedor).NotNull().WithMessage("Informe o Fornecedor.");
        }
    }
}
