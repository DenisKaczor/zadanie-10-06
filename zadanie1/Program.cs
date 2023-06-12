using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj liczby naturalne");
			double podstawa = Convert.ToDouble(Console.ReadLine());
			double potega = Convert.ToDouble(Console.ReadLine());
			while (podstawa < 0 | podstawa % 1 != 0)
			{
				Console.WriteLine("Podaj liczbę naturalną dla podstawy");
				podstawa = Convert.ToDouble(Console.ReadLine());
			}
			while (potega < 0 | potega % 1 != 0)
			{
				Console.WriteLine("Podaj liczbę naturalną dla potęgi");
				potega = Convert.ToDouble(Console.ReadLine());
			}
			double wynik = podstawa;
			if (potega == 0)
			{
				Console.WriteLine("1");
				Console.ReadKey();
			}
			else 
			{ 
				for (int i = 1;	i<potega; i++)
				{
					wynik = wynik * podstawa;
				}
				Console.WriteLine(wynik);
				Console.ReadKey();
			}
	}
	}
}
