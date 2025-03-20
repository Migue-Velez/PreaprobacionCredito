using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class IngresoDatos
    {
        public string TipoDocumento { get; set; }
        public int Documento { get; set; }
        public int Puntaje { get; set; }
        public int PlazoSolicitado { get; set; }
        public int IngresosTotales { get; set; }
        public int EgresosTotales { get; set; }
        public int MontoSolicitado { get; set; }

        public IngresoDatos(string tipoDocumento, int documento, int puntaje, int plazoSolicitado, int ingresosTotales, int egresosTotales, int montoSolicitado)
        {
            TipoDocumento = tipoDocumento;
            Documento = documento;
            Puntaje = puntaje;
            PlazoSolicitado = plazoSolicitado;
            IngresosTotales = ingresosTotales;
            EgresosTotales = egresosTotales;
            MontoSolicitado = montoSolicitado;
        }

    }
}
