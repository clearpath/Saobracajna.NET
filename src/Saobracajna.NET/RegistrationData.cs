using SaobracajnaNET.Native;

namespace SaobracajnaNET
{
	public struct RegistrationData
	{
		public string RegistrationInfo;
		public string SignatureData;
		public string IssuingAuthority;

		internal static RegistrationData Transcribe(groupSD_REGISTRATION_DATA nativeData)
		{
			var result = new RegistrationData();

			result.RegistrationInfo = nativeData.registrationData;
			result.SignatureData = nativeData.signatureData;
			result.IssuingAuthority = nativeData.issuingAuthority;
			
			return result;
		}
	}
}
