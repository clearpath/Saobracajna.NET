using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET.Native
{
	static class ErrorCodes
	{
		public const int SD_OK = 0;
		public const int ERROR_BAD_FORMAT = 11;
		public const int ERROR_INVALID_ACCESS = 12;
		public const int ERROR_INVALID_DATA = 13;
		public const int ERROR_INVALID_PARAMETER = 87;
		public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;
		public const int ERROR_SERVICE_NOT_ACTIVE = 1062;
		public const int E_POINTER = unchecked((int)0x80004003);
		public const int SCARD_E_INSUFFICIENT_BUFFER = unchecked((int)0x80100008);
		public const int SCARD_E_UNKNOWN_READER = unchecked((int)0x80100009);
		public const int SCARD_E_NO_SMARTCARD = unchecked((int)0x8010000C);
		public const int SCARD_E_INVALID_VALUE = unchecked((int)0x80100011);
		public const int SCARD_E_READER_UNAVAILABLE = unchecked((int)0x80100017);
		public const int SCARD_E_CARD_UNSUPPORTED = unchecked((int)0x8010001C);
		public const int SCARD_E_NO_READERS_AVAILABLE = unchecked((int)0x8010002E);
	}
}
