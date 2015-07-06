using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saobracajna.NET
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
	struct groupSD_VEHICLE_DATA
	{

		/// char[16]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
		public string dateOfFirstRegistration;

		/// int
		public int dateOfFirstRegistrationSize;

		/// char[5]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 5)]
		public string yearOfProduction;

		/// int
		public int yearOfProductionSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string vehicleMake;

		/// int
		public int vehicleMakeSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string vehicleType;

		/// int
		public int vehicleTypeSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string commercialDescription;

		/// int
		public int commercialDescriptionSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string vehicleIDNumber;

		/// int
		public int vehicleIDNumberSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string registrationNumberOfVehicle;

		/// int
		public int registrationNumberOfVehicleSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string maximumNetPower;

		/// int
		public int maximumNetPowerSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string engineCapacity;

		/// int
		public int engineCapacitySize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string typeOfFuel;

		/// int
		public int typeOfFuelSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string powerWeightRatio;

		/// int
		public int powerWeightRatioSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string vehicleMass;

		/// int
		public int vehicleMassSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string maximumPermissibleLadenMass;

		/// int
		public int maximumPermissibleLadenMassSize;

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string typeApprovalNumber;

		/// int
		public int typeApprovalNumberSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string numberOfSeats;

		/// int
		public int numberOfSeatsSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string numberOfStandingPlaces;

		/// int
		public int numberOfStandingPlacesSize;

		/// char[100]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 100)]
		public string engineIDNumber;

		/// int
		public int engineIDNumberSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string numberOfAxles;

		/// int
		public int numberOfAxlesSize;

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string vehicleCategory;

		/// int
		public int vehicleCategorySize;

		/// char[50]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 50)]
		public string colourOfVehicle;

		/// int
		public int colourOfVehicleSize;

		/// char[200]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 200)]
		public string restrictionToChangeOwner;

		/// int
		public int restrictionToChangeOwnerSize;

		/// char[20]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
		public string vehicleLoad;

		/// int
		public int vehicleLoadSize;
	}
}
