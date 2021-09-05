#if VRC_SDK_VRCSDK3
using VitDeck.Language;
using VRC.Udon;

namespace VitDeck.Validator
{
    /// <summary>
    /// VRCObjectSyncのAllowOwnershipTransferOnCollisionは必ずFalseにすること
    /// </summary>
    internal class VRCObjectSyncAllowOwnershipTransferOnCollisionIsFalseRule : BaseVRCObjectSyncRule
    {
        public VRCObjectSyncAllowOwnershipTransferOnCollisionIsFalseRule(string name) : base(name)
        {
        }

        protected override void ComponentLogic(VRC.SDK3.Components.VRCObjectSync component)
        {
            if (component.AllowCollisionOwnershipTransfer)
            {
                AddIssue(new Issue(
                        component, 
                        IssueLevel.Error, 
                        LocalizedMessage.Get("VRCObjectSyncAllowOwnershipTransferOnCollisionIsFalseRule.Title")
                    )
                );
            }
        }
    }
}
#endif
