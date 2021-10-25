using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int x = rand.Next(100, 1000);

			int n = 0;

			while (n != x)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("Введите число");
				int.TryParse(Console.ReadLine(), out n);

				if (n > x)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Много. Попробуйте ещё раз");
				}

				else if (n < x)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Мало. Попробуйте ещё раз");
				}

				else
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Угадал");

				}
			}
		}
	}
}
