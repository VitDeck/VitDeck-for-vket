#if VRC_SDK_VRCSDK3
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VitDeck.Language;
using VRC.Udon;

namespace VitDeck.Validator
{
    /// <summary>
    /// UdonBehaviourを含むオブジェクトのLayerはUserLayer23としてください
    /// </summary>
    internal class UdonBehaviourLayerConstraintRule : BaseUdonBehaviourRule
    {
        private readonly HashSet<string> excludedAssetGUIDs;

        public UdonBehaviourLayerConstraintRule(string name, string[] excludedAssetGUIDs) : base(name)
        {
            this.excludedAssetGUIDs = new HashSet<string>(excludedAssetGUIDs);
        }

        protected override void ComponentLogic(UdonBehaviour component)
        {
        }

        protected override void HasComponentObjectLogic(GameObject hasComponentObject)
        {
            var objs =  hasComponentObject.transform.GetComponentsInChildren<Transform>();
            foreach (var obj in objs)
            {
                Object prefab = PrefabUtility.GetPrefabParent(obj);
                if (obj.gameObject.layer != 23 && !excludedAssetGUIDs.Contains(GetGUID(prefab)))
                {
                    AddIssue(new Issue(
                            obj, 
                            IssueLevel.Error, 
                            LocalizedMessage.Get("UdonBehaviourLayerConstraintRule.InvalidLayer"),
                            LocalizedMessage.Get("UdonBehaviourLayerConstraintRule.InvalidLayer.solution")
                        )
                    );
                }
            }
        }

        private static string GetGUID(Object asset)
        {
            return AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(asset));
        }
    }
}
#endif
