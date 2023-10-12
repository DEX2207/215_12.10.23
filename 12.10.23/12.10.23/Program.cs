using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число: ");
            //string a=Convert.ToString(Console.ReadLine());
            //Console.WriteLine($"В вашем числе {a.Length} цифр");
            //Console.ReadKey();
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int i = 0;
            //    for (i = 0; i <= a; i++) 
            //    {
            //        a /= 10;
            //    }
            //    Console.WriteLine($"В вашем числе {i} цифр");
            //    Console.ReadLine();
            //for (int i = 0; i <=255; i++) 
            //    {
            //        Console.WriteLine($"Код {i} cooтветствует символу {(char)i}");
            //    }
            //Console.ReadLine();

            //Console.Write("Введите символ: ");
            //char i=Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Символу {i} соответствует код {(int)i}");
            //Console.ReadKey();

            //Console.Write("Введите символ: ");
            //char i = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Следующий символ : {(char)((int)i+1)}");
            //Console.ReadKey();

            //Console.Write("Введите символ: ");
            //char i = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Следующиe символы : {(char)((int)i - 1)} {(char)((int)i - 2)}");
            //Console.ReadKey();

            /*Console.Write("Введите символ: ");
            char i = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Следующиe символы : {(char)((int)i - 1)} {(char)((int)i +1 )}");
            Console.ReadKey();*/

            //Console.Write("Введите название футбольного клуба: ");
            //string club=Console.ReadLine();
            //char [] mass=club.ToCharArray();
            ////for (int i=0; i<mass.Length; i++)
            ////{
            ////    Console.WriteLine(mass[i]);
            ////}
            //foreach (var elem in mass)
            //{
            //    Console.WriteLine(elem);
            //}
            //Console.ReadLine();


            //Console.Write("Введите слово: ");
            //string club = Console.ReadLine();
            //char[] mass = club.ToCharArray();
            //for (int i=club.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(mass[i]);
            //}
            //Console.ReadLine();

            //Console.Write("Введите слово: ");
            //string word=Console.ReadLine();
            //Console.WriteLine($"{word.ToUpper()} {word.ToLower()} ");
            //Console.ReadLine();

            Console.Write("Введите название футбольного клуба: ");
            string club = Console.ReadLine();
            char[] mass = club.ToCharArray();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"{mass[i]}={(int)mass[i]}");
            }
            Console.ReadLine(); 
        }
    }
}
