﻿using System;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            string userData;
            double radius;
            double circleArea;

            Console.WriteLine("Proporciona el radio de tu circulo por favor:");
            userData = Console.ReadLine();

            if(double.TryParse(userData, out radius))
            {
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"El area de tu circulo es: {circleArea}");
            }
            else
            {
                Console.WriteLine("por favor digite numeros enteros");
            }
        }
         
    }

}
