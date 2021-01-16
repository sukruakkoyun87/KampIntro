using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine();
            //array -dizi

            string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlama başlangıç için temel kurs", "Java","Python","C#"};

      
            for (int i = 0; i <Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }

            Console.WriteLine("For bitti");
            Console.WriteLine();
            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach Bitti");
            Console.WriteLine();
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
