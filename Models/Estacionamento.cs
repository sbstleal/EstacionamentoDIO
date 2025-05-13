using System;
using System.Collections.Generic;

namespace EstacionamentoDIO.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do ve�culo para estacionar: ");
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Ve�culo adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inv�lida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do ve�culo para remover: ");
            string placa = Console.ReadLine()?.ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.Write("Digite a quantidade de horas que o ve�culo permaneceu estacionado: ");
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O ve�culo {placa} foi removido e o pre�o total foi de: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("Horas inv�lidas.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse ve�culo n�o est� estacionado aqui. Verifique a placa digitada.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Ve�culos estacionados:");
                foreach (string v in veiculos)
                {
                    Console.WriteLine($"- {v}");
                }
            }
            else
            {
                Console.WriteLine("N�o h� ve�culos estacionados.");
            }
        }
    }
}
