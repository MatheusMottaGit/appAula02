using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAula02.uteis
{
    public class CalculaAumento
    {
        public double aumentar(double valor, double percentual)
        {
            return valor + (valor * percentual);
        }
    }
}
