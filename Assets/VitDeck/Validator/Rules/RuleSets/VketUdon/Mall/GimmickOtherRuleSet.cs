#if VRC_SDK_VRCSDK3
using System.Linq;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator.RuleSets
{
    public class GimmickOtherRuleSet : VketUdonRuleSetBase
    {
        public GimmickOtherRuleSet():base(new VketMallOfficialAssetData())
        {
        }
        public override string RuleSetName => "Mall - GimmickOther";

        protected override string UdonSharpNamespace => "VketMall.Circle";

        protected override long FolderSizeLimit => 100 * MegaByte;

        protected override Vector3 BoothSizeLimit => new Vector3(1, 2, 1);

        protected override int UdonBehaviourCountLimit => 5;

        protected override int VRCObjectSyncCountLimit => 2;

        protected override int VRCObjectPoolCountLimit => 0;

        protected override int VRCObjectPoolPoolLimit => 0;

        protected override int VRCPickupCountLimit => 2;

        protected override int UdonBehaviourSynchronizePositionCountLimit => 10;

        protected override int UdonScriptSyncedVariablesLimit => 10;

        protected override int MaterialUsesLimit => 5;

        protected override int LightmapCountLimit => 0;

        protected override int VRCStationCountLimit => 4;

        protected override int ClothCountLimit => 0;

        protected override int AudioSourceCountLimit => 1;

        protected override int VketVideoPlayerUsesLimit => 0;

        protected override float RayCastLength => 10.0f;

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

        protected override int AreaLightUsesLimit => 0;

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
            // シェーダーホワイトリストのチェック
            rules.Add(
                new ShaderWhitelistRule(LocalizedMessage.Get("Booth.ShaderWhiteListRule.Title"),
                    _officialAssetData.AllowedShaders, LocalizedMessage.Get("Booth.ShaderWhiteListRule.Solution")) 
                );
            return rules.ToArray();
        }
    }
}
#endif