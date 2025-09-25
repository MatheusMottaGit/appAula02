using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAula02.uteis
{
    public class Fibonacci
    {
        int chosen;
        
        public int generateFiboSeq(int position) {

            if (position == 0)
            {
                return position;
            }

            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.....
            for (int i = 0; i < position; i++)
            {
                int start = i;

                if (start == 0)
                {
                    continue;
                }

                int next = start + (i - 1);

                chosen = next;
            }

            return chosen;
        }
    }
}
