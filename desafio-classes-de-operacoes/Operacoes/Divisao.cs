using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_classes_de_operacoes.Operacoes
{
    public class Divisao
    {
        public double Calcular(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividendo / divisor;
            }
        }
    }
}
