using System.Data;
using System.Runtime.CompilerServices;

namespace CapaNegocio
{
    public class Logica
    {
        private FuenteDeDatos fuenteDeDatos;

        public Logica(FuenteDeDatos fuenteDeDatos)
        {
            this.fuenteDeDatos = fuenteDeDatos;
        }

        public string verificarViabilidad(string tipoDocumento, int documento, int puntaje, int plazoSolicitado, int ingresosTotales, int egresosTotales, int montoSolicitado)
        {

            int balanza = ingresosTotales - egresosTotales;

            if (tipoDocumento == "Tarjeta de identidad")
            {
                return "Esta persona no está habilitada para realizar un crédito.";

            } else
            {
                if (plazoSolicitado < 1 || plazoSolicitado > 72)
                {
                    return "No es viable realizar el crédito.";

                }
                else
                {
                    if (balanza <= 0)
                    {
                        return "No es viable realizar el crédito.";

                    }
                    else
                    {
                        float relacionCreditoBalanzaSinRedondear = (montoSolicitado / plazoSolicitado) / balanza;
                        float relacionCreditoBalanza = (float)Math.Round(relacionCreditoBalanzaSinRedondear, 2);

                        if (relacionCreditoBalanza >= 0.95)
                        {
                            return "No es viable realizar el crédito.";

                        }
                        else {
                            puntaje = fuenteDeDatos.consultarPuntaje(documento);
                        } if (relacionCreditoBalanza >= 0.7 & relacionCreditoBalanza < 0.95 & puntaje >= 800)
                        {
                            return "El crédito ha sido aprobado.";

                        }
                        else if (relacionCreditoBalanza >= 0.4 & relacionCreditoBalanza < 0.7 & puntaje >= 600)
                        {
                            return "El crédito ha sido aprobado.";

                        }
                        else if (relacionCreditoBalanza < 0.4 & puntaje >= 400)
                        {
                            return "El crédito ha sido aprobado.";

                        }
                        else
                        {
                            return "No es viable realizar el crédito.";
                        }

                    }
                }
            }
        }
    }
}
