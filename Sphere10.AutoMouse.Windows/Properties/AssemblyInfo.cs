using Hydrogen.Application;
using System.Reflection;
using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("EC221BB7-1AD9-45E6-BC3B-307C8F39CA0D")]


[assembly: AssemblyCopyright("Copyright © Sphere 10 Software 2008 - {CurrentYear}")]
[assembly: AssemblyProductDistribution(ProductDistribution.ReleaseCandidate)]
[assembly: AssemblyCompanyNumber("ABN 39600596316")]
[assembly: AssemblyCompanyLink("https://sphere10.com")]
[assembly: AssemblyProductCode("2fbd6040-dece-45df-9f7a-7d2b562141ad")]
[assembly: AssemblyProductLink("https://sphere10.com/products/automouse")]
[assembly: AssemblyProductPurchaseLink("https://sphere10.com/products/automouse")]
[assembly: AssemblyProductHelpCHM("{StartPath}/AutoMouse.CHM")]
[assembly: AssemblyProductSecret("db7d8cb29fa78c6eb2d6fa268fa0ed4d06f01422adce6a17b355655c3df3f4fc")]
#if DEBUG
[assembly: AssemblyProductDrmApi("http://localhost:5000/api/drm")]
#else
[assembly: AssemblyProductDrmApi("https://sphere10.com/api/drm")]
#endif
[assembly: AssemblyProductLicense(
	"""
	{
	  "authority": {
	    "name": "Sphere 10 Software General Software Products",
	    "dss": "ecdsa-secp256k1",
	    "publicKey": "A0xL8HSZ7Cl9IYUx92/e34NPhYZHkQEaWcyU2BuJx/2T"
	  },
	  "license": {
	    "Item": {
	      "name": "Auto Mouse v1 Trial",
	      "productKey": "0000-0000-0000-0003",
	      "productCode": "2fbd6040-dece-45df-9f7a-7d2b562141ad",
	      "featureLevel": "free",
	      "expirationPolicy": "disable",
	      "majorVersionApplicable": 1,
	      "expirationDays": 30
	    },
	    "Signature": "MEQCICyNYvrMQD0aZUpZdQKskiV+PbQGB530pVbLscNTIrg8AiAVO7hs7WkBt4wVCX52mBj/TY+p/67INJiLCwE7dm0lug=="
	  },
	  "command": {
	    "Item": {
	      "productKey": "0000-0000-0000-0003",
	      "action": "enable"
	    },
	    "Signature": "MEQCIHcZcf+8MvivmZF/TTKDQt1v6dz/pscQNfrJ/OOqyop+AiBkLBj5ugambukYjCFa3EbdZPUuMqXtD2Bwe+My/x4wjQ=="
	  }
	}
	""")]
