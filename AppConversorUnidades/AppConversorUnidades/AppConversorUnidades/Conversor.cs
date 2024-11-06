using System;

namespace ConversorDeUnidades
{
    public static class Conversor
    {
        //conversión de longitud
        public static double ConvertirMetrosAKilometros(double metros)
        {
            return metros / 1000.0;
        }

        public static double ConvertirKilometrosAMetros(double kilometros)
        {
            return kilometros * 1000.0;
        }

        //conversión de peso
        public static double ConvertirKilogramosALibras(double kilogramos)
        {
            return kilogramos * 2.20462;
        }

        public static double ConvertirLibrasAKilogramos(double libras)
        {
            return libras / 2.20462;
        }

        //conversión de temperatura
        public static double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32;
        }

        public static double ConvertirFahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
