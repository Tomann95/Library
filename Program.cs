using Bibloteka_miejska;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> biblioteka = new List<string>();
        bool dzialaj = true;
        
        while (dzialaj)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("         Bibloteka Miejska             ");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Dodaj książkę");
            Console.WriteLine("2. Wyświetl listę książek");
            Console.WriteLine("3. Usuń książkę");
            Console.WriteLine("4. Zakończ program");
            Console.WriteLine("====================================");
            Console.Write("Wybierz opcję (1-4): ");

            string wybor = Console.ReadLine();
            Console.WriteLine();

            AddBook addBook = new AddBook();
            ViewBook viewBook = new ViewBook();
            RemoveBook removeBook = new RemoveBook();

            if (wybor == "1")
            {
                addBook.Book(biblioteka);
            }
            
            else if (wybor == "2")
            {
                viewBook.VBook(biblioteka);
            }

            else if (wybor == "3")
            {
                removeBook.RBook(biblioteka);
            }

            else if (wybor == "4")
            {

                dzialaj = false;
                Console.WriteLine("Zamykanie programu...");
            }
            else
            {

                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
            }

            Console.WriteLine(); 
        }

        
        Console.WriteLine("Program został zamknięty.");
        Console.ReadKey();
    }
}

