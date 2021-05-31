#if VRC_SDK_VRCSDK3
using System.Linq;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator.RuleSets
{
    public class Vket6ConceptWorldRuleSet : VketUdonRuleSetBase
    {
        public Vket6ConceptWorldRuleSet():base(new Vket6OfficialAssetData())
        {
        }
        public override string RuleSetName => "Vket6 - ConceptWorld";

        protected override string UdonSharpNamespace => "Vket6.Circle";

        protected override long FolderSizeLimit => 100 * MegaByte;

        protected override Vector3 BoothSizeLimit => new Vector3(4, 5, 4);

        protected override int UdonBehaviourCountLimit => 10;

        protected override int UdonBehaviourSynchronizePositionCountLimit => 10;

        protected override int UdonScriptSyncedVariablesLimit => 3;

        protected override int MaterialUsesLimit => 20;

        protected override int LightmapCountLimit => 1;

        protected override int VRCStationCountLimit => 4;

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

        protected override int PickupObjectSyncUsesLimit => 5;

        protected override bool UdonInactiveRuleIsEnabled => false;

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