using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saobracajna.NET
{
	class NativeConstants
	{
		/// __eVehicleRegistrationAPI_h__ -> 
		/// Error generating expression: Value cannot be null.
		///Parameter name: node
		public const string @__eVehicleRegistrationAPI_h__ = "";

		/// SD_API -> extern "C" __declspec(dllimport)
		/// Error generating expression: Expression is not parsable.  Treating value as a raw string
		public const string SD_API = "extern \"C\" __declspec(dllimport)";

		/// Warning: Generation of Method Macros is not supported at this time
		/// SD_FIELD -> "(name,length) char	name[length]; 
		///	long	name ## Size"
		public const string SD_FIELD = "(name,length) char\tname[length]; \r\n\tlong\tname ## Size";

		/// SD_REGISDATA_MAX_SIZE -> (4096)
		public const int SD_REGISDATA_MAX_SIZE = 4096;

		/// SD_SIGNATURE_MAX_SIZE -> (1024)
		public const int SD_SIGNATURE_MAX_SIZE = 1024;

		/// SD_AUTHORITY_MAX_SIZE -> (4096)
		public const int SD_AUTHORITY_MAX_SIZE = 4096;
	}

}
