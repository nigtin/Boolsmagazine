using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Вариант12
{
    public class Class2
    { 
        public void Zapros()
        {
            string path = @"C:\Users\truni\source\repos\Вариант12\Вариант12\bin\Debug\Catalog.txt";
            System.Console.WriteLine("Введите данные о книге: ");
            string text = Console.ReadLine();
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8)) { 
            string line;
             int NA = 0;
            while ((line = sr.ReadLine()) !=null)
                {
                    if (text == line)
                    {
                        Console.WriteLine("Книга добавлена в корзину");
                        using (var writer = new StreamWriter("Korzina.txt", true))
                        {
                           
                            writer.WriteLine(text);
                            writer.Close();
                        }
                        NA = NA + 1;
                        break;
                      
                    }
                  
                }
            if (NA == 0) { 
                    Console.WriteLine("Книга добавлена в список желаемого");
                    using (var writer = new StreamWriter("Pop.txt", true))
                    {
                       
                        writer.WriteLine(text);
                        writer.Close();
                    }
                }
                NA = 0;

            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }
}
