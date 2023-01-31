using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_classes_de_operacoes.Operacoes
{
    public class Operacoes
    {
        public Adicao Adicao { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }

        public Operacoes()
        {
            Adicao = new Adicao();
            Subtracao = new Subtracao();
            Divisao = new Divisao();
            Multiplicacao = new Multiplicacao();
        }
    }
}
