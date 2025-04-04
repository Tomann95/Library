using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka_miejska
{
    class RemoveBook
    {
        public void RBook(List<string> biblioteka)
        {
           
            if (biblioteka.Count == 0)
            {
                Console.WriteLine("Biblioteka jest pusta. Brak książek do usunięcia!");
            }
            else
            {
                Console.WriteLine("Podaj numer książki do usunięcia (z listy):");
                for (int i = 0; i < biblioteka.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {biblioteka[i]}");
                }
                Console.Write("Twój wybór: ");
                string numerDoUsuniecia = Console.ReadLine();


                if (int.TryParse(numerDoUsuniecia, out int indeks))
                {

                    if (indeks > 0 && indeks <= biblioteka.Count)
                    {
                        Console.WriteLine($"Usunięto książkę: \"{biblioteka[indeks - 1]}\"");
                        biblioteka.RemoveAt(indeks - 1);
                    }
                    else
                    {
                        Console.WriteLine("Błędny numer książki!");
                    }
                }
                else
                {
                    Console.WriteLine("Podano niepoprawny numer!");
                }
            }
        }
    }
    }

