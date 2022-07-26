using System;

namespace Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Preço: ");
            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20) ? preco * 0.10 : preco * 0.05;


            Console.WriteLine("Valor total:" + (preco - desconto));




        }
    }
}
