using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    public class SceneComponentLimitRule : BaseRule
    {
        private readonly System.Type type;
        private int count;
        private readonly int limit;
        private readonly HashSet<string> excludedAssetGUIDs;

        public SceneComponentLimitRule(string name, System.Type type, int limit, string[] excludedAssetGUIDs) : base(name)
        {
            this.type = type;
            this.limit = limit;
            this.excludedAssetGUIDs = new HashSet<string>(excludedAssetGUIDs);
        }

        protected override void Logic(ValidationTarget target)
        {
            var assets = target.GetScenes()[0].GetRootGameObjects();

            count = 0;

            foreach (var asset in assets)
            {
                if (asset.name != "Reference Object")
                {
                    FindComponent(asset);
                }
            }

            if (count > limit)
            {
                var message = LocalizedMessage.Get("SceneComponentLimitRule.Overuse", type.Name, limit, count);
                var solution = LocalizedMessage.Get("SceneComponentLimitRule.Overuse.Solution", type.Name);

                AddIssue(new Issue(
                    null,
                    IssueLevel.Error,
                    message,
                    solution));
            }
        }

        private void FindComponent(GameObject obj)
        {

            for (int i = 0; i < obj.transform.childCount; i++)
            {
                Object prefab = PrefabUtility.GetPrefabParent(obj.transform.GetChild(i).gameObject);
                if (excludedAssetGUIDs.Contains(GetGUID(prefab)))
                {
                    return;
                }

                if (obj.transform.GetChild(i).gameObject.GetComponent(type) != null)
                {
                    count++;
                }
                FindComponent(obj.transform.GetChild(i).gameObject);
            }

        }

        private static string GetGUID(Object asset)
        {
            return AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(asset));
        }

    }
}