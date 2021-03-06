using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_OfertasWebApi.Domains
{
    public partial class Produto
    {
        public Produto()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdProduto { get; set; }
        public int? IdPjuridica { get; set; }
        public int? IdPfisica { get; set; }
        public int? IdTipoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string LinkProduto { get; set; }
        public string ImagemProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public virtual Pfisica IdPfisicaNavigation { get; set; }
        public virtual Pjuridica IdPjuridicaNavigation { get; set; }
        public virtual TipoProduto IdTipoProdutoNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
