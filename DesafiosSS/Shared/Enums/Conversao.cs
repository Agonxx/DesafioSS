using System.ComponentModel;

namespace DesafiosSS.Shared.Enums
{
    public enum ETipoConversao
    {
        [Description("Distância")]
        Distancia = 1,

        [Description("Peso")]
        Peso = 2,

        [Description("Temperatura")]
        Temperatura = 3
    }

    public enum EUnidadesDistancia
    {
        [Description("Metro")]
        Metro = 1,

        [Description("Quilômetro")]
        Quilometro = 2,

        [Description("Milha")]
        Milha = 3,
    }
    
    public enum EUnidadesPeso
    {
        [Description("Quilograma")]
        Quilograma = 1,

        [Description("Grama")]
        Grama = 2,

        [Description("Tonelada")]
        Tonelada = 3,
    }
    
    public enum EUnidadesTemperatura
    {
        [Description("Celsius")]
        Celsius = 1,

        [Description("Fahrenheit")]
        Fahrenheit = 2,

        [Description("Kelvin")]
        Kelvin = 3,
    }



}
