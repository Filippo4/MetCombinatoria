using System;
using System.Numerics;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
      
        public static int Fattoriale(long n)
        {
            string numero = "30414093201713378043612608166064768844377641568960512000000000000";
            BigInteger number1 = new BigInteger(numero);
            if (n < 0)
            {
                throw new Exception("Non può essere calcolato con un numero negativo");
            }

            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fattoriale(n - 1);
            }
        }                        
    }
}
