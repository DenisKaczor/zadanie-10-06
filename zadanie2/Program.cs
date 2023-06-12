using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt16(Console.ReadLine());
			int a = 0;
			int b = 1;
			int i = 3;
			if(n==0)
			{
				Console.WriteLine("brak wartości");
			}
			else if(n==1)
			{
				Console.WriteLine(a);
			}
			else if (n==2)
			{
				Console.WriteLine(a);
				Console.WriteLine(b);
			}
			else
			{
				Console.WriteLine(a);
				Console.WriteLine(b);
				while(i<=n)
				{
					int c = a + b;
					Console.WriteLine(c);
					i++;
					if(i<=n)
					{
						a = b + c;
						Console.WriteLine(a);
						i++;
						if(i <= n)
						{
							b = a + c;
							Console.WriteLine(b);
							i++;
						}
					}	
					
					

				}
			}
			
			Console.ReadKey();

		}
	}
}
