using SaobracajnaNET.Native;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace SaobracajnaNET
{
	public class SaobracajnaReader
	{
		public static AllData ReadAll()
		{
			var nativeResult = NativeMethods.sdStartup(1);
			CheckNativeResult(nativeResult);

			try
			{
				int nameSize = 10000;
				byte[] readerName = new byte[nameSize];
				nativeResult = NativeMethods.GetReaderName(0, readerName, ref nameSize);
				CheckNativeResult(nativeResult);

				nativeResult = NativeMethods.SelectReader(readerName);
				CheckNativeResult(nativeResult);

				nativeResult = NativeMethods.sdProcessNewCard();
				CheckNativeResult(nativeResult);


				var result = new AllData();

				var nativeDocumentData = new groupSD_DOCUMENT_DATA();
				nativeResult = NativeMethods.sdReadDocumentData(ref nativeDocumentData);
				CheckNativeResult(nativeResult);

				result.DocumentData = DocumentData.Transcribe(nativeDocumentData);

				return result;
			}
			finally
			{
				nativeResult = NativeMethods.sdCleanup();
				if (nativeResult != ErrorCodes.SD_OK)
				{
					var errorMessage = GetErrorMessage(nativeResult);
					Debug.Print(errorMessage);
				}
			}

			return new AllData();
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

			var errorFields = typeof(ErrorCodes).GetFields();
			var foundField = errorFields
				.Select(x => new { Field = x, Code = (uint)x.GetValue(null) })
				.FirstOrDefault(x => x.Code == errorCode);

			if (foundField != null)
			{
				result = string.Format("An error occurred. Error code: {0}({1})", foundField.Field.Name, errorCode);
			}
			else
			{
				errorFields = typeof(ScardError).GetFields();
				foundField = errorFields
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
						result = string.Format("An error occurred. Error code: {0}({1})", foundField.Field.Name, errorCode);
					}
				}
			}

			return result;
		}

	}
}
