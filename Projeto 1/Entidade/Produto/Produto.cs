using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Entidade.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Unidades { get; set; }
        public double Preco { get; set; }
        public double Preco_venda { get; set; }

    }
}
