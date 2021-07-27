using UnityEditor;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    internal class RigidbodyRule : ComponentBaseRule<Rigidbody>
    {
        private bool allowIsKinematic;

        public RigidbodyRule(string name,bool allowIsKinematic) : base(name)
        {
            this.allowIsKinematic = allowIsKinematic;
        }

        protected override void ComponentLogic(Rigidbody component)
        {
            if (!allowIsKinematic)
            {
                if (!component.isKinematic)
                {
                    AddIssue(new Issue(
                        component,
                        IssueLevel.Error,
                        LocalizedMessage.Get("RigidbodyRule.UseIsKinematic")));
                }
            }
        }

        protected override void HasComponentObjectLogic(GameObject hasComponentObject)
        {
        }
    }
}