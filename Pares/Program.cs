using System;

namespace Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, qPares = 0;
            Console.WriteLine("Quantidade pares\n\n");
            Console.WriteLine("Digite o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
            {
                for (int i = n1 + 1; i < n2; i++)
                {
                    if (i % 2 == 0)
                    {
                        qPares++;
                    }
                }
                Console.WriteLine("Quantidade de Pares:{0}", qPares.ToString());

            }
            else
            {
                Console.WriteLine("O primwerio número devbe ser menor que o segundo.");
            }


        }
    }
}
