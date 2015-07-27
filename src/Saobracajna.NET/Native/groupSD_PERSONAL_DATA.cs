using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET.Native
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
	struct groupSD_PERSONAL_DATA
	{
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string ownersPersonalNo;

		/// int
		public int ownersPersonalNoSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string ownersSurnameOrBusinessName;

		/// int
		public int ownersSurnameOrBusinessNameSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string ownerName;

		/// int
		public int ownerNameSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 200)]
		public string ownerAddress;

		/// int
		public int ownerAddressSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string usersPersonalNo;

		/// int
		public int usersPersonalNoSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string usersSurnameOrBusinessName;

		/// int
		public int usersSurnameOrBusinessNameSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string usersName;

		/// int
		public int usersNameSize;

		
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 200)]
		public string usersAddress;

		/// int
		public int usersAddressSize;
	}

}
