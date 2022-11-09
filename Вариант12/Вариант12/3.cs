using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Вариант12
{
    public class Class3
    {
        public void Korzina()
        {
            FileStream stream1 = File.OpenRead("Korzina.txt");
            
                
               
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);
                
                string textFromFile = System.Text.Encoding.UTF8.GetString(array);
                System.Console.WriteLine(textFromFile);

                stream1.Close();
                
            
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            
        }
    }
    
   
}
//System.Console.WriteLine("Введите данные о книге: ");
//string text = Console.ReadLine();
//using (FileStream stream = new FileStream("Zapros.txt", FileMode.OpenOrCreate))
//{
  //  byte[] array = System.Text.Encoding.UTF8.GetBytes(text);
    //stream.Write(array, 0, array.Length);
//}