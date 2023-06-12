using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wymyśle cyfrę od 1 do 20 a ja ją odgadnę");
			int większa = 20;
			int mniejsza = 1;
			int x = losowanie(mniejsza, większa);
			Console.ReadKey();
			Console.WriteLine("czy twoja liczba to " + x);
			int i = int.Parse(Console.ReadLine());
			while(i!=0)
			{ 
				if (i > 0)
				{
					mniejsza = x+1;
					x = losowanie(mniejsza, większa);
					Console.WriteLine("czy twoja liczba to " + x);
					i = int.Parse(Console.ReadLine());
				}
				else if(i<0)
				{
					większa = x-1;
					x = losowanie(mniejsza,większa);
					Console.WriteLine("czy twoja liczba to " + x);
					i = int.Parse(Console.ReadLine());
				}
				else
				{
					break;
				}
			}
			Console.WriteLine("Znalazłem twoją liczbę. Jest ona równa: " + x);
			Console.ReadKey();

		}
		static int losowanie(int poczatek, int koniec)
		{
			Random rnd = new Random();
			int wylosowana = rnd.Next(poczatek, koniec);
			return wylosowana;
		}
	}
}
