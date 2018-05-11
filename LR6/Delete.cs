using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Delete
    {
        public int[] DeletingFromArray(int[] a, int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                m = a[i];
                for (int j = 0; j < n; j++)
                {
                    if (a[j] == m)
                    {
                        k = k + 1;
                    }
                    if (k > 2)
                        for (int l = 0; l < a.Length; l++)
                        {
                            if (a[l] == m)
                                Array.Clear(a, l, 1);
                        }
                }
            }

            return a;
        }
    }
}
