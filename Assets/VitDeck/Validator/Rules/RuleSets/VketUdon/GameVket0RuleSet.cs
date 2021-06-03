#if VRC_SDK_VRCSDK3
using System.Linq;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator.RuleSets
{
    public class GameVket0RuleSet : VketUdonRuleSetBase
    {
        public GameVket0RuleSet():base(new GameVket0OfficialAssetData())
        {
        }
        public override string RuleSetName => "GameVketZero";

        protected override string UdonSharpNamespace => "GamV0.Circle";

        protected override long FolderSizeLimit => 100 * MegaByte;

        protected override Vector3 BoothSizeLimit => new Vector3(10, 10, 10);

        protected override int UdonBehaviourCountLimit => 25;

        protected override int VRCObjectSyncCountLimit => 5;

        protected override int VRCObjectPoolCountLimit => 1;

        protected override int VRCObjectPoolPoolLimit => 5;

        protected override int VRCPickupCountLimit => 10;

        protected override int UdonBehaviourSynchronizePositionCountLimit => 10;

        protected override int UdonScriptSyncedVariablesLimit => 3;

        protected override int MaterialUsesLimit => 60;

        protected override int LightmapCountLimit => 2;

        protected override int VRCStationCountLimit => 8;

        protected override int ClothCountLimit => 1;

        protected override int AudioSourceCountLimit => 10;

        protected override int VketVideoPlayerUsesLimit => 1;

        protected override LightConfigRule.LightConfig ApprovedPointLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new [] { LightmapBakeType.Baked, LightmapBakeType.Realtime });
            }
        }

        protected override LightConfigRule.LightConfig ApprovedSpotLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked, LightmapBakeType.Realtime });
            }
        }

        protected override LightConfigRule.LightConfig ApprovedAreaLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked });
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

        protected override int PickupObjectSyncUsesLimit => 10;

        protected override bool UdonInactiveRuleIsEnabled => true;

        protected override bool ExhibitStructureRuleIsEnabled => true;

        protected override bool UdonDynamicObjectParentRuleIsEnabled => true;

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