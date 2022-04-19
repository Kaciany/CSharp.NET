using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Converção implícita  de tipos numéricos

            // Verificar se a abrangência de valores dos tipos de dados numéricos são compatíveis para que
            // aconteça a conversão desses valores.

            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2;

            num2 = num1;

            float num3 = 1250.45f;
            double num4 = num3;

            int numero = 'C';

            Console.WriteLine(numero);
            Console.ReadKey();

        }

    }
}
