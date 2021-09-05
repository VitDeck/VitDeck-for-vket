#if VRC_SDK_VRCSDK3
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    /// <summary>
    /// 全てのUdonBehaviourオブジェクトの親であるDynamicオブジェクトは初期でInactive状態にしてください
    /// </summary>
    internal class UdonDynamicObjectInactiveRule : BaseRule
    {
        private bool isEnabled;
        public UdonDynamicObjectInactiveRule(string name,bool isEnabled) : base(name)
        {
            this.isEnabled = isEnabled;
        }

        protected override void Logic(ValidationTarget target)
        {
            if (isEnabled)
            {
                var rootObjects = target.GetRootObjects();

                foreach (var rootObject in rootObjects)
                {
                    LogicForRootObject(rootObject);
                }
            }
        }

        private void LogicForRootObject(GameObject rootObject)
        {
            GameObject dynamicRoot = null;

            foreach (Transform child in rootObject.transform)
            {
                if (child.name == "Dynamic" && dynamicRoot == null)
                {
                    dynamicRoot = child.gameObject;
                }
            }

            CheckIsActive("Dynamic", dynamicRoot, !isEnabled);
        }

        private void CheckIsActive(string instanceName, GameObject instance, bool isActive)
        {
            if (instance.activeSelf != isActive)
            {
                AddIssue(new Issue(
                    instance,
                    IssueLevel.Error,
                    LocalizedMessage.Get("UdonDynamicObjectInactiveRule.isActive", instanceName),
                    LocalizedMessage.Get("UdonDynamicObjectInactiveRule.isActive.Solution", instanceName)
                ));
            }
        }
    }
}
#endif