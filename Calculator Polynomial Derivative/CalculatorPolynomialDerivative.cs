using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CalculatorPolynomialDerivative
    {
        public int[] DerivePolynomial(int[] p)
        {
            if (p.Length == 1)
            {
                return new int[] { 0 };
            }

            var result = new int[p.Length - 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = p[i + 1] * (i + 1);
               
            }
            return result;


        }

        
    }
}
