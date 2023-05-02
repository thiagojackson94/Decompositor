using System;
using Decompositor.Servicos;

namespace Decompositor
{
    class Program
    {
        static void Main(string[] args)
        {
            DecompositorMaster decompositor = new DecompositorMaster();

            Console.WriteLine("Bem vindo!");

            var sair = "0";
            while (!sair.ToLower().Equals("n"))
            {

                Console.WriteLine("Digite um número a decompor:");
                var resposta = decompositor.DecomporNumero(Console.ReadLine());
                Console.WriteLine(resposta);
                //Console.ReadKey();

                Console.WriteLine("Deseja continuar? (S - continuar N - para sair)");
                sair = Console.ReadLine();
            }

        }
    }
}
