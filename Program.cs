using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PTI_POO___Hannah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) ao cálculo de diárias de veículos!");
            string r = ".";
            while (r != "sair")
            {
                Carro c = new Carro();

                Moto m = new Moto();

                Console.WriteLine("Digite um veículo desejado (\"moto\" ou \"carro\") ou digite \"sair\" para sair.");
                r = Console.ReadLine();

                if (r == "moto")
                {
                    Console.WriteLine("Digite o número de diárias desejado: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{m.CalcularValorTotal(d):F2}");
                    Console.WriteLine(".");
                }

                else if (r == "carro")
                {
                    Console.WriteLine("Digite o número de diárias desejado: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{c.CalcularValorTotal(d):F2}");
                    Console.WriteLine(".");
                }
            }
            Console.WriteLine("Saindo do programa...");
        }
    }
}

