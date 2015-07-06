using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET.Native
{
	static class ErrorCodes
	{
		public const uint SD_OK = 0;
		public const uint ERROR_BAD_FORMAT = 11;
		public const uint ERROR_INVALID_ACCESS = 12;
		public const uint ERROR_INVALID_DATA = 13;
		public const uint ERROR_INVALID_PARAMETER = 87;
		public const uint ERROR_SERVICE_ALREADY_RUNNING = 1056;
		public const uint ERROR_SERVICE_NOT_ACTIVE = 1062;
		public const uint E_POINTER = 0x80004003;
		public const uint SCARD_E_INSUFFICIENT_BUFFER = 0x80100008;
		public const uint SCARD_E_UNKNOWN_READER = 0x80100009;
		public const uint SCARD_E_NO_SMARTCARD = 0x8010000C;
		public const uint SCARD_E_INVALID_VALUE = 0x80100011;
		public const uint SCARD_E_READER_UNAVAILABLE = 0x80100017;
		public const uint SCARD_E_CARD_UNSUPPORTED = 0x8010001C;
		public const uint SCARD_E_NO_READERS_AVAILABLE = 0x8010002E;
	}
}
