using SaobracajnaNET.Native;
using System;
using System.Diagnostics;
using System.Linq;

namespace SaobracajnaNET
{
	public class SaobracajnaReader
	{
		private AllData ReadAll()
		{
			var nativeResult = NativeMethods.sdStartup(0);
			CheckNativeResult(nativeResult);

			try
			{
				int nameSize = 0;
				IntPtr readerName = IntPtr.Zero;
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
		}

		private void CheckNativeResult(int nativeResult)
		{
			if (nativeResult == ErrorCodes.SD_OK)
				return;

			var errorMessage = GetErrorMessage(nativeResult);

			throw new SaobracajnaNETException(errorMessage);
		}

		private static string GetErrorMessage(int nativeResult)
		{
			var errorFields = typeof(ErrorCodes).GetFields();
			var foundField = errorFields
				.Select(x => new { Name = x.Name, Code = (int)x.GetValue(null) })
				.FirstOrDefault(x => x.Code == nativeResult);

			if (foundField != null)
			{
				return foundField.Name;
			}

			return nativeResult.ToString();
		}
	}
}
