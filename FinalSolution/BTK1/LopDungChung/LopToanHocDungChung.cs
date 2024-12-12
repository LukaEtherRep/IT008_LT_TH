using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK1.LopDungChung
{
    internal class LopToanHocDungChung
    {
        public static int USCLN(int a, int b)
        {
            int A, B;
            A = Math.Abs(a);
            B = Math.Abs(b);

            if (B == 0)
            {
                return A;
            }
            else
            {
                return USCLN(B, A % B);
            }
        }
    }
}
