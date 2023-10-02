namespace Aula1
{
  class Program
  { 
    static void Main()
    {
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Seu peso: ");

            double height = double.Parse(Console.ReadLine());

            double imc = weight / (height * height);

            if (imc < 18.5)
            {
                Console.WriteLine("Magreza");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Normal ");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade 1");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade 2");
            }
            else
            {
                Console.WriteLine("Obesidade 3");
            }
        }
  }
}
