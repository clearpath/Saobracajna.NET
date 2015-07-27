using System.Runtime.InteropServices;

namespace SaobracajnaNET.Native
{
	static class NativeMethods
	{
		private const string DLL = "eVehicleRegistrationAPI.dll";

		/// Return Type: int
		///apiVersion: int
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdStartup", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdStartup(int apiVersion);


		/// Return Type: int
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdCleanup", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdCleanup();


		/// Return Type: int
		///index: int
		///readerName: char*
		///nameSize: int*
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "GetReaderName", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetReaderName(int index, byte[] readerName, ref int nameSize);


		/// Return Type: int
		///readerName: char*
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "SelectReader", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SelectReader(byte[] readerName);


		/// Return Type: int
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdProcessNewCard", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdProcessNewCard();


		/// Return Type: int
		///param0: SD_REGISTRATION_DATA*
		///index: int
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdReadRegistration", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdReadRegistration(ref groupSD_REGISTRATION_DATA param0, int index);


		/// Return Type: int
		///param0: SD_DOCUMENT_DATA*
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdReadDocumentData", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdReadDocumentData(ref groupSD_DOCUMENT_DATA param0);


		/// Return Type: int
		///param0: SD_VEHICLE_DATA*
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdReadVehicleData", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdReadVehicleData(ref groupSD_VEHICLE_DATA param0);


		/// Return Type: int
		///param0: SD_PERSONAL_DATA*
		[System.Runtime.InteropServices.DllImportAttribute(DLL, EntryPoint = "sdReadPersonalData", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint sdReadPersonalData(ref groupSD_PERSONAL_DATA param0);
	}

}