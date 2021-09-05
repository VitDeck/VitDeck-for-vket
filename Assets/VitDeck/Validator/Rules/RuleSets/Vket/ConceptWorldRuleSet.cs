using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VitDeck.Validator.RuleSets
{
    public class ConceptWorldRuleSet : VketRuleSetBase
    {
        public override string RuleSetName
        {
            get
            {
                return "Vket - ConceptWorld";
            }
        }

        protected override long FolderSizeLimit
        {
            get
            {
                return 50 * MegaByte;
            }
        }

        protected override Vector3 BoothSizeLimit
        {
            get
            {
                return new Vector3(4, 5, 4);
            }
        }

        protected override int VRCTriggerCountLimit
        {
            get
            {
                return 25;
            }
        }

        protected override int MaterialUsesLimit
        {
            get
            {
                return 20;
            }
        }

        protected override int LightmapCountLimit
        {
            get
            {
                return 1;
            }
        }

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

        protected override int AreaLightUsesLimit
        {
            get
            {
                return 3;
            }
        }
        
        protected override LightmapBakeType[] unusablePointLightModes
        {
            get
            {
                return new LightmapBakeType[] { };
            }
        }

        protected override LightmapBakeType[] unusableSpotLightModes
        {
            get
            {
                return new LightmapBakeType[] { };
            }
        }

        protected override int ChairPrefabUsesLimit
        {
            get
            {
                return 1;
            }
        }

        protected override int PickupObjectSyncUsesLimit
        {
            get
            {
                return 5;
            }
        }
    }
}