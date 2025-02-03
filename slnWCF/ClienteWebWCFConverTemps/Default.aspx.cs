using ClienteWebWCFConverTemps.ServiceReference2;
using System;

namespace ClienteWebWCFConverTemps
{
    public partial class Default : System.Web.UI.Page
    {
        private ServWebWCFConverTempsClient cliente = null;
        private double nGrados;


        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            cliente = new ServWebWCFConverTempsClient();

            cliente.ConvCentAFahrCompleted +=
                new EventHandler<ConvCentAFahrCompletedEventArgs>(
                    Cliente_ConvCentAFahrCompleted);
            cliente.ConvFahrACentCompleted +=
                new EventHandler<ConvFahrACentCompletedEventArgs>(
                    Cliente_ConvFahrACentCompleted);
            cliente.ResultadoDetalladoCompleted +=
                new EventHandler<ResultadoDetalladoCompletedEventArgs>(
                    Cliente_ResultadoDetalladoCompleted);
        }

        private void Cliente_ConvCentAFahrCompleted(object sender, ConvCentAFahrCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblError.Text = "Error en la conversión de grados C a F";
            }
            else
            {
                txtGrados.Text = Convert.ToString(e.Result);
            }
        }
        private void Cliente_ConvFahrACentCompleted(object sender, ConvFahrACentCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblError.Text = "Error en la conversión de grados F a C";
            }
            else
            {
                txtGrados.Text = Convert.ToString(e.Result);
            }
        }
        private void Cliente_ResultadoDetalladoCompleted(object sender, ResultadoDetalladoCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblError.Text = "Error al obtener detalles del resultado";
            }
            else
            {
                txtGrados.Text = e.Result.Literal;
            }
        }


        public void ConvCentAFahrAsync(double gCent)
        {
            this.ConvCentAFahrAsync(gCent);
        }
        public void ConvFahrACentAsync(double gFahr)
        {
            this.ConvFahrACentAsync(gFahr);
        }

        protected void btnConvertir_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            try
            {
                nGrados = Convert.ToDouble(txtGrados.Text);

                if (boConvCF.Checked)
                {
                    cliente.ConvCentAFahrAsync(nGrados);
                }
                if (boConvFC.Checked)
                {
                    cliente.ConvFahrACentAsync(nGrados);
                }
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                nGrados = Convert.ToDouble(txtGrados.Text);
                Detalles detalle = new Detalles();
                detalle.Grados = nGrados;
                detalle.SonCentigrados = boConvCF.Checked;
                cliente.ResultadoDetalladoAsync(detalle);
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtGrados.Text = string.Empty;
            lblError.Text = string.Empty;
            boConvCF.Checked = false;
            boConvFC.Checked = false;
        }
    }
}
