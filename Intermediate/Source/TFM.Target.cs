using UnrealBuildTool;

public class TFMTarget : TargetRules
{
	public TFMTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TFM");
	}
}
