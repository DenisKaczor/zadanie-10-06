using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
	internal class Program
	{
		static void Main(string[] args)
			{
				Console.WriteLine("Wprowadż kwotę");
				decimal k = decimal.Parse(Console.ReadLine());
				Console.WriteLine("Wprowadż oprocentowanie w skali roku");
				decimal p = decimal.Parse(Console.ReadLine());
				Console.WriteLine("Wprowadż liczbę miesięcy oszczędzania");
				int l = int.Parse(Console.ReadLine());
				decimal procent = p / 12 / 100;
				decimal zarobek = k * (decimal)Math.Pow(1 + (double)procent, l);
				decimal podatek = 0.19m * (zarobek - k);
				decimal fz = zarobek - podatek - k;
				Console.WriteLine("Kwota zarobiona wynosi: " + fz +"zł");
				Console.ReadKey();

			}

		}
}
