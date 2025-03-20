using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        private Logica logica;
        private ConexionSQLServer conexionSQL;
        public Form1()
        {
            InitializeComponent();
            logica = new Logica(new ConexionSQLServer());
            conexionSQL = new ConexionSQLServer();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = cbTipoDocumento.Text;
            int documento = int.Parse(tbDocumento.Text);
            int puntaje = conexionSQL.consultarPuntaje(documento);
            int plazoSolicitado= int.Parse(tbPlazoSolicitado.Text);
            int ingresosTotales = int.Parse(tbIngresosTotales.Text);
            int egresosTotales = int.Parse(tbEgresosTotales.Text);
            int montoSolicitado = int.Parse(tbMontoSolicitado.Text);

            string respuesta = logica.verificarViabilidad(tipoDocumento, documento, puntaje, plazoSolicitado, ingresosTotales, egresosTotales, montoSolicitado);

            if (puntaje == -1)
            {
                MessageBox.Show("No se le ha encontrado en la Base de Datos.", "Resultado viabilidad",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                switch (respuesta)
                {
                    case "Esta persona no está habilitada para realizar un crédito.":
                        MessageBox.Show("No estás habilitado para realizar un crédito por ser menor de edad.", "Resultado viabilidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "No es viable realizar el crédito.":
                        MessageBox.Show("No estás habilitado para realizar un crédito.", "Resultado viabilidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Estás habilitado para realizar un crédito.", "Resultado viabilidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }

                tbDocumento.Text = string.Empty;
            tbPlazoSolicitado.Text = string.Empty;
            tbIngresosTotales.Text = string.Empty;
            tbEgresosTotales.Text = string.Empty;
            tbMontoSolicitado.Text = string.Empty;

        }
    }
}
