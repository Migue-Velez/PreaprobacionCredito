using CapaNegocio;

namespace CapaAccesoDatosMemoria
{
    public class DatosMemoria : FuenteDeDatosPrueba
    {
        public List<IngresoDatos> ingresoDatos;

        public DatosMemoria()
        {
            IngresoDatos dato1 = new IngresoDatos("Tarjeta de identidad", 1234567890, 800, 32, 4500, 15000, 15000000);
            IngresoDatos dato2 = new IngresoDatos("Cédula ciudadanía", 1034567890, 600, 2500, 150000000, 2500, 5000);
            IngresoDatos dato3 = new IngresoDatos("Cédula ciudadanía", 1044567890, 600, 1, 600000, 3500000, 80000000);
            IngresoDatos dato4 = new IngresoDatos("Cédula ciudadanía", 1054567890, 650, 15, 6500351, 6500350, 50000000);
            IngresoDatos dato5 = new IngresoDatos("Cédula ciudadanía", 1064567890, 801, 15, 10000000, 5000000, 70000000);
            IngresoDatos dato6 = new IngresoDatos("Cédula ciudadanía", 1074567890, 601, 15, 8000000, 4000000, 30000000);
            IngresoDatos dato7 = new IngresoDatos("Cédula ciudadanía", 1084567890, 401, 25, 8000000, 4000000, 20000000);
            IngresoDatos dato8 = new IngresoDatos("Cédula ciudadanía", 1094567890, 350, 25, 4000000, 2000000, 10000000);

            ingresoDatos = new List<IngresoDatos>();

            ingresoDatos.Add(dato1);
            ingresoDatos.Add(dato2);
            ingresoDatos.Add(dato3);
            ingresoDatos.Add(dato4);
            ingresoDatos.Add(dato5);
            ingresoDatos.Add(dato6);
            ingresoDatos.Add(dato7);
            ingresoDatos.Add(dato8);

        }

        public int consultarPuntaje(int documento)
        {
            var ingreso = ingresoDatos.Find(d => d.Documento == documento);
            return ingreso != null ? ingreso.Puntaje : -1;
        }

        public IngresoDatos consultarPersona(int documento)
        {
            return ingresoDatos.Find(documento => documento.Documento.Equals(documento));
        }

        public bool registrarDatos(IngresoDatos ingresoNuevo)
        {
            this.ingresoDatos.Add(ingresoNuevo);
            return true;
        }

    }
}
