using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContaCorrente : IConta
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public decimal Saldo { get; set; }

        public ContaCorrente(string nome, string cpf, int idade, decimal saldo)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
            Saldo = saldo;
        }
    }
}
