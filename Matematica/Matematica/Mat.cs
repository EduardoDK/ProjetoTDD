using System;

namespace Matematica
{
    public class Mat
    {
        public static string msgErroRaizValorNegativo = "Não existe solução no conjunto dos reais";

        public double RaizQuadrada(double entrada)
        {

            if (entrada < 0)
                throw new ArgumentOutOfRangeException("entrada",entrada, msgErroRaizValorNegativo);


            return Math.Pow(entrada, 1.0 / 2.0);
                
        
        }

      

        public double MediaAritimetica(double[] num)
        {

            double resultado = 0;


            for (int i = 0; i < num.Length; i++)
            {
                resultado += num[i];
            }


            resultado = resultado / num.Length;

            return resultado;
        }
    }
}
