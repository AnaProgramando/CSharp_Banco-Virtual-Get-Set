using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco Virtual - Get e Set: \r\n");

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Beltrano";
            cliente.CPF = "123.456.789-10";
            cliente.Profissao = "Professor";

            conta.Titular = cliente;

            Console.WriteLine("O nome do titular é " + conta.Titular.Nome + ".");
            Console.WriteLine("O CPF do titular é " + conta.Titular.CPF + ".");
            Console.WriteLine("A profissão do titular é " + conta.Titular.Profissao + ".");

            // Conforme a regra criada na classe ContaCorrente, o saldo não pode ser menor que zero, por isso ele assume o saldo definido como padrão, ou seja, o 100.
            conta.Saldo = -200;
            Console.WriteLine("O saldo da conta é R$ " + conta.Saldo + ".");

            Console.ReadLine();
        }
    }
}
