using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант12
{
    public class Class1
    {
        public void catalog() { 
        using(FileStream stream1 = File.OpenRead("Catalog.txt"))
        {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.UTF8.GetString(array);
                System.Console.WriteLine(textFromFile );
        }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }

}
