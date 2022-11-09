using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Вариант12
{
    public class Class4
    {
        public void Opoveshenie()
        {

            var file2 = File.ReadLines("Catalog.txt");
            var file1 = File.ReadLines("Pop.txt");
            File.WriteAllLines("Result.txt", file2.Intersect(file1));
            string path = @"C:\Users\truni\source\repos\Вариант12\Вариант12\bin\Debug\Result.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line = sr.ReadLine();

                if (line != null) { Console.WriteLine("Книги из списка желаемого появились в каталоге"); }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }

    }
}
       
   