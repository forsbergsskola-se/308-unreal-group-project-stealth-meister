// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ArtOfThievery : ModuleRules
{
	public ArtOfThievery(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
