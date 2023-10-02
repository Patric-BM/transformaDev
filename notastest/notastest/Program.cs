using System;

namespace notastest
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(123, "João");
            aluno1.RegistrarNota1(7);
            aluno1.RegistrarNota2(8);
            aluno1.RegistrarNotaTrabalho(5);
            aluno1.Imprimir();
            
        }
    }
}

