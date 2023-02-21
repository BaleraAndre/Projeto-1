using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Entidade.Funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public double Salario { get; set; }
        public DateTime Data_Registro { get; set; }
    }
}
