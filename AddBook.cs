using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka_miejska
{
    public class AddBook
    {
        public void Book(List<string> biblioteka)
        {
            Console.Write("Podaj tytuł książki: ");
            string tytul = Console.ReadLine();
            biblioteka.Add(tytul);
            Console.WriteLine($"Książka \"{tytul}\" została dodana do biblioteki.");
        }
    }
}
        
     

