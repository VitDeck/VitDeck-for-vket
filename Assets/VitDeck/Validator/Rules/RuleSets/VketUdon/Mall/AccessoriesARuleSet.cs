#if VRC_SDK_VRCSDK3
using System.Linq;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator.RuleSets
{
    public class AccessoriesARuleSet : VketUdonRuleSetBase
    {
        public AccessoriesARuleSet():base(new VketMallOfficialAssetData())
        {
        }
        public override string RuleSetName => "Mall - AccessoriesA";

        protected override string UdonSharpNamespace => "VketMall.Circle";

        protected override long FolderSizeLimit => 100 * MegaByte;

        protected override Vector3 BoothSizeLimit => new Vector3(0.5f, 0.5f, 0.5f);

        protected override int UdonBehaviourCountLimit => 10;

        protected override int VRCObjectSyncCountLimit => 5;

        protected override int VRCObjectPoolCountLimit => 1;

        protected override int VRCObjectPoolPoolLimit => 5;

        protected override int VRCPickupCountLimit => 10;

        protected override int UdonBehaviourSynchronizePositionCountLimit => 10;

        protected override int UdonScriptSyncedVariablesLimit => 10;

        protected override int MaterialUsesLimit => 3;

        protected override int LightmapCountLimit => 0;

        protected override int VRCStationCountLimit => 4;

        protected override int ClothCountLimit => 1;

        protected override int AudioSourceCountLimit => 10;

        protected override int VketVideoPlayerUsesLimit => 1;

        protected override LightConfigRule.LightConfig ApprovedPointLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked, LightmapBakeType.Realtime },
                            0, 7,
                            0, 10,
                            0, 15);
            }
        }

        protected override LightConfigRule.LightConfig ApprovedSpotLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked, LightmapBakeType.Realtime },
                            0, 7,
                            0, 10,
                            0, 15);
            }
        }

        protected override LightConfigRule.LightConfig ApprovedAreaLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked },
                            0, 30,
                            0, 10,
                            0, 15);
            }
        }

        protected override int AreaLightUsesLimit => 3;

        protected override LightmapBakeType[] unusablePointLightModes
        {
            get
            {
                return new LightmapBakeType[] { LightmapBakeType.Realtime, LightmapBakeType.Mixed };
            }
        }

        protected override LightmapBakeType[] unusableSpotLightModes
        {
            get
            {
                return new LightmapBakeType[] { LightmapBakeType.Realtime, LightmapBakeType.Mixed };
            }
        }

        protected override ValidationLevel MoreAdvancedObjectValidationLevel => ValidationLevel.ALLOW;

        protected override int ChairPrefabUsesLimit => 1;

        protected override int PickupObjectSyncUsesLimit => 5;

        protected override bool UdonInactiveRuleIsEnabled => false;

        protected override bool ExhibitStructureRuleIsEnabled => false;

        protected override bool UdonDynamicObjectParentRuleIsEnabled => false;

        public override IRule[] GetRules()
        {
            var rules = base.GetRules().ToList();
            rules.Add(
                new ComponentWhitelistRule(LocalizedMessage.Get("Booth.ComponentWhitelistRule.Solution"), GetComponentReferences())
                );
            // シェーダーホワイトリストのチェック
            rules.Add(
                new ShaderWhitelistRule(LocalizedMessage.Get("Booth.ShaderWhiteListRule.Title"),
                    _officialAssetData.AllowedShaders, LocalizedMessage.Get("Booth.ShaderWhiteListRule.Solution"))
                );
            return rules.ToArray();
        }

        private ComponentReference[] GetComponentReferences()
        {
            return new ComponentReference[] {
                new ComponentReference("BoothRangeIndicator", new string[]{"VitDeck.Validator.BoundsIndicators.BoothRangeIndicator"}, ValidationLevel.ALLOW),
                new ComponentReference("MeshFilter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
                new ComponentReference("MeshRenderer", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("SkinnedMeshRenderer", new string[]{"UnityEngine.SkinnedMeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("DynamicBone", new string[]{"DynamicBone"}, ValidationLevel.ALLOW),
                new ComponentReference("DynamicBoneCollider", new string[]{"DynamicBoneCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("VRCObjectSync", new string[]{"VRC.SDK3.Components.VRCObjectSync"}, ValidationLevel.ALLOW),
                new ComponentReference("VRCPickup", new string[]{"VRC.SDK3.Components.VRCPickup"}, ValidationLevel.ALLOW),
                new ComponentReference("Rigidbody", new string[]{"UnityEngine.Rigidbody"}, ValidationLevel.ALLOW),
                new ComponentReference("CapsuleCollider", new string[]{"UnityEngine.CapsuleCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Animator", new string[]{"UnityEngine.Animator"}, ValidationLevel.ALLOW),
                new ComponentReference("UdonBehaviour", new string[]{"VRC.Udon.UdonBehaviour"}, ValidationLevel.ALLOW),
                new ComponentReference("VketPickup", new string[]{"Vket.VketPrefabs.VketPickup"}, ValidationLevel.ALLOW),
                new ComponentReference("VketFollowPickup", new string[]{"Vket.VketPrefabs.VketFollowPickup"}, ValidationLevel.ALLOW),
            };
        }
    }
}
#endif