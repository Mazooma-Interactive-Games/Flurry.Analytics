using System;

#if __UNIFIED__
using Foundation;
using ObjCRuntime;
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
#endif

[assembly: LinkerSafe]
	
[assembly: LinkWith (
	"libFlurry_7.2.1.a",
    LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s,
	ForceLoad = true, 
	SmartLink = true,
	Frameworks = "SystemConfiguration Security")]
