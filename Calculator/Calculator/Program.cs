using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         START:

            Stack<double> notationStack = new Stack<double>();
            string islem;
            double sonuc;
            
            Console.WriteLine("Hesaplanacak Değeri Giriniz:");

            islem = Console.ReadLine();
            char[] karakterDizi = islem.ToCharArray();
            string[] islemDizi = new string[karakterDizi.Length];

            for (int j = 0; j < karakterDizi.Length; j++)
            {
                islemDizi[j] = Convert.ToString(karakterDizi[j]);
            }

            Console.WriteLine();
            Array.Reverse(islemDizi);

            foreach (string c in islemDizi)
            {
                if (int.TryParse(c, out int n))
                {
                    notationStack.Push(n);
                }
                if (c == "+")
                {
                    double x = notationStack.Pop();
                    double y = notationStack.Pop();
                    sonuc = x + y;
                    notationStack.Push(sonuc);
                }
                if (c == "-")
                {
                    double x = notationStack.Pop();
                    double y = notationStack.Pop();
                    sonuc = x - y;
                    notationStack.Push(sonuc);
                }
                if (c == "*")
                {
                    double x = notationStack.Pop();
                    double y = notationStack.Pop();
                    sonuc = x * y;
                    notationStack.Push(sonuc);
                }
                if (c == "/")
                {
                    double x = notationStack.Pop();
                    double y = notationStack.Pop();
                    sonuc = x / y;
                    notationStack.Push(sonuc);
                }

            }

            Console.WriteLine("Sonuç : {0}", notationStack.Peek());

            Console.WriteLine("Başka bir hesaplama yapmak istiyor musunuz? (E/H)");

        SORGU:
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "E":
                    Console.Clear();
                    goto START;
                case "H":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("YANLIŞ GİRDİNİZ.Lütfen E ya da H giriniz :");
                    goto SORGU;

            }
        }
    }
}