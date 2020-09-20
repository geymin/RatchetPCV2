// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RatchetPCV2Target : TargetRules
{
    public RatchetPCV2Target(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        ExtraModuleNames.Add("RatchetAndClankTuts");
    }
}
