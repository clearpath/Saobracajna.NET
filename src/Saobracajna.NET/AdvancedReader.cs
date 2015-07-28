using SaobracajnaNET.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace SaobracajnaNET
{
	public class AdvancedReader : IDisposable
	{
		public AdvancedReader()
		{
			var nativeResult = NativeMethods.sdStartup(1);
			CheckNativeResult(nativeResult);
		}

		public ReaderDescriptor GetReaderDescriptor(int index)
		{
			int nameSize = 10000;
			byte[] readerName = new byte[nameSize];
			var nativeResult = NativeMethods.GetReaderName(index, readerName, ref nameSize);
			CheckNativeResult(nativeResult);

			return new ReaderDescriptor
			{
				Identifier = readerName.Take(nameSize).ToArray()
			};
		}

		public List<ReaderDescriptor> GetAllReaders()
		{
			var result = new List<ReaderDescriptor>();

			int index = 0;
			while (true)
			{
				try
				{
					var descriptor = GetReaderDescriptor(index);
					result.Add(descriptor);

					index++;
				}
				catch (SaobracajnaNETException e)
				{
					if (e.ErrorCode == ScardError.SCARD_E_UNKNOWN_READER)
						break;

					throw;
				}
			}

			return result;
		}

		public void SelectReader(ReaderDescriptor descriptor)
		{
			var nativeResult = NativeMethods.SelectReader(descriptor.Identifier);
			CheckNativeResult(nativeResult);
		}

		public void ProcessNewCard()
		{
			var nativeResult = NativeMethods.sdProcessNewCard();
			CheckNativeResult(nativeResult);
		}

		public VehicleData ReadVehicleData()
		{
			var nativeVehicleData = new groupSD_VEHICLE_DATA();
			var nativeResult = NativeMethods.sdReadVehicleData(ref nativeVehicleData);
			CheckNativeResult(nativeResult);

			var result = VehicleData.Transcribe(nativeVehicleData);

			return result;
		}

		public DocumentData ReadDocumentData()
		{
			var nativeDocumentData = new groupSD_DOCUMENT_DATA();
			var nativeResult = NativeMethods.sdReadDocumentData(ref nativeDocumentData);
			CheckNativeResult(nativeResult);

			var result = DocumentData.Transcribe(nativeDocumentData);

			return result;
		}

		public PersonalData ReadPersonalData()
		{
			var nativePersonalData = new groupSD_PERSONAL_DATA();
			var nativeResult = NativeMethods.sdReadPersonalData(ref nativePersonalData);
			CheckNativeResult(nativeResult);

			var result = PersonalData.Transcribe(nativePersonalData);

			return result;
		}


		/// <param name="index">od 1 do 3</param>
		public RegistrationData ReadRegistrationData(int index)
		{
			var nativeRegistrationData = new groupSD_REGISTRATION_DATA();
			var nativeResult = NativeMethods.sdReadRegistration(ref nativeRegistrationData, index);
			CheckNativeResult(nativeResult);

			var result = RegistrationData.Transcribe(nativeRegistrationData);

			return result;
		}

		static void CheckNativeResult(uint nativeResult)
		{
			if (nativeResult == ErrorCodes.SD_OK)
				return;

			var message = GetErrorMessage(nativeResult);

			throw new SaobracajnaNETException(message, nativeResult);
		}

		private static string GetErrorMessage(uint errorCode)
		{
			string result = "Unrecognized error code: " + errorCode;

			var errorFields = typeof(ErrorCodes).GetFields().Union(typeof(ScardError).GetFields());
			var foundField = errorFields
				.Select(x => new { Field = x, Code = (uint)x.GetValue(null) })
				.FirstOrDefault(x => x.Code == errorCode);

			if (foundField != null)
			{
				var attributes = foundField.Field.GetCustomAttributes(typeof(DescriptionAttribute), false);
				if (attributes.Length > 0)
				{
					var descriptionAttribute = (DescriptionAttribute)attributes[0];
					result = string.Format("{0} Error code: {1} ({2})", descriptionAttribute.Description, foundField.Field.Name, errorCode);
				}
				else
				{
					result = string.Format("An error occurred. Error code: {0} ({1})", foundField.Field.Name, errorCode);
				}
			}

			return result;
		}


		private bool disposed;

		public void Dispose()
		{
			if (disposed)
				return;

			var nativeResult = NativeMethods.sdCleanup();
			if (nativeResult != ErrorCodes.SD_OK)
			{
				var errorMessage = GetErrorMessage(nativeResult);
				Debug.Print(errorMessage);
				Trace.TraceError(errorMessage);
			}
		}
	}
}
