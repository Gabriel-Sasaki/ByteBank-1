using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando conta do Bruno e adicionando o nome do titular
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            // Escrevendo o saldo da conta do Bruno na tela
            Console.WriteLine(contaDoBruno.saldo);

            // Tentando sacar um valor da conta do Bruno
            bool resultadoSaque = contaDoBruno.Sacar(500);

            // Escrevendo o resultado do saque e o saldo da conta do Bruno
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            // Depositando um valor e mostrando o saldo da conta do Bruno
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            // Criando conta da Gabriela e adicionando o nome do titular
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            // Escrevendo os saldos da conta do Bruno e da Gabriel antes da transferência
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            // Transferindo um valor da conta do Bruno para a conta da Gabriela
            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            // Escrevendo os saldos da conta do Bruno e da Gabriel depois da transferência
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            // Escrevendo se a transferência foi realizada com sucesso ou não
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            // Transferindo um valor da cotna da Gabriela para a conta do Bruno
            contaDaGabriela.Transferir(100, contaDoBruno);

            // Escrevendo os saldos da conta do Bruno e da Gabriel depois da transferência
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
