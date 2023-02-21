using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Entidade.Cliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public DateTime Data_Registro { get; set; }

        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
