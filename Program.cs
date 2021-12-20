using System;

namespace KelipatanAndPalindromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            mulai();
        }

        static void mulai()
        {
            Console.WriteLine("1. Kelipatan ");
            Console.WriteLine("2. Palindrom ");
            Console.WriteLine("0. Exit ");
            Console.Write("Ketik angka untuk memilih :");
            int I = Convert.ToInt32(Console.ReadLine().Trim());
            if (I == 1) Kelipatan();
            else if (I == 2) Palindrom();
            else if (I == 0) Environment.Exit(0);
            else mulai();
        }

        static void Kelipatan()
        {
            Console.WriteLine("==Kelipatan==");
            Console.Write("Isi angka dari 1 - 50, kelipatan 3 atau 5 :");
            string isi = "";
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if (N <= 50 && N > 0)
            {
                if (N % 3 == 0) isi = "ANTER";
                if (N % 5 == 0) isi += "AJA";
                if (isi == "") Console.WriteLine("isi angka kelipatan 3 atau 5");
                else Console.WriteLine(isi);
            }
            else Console.WriteLine("data invalid");

            Console.WriteLine("====");
            Console.WriteLine("");
            mulai();
        }

        static void Palindrom()
        {
            Console.WriteLine("==Palindrom==");
            Console.Write("Kalimat palindrom :");
            string isi = Convert.ToString(Console.ReadLine().Trim());
            Console.WriteLine(isPalindrom(isi));
            Console.WriteLine("====");
            Console.WriteLine("");
            mulai();
        }

        public static bool isPalindrom(string isiString)
        {
            string pertama = isiString.Substring(0, isiString.Length / 2);
            char[] arr = isiString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string kedua = temp.Substring(0, temp.Length / 2);
            return pertama.ToLower().Equals(kedua.ToLower());
        }
    }
}
