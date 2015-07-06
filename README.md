# Saobracajna.NET

Saobracajna.NET je .NET wrapper za eVehicleRegistrationAPI biblioteku MUP-a Republike Srbije.

Nastao je da bi se izbegao rad sa COM komponentom, kako je inace predvidjeno da se koristi iz .NET-a, sto olaksava kasniji deployment aplikacije koja iscitava dozvole.

Win32 .dll i prateci fajlovi su preuzeti sa sajta MUP-a u julu 2015.

Krajnjem korisniku je potrebno isporuciti pored .NET wrapper-a i eVehicleRegistrationAPI.dll tj obezbediti da se eVehicleRegistrationAPI.dll nalazi pored .exe fajla.

C# kod za pozivanje funkcija iz Win32 biblioteke je generisan uz pomoc alata [*P/Invoke Interop Assistant*](http://blogs.microsoft.co.il/sasha/2008/01/12/pinvoke-signature-generator/).