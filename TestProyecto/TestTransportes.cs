using Entidades;
namespace TestProyecto
{
    [TestClass]
    public class TestTransportes
    {
        /// <summary>
        /// Metodo de testeo que verifica la igualdad de dos autos iguales
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
        /// Metodo de testeo que verifica la igualdad de dos autos distintos
        /// </summary>
        [TestMethod]
        public void VerificarAutosIgualesFalla()
        {
            Auto auto1 = new Auto(3, EVelocidad.Media, 4, ECarga.Media, "88");
            Auto auto2 = new Auto(3, EVelocidad.Alta, 4, ECarga.Media, "06");

            bool rta = auto1 == auto2;

            Assert.IsFalse(rta);
        }
    }
}