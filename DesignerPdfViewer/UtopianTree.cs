using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPdfViewer
{
    // Source Material: https://www.hackerrank.com/challenges/utopian-tree/problem
    // 
    /// <summary>
    /// 
    /// </summary>
    public static class UtopianTree
    {
        public static int CalculateTreeAge(int n)
        {
            int h = 1;
            if (n==0)
            {
                return h;
            }
            else if (n==1)
            {
                return h*2;
            }
            else
            {
                // start from year 2 summer
               // h = h * 2 + 1;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                       h += 1;
                    }
                    else
                    {
                        h *= 2; // even cycle double in the spring
                    }
                    
                }
                return h; // (CalculateTreeAge(n-1) * 2 + 1)
            }
        }
    }
}
