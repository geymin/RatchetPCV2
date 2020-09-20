// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RatchetPCV2EditorTarget : TargetRules
{
	public RatchetPCV2EditorTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Editor;

        ExtraModuleNames.Add("RatchetAndClankTuts");
    }
}
