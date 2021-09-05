using UnityEditor;
using UnityEngine;
using VitDeck.Language;

namespace VitDeck.Validator
{
    internal class AudioSourceRule : ComponentBaseRule<AudioSource>
    {
        public AudioSourceRule(string name) : base(name)
        {
        }

        protected override void ComponentLogic(AudioSource component)
        {
            DefaultDisabledLogic(component);
            SpatialBlendCheckLogic(component);
        }


        private void DefaultDisabledLogic(AudioSource component)
        {
            if (component.enabled)
            {

                var message = LocalizedMessage.Get("AudioSourceRule.DefaultDisabled");
                var solution = LocalizedMessage.Get("AudioSourceRule.DefaultDisabled.Solution");

                AddIssue(new Issue(
                    component,
                    IssueLevel.Error,
                    message,
                    solution));
            }
        }


        private void SpatialBlendCheckLogic(AudioSource component)
        {
            if (component.spatialBlend != 1.0f)
            {
                AddResultLog(LocalizedMessage.Get("AudioSourceRuleRule.SpatialBlend"));
            }
        }

        protected override void HasComponentObjectLogic(GameObject hasComponentObject)
        {
        }
    }
}