using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    public class Vket6KujaBoothBoxRule : BaseRule
    {
        private GameObject box;

        public Vket6KujaBoothBoxRule(string name) : base(name)
        {
        }

        protected override void Logic(ValidationTarget target)
        {
            var assets = target.GetScenes()[0].GetRootGameObjects();

            foreach (var asset in assets)
            {
                if (asset.name == "Reference Object")
                {
                    FindBox(asset);
                }
            }

            if (box == null)
            {
                var message = LocalizedMessage.Get("Vket6KujaBoothBoxRule.Select");
                var solution = LocalizedMessage.Get("Vket6KujaBoothBoxRule.Select.Solution");

                AddIssue(new Issue(
                    null,
                    IssueLevel.Error,
                    message,
                    solution));
            }
            else
            {
                Debug.Log(box.name);
            }
        }

        private void FindBox(GameObject obj)
        {
            for (int i = 0; i < obj.transform.childCount; i++)
            {
                Object prefab = PrefabUtility.GetPrefabParent(obj);
                if (GetGUID(prefab) == "750eed323838fe448951af4a1d2e25d6" && obj.transform.GetChild(i).gameObject.active)
                {
                    box = obj.transform.GetChild(i).gameObject;
                }
                FindBox(obj.transform.GetChild(i).gameObject);
            }
        }

        private static string GetGUID(Object asset)
        {
            return AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(asset));
        }

    }
}