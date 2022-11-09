using System;
using System.IO;

namespace Вариант12
{
    internal class Class5
    {
        public void Ochistka()
        {
            string path = @"C:\Users\truni\source\repos\Вариант12\Вариант12\bin\Debug\Pop.txt";
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
