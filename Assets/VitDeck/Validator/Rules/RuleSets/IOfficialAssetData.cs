namespace VitDeck.Validator.RuleSets
{
    public interface IOfficialAssetData
    {
        string[] GUIDs { get; }
        string[] MaterialGUIDs { get; }
        string[] PickupObjectSyncPrefabGUIDs { get; }
        string[] AvatarPedestalPrefabGUIDs { get; }
        string[] UdonBehaviourPrefabGUIDs { get; }
        string[] SizeIgnorePrefabGUIDs { get; }
        string[] AudioSourcePrefabGUIDs { get; }
        string[] CanvasPrefabGUIDs { get; }
        string[] PointLightProbeGUIDs { get; }
        string[] VRCSDKPrefabGUIDs { get; }
    }
}