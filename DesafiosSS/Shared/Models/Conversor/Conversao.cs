using DesafiosSS.Shared.Enums;
using DesafiosSS.Shared.Utils;

namespace DesafiosSS.Shared.Models.Conversor
{
    public class Conversao
    {
        public ETipoConversao TipoConversao { get; set; } = ETipoConversao.Distancia;
        public List<EUnidadesDistancia> ListDistancias { get; set; } = EnumUtils.GetEnumList<EUnidadesDistancia>();
        public List<EUnidadesPeso> ListPesos { get; set; } = EnumUtils.GetEnumList<EUnidadesPeso>();
        public List<EUnidadesTemperatura> ListTemperaturas { get; set; } = EnumUtils.GetEnumList<EUnidadesTemperatura>();
    }

    public class BaseConversao
    {
        public double ValorOriginal { get; set; }
        public double ValorNovo { get; set; }
    }

    public class ConvDistancia : BaseConversao
    {
        public EUnidadesDistancia TipoOriginal { get; set; } = EUnidadesDistancia.Metro;
        public EUnidadesDistancia TipoNovo { get; set; } = EUnidadesDistancia.Metro;
    }

    public class ConvPeso : BaseConversao
    {
        public EUnidadesPeso TipoOriginal { get; set; } = EUnidadesPeso.Quilograma;
        public EUnidadesPeso TipoNovo { get; set; } = EUnidadesPeso.Quilograma;
    }

    public class ConvTemperatura : BaseConversao
    {
        public EUnidadesTemperatura TipoOriginal { get; set; } = EUnidadesTemperatura.Celsius;
        public EUnidadesTemperatura TipoNovo { get; set; } = EUnidadesTemperatura.Celsius;
    }


}
