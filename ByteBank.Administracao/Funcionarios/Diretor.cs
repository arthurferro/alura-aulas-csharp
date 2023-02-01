using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Administracao.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public Diretor (string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
