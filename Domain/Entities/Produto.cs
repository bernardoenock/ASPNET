using System;
using System.ComponentModel.DataAnnotations;

namespace TesteASPNET.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataDelecao { get; set; }
    }
}
