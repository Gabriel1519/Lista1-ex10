using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Real;
            double Dolar;
            double Cotação;

            Console.Write("Insira a Cotação do Dolar: ");
            Cotação = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantia de Dolares: ");
            Dolar = double.Parse(Console.ReadLine());

            Real = Cotação * Dolar;

        

            Console.WriteLine("A Quantia em Reais é {0}.", Real);
        }
    }
}
