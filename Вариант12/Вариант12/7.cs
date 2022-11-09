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
    internal class Class7
    {
        public void Shelaemoe()
        {
            FileStream stream1 = File.OpenRead("Pop.txt");



            byte[] array = new byte[stream1.Length];
            stream1.Read(array, 0, array.Length);

            string textFromFile = System.Text.Encoding.UTF8.GetString(array);
            System.Console.WriteLine(textFromFile);

            stream1.Close();


            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }
}
