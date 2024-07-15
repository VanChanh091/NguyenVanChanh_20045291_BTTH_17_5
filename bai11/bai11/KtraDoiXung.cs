using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    public class KtraDoiXung
    {
        public bool IsSymmetry(int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
