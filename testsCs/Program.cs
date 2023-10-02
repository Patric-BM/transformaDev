
using System;

namespace testsCs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "No name";

            Console.Write("Enter price: ");
            int price = int.TryParse(Console.ReadLine(), out int priceInt) ? priceInt : 0;

            Console.Write("Enter weight: ");
            double weight = double.TryParse(Console.ReadLine(), out double weightDouble) ? weightDouble : 0;

            Console.WriteLine("Price: " + price);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);

            // Desafio 1: Calculadora


            Console.WriteLine("Enter two numbers: ");
            double number1 = double.Parse(Console.ReadLine() ?? "1");
            double number2 = double.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("Sum: " + (number1 + number2));
            Console.WriteLine("Subtraction: " + (number1 - number2));
            Console.WriteLine("Multiplication: " + (number1 * number2));
            Console.WriteLine("Division: " + (number1 / number2));

            // Calculate age

            Console.WriteLine("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter your current year: ");
            int currentYear = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Your age is: " + (currentYear - birthYear));

            // tip calculate

            Console.WriteLine("Enter the total account amount ");
            double totalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tip percentage ");
            double tipPercentage = double.Parse(Console.ReadLine() ?? "0");
            double totalPaid = totalAmount + (totalAmount * (tipPercentage / 100));
            Console.WriteLine("Total paid: " + totalPaid);
            Console.WriteLine("Tip: " + tipPercentage);

            // Desafio 4: Conversor de moedas

            Console.WriteLine("Enter the amount in reais: ");
            double amountInReais = double.Parse(Console.ReadLine() ?? "0");
            double amountInDollars = amountInReais / 5.23;
            double amountInEuros = amountInReais / 6.20;
            Console.WriteLine("Amount in reais: " + amountInReais);
            Console.WriteLine("Amount in dollars: " + amountInDollars);
            Console.WriteLine("Amount in euros: " + amountInEuros.ToString("F2"));


           // checar se um número é par ou impar

           int number =  int.Parse(Console.ReadLine() ?? "0");

            if (number / 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }


            // imc calculator

            Console.WriteLine("Enter your weight: ");


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

  /*          DESAFIO 05:

 */

            Console.WriteLine("Enter the fish weight: ");
            double fishWeight = double.Parse(Console.ReadLine() ?? "0");
            double excess = fishWeight - 50;
            double fine = excess * 4;
            if (fishWeight > 50)
            {
                Console.WriteLine("Excess: " + excess);
                Console.WriteLine("Fine: " + fine);
            }
            else
            {
                Console.WriteLine("Excess: 0");
                Console.WriteLine("Fine: 0");
            }

            /*
            DESAFIO 06:

            */

            Console.WriteLine("Enter the swimmer age: ");
            int swimmerAge = int.Parse(Console.ReadLine() ?? "0");
            if (swimmerAge >= 5 && swimmerAge <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (swimmerAge >= 8 && swimmerAge <= 11)
            {
                Console.WriteLine("Infantil B");
            }
            else if (swimmerAge >= 12 && swimmerAge <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (swimmerAge >= 14 && swimmerAge <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Adultos");
            }

           /*
           DESAFIO 07:

           */

            Console.WriteLine("Enter the product code: ");
            int productCode = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the product name: ");
            string productName = Console.ReadLine() ?? "No name";
            Console.WriteLine("Enter the product quantity: ");
            int productQuantity = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the product price: ");
            double productPrice = double.Parse(Console.ReadLine() ?? "0");
            double totalValue = productQuantity * productPrice;
            Console.WriteLine("Product code: " + productCode);
            Console.WriteLine("Product name: " + productName);
            Console.WriteLine("Product quantity: " + productQuantity);
            Console.WriteLine("Product price: " + productPrice);
            Console.WriteLine("Total value: " + totalValue);

            /*
            DESAFIO 08:

            Elabore um algoritmo que leia o nome de um aluno e as notas das três provas que ele
            obteve no semestre. No final informar o nome do aluno e a sua média (aritmética).
            */

            Console.WriteLine("Enter the student name: ");
            string studentName = Console.ReadLine() ?? "No name";
            Console.WriteLine("Enter the first grade: ");
            double firstGrade = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the second grade: ");
            double secondGrade = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the third grade: ");
            double thirdGrade = double.Parse(Console.ReadLine() ?? "0");
            double average = (firstGrade + secondGrade + thirdGrade) / 3;
            Console.WriteLine("Student name: " + studentName);
            Console.WriteLine("Average: " + average);

            /*
            
            DESAFIO 10:

            Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
            maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
            é palíndroma ou não. Utilize split e join

            */




            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine().ToLower();
            string reverseWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            if (word == reverseWord)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }

            /*
            DESAFIO 11:

            */

            Console.WriteLine("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine() ?? "0");
            double percentage = 0;
            double increase = 0;
            if (salary <= 280)
            {
                percentage = 20;
                increase = salary * (percentage / 100);
            }
            else if (salary > 280 && salary <= 700)
            {
                percentage = 15;
                increase = salary * (percentage / 100);
            }
            else if (salary > 700 && salary <= 1500)
            {
                percentage = 10;
                increase = salary * (percentage / 100);
            }
            else
            {
                percentage = 5;
                increase = salary * (percentage / 100);
            }
            double newSalary = salary + increase;
            Console.WriteLine("Salary before the increase: " + salary);
            Console.WriteLine("Percentage of increase: " + percentage);
            Console.WriteLine("Increase: " + increase);
            Console.WriteLine("New salary: " + newSalary);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();

            dictionary.Add("carro", "automóvel");
            dictionary2.Add(1, "automóvel");

        
         


        

            




            




        



        }
    }
}