using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaNET
{
	class SaobracajnaReader
	{
		private void ReadAll()
		{
			NativeMethods.sdStartup(0);



			var nativeResult = NativeMethods.sdCleanup();
		}
	}
}
