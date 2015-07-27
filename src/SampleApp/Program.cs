using System;
using SaobracajnaNET;

namespace SampleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine(
@"Za citanje saobracajne dozvole pritisnite bilo koji taster. 
Za kraj rada pritisnite taster 'K'.");

				var key = Console.ReadKey();
				if (key.Key != ConsoleKey.K)
				{
					try
					{
						var data = SaobracajnaReader.ReadAll();
						PrintData(data);
					}
					catch (Exception e)
					{
						Console.WriteLine(e);
					}
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
