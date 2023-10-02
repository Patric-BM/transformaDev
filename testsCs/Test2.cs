using System;
using System.Collections.Generic;

namespace Testando
{
    public class Testando
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
            string value = Console.ReadLine();

            dictionary.Add("carro", value);
            dictionary2.Add(1, "um");

            Console.WriteLine(dictionary["carro"]);
            Console.WriteLine(dictionary2[1]);
        }
    }
}
