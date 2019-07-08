using System;

namespace ApplicationCore.Entities
{
    public class Pedido : Base
    {
        public DateTime? DataPedido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string Numero { get; set; }
        public int? ProdutoId { get; set; }
        public int? VendedorId { get; set; }
        public int? ClienteId { get; set; }
        public int? Quantidade { get; set; }
        public string Observacao { get; set; }

        public Pedido()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}

