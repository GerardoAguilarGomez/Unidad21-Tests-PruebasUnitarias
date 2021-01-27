using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unidad21_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void areaCuadradoTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.areacuadrado(3);
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void areaCirculoTest()
        {
            Geometria G1 = new Geometria();
            double resultado = G1.areaCirculo(2);
            Assert.AreEqual(12.5664, resultado);
        }

        [TestMethod]
        public void areaTrianguloTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.areatriangulo(2,3);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void areaRectanguloTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.arearectangulo(2, 3);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void areaPentagonoTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.areapentagono(2, 3);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void areaRomboTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.arearombo(2, 3);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void areaRomboideTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.arearomboide(2, 3);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void areaTrapecioTest()
        {
            Geometria G1 = new Geometria();
            int resultado = G1.areatrapecio(3, 3,5);
            Assert.AreEqual(15, resultado);
        }
    }
}
