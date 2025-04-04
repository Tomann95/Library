using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka_miejska
{
    class ViewBook
    {
        public void VBook(List<string> biblioteka)
        {
            Console.WriteLine("Lista książek w bibliotece:");
            for (int i = 0; i < biblioteka.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {biblioteka[i]}");
            }
        }
    }
}
