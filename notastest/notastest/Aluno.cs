using System;
namespace notastest
{
    using System;


    public class Aluno
    {
        private int matricula;
        private string nome;
        private double nota1;
        private double nota2;
        private double notaTrabalho;

        public Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
     
        }

        public void RegistrarNota1(double nota1)
        {
            this.nota1 = nota1;
        }

        public void RegistrarNota2(double nota2)
        {
            this.nota2 = nota2;
        }

        public void RegistrarNotaTrabalho(double notaTrabalho)
        {
            this.notaTrabalho = notaTrabalho;
        }

        private double CalcularMedia()
        {
            double media = (nota1 * 2.5 + nota2 * 2.5 + notaTrabalho * 2) / 7;
            return double.Parse(media.ToString("0.00"));
        }

        public void Imprimir()
        {
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Nota Trabalho: " + notaTrabalho);
            Console.WriteLine("Media: " + CalcularMedia());
        }
    }


   

}



