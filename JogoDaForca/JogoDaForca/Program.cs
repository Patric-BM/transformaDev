using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoDaForca jogo = new JogoDaForca();
            jogo.StartGame();
        }
    }

    class JogoDaForca
    {
        private readonly Dictionary<int, Dictionary<string, List<string>>> wordsMap = new Dictionary<int, Dictionary<string, List<string>>>
        {
            {0, new Dictionary<string, List<string>> { { "animais", new List<string> { "cachorro", "gato", "papagaio", "tartaruga", "leão", "tigre" } } } },
            {1, new Dictionary<string, List<string>> { { "frutas", new List<string> { "banana", "maçã", "abacaxi", "melancia", "morango", "laranja" } } } },
            {2, new Dictionary<string, List<string>> { { "profissões", new List<string> { "médico", "advogado", "engenheiro", "professor", "dentista", "arquiteto" } } } },
            {3, new Dictionary<string, List<string>> { { "esportes", new List<string> { "futebol", "vôlei", "basquete", "natação", "tênis", "handebol" } } } },
            {4, new Dictionary<string, List<string>> { { "comidas", new List<string> { "arroz", "feijão", "macarrão", "batata", "carne", "frango" } } } }
        };

        private string word;
        private string dica;
        private List<char> letters;
        private string wrongLetters;
        private int attempts;

        public void StartGame()
        {
            Random random = new Random();
            int index = random.Next(0, wordsMap.Count);
            Dictionary<string, List<string>> category = wordsMap[index];
            List<string> selectedWords = category.Values.First();
            int indexWord = random.Next(0, selectedWords.Count);
            word = selectedWords[indexWord];
            dica = category.Keys.First();

            letters = new List<char>();
            wrongLetters = "";
            attempts = 0;

            for (int i = 0; i < word.Length; i++)
            {
                letters.Add('_');
            }

            while (attempts <= 6)
            {
                Console.Clear();
                Console.WriteLine(" -  Jogo da Forca - ");
                Console.WriteLine();
                Console.WriteLine("Erros: " + attempts + " de 6" + " \n");
                Console.WriteLine("Tente adivinhar a palavra da Categoria: " + dica);
                if (attempts == 6)
                {
                    ShowHangman();
                    Console.WriteLine("Você perdeu!");
                    Console.WriteLine("A palavra era: " + word);
                    GameQuit();
                } else
                {
                    ShowHangman();
                }

                Console.WriteLine("Letras erradas: " + wrongLetters);

                if (!letters.Contains('_'))
                {
                    Console.WriteLine("Você ganhou!");
                    Console.WriteLine("A palavra era: " + word);
                    GameQuit();
                }

                Console.WriteLine("Digite uma letra:");
                char letter;
                try
                {
                    letter = GetValidLetter();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                UpdateWord(letter);

                if (!word.Contains(letter) && !wrongLetters.Contains(letter))
                {
                    wrongLetters += letter + " ";
                    attempts++;
                }
            }

        
        }

        private void ShowHangman()
        {
            string ListLetters = string.Join(" ", letters);
            List<string> HangmanDesign = new List<string>
            {
                $@"
        _______
       |       |
               |
               |
               |
               |
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
               |
               |
               | 
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
       |       |
               |
               |
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
      /|       |
               |
               |
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
      /|\      |
               |
               |
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
      /|\      |
      /        |
               |
    {ListLetters}
    ",
                $@"
        _______
       |       |
       O       |
      /|\      |
      / \      |
               |
    {ListLetters}
    "
            };

            Console.WriteLine(HangmanDesign[attempts]);
        }

        private char GetValidLetter()
        {
            char letter;
            if (!char.TryParse(Console.ReadLine(), out letter))
            {
                throw new ArgumentException("Entrada inválida. Digite apenas uma letra.");
            }

            letter = char.ToLower(letter);
            if (!char.IsLetter(letter))
            {
                throw new ArgumentException("Entrada inválida. Digite apenas uma letra.");
            }

            return letter;
        }

        private void UpdateWord(char letter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    letters[i] = letter;
                }
            }
        }

        private void GameQuit()
        {
            Console.WriteLine("Deseja jogar novamente? (S para sim, qualquer outra tecla para sair)");
            char resposta = char.ToLower(Console.ReadKey().KeyChar);
            if (resposta == 's')
            {
                Console.Clear();
                StartGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
