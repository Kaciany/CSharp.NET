using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nome1, nome2, nome3, nome4, comando;
            Console.WriteLine("Digite  nome 1: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite nome 2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite  nome 3: ");
            nome3 = Console.ReadLine();
            Console.WriteLine("Digite nome 4: ");
            nome4 = Console.ReadLine();

            // Mecanismo para inverter os nomes

            comando = nome1;
            nome1 = nome4;
            nome4 = comando;
            comando = nome2;
            nome2 = nome3;
            nome3 = comando;


            Console.WriteLine();
            Console.WriteLine("Nomes exibidos na sequência invertida: ");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();

        }
    }
}
