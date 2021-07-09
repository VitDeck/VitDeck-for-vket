#if VRC_SDK_VRCSDK3
using System.Linq;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator.RuleSets
{
    public class Vket6KujaRuleSet : VketUdonRuleSetBase
    {
        public Vket6KujaRuleSet():base(new Vket6OfficialAssetData())
        {
        }
        public override string RuleSetName => "Vket6 - Kuja";

        protected override string UdonSharpNamespace => "Vket6.Circle";

        protected override long FolderSizeLimit => 100 * MegaByte;

        protected override Vector3 BoothSizeLimit => new Vector3(4, 5, 4);

        protected override int UdonBehaviourCountLimit => 10;

        protected override int VRCObjectSyncCountLimit => 5;

        protected override int VRCObjectPoolCountLimit => 1;

        protected override int VRCObjectPoolPoolLimit => 5;

        protected override int VRCPickupCountLimit => 10;

        protected override int UdonBehaviourSynchronizePositionCountLimit => 10;

        protected override int UdonScriptSyncedVariablesLimit => 10;

        protected override int MaterialUsesLimit => 20;

        protected override int LightmapCountLimit => 1;

        protected override int VRCStationCountLimit => 4;

        protected override int ClothCountLimit => 1;

        protected override int AudioSourceCountLimit => 10;

        protected override int VketVideoPlayerUsesLimit => 1;

        protected override float RayCastLength => 4.0f;

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

        protected override bool ExhibitStructureRuleIsEnabled => true;

        protected override bool UdonDynamicObjectParentRuleIsEnabled => true;

        public override IRule[] GetRules()
        {
            var rules = base.GetRules().ToList();
            // シェーダーホワイトリストのチェック
            //rules.Add(
            //    new ShaderWhitelistRule(LocalizedMessage.Get("Booth.ShaderWhiteListRule.Title"),
            //        _officialAssetData.AllowedShaders, LocalizedMessage.Get("Booth.ShaderWhiteListRule.Solution")) 
            //    );

            rules.Add(
                new Vket6KujaBoothBoxRule(LocalizedMessage.Get("Vket6KujaBoothBoxRule.Title"))
                );
            return rules.ToArray();
        }
    }
}
#endif