using System;
using System.Text;

namespace _2consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("\n\tВведите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.Write($"\n\t Искомое слово: ");
            string buffer = Console.ReadLine();

            string[] buf = a.ToString().Split(' ', ',', '.', '!', '?', '-', '\'', '\\', '\"', '*');
            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i].ToLower() == buffer.ToLower())
                    sum++;
            }
            Console.Write($"\n\nКоличество повторений: {sum}\n\n");
        }
    }
}
