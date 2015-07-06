﻿namespace Saobracajna.NET
{
	static class NativeMethods
	{
		/// Return Type: int
		///apiVersion: int
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdStartup")]
		public static extern int sdStartup(int apiVersion);


		/// Return Type: int
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdCleanup")]
		public static extern int sdCleanup();


		/// Return Type: int
		///index: int
		///readerName: char*
		///nameSize: int*
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "GetReaderName")]
		public static extern int GetReaderName(int index, System.IntPtr readerName, ref int nameSize);


		/// Return Type: int
		///readerName: char*
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "SelectReader")]
		public static extern int SelectReader(System.IntPtr readerName);


		/// Return Type: int
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdProcessNewCard")]
		public static extern int sdProcessNewCard();


		/// Return Type: int
		///param0: SD_REGISTRATION_DATA*
		///index: int
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdReadRegistration")]
		public static extern int sdReadRegistration(ref groupSD_REGISTRATION_DATA param0, int index);


		/// Return Type: int
		///param0: SD_DOCUMENT_DATA*
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdReadDocumentData")]
		public static extern int sdReadDocumentData(ref groupSD_DOCUMENT_DATA param0);


		/// Return Type: int
		///param0: SD_VEHICLE_DATA*
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdReadVehicleData")]
		public static extern int sdReadVehicleData(ref groupSD_VEHICLE_DATA param0);


		/// Return Type: int
		///param0: SD_PERSONAL_DATA*
		[System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "sdReadPersonalData")]
		public static extern int sdReadPersonalData(ref groupSD_PERSONAL_DATA param0);
	}

}