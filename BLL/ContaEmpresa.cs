using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ContaEmpresa : IConta
    {
        public string Nome { get; set; }
        public decimal Saldo { get; set; }
        public string Cnpj { get; set; }

        public ContaEmpresa(string nome, decimal saldo, string cnpj)
        {
            Nome = nome;
            Saldo = saldo;
            Cnpj = cnpj;
        }
    }
}
