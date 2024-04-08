using DesafiosSS.Shared.Enums;

namespace DesafiosSS.Shared.Utils
{
    public static class DistanciaUtils
    {

        public static double ConverterMetro(double valorOriginal, EUnidadesDistancia eUnidadesDistancia)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesDistancia switch
            {
                EUnidadesDistancia.Quilometro => valorOriginal / 1000,
                EUnidadesDistancia.Milha => valorOriginal / 1609.34,
                _ => valorOriginal
            };
        }

        public static double ConverterQuilometro(double valorOriginal, EUnidadesDistancia eUnidadesDistancia)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesDistancia switch
            {
                EUnidadesDistancia.Metro => valorOriginal * 1000,
                EUnidadesDistancia.Milha => valorOriginal / 1.60934,
                _ => valorOriginal
            };
        }

        public static double ConverterMilha(double valorOriginal, EUnidadesDistancia eUnidadesDistancia)
        {
            double novoValor = 0.0;
            return novoValor = eUnidadesDistancia switch
            {
                EUnidadesDistancia.Metro => valorOriginal * 1609.34,
                EUnidadesDistancia.Quilometro => valorOriginal * 1.60934,
                _ => valorOriginal
            };
        }
    }
}
