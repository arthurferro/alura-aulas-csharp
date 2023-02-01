using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Administracao.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } //Visível na própria classe e visível nas classes que herdam Funcionario
        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual double PremioSemestral()
        {
            return Salario * 0.2;
        }
          public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public void ExibirDados(){
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {Cpf}");
            System.Console.WriteLine($"Salário: {Salario.ToString("F")}");
            System.Console.WriteLine("--------------------------");
        }

    }
}
