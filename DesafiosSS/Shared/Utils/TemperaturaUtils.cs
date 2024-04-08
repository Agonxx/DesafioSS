using DesafiosSS.Shared.Enums;

namespace DesafiosSS.Shared.Utils
{
    public static class TemperaturaUtils
    {
        public static double ConverterCelcius(double valorOriginal, EUnidadesTemperatura eUnidadesTemperatura)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesTemperatura switch
            {
                EUnidadesTemperatura.Fahrenheit => valorOriginal * 9/5 + 32,
                EUnidadesTemperatura.Kelvin => valorOriginal + 273.15,
                _ => valorOriginal
            };
        }

        public static double ConverterFahrenheit(double valorOriginal, EUnidadesTemperatura eUnidadesTemperatura)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesTemperatura switch
            {
                EUnidadesTemperatura.Celsius => (valorOriginal - 32) * 5/9 ,
                EUnidadesTemperatura.Kelvin => (valorOriginal + 459.67) * 5/9,
                _ => valorOriginal
            };
        }

        public static double ConverterKelvin(double valorOriginal, EUnidadesTemperatura eUnidadesTemperatura)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesTemperatura switch
            {
                EUnidadesTemperatura.Celsius => valorOriginal - 273.15,
                EUnidadesTemperatura.Fahrenheit => valorOriginal * 9/5 + 459.67,
                _ => valorOriginal
            };
        }
    }
}
