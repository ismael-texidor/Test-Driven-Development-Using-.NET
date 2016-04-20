using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Matrix
    {
        Dictionary<string, int> _m = new Dictionary<string, int>();

        public int Get(int y, int x)
        {
            return _m[y + " " + x];
        }

        public void Set(int y, int x, int value)
        {
            _m[y + " " + x] = value;       
        }
    }
}
