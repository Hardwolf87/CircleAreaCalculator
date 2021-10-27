using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData;
            double triangleBase;
            double altura;
            double triangleArea;

            Console.WriteLine("Hola, te proporcionaré el área de un triangulo.");
            Console.WriteLine(@" /\");
            Console.WriteLine(@"/__\");
            Console.WriteLine("proporciona el valor de la base de un triangulo");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out triangleBase))
            {

                Console.WriteLine("Proporciona la altura del triangulo");
                userData = Console.ReadLine();
                if (double.TryParse(userData, out altura))
                {
                    triangleArea = (triangleBase * altura) / 2;
                    Console.WriteLine($"El área de tú triangulo es: {triangleArea}");
                }
                else
                {
                    Console.WriteLine("Los datos proporcionados son incorrectos.");
                }
            }
            else
            {
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }
            Console.ReadKey();
        }

    }





}