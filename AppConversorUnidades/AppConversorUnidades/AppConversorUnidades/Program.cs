using System;

namespace ConversorDeUnidades
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Conversor de Unidades");
                Console.WriteLine("1. Convertir Longitud (Metros <-> Kilómetros)");
                Console.WriteLine("2. Convertir Peso (Kilogramos <-> Libras)");
                Console.WriteLine("3. Convertir Temperatura (Celsius <-> Fahrenheit)");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ConvertirLongitud();
                        break;
                    case "2":
                        ConvertirPeso();
                        break;
                    case "3":
                        ConvertirTemperatura();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void ConvertirLongitud()
        {
            Console.WriteLine("\nConversión de Longitud:");
            Console.Write("Ingrese metros para convertir a kilómetros: ");
            double metros = double.Parse(Console.ReadLine());
            Console.WriteLine($"{metros} metros = {Conversor.ConvertirMetrosAKilometros(metros)} kilómetros");

            Console.Write("Ingrese kilómetros para convertir a metros: ");
            double kilometros = double.Parse(Console.ReadLine());
            Console.WriteLine($"{kilometros} kilómetros = {Conversor.ConvertirKilometrosAMetros(kilometros)} metros");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void ConvertirPeso()
        {
            Console.WriteLine("\nConversión de Peso:");
            Console.Write("Ingrese kilogramos para convertir a libras: ");
            double kilogramos = double.Parse(Console.ReadLine());
            Console.WriteLine($"{kilogramos} kg = {Conversor.ConvertirKilogramosALibras(kilogramos)} libras");

            Console.Write("Ingrese libras para convertir a kilogramos: ");
            double libras = double.Parse(Console.ReadLine());
            Console.WriteLine($"{libras} libras = {Conversor.ConvertirLibrasAKilogramos(libras)} kg");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void ConvertirTemperatura()
        {
            Console.WriteLine("\nConversión de Temperatura:");
            Console.Write("Ingrese grados Celsius para convertir a Fahrenheit: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{celsius} °C = {Conversor.ConvertirCelsiusAFahrenheit(celsius)} °F");

            Console.Write("Ingrese grados Fahrenheit para convertir a Celsius: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{fahrenheit} °F = {Conversor.ConvertirFahrenheitACelsius(fahrenheit)} °C");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}