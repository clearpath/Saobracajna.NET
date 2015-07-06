using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET.Native
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
	struct groupSD_REGISTRATION_DATA
	{

		/// char[4096]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4096)]
		public string registrationData;

		/// int
		public int registrationDataSize;

		/// char[1024]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string signatureData;

		/// int
		public int signatureDataSize;

		/// char[4096]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4096)]
		public string issuingAuthority;

		/// int
		public int issuingAuthoritySize;
	}
}
