using System;

namespace ServiceConverTemp
{
    public class ServWebWCFConverTemps : IServWebWCFConverTemps
    {
        public double ConvCentAFahr(double gCent)
        {
            double grados = Math.Round(9.0 / 5.0 * gCent + 32.0, 2);
            return grados;
        }

        public double ConvFahrACent(double gFahr)
        {
            double grados = Math.Round(((gFahr - 32.0) * 5.0) / 9.0, 2);
            return grados;
        }

        public Detalles ResultadoDetallado(Detalles detalle)
        {
            if (detalle == null)
                throw new ArgumentNullException(nameof(detalle), "El objeto 'detalle' no puede ser nulo.");
           
            if (detalle.SonCentigrados)
                detalle.Literal = ConvCentAFahr(detalle.Grados) + " grados fahrenheit.";
            else
                detalle.Literal = ConvFahrACent(detalle.Grados) + " grados centigrados.";

            return detalle;
        }
    }
}
