#if VRC_SDK_VRCSDK3
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VRC.Udon;

namespace VitDeck.Exporter.Addons.VRCSDK3
{
    public class LinkedUdonManager
    {
        private const string _udonProgramBasePath = "Assets/SerializedUdonPrograms/";
        public static string[] GetLinkedAssetPaths()
        {
            var paths = new List<string>();
            var udonBehaviours = Resources.FindObjectsOfTypeAll<UdonBehaviour>();
            foreach (var udonBehaviour in udonBehaviours)
            {
                if (udonBehaviour.programSource == null) continue;
                var programName = udonBehaviour.programSource.SerializedProgramAsset.name;
                var assetPath = _udonProgramBasePath + programName + ".asset";
                var guid = AssetDatabase.AssetPathToGUID(assetPath);
                if (guid != null && Array.IndexOf(_excludeGUIDs, guid) == -1)
                {
                    paths.Add(assetPath);
                }
            }
            return paths.ToArray();
        }

        private static readonly string[] _excludeGUIDs = new[]
        {
            "2f916e008aa8f294c991c22b42ea5944",  // 73398b290b7c5ec43a2e158bfc1c45db Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/Scripts/AutoResetPickup.asset
            "2595ee2141e0fc4408caf75680ef9eb5",  // 0d2cf2386895ff5499a1660a4327ad75 Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Scripts/AvatarPedestal.asset
            "cb458453c6b8c4a4884ba5d3b2f9de56",  // 6ea1e8fa7533f9647996810212fa976e Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Scripts/CirclePageOpener.asset
            "4c879ab359f0cc54984884027c8a015e",  // fe9c6cf6073f2514e82259a4142d6932 Assets/VitDeck/Templates/07_UC/SharedAssets/UC_WorldSetting.asset
            "07ddc9396861b7c4cad40254456b1f9b",  // 6280669e97dfe384988401d2c650a08f Assets/VitDeck/Templates/G00_Gamv0/SharedAssets/UdonScript/WorldSetting(Gamv0).asset
            "f7ce97192c1898c47a87f949b891d91f",  // 414a471b5fafc3246a7c33b2ae29f2b9 Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayer.prefab
            "5a528a40ac7004845bcc072f255cd626",  // 6abc392e5dd9c1848b09205e404a5adf Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayerMaster.prefab
        };
    }
}
#endif
