using SaobracajnaNET.Native;

namespace SaobracajnaNET
{
	public struct PersonalData
	{
		public string OwnersPersonalNo;
		public string OwnersSurnameOrBusinessName;
		public string OwnerName;
		public string OwnerAddress;
		public string UsersPersonalNo;
		public string UsersSurnameOrBusinessName;
		public string UsersName;
		public string UsersAddress;

		internal static PersonalData Transcribe(groupSD_PERSONAL_DATA nativeData)
		{
			var result = new PersonalData();

			result.OwnersPersonalNo = nativeData.ownersPersonalNo;
			result.OwnersSurnameOrBusinessName = nativeData.ownersSurnameOrBusinessName;
			result.OwnerName = nativeData.ownerName;
			result.OwnerAddress = nativeData.ownerAddress;
			result.UsersPersonalNo = nativeData.usersPersonalNo;
			result.UsersSurnameOrBusinessName = nativeData.usersSurnameOrBusinessName;
			result.UsersName = nativeData.usersName;
			result.UsersAddress = nativeData.usersAddress;
			
			return result;
		}
	}
}
