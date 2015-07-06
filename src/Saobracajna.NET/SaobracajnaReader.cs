using SaobracajnaNET.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET
{
	class SaobracajnaReader
	{
		private void ReadAll()
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
