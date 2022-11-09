using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Вариант12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();
            Class4 class4 = new Class4();
            Class5 class5 = new Class5();
            Class6 class6 = new Class6();
            Class7 class7 = new Class7();  
            class4.Opoveshenie();
           for (int i = 0; i < 100000; i++) {
                
                Console.WriteLine("\nВведите цифру в соответствии с тем что вы хотите сделать.");
            Console.WriteLine("1-Посмотреть каталог  2-Заказать книгу   3-посмотреть корзину 4-посмотреть список желаемого \n5 - очистить список желаемого 6 - очистить корзину 0-выход");
            string Zifra = Console.ReadLine();
                if (Zifra == "0") { break; }
                if (Zifra == "1") { class1.catalog(); }
                if (Zifra == "2") { class2.Zapros(); }
                if (Zifra == "3") { class3.Korzina(); }
                if (Zifra == "4") { class7.Shelaemoe(); }
                if (Zifra == "5") { class5.Ochistka(); }
                if (Zifra == "6") { class6.Ochistka(); }
            }
            
        }
    }
    }

