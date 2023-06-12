using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj liczby naturalne");
			double n = Convert.ToDouble(Console.ReadLine());
			double k = Convert.ToDouble(Console.ReadLine());
			double nSilnia = 1;
			double kSilnia = 1;
			while (n < 0 | n % 1 != 0)
			{
				Console.WriteLine("Podaj liczbę naturalną dla n");
				n = Convert.ToDouble(Console.ReadLine());
			}
			while (k < 0 | k % 1 != 0)
			{
				Console.WriteLine("Podaj liczbę naturalną dla k");
				k = Convert.ToDouble(Console.ReadLine());
			}

			for(int i = 2; i <= n; i++)
			{
				nSilnia = nSilnia * i;

			}
			for (int i = 2; i <= k; i++)
			{
				kSilnia = kSilnia * i; 

			}
			Console.WriteLine("m jest równe: " +(nSilnia-kSilnia)/kSilnia);
			Console.ReadKey();
		}
	}
}
