using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarăm tabloul pentru a stoca cuvintele
            string[][] words = new string[26][];

            // Inițializăm fiecare componentă a tabloului cu un tablou nou de string-uri
            for (int i = 0; i < 26; i++)
            {
                words[i] = new string[0];
            }

            // Citim argumentele liniei de comandă
            string[] arguments = Environment.GetCommandLineArgs();

            // Parcurgem fiecare cuvânt din argumente
            for (int i = 1; i < arguments.Length; i++)
            {
                string word = arguments[i];

                // Verificăm prima literă a cuvântului
                char firstLetter = char.ToUpper(word[0]);
                int index = firstLetter - 'A';

                // Adăugăm cuvântul în componenta corespunzătoare a tabloului
                Array.Resize(ref words[index], words[index].Length + 1);
                words[index][words[index].Length - 1] = word;
            }

            // Afișăm tabloul rezultat
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("{0}: {1}", (char)('A' + i), string.Join(", ", words[i]));
            }
            Console.ReadKey();
        }
    }
}
