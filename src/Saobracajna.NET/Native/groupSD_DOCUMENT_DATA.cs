using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET.Native
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
	struct groupSD_DOCUMENT_DATA
	{

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string stateIssuing;

		/// int
		public int stateIssuingSize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string competentAuthority;

		/// int
		public int competentAuthoritySize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string authorityIssuing;

		/// int
		public int authorityIssuingSize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 30)]
		public string unambiguousNumber;

		/// int
		public int unambiguousNumberSize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
		public string issuingDate;

		/// int
		public int issuingDateSize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
		public string expiryDate;

		/// int
		public int expiryDateSize;

		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string serialNumber;

		/// int
		public int serialNumberSize;
	}
}
