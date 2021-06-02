#if VRC_SDK_VRCSDK3
using VitDeck.Language;
using VRC.Udon;

namespace VitDeck.Validator
{
    /// <summary>
    /// VRCObjectPoolのPoolに登録するオブジェクトはn個以内にすること
    /// </summary>
    internal class VRCObjectPoolPoolLimitRule : BaseVRCObjectPoolRule
    {
        private readonly int limit;

        public VRCObjectPoolPoolLimitRule(string name,int limit) : base(name)
        {
            this.limit = limit;
        }

        protected override void ComponentLogic(VRC.SDK3.Components.VRCObjectPool component)
        {
            if (component.Pool.Length > limit)
            {
                AddIssue(new Issue(
                        component, 
                        IssueLevel.Error,
                        LocalizedMessage.Get("VRCObjectPoolPoolLimitRule.Overuse", limit, component.Pool.Length),
                        LocalizedMessage.Get("VRCObjectPoolPoolLimitRule.Overuse.Solution")
                    )
                );
            }
        }
    }
}
#endif
