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

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string stateIssuing;

		/// int
		public int stateIssuingSize;

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string competentAuthority;

		/// int
		public int competentAuthoritySize;

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string authorityIssuing;

		/// int
		public int authorityIssuingSize;

		/// char[30]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 30)]
		public string unambiguousNumber;

		/// int
		public int unambiguousNumberSize;

		/// char[16]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
		public string issuingDate;

		/// int
		public int issuingDateSize;

		/// char[16]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
		public string expiryDate;

		/// int
		public int expiryDateSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string serialNumber;

		/// int
		public int serialNumberSize;
	}
}
