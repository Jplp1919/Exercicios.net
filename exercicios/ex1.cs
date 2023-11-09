using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class ex1
    {
        public int findBiggest(List<int> l1)
        {
            int biggest = 0;
            foreach (int i in l1)
            {
                if (i > biggest)
                {
                  biggest = i;
                }
            }

            return biggest;
        }
    }
}
