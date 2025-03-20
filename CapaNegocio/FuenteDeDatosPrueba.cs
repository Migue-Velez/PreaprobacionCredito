using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public interface FuenteDeDatosPrueba : FuenteDeDatos
    {
        public int consultarPuntaje(int documento);
    }
}
