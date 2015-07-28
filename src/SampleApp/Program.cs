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
			PrintStruct(data.VehicleData);
			PrintStruct(data.DocumentData);
			PrintStruct(data.PersonalData);
			Console.WriteLine("{0} pieces of RegistrationData", data.RegistrationData.Count);
		}

		private static void PrintStruct(object instance)
		{
			var type = instance.GetType();
		
			var fields = type.GetFields();
			foreach (var field in fields)
			{
				var value = field.GetValue(instance);

				Console.WriteLine("{0}: {1}", type.Name + "." + field.Name, value);
			}
		}
	}
}
