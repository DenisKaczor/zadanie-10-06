using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("wprowadź x: ");
			double x = Double.Parse(Console.ReadLine());
			Console.WriteLine("wprowadź n by sprawdzić czy jest silnią X: ");
			double n = Double.Parse(Console.ReadLine());
			if(liczSilnia(n)==x)
			{
				Console.WriteLine(n);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Liczba x nie jest silnią liczby n");
				Console.ReadKey();
			}
		}
		public static double liczSilnia(double n)
		{
			double nSilnia = 1;
			for (int i = 1; i <= n; i++)
			{
				nSilnia = nSilnia * i;
			}
			return nSilnia;

		}
	}
}
