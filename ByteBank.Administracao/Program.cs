using System;
using ByteBank.Administracao.Funcionarios;
using ByteBank.Administracao.Utilitarios;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "123.456.789-10";
pedro.Salario = 2100;

Funcionario roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.Cpf = "987.654.321-12";
roberta.Salario = 5000;

Console.WriteLine($"Bonificação de {pedro.Nome} - R${pedro.GetBonificacao()}");

Console.WriteLine($"Bonificação de {roberta.Nome} - R${roberta.GetBonificacao()}");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);
Console.WriteLine($"Total de bonificações: R${gerenciador.getBonificacao()}");
