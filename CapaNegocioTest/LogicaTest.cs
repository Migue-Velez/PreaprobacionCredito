using CapaNegocio;
using CapaAccesoDatosMemoria;

namespace CapaNegocioTest
{
    [TestClass]
    public sealed class LogicaTest
    {
        private Logica logica;

        public LogicaTest()
        {
            this.logica = new Logica(new DatosMemoria());
        }

        [TestMethod]
        public void probarPersonaConTarjetaDeIdentidad()
        {
            string resultadoEsperado = "Esta persona no está habilitada para realizar un crédito.";
            string resultadoObtenido = logica.verificarViabilidad("Tarjeta de identidad", 1234567890, 800, 32, 4500, 15000, 15000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConPlazoSolicitadoFueraDelRango()
        {
            string resultadoEsperado = "No es viable realizar el crédito.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1034567890, 600, 2500, 150000000, 2500, 5000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConBalanzaMenorDeCero()
        {
            string resultadoEsperado = "No es viable realizar el crédito.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1044567890, 600, 1, 600000, 3500000, 80000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConCreditoBalanzaMayorDePunto95()
        {
            string resultadoEsperado = "No es viable realizar el crédito.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1054567890, 650, 15, 6500351, 6500350, 50000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConCreditoBalanzaEntrePunto7YPunto95ConPuntajeDePorLoMenos800()
        {
            string resultadoEsperado = "El crédito ha sido aprobado.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1064567890, 801, 15, 10000000, 5000000, 70000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConCreditoBalanzaEntrePunto4YPunto7ConPuntajeDePorLoMenos600()
        {
            string resultadoEsperado = "El crédito ha sido aprobado.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1074567890, 601, 15, 8000000, 4000000, 30000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        
        [TestMethod]
        public void probarPersonaConCreditoBalanzaMenorAPunto4YConPuntajeDePorLoMenos400()
        {
            string resultadoEsperado = "El crédito ha sido aprobado.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1084567890, 401, 25, 8000000, 4000000, 20000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod]
        public void probarPersonaConCreditoBalanzaMenorAPunto4YConPuntajeMenorDe400()
        {
            string resultadoEsperado = "No es viable realizar el crédito.";
            string resultadoObtenido = logica.verificarViabilidad("Cédula ciudadanía", 1094567890, 350, 25, 4000000, 2000000, 10000000);
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
    }
}
