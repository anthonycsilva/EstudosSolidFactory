using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface ContaEmpresaFactoryMethod
    {
        ContaEmpresa CriaContaEmpresa(string nome, decimal saldo, string cnpj);
    }

    public class FabricaContaEmpresa : ContaEmpresaFactoryMethod
    {
        public ContaEmpresa CriaContaEmpresa(string nome, decimal saldo, string cnpj)
        {
            return new ContaEmpresa(nome, saldo, cnpj);
        }
    }
}
