// K-B 20202

using UnrealBuildTool;
using System.Collections.Generic;

public class CombatGameEditorTarget : TargetRules
{
	public CombatGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "CombatGame" } );
	}
}
