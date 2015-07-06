using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaobracajnaNET;

namespace SampleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Za citanje saobracane dozvole pritisnite taster Enter. Pritisnite bilo koji drugi taster za kraj rada.");
				var key = Console.ReadKey();
				if (key.Key == ConsoleKey.Enter)
				{
					var data = SaobracajnaReader.ReadAll();
					PrintData(data);
				}
				else
				{
					break;
				}
			}
		}

		private static void PrintData(AllData data)
		{
			Console.WriteLine(data.DocumentData.AuthorityIssuing);
		}
	}
}
