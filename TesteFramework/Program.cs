using System;
using TesteFramework.Servicos;

namespace TesteFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Decompositor decompositor = new Decompositor();

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
