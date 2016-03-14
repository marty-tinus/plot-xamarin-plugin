using ObjCRuntime;

[assembly: LinkWith ("libPlot-v1_14_1_beta.a",
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, 
	SmartLink = true, ForceLoad = true, Frameworks = "MessageUI CoreLocation", LinkerFlags = "-lsqlite3")]

