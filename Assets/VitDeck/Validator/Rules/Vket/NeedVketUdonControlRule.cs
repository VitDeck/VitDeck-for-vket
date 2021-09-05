#if VRC_SDK_VRCSDK3
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    /// <summary>
    /// 運営が配布するprefabs以外でUdonBehaviourコンポーネントを使用する際にVketUdonControlコンポーネントがアタッチされているか検証するルール
    /// </summary>
    public class NeedVketUdonControlRule : BaseRule
    {
        private readonly HashSet<string> excludedAssetGUIDs;
        private bool errorFlag;
        private Object obj;

        public NeedVketUdonControlRule(string name, string[] excludedAssetGUIDs) : base(name)
        {
            this.excludedAssetGUIDs = new HashSet<string>(excludedAssetGUIDs);
        }

        protected override void Logic(ValidationTarget target)
        {
            var assets = target.GetScenes()[0].GetRootGameObjects();

            errorFlag = false;

            foreach (var asset in assets)
            {
                FindComponent(asset);
            }

            if (errorFlag)
            {
                var message = LocalizedMessage.Get("NeedVketUdonControlRule.Need", obj.name);
                var solution = LocalizedMessage.Get("NeedVketUdonControlRule.Need.Solution");

                AddIssue(new Issue(
                    null,
                    IssueLevel.Error,
                    message,
                    solution));
            }
        }

        private static string GetGUID(Object asset)
        {
            return AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(asset));
        }

        public void FindComponent(GameObject obj)
        {

            for (int i = 0; i < obj.transform.childCount; i++)
            {
                if (obj.name == "Dynamic")
                {
                    if (obj.transform.GetChild(i).gameObject.GetComponent<VRC.Udon.UdonBehaviour>() != null)
                    {
                        //if (obj.transform.GetChild(i).gameObject.GetComponent<Vket.UdonManager.VketUdonControl>() == null)
                        //{
                        //    errorFlag = true;
                        //    this.obj = obj.transform.GetChild(i).gameObject;
                        //}
                    }
                }
                FindComponent(obj.transform.GetChild(i).gameObject);
            }

        }
    }
}
#endif
