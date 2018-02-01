using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPalindromas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string palavra = string.Empty;
            Console.WriteLine("Digite uma Palavra");
            palavra = Console.ReadLine(); 

            //Compara o nome Ana e imprime palíndromo
            if (IsPalindrome(palavra))
                Console.WriteLine("Palíndromo");
            else
                Console.WriteLine("Palavra qualquer");
            Console.ReadKey();
        }

        private static bool IsPalindrome(string palavra)
        {
            //converte a palavra em um array de letras (caracteres) e reverte as posições.
            char[] letters = palavra.ToCharArray();
            Array.Reverse(letters);

            //transforma as letras reversas em uma string (palavra)
            string reversepalavra = new string(letters);

            //compara colocando em minúscula pois o que importa é o sentido
            if (RemoveOthers(palavra.ToLower()) == RemoveOthers(reversepalavra.ToLower()))
                return true;
            else
                return false;
        }
        //remove acentuação
        private static string RemoveOthers(string palavra)
        {
            palavra = palavra.Replace("À", "A");
            palavra = palavra.Replace("Â", "A");
            palavra = palavra.Replace("Á", "A");
            palavra = palavra.Replace("Ã", "A");

            palavra = palavra.Replace("à", "a");
            palavra = palavra.Replace("â", "a");
            palavra = palavra.Replace("á", "a");
            palavra = palavra.Replace("ã", "a");

            palavra = palavra.Replace("Ê", "E");
            palavra = palavra.Replace("É", "E");

            palavra = palavra.Replace("ê", "e");
            palavra = palavra.Replace("é", "e");

            palavra = palavra.Replace("Ó", "O");
            palavra = palavra.Replace("Ô", "O");

            palavra = palavra.Replace("ó", "o");
            palavra = palavra.Replace("ô", "o");

            palavra = palavra.Replace("ú", "u");

            return palavra;
        }

    }
}
