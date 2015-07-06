using SaobracajnaNET.Native;

namespace SaobracajnaNET
{
	public struct DocumentData
	{
		public string StateIssuing;
		public string CompetentAuthority;
		public string AuthorityIssuing;
		public string UnambiguousNumber;
		public string IssuingDate;
		public string ExpiryDate;
		public string SerialNumber;

		internal static DocumentData Transcribe(groupSD_DOCUMENT_DATA nativeDocumentData)
		{
			var result = new DocumentData();

			result.AuthorityIssuing = nativeDocumentData.authorityIssuing;
			/*...*/

			return result;
		}
	}
}
