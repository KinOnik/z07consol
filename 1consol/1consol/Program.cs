using System;
using System.Text;


namespace _1consol
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("\n\tВведите строку: ");
			StringBuilder a = new StringBuilder(Console.ReadLine());
			Console.Write("\n\tКакой символ удалить: ");
			char buf = Console.ReadKey().KeyChar;

			a.Replace(buf.ToString().ToLower(), "");
			a.Replace(buf.ToString().ToUpper(), "");
			Console.Write($"\n\nИзмененная строка: {a}\n\n");
		}
	}
}
