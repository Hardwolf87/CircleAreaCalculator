using System;

namespace CalculadoraSumayResta
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion;
            int primerDato;
            int segundoDato;

            Console.WriteLine("soy la calculadora mulita, solo sumo y resto, que deseas ejecutar:");
            Console.WriteLine("1. Suma");





            Console.WriteLine("2. Resta");
            operacion = ObtenerDatosEnterosDelUsuario("Proporciona la operacion que deseas ejecutar:");

            switch(operacion)
            {
                case 1:
                    //Suma
                    primerDato = ObtenerDatosEnterosDelUsuario("proporciona el primer numero, debe ser entero:");
                    segundoDato = ObtenerDatosEnterosDelUsuario("proporciona el segundo numero, tambien debe ser entero:");
                    Console.WriteLine($"el resultado de {primerDato} + {segundoDato} = {primerDato + segundoDato}");
                    break;


                case 2:
                    //Resta
                    primerDato = ObtenerDatosEnterosDelUsuario("proporciona el primer numero, debe ser entero:");
                    segundoDato = ObtenerDatosEnterosDelUsuario("proporciona el segundo numero, tambien debe ser entero:");
                    Console.WriteLine($"el resultado de {primerDato} - {segundoDato} = {primerDato - segundoDato}");
                    break;
            }

        }

        private static int ObtenerDatosEnterosDelUsuario(string mensaje)
        {
            string valorUsuario;
            int dato = 0;
            bool datoValido = false;
            while (!datoValido)
            {
                Console.WriteLine(mensaje);
                valorUsuario = Console.ReadLine();
                if(!int.TryParse(valorUsuario, out dato))
                {
                    Console.WriteLine("el dato que diste es mulita, como yo, y no sirve.");

                }
                else
                {
                    datoValido = true;
                }
            }
            return dato;
        }
    }
}
