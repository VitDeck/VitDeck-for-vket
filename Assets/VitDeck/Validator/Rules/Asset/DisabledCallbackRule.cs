using UnityEngine;
using VitDeck.Language;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
#if VRC_SDK_VRCSDK3
using VRC.SDKBase;
using System.IO;
using System.Text.RegularExpressions;

namespace VitDeck.Validator
{
    /// <summary>
    /// 禁止されたコールバックが使用されていないか検出するルール
    /// </summary>
    public class DisabledCallbackRule : BaseRule
    {
        private readonly HashSet<string> excludedAssetGUIDs;
        private readonly string[] disabledCallback;

        public DisabledCallbackRule(string name,string[] disabledCallback, string[] excludedAssetGUIDs) : base(name)
        {
            this.excludedAssetGUIDs = new HashSet<string>(excludedAssetGUIDs);
            this.disabledCallback = disabledCallback;
        }

        protected override void Logic(ValidationTarget target)
        {
            var assets = target.GetAllAssets();

            foreach (var asset in assets)
            {
                if (asset.GetType() == typeof(MonoScript) && !excludedAssetGUIDs.Contains(GetGUID(asset)))
                {
                    using (var fs = new StreamReader(AssetDatabase.GetAssetPath(asset), System.Text.Encoding.GetEncoding("UTF-8")))
                    {
                        string code = fs.ReadToEnd();
                        foreach (var callback in disabledCallback)
                        {
                            if (Regex.IsMatch(code, callback))
                            {
                                var message = LocalizedMessage.Get("DisabledCallbackRule.Use", Regex.Match(code, callback));
                                var solution = LocalizedMessage.Get("DisabledCallbackRule.Use.Solution");

                                AddIssue(new Issue(
                                    null,
                                    IssueLevel.Error,
                                    message,
                                    solution));
                            }
                        }
                    }
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
