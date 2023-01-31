using System;

class Aluno
{
    private int matricula;
    public int Matricula
    {
        get { return matricula; } set {
            if (value < 0)
            {
                Console.WriteLine("Número inválido, digite um número maior do que 0(zero).");
            }
            else
            {
                matricula = value;
            }
        }
    }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public int TipoCurso { get; set; }
}