using System.Collections.Generic;

namespace SaobracajnaNET
{
	public static class SaobracajnaReader
	{
		public static List<ReaderDescriptor> GetAllReaders()
		{
			using (var advancedReader = new AdvancedReader())
				return advancedReader.GetAllReaders();
		}

		public static AllData ReadAll()
		{
			var readers = GetAllReaders();
			if (readers.Count > 0)
			{
				return ReadAll(readers[0]);
			}

			return new AllData();
		}

		public static AllData ReadAll(ReaderDescriptor readerDescriptor, bool readRegistrationData = false)
		{
			using (var advancedReader = new AdvancedReader())
			{
				advancedReader.SelectReader(readerDescriptor);
				advancedReader.ProcessNewCard();

				var result = new AllData();

				result.VehicleData = advancedReader.ReadVehicleData();
				result.DocumentData = advancedReader.ReadDocumentData();
				result.PersonalData = advancedReader.ReadPersonalData();

				result.RegistrationData = new List<RegistrationData>();
				if (readRegistrationData)
				{
					for (int i = 1; i <= 3; i++)
					{
						var registrationData = advancedReader.ReadRegistrationData(i);
						result.RegistrationData.Add(registrationData);
					}	
				}

				return result;
			}
		}
	}
}
