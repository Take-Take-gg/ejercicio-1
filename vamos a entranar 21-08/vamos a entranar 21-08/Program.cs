using System;

namespace loggin
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Imprime los numeros del (x) y (y) y di de cunato en cuanto");
            Console.WriteLine("empieza el ciclo");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("termina el ciclo");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿De cuanto en cunto?");
            z = Convert.ToDouble(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("va de menor a mayor");
                for (double i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }

            if (x > y)
            {
                Console.WriteLine("va de mayor a menor");
                for (double i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }

        }
    }
}