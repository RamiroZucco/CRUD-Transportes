using Entidades;
namespace TestProyecto
{
    /// <summary>
    /// Clase de tipo test con los m�todos de testeo
    /// </summary>
    [TestClass]
    public class TestTransportes
    {
        /// <summary>
        /// M�todo de testeo que verifica la igualdad de dos autos iguales
        /// </summary>
        [TestMethod]
        public void VerificarAutosIgualesOk()
        {
            //Arrange
            Auto auto1 = new Auto(3,EVelocidad.Media,4,ECarga.Media,"88");
            Auto auto2 = new Auto(3, EVelocidad.Hiper, 4, ECarga.Pesada, "88");

            //Act
            bool rta = auto1 == auto2;

            //Assert
            Assert.IsTrue(rta);
        }
        
        /// <summary>
        /// M�todo de testeo que verifica la igualdad de dos autos distintos
        /// </summary>
        [TestMethod]
        public void VerificarAutosIgualesFalla()
        {
            Auto auto1 = new Auto(3, EVelocidad.Media, 4, ECarga.Media, "88");
            Auto auto2 = new Auto(3, EVelocidad.Alta, 4, ECarga.Media, "06");

            bool rta = auto1 == auto2;

            Assert.IsFalse(rta);
        }

        /// <summary>
        /// M�todo de testeo que verifica la igualdad de dos caballos iguales
        /// </summary>
        [TestMethod]
        public void VerificarCaballosIgualesOk()
        {
            Caballo c1 = new Caballo("Rayo", 3,EVelocidad.Baja, EColor.Pinto, ECarga.Liviana);
            Caballo c2 = new Caballo("Rayo", 3,EVelocidad.Baja, EColor.Pinto, ECarga.Liviana);

            bool rta = c1 == c2;

            Assert.IsTrue(rta);
        }

        /// <summary>
        /// M�todo de testeo que verifica la igualdad de dos caballos distintos
        /// </summary>
        [TestMethod]
        public void VerificarCaballosIgualesFalla()
        {
            Caballo c1 = new Caballo();
            Caballo c2 = new Caballo("Rayo",3,EVelocidad.Baja,EColor.Pinto,ECarga.Media);

            bool rta = c1 == c2;

            Assert.IsFalse(rta);
        }

        /// <summary>
        /// M�todo de testeo que verifica si el parametro modelo no es null
        /// </summary>
        [TestMethod]
        public void VerificarModeloNoEsNull()
        {
            Avion a = new Avion(3,EVelocidad.Hiper,"AR-650",30,ECarga.MuyPesada);

            string modelo = a.Modelo;

            Assert.IsNotNull(modelo);
        }

        /// <summary>
        /// M�todo de testeo que verifica si el parametro modelo es null
        /// </summary>
        [TestMethod]
        public void VerificarModeloEsNull()
        {
            Avion a = new Avion();

            string modelo = a.Modelo;

            Assert.IsNull(modelo);
        }
    }
}