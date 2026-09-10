using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdutos
{
    public class ProdutoFisico : Produto
    {
        public double PesoKg { get; set; }

        // Sobrecarga de construtores chamando o construtor base
        public ProdutoFisico(string nome, decimal precoBase, double pesoKg) : base (nome, precoBase)
        {
            PesoKg = pesoKg;
        }

        // Polimorfismo: sobrescrevendo o metodo abastrato da classe base
        // o produto físico possui um acrescimo de frete baseado no peso
        public override decimal CalcularPrecoFinal()
        {
            decimal frete = (decimal)(PesoKg * 2.50);
            return PrecoBase + frete;
        }
    }
}
