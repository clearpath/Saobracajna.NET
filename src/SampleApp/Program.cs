using System;
using SaobracajnaNET;

namespace SampleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var readers = SaobracajnaReader.GetAllReaders();
			if (readers.Count == 0)
			{
				Console.WriteLine("Nema povezanih citaca.");
				Console.Read();
				return;
			}

			Console.WriteLine("Odaberite citac <0>:");
			for (int i = 0; i < readers.Count; i++)
				Console.WriteLine("{0}) {1}", i, readers[i].BestGuessString);

			ReaderDescriptor descriptor;
			while (true)
			{
				var key = Console.ReadKey();
				if (key.Key == ConsoleKey.Enter)
				{
					descriptor = readers[0];
					break;
				}

				
				var index = (int)key.KeyChar - (int)'0';
				if (index >= 0 && index < readers.Count)
				{
					descriptor = readers[index];
					break;
				}
			}

			Console.WriteLine();
			Console.WriteLine("Odabrani citac je:");
			Console.WriteLine(descriptor.BestGuessString);
			Console.WriteLine();

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
						var data = SaobracajnaReader.ReadAll(descriptor);
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
