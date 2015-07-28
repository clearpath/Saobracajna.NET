using SaobracajnaNET.Native;

namespace SaobracajnaNET
{
	public struct VehicleData
	{
		public string DateOfFirstRegistration;
		public string YearOfProduction;
		public string VehicleMake;
		public string VehicleType;
		public string CommercialDescription;
		public string VehicleIDNumber;
		public string RegistrationNumberOfVehicle;
		public string MaximumNetPower;
		public string EngineCapacity;
		public string TypeOfFuel;
		public string PowerWeightRatio;
		public string VehicleMass;
		public string MaximumPermissibleLadenMass;
		public string TypeApprovalNumber;
		public string NumberOfSeats;
		public string NumberOfStandingPlaces;
		public string EngineIDNumber;
		public string NumberOfAxles;
		public string VehicleCategory;
		public string ColourOfVehicle;
		public string RestrictionToChangeOwner;
		public string VehicleLoad;

		internal static VehicleData Transcribe(groupSD_VEHICLE_DATA nativeData)
		{
			var result = new VehicleData(); ;

			result.DateOfFirstRegistration = nativeData.dateOfFirstRegistration;
			result.YearOfProduction = nativeData.yearOfProduction;
			result.VehicleMake = nativeData.vehicleMake;
			result.VehicleType = nativeData.vehicleType;
			result.CommercialDescription = nativeData.commercialDescription;
			result.VehicleIDNumber = nativeData.vehicleIDNumber;
			result.RegistrationNumberOfVehicle = nativeData.registrationNumberOfVehicle;
			result.MaximumNetPower = nativeData.maximumNetPower;
			result.EngineCapacity = nativeData.engineCapacity;
			result.TypeOfFuel = nativeData.typeOfFuel;
			result.PowerWeightRatio = nativeData.powerWeightRatio;
			result.VehicleMass = nativeData.vehicleMass;
			result.MaximumPermissibleLadenMass = nativeData.maximumPermissibleLadenMass;
			result.TypeApprovalNumber = nativeData.typeApprovalNumber;
			result.NumberOfSeats = nativeData.numberOfSeats;
			result.NumberOfStandingPlaces = nativeData.numberOfStandingPlaces;
			result.EngineIDNumber = nativeData.engineIDNumber;
			result.NumberOfAxles = nativeData.numberOfAxles;
			result.VehicleCategory = nativeData.vehicleCategory;
			result.ColourOfVehicle = nativeData.colourOfVehicle;
			result.RestrictionToChangeOwner = nativeData.restrictionToChangeOwner;
			result.VehicleLoad = nativeData.vehicleLoad;

			return result;
		}
	}
}
