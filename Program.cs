using System;
using EstacionamentoDIO.Models;

namespace EstacionamentoDIO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

            Console.Write("Digite o preço inicial: ");
            decimal precoInicial = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o preço por hora: ");
            decimal precoPorHora = decimal.Parse(Console.ReadLine());

            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (exibirMenu)
                {
                    Console.WriteLine("\nPressione uma tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("O programa se encerrou. Até a próxima!");
        }
    }
}
