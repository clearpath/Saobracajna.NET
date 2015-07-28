# Saobracajna.NET

Saobracajna.NET je .NET wrapper za eVehicleRegistrationAPI biblioteku MUP-a Republike Srbije. Predvidjeni nacin rada iz .NET-a sa tom bibliotekom je putem COM komponente. 
Ovaj wrapper je napravljen da bi se to izbeglo.

## Upotreba

Jednostavan nacin rada:

```csharp
var data = SaobracajnaReader.ReadAll();
Console.WriteLine(data.VehicleData.VehicleMake);
```

Napredni nacin rada:

```csharp
using (var advancedReader = new AdvancedReader())
{
	var readerDescriptor = advancedReader.GetReaderDescriptor(0);
	advancedReader.SelectReader(readerDescriptor);
	advancedReader.ProcessNewCard();
	
	var vehicleData = advancedReader.ReadVehicleData();

	Console.WriteLine(vehicleData.VehicleMake);
}
```



## Deployment

Krajnjem korisniku je potrebno isporuciti i .NET wrapper i eVehicleRegistrationAPI.dll, tj. potrebno je obezbediti da se eVehicleRegistrationAPI.dll nalazi pored .exe fajla.

## Aktuelna verzija je 0.9
Kod je testiran na jednom racunaru, sa jednim citacem i jednom saobracajnom dozvolom, tako da sa pravom poseduje sertifikat 'Works on my machine'.

## Napomene
C# kod za pozivanje funkcija iz Win32 biblioteke je generisan uz pomoc alata [*P/Invoke Interop Assistant*](http://blogs.microsoft.co.il/sasha/2008/01/12/pinvoke-signature-generator/) i donekle doradjen.
Neki trikovi preuzeti su iz [*Celik.NET*](http://www.elitesecurity.org/t415641-CelikNET-LGPL-CLR-Interop-Wrapper-za-CelikAPI) biblioteke.
