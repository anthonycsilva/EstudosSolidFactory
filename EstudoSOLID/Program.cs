using System;
using BLL;
namespace EstudoSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaContaCorrente fabrica = new FabricaContaCorrente();
            var conta = fabrica.CriaContaCorrente("Anthony", "111.111.111-11", 22, 1200);
            Console.WriteLine(conta.Nome);




            FabricaContaEmpresa fabricaContaEmpresa = new FabricaContaEmpresa();
            var contaEmpresa = fabricaContaEmpresa.CriaContaEmpresa("Perola Doces", 10000000, "97390-2");
            Console.WriteLine(contaEmpresa.Saldo);
        }
    }
}
