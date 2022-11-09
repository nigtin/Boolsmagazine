using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант12
{
    internal class Class6
    {
        public void Ochistka()
        {
            string path = @"C:\Users\truni\source\repos\Вариант12\Вариант12\bin\Debug\Korzina.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                // альтернатива с помощью класса File
                // File.Delete(path);
            }
            fileInf.Create().Close();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }
}
