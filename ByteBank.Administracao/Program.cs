using System;
using ByteBank.Administracao.Funcionarios;
using ByteBank.Administracao.Utilitarios;

Funcionario pedro = new Funcionario("123.456.789-10",2000);
pedro.Nome = "Pedro";

Funcionario roberta = new Diretor("987.654.321-12",5000);
roberta.Nome = "Roberta";

Funcionario arthur = new Diretor("123.321.123-10", 2800);
arthur.Nome = "Arthur";


Console.WriteLine($"Bonificação de {pedro.Nome} - R${pedro.GetBonificacao()}");
Console.WriteLine($"Bonificação de {roberta.Nome} - R${roberta.GetBonificacao()}");
Console.WriteLine($"Bonificação de {arthur.Nome} - R${arthur.GetBonificacao()}");


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);
gerenciador.Registrar(arthur);
Console.WriteLine($"Total de bonificações: R${gerenciador.getBonificacao()}");
Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

pedro.ExibirDados();
roberta.ExibirDados();
arthur.ExibirDados();

pedro.AumentarSalario();
roberta.AumentarSalario();
arthur.AumentarSalario();

System.Console.WriteLine("Salário após ajuste");
pedro.ExibirDados();
roberta.ExibirDados();
arthur.ExibirDados();