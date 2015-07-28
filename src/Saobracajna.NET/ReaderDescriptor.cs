using System.Text;

namespace SaobracajnaNET
{
	public struct ReaderDescriptor
	{
		public byte[] Identifier;

		public string BestGuessString
		{
			get { return Encoding.ASCII.GetString(Identifier); }

		}
	}
}
