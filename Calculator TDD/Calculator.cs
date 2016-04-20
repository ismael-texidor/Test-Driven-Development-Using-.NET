using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
   public class Calculator
    {
       private int sum;

       public int Add(int[] p)
       {
           //if (p.Length == 2)
           //    sum = p[0] + p[1];

           //else if (p.Length == 3)
           //    sum = p[0] + p[1] + p[2];

           //else if (p.Length == 4)
           //    sum = p[0] + p[1] + p[2] + p[3];

           if (p.Length == 1)
           {
               sum = p[0];
           }

           for (int i = 0; i < p.Length; i++)
           {
               sum = sum + p[i];
           }

           return sum;

       }

    }
}

