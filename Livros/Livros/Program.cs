using System;
using Livros;
using System.Collections.Generic;

namespace Livros
{
    class Program
    {
        static void Main(string[] args)
        {
          
Person person1 = new Person("John", 30);
        Person person2 = new Person("Maria", 25);

        Book book1 = new Book("Learning C#", "Author1", 2022);
        Book book2 = new Book("Introduction to Programming", "Author2", 2021);
        Book book3 = new Book("Algorithms and Data Structures", "Author3", 2020);
        Book book4 = new Book("Design Patterns", "Author4", 2019);
        Book book5 = new Book("SQL for Beginners", "Author5", 2021);

        Loan loan1 = new Loan(person1, book1);
        Loan loan2 = new Loan(person2, book3);
        Loan loan3 = new Loan(person1, book5);

        loan1.Return(); 
        loan2.Return(); 
        loan3.Return(); 

        Console.WriteLine("Loan 1 - Late: " + loan1.Late);
        Console.WriteLine("Loan 2 - Late: " + loan2.Late);
        Console.WriteLine("Loan 3 - Late: " + loan3.Late);
        
        }
    }
}