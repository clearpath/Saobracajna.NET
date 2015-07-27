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
			PrintStruct(data.DocumentData);
		}

		private static void PrintStruct(object instance)
		{
			var type = instance.GetType();
		
			var fields = type.GetFields();
			foreach (var field in fields)
			{
				var value = field.GetValue(instance);

				Console.WriteLine("{0,-20}: {1,-50}", type.Name + "." + field.Name, value);
			}
		}
	}
}
