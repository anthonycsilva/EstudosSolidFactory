using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ContaCorrenteFactoryMethod
    {
        ContaCorrente CriaContaCorrente(string nome, string cpf, int idade, decimal saldo);
    }

    public class FabricaContaCorrente : ContaCorrenteFactoryMethod
    {
        public ContaCorrente CriaContaCorrente(string nome, string cpf, int idade, decimal saldo)
        {
            return new ContaCorrente(nome, cpf, idade, saldo);
        }
    }

}
