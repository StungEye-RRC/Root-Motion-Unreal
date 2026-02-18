// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ThirdPersonCpp : ModuleRules
{
	public ThirdPersonCpp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ThirdPersonCpp",
			"ThirdPersonCpp/Variant_Platforming",
			"ThirdPersonCpp/Variant_Platforming/Animation",
			"ThirdPersonCpp/Variant_Combat",
			"ThirdPersonCpp/Variant_Combat/AI",
			"ThirdPersonCpp/Variant_Combat/Animation",
			"ThirdPersonCpp/Variant_Combat/Gameplay",
			"ThirdPersonCpp/Variant_Combat/Interfaces",
			"ThirdPersonCpp/Variant_Combat/UI",
			"ThirdPersonCpp/Variant_SideScrolling",
			"ThirdPersonCpp/Variant_SideScrolling/AI",
			"ThirdPersonCpp/Variant_SideScrolling/Gameplay",
			"ThirdPersonCpp/Variant_SideScrolling/Interfaces",
			"ThirdPersonCpp/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
