using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saobracajna.NET
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
	struct groupSD_PERSONAL_DATA
	{

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string ownersPersonalNo;

		/// int
		public int ownersPersonalNoSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string ownersSurnameOrBusinessName;

		/// int
		public int ownersSurnameOrBusinessNameSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string ownerName;

		/// int
		public int ownerNameSize;

		/// char[200]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 200)]
		public string ownerAddress;

		/// int
		public int ownerAddressSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string usersPersonalNo;

		/// int
		public int usersPersonalNoSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string usersSurnameOrBusinessName;

		/// int
		public int usersSurnameOrBusinessNameSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string usersName;

		/// int
		public int usersNameSize;

		/// char[200]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 200)]
		public string usersAddress;

		/// int
		public int usersAddressSize;
	}

}
