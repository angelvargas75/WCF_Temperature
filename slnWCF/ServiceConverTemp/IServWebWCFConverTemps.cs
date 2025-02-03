using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceConverTemp
{
    [ServiceContract]
    public interface IServWebWCFConverTemps
    {
        [OperationContract]
        double ConvCentAFahr(double gCent);

        [OperationContract]
        double ConvFahrACent(double gFahr);

        [OperationContract]
        Detalles ResultadoDetallado(Detalles detalle);
    }


    [DataContract]
    public class Detalles
    {
        [DataMember]
        public bool SonCentigrados { get; set; }

        [DataMember]
        public string Literal { get; set; }

        [DataMember]
        public double Grados { get; set; }
    }
}
