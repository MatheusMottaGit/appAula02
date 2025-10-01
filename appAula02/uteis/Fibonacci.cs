using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAula02.uteis
{
    public class Fibonacci
    {
        public int generateFiboSeq(int position)
        {

            if (position == 0) return 0;
            if (position == 1) return 1;

            int previous = 0;
            int current = 1;
            int next = 0;

            for (int i = 2; i <= position; i++)
            {
                next = previous + current;
                previous = current;
                current = next;
            }

            return next;
        }
    }
}