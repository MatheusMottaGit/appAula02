using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAula02.uteis
{
    public class Imc
    {
        public float calculaImc(float peso, float altura) {
            return peso / (altura * altura);
        }
    }
}
