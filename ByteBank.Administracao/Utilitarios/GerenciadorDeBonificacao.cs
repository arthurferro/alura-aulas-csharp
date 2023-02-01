using ByteBank.Administracao.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Administracao.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }
        public double TotalPremioSemestral { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
        }

        public double getBonificacao()
        {
            return TotalBonificacao;
        }

        public void RegistrarPremioSemestral(Funcionario funcionario)
        {
            TotalPremioSemestral += funcionario.PremioSemestral();
        }

        public double getPremioSemestral(Funcionario funcionario)
        {
            return TotalPremioSemestral;
        }
    }
}