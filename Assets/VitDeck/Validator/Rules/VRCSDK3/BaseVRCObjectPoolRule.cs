#if VRC_SDK_VRCSDK3
using System;
using System.Collections.Generic;
using UnityEngine;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using VRC.Udon.Editor.ProgramSources.UdonGraphProgram;
using VRC.Udon.Graph;
using VRC.Udon.UAssembly.Disassembler;

namespace VitDeck.Validator
{
    /// <summary>
    /// VRCObjectPoolを探してそれぞれバリデーションするためのクラス
    /// 詳細な規約はクラスを継承して ComponentLogic に記述する
    /// </summary>
    internal class BaseVRCObjectPoolRule : ComponentBaseRule<VRC.SDK3.Components.VRCObjectPool>
    {
        public BaseVRCObjectPoolRule(string name) : base(name)
        {
        }

        protected override void ComponentLogic(VRC.SDK3.Components.VRCObjectPool component)
        {

        }

        protected override void HasComponentObjectLogic(GameObject hasComponentObject)
        {
        }

    }
}
#endif
