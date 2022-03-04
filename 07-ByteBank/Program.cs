using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar o total de contas criadas
            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

            // Criando uma conta genérica e mostrando o total de contas criadas
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

            // Mostrando a agência e o número da conta genérica
            Console.WriteLine("Agência da Conta: " + conta.Agencia);
            Console.WriteLine("Número da Conta: " + conta.Numero);

            // Criando a conta da Gabriela e mostrando o total de contas criadas
            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
