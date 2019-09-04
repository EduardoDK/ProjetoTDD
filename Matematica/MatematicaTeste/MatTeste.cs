using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatematicaTeste
{
    [TestClass]
    public class MatTeste
    {
        [TestMethod]
        public void RaizQuadradaBasicaTeste()
        {

            Mat m = new Mat();

            double esperado = 2.0;
            double entrada = esperado * esperado;
            double resultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);

                        



        }

        [TestMethod]
        public void RaizQuadradaInteiroPositivo()
        {

            Mat m = new Mat();

            double esperado = 5.0;
            double entrada = esperado * esperado;
            double resultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);





        }
        [TestMethod]
        public void RaizQuadradaValorNegativo()
        {
            Mat m = new Mat();

            double entrada = -1.0;


            try
            {
                m.RaizQuadrada(entrada);
            }
            catch (ArgumentException ae)
            {
                StringAssert.Contains(ae.Message, Mat.msgErroRaizValorNegativo);
                return;
            }

            Assert.Fail("O metódo não lançou uma exeção esperada");


        }
        [TestMethod]
        public void RaizQuadradaNumeroQuebrado()
        {

            Mat m = new Mat();

            double esperado = 3.3;
            double entrada = esperado * esperado;
            double resultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);





        }
        [TestMethod]
        public void RaizQuadradaValorNegativoQuebrado()
        {
            Mat m = new Mat();

            double entrada = -1.8;


            try
            {
                m.RaizQuadrada(entrada);
            }
            catch (ArgumentException ae)
            {
                StringAssert.Contains(ae.Message, Mat.msgErroRaizValorNegativo);
                return;
            }

            Assert.Fail("O metódo não lançou uma exeção esperada");


        }
        [TestMethod]
        public void TesteMediaAritimeticaDoisValores()
        {
            Mat m = new Mat();

            double resultadoEsperado = 10.0;
            double[] num = new double[5];
            num[0] = 10.0;
            num[1] = 10.0;
            num[2] = 10.0;
            num[3] = 10.0;
            num[4] = 10.0;

            double resultadoReal = m.MediaAritimetica(num);

        

            Assert.AreEqual(resultadoEsperado, resultadoReal);


      




        }

    }
   

}
