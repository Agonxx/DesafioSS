using DesafiosSS.Shared.Enums;

namespace DesafiosSS.Shared.Utils
{
    public static class PesoUtils
    {

        public static double ConverterGrama(double valorOriginal, EUnidadesPeso eUnidadesPeso)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesPeso switch
            {
                EUnidadesPeso.Quilograma => valorOriginal / 1000,
                EUnidadesPeso.Tonelada => valorOriginal / 1000000,
                _ => valorOriginal
            };
        }

        public static double ConverterQuilograma(double valorOriginal, EUnidadesPeso eUnidadesPeso)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesPeso switch
            {
                EUnidadesPeso.Grama => valorOriginal * 1000,
                EUnidadesPeso.Tonelada => valorOriginal / 1000,
                _ => valorOriginal
            };
        }

        public static double ConverterTonelada(double valorOriginal, EUnidadesPeso eUnidadesPeso)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesPeso switch
            {
                EUnidadesPeso.Grama => valorOriginal / 1000000,
                EUnidadesPeso.Quilograma => valorOriginal / 1000,
                _ => valorOriginal
            };
        }
    }
}
