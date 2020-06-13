using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Pedido
    {
        //PK
        public int Id { get; set; }
        
        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }
        public string TransactionId { get; set; }

        //Frete
        public string FreteEmpresa { get; set; } //ECT - Correios
        public string FreteCodRastreamento { get; set; }

        public string FormaPagamento { get; set; } //Boleto-Cartão Credito
        public decimal ValorTotal { get; set; }
        public string DadosTransaction { get; set; } //Transaction - JSON
        public string DadosProdutos { get; set; } //ProdutoItem - JSON

        public DateTime DataRegistro { get; set; }
        public string Situacao { get; set; } // U

        //URL - Com site da Receita - Nota Fiscal
        public string NFE { get; set; }

        [ForeignKey("PedidoId")]
        public virtual ICollection<PedidoSituacao> PedidoSituacaos { get; set; }

        //TODO - Pedido -> Historico de situação

    }
}
