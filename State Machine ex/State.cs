using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class State
    {
        public bool IsValid(string input)
        {
            //if (input.All((char c) => c == 'a' || c == 'b' || c == 'c'))
            //{
            //    if (input.Contains("ba") || input.Contains("cb") || input.Contains("ca"))
            //    {
            //        return false;
            //    }

            //    return true;
            //}

            //return false;

            // 1 (I've seen an a - I'm looking for a's, b's or c's)
            // 2 (I've seen a b - I'm looking for b's or c's)
            // 3 (I've seen a c - I'm looking for c's)
            int state = 1;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (state == 1)
                {
                    if (c == 'a')
                    {
                    }
                    else if (c == 'b')
                    {
                        state = 2;
                    }
                    else if (c == 'c')
                    {
                        state = 3;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (state == 2)
                {

                    if (c == 'a')
                    {
                        return false;
                    }
                    else if (c == 'b')
                    {
                    }
                    else if (c == 'c')
                    {
                        state = 3;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (state == 3)
                {

                    if (c == 'a')
                    {
                        return false;
                    }
                    else if (c == 'b')
                    {
                        return false;
                    }
                    else if (c == 'c')
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
