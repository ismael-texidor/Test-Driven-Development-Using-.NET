using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class MatrixFactory
    {
     
        public Matrix Parse(string matrix)
        {
            int row = 0;
            int col = 0;

            var input = matrix.ToCharArray();


            var m = new Matrix();

            //{
            //    var c = int.Parse(input[2] + "");
            //    m.Set(0, 0, c);
            //}


            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == '[' && input[j + 1] == '[')
                {
                    var num = string.Join("", input.Skip(2).TakeWhile(c => char.IsNumber(c)));
                    var value = int.Parse(num);
                    m.Set(row, col, value);
                    row++;

                }
                else if (input[j] == ',' && char.IsNumber(input[j + 1]))
                {
                    var num1 = string.Join("", input.Skip(j + 1).TakeWhile(c => char.IsNumber(c)));
                    var value1 = int.Parse(num1);
                    m.Set(row, col, value1);
                    row++;
                }

                else if (input[j] == ',' && input[j + 1] == '[')
                {
                    row = 0;
                    col++;
                    var num1 = string.Join("", input.Skip(j + 2).TakeWhile(c => char.IsNumber(c)));
                    var value1 = int.Parse(num1);
                    m.Set(row, col, value1);
                    row++;
                }
            }

            //int offset = 0;

            //for (int i = 0; i < columnCount; i++)
            //{
            //    var num = string.Join("", input.Skip(2 + 2 * i + offset).TakeWhile(c => char.IsNumber(c)     ));
            //    offset += num.Length - 1;
            //    var value = int.Parse(num);
            //    m.Set(i, 0, value);
            //}

            return m;
        }
    }
}
