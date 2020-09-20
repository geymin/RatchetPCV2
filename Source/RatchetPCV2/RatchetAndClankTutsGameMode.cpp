// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

#include "RatchetAndClankTuts.h"
#include "RatchetAndClankTutsGameMode.h"
#include "RatchetAndClankTutsCharacter.h"

ARatchetAndClankTutsGameMode::ARatchetAndClankTutsGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
