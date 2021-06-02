#if VRC_SDK_VRCSDK3
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using VitDeck.Language;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace VitDeck.Validator
{
    /// <summary>
    /// PhysicsクラスのCast関数 layerMaskを設定し、レイヤー23以外のコライダを無視するようにする, maxDistanceは最長で10メートルまで
    /// </summary>
    /// <remarks>
    /// UdonAssemblyを調査し、特定の関数の引数が使用されているか、正しい値が設定されているかを調査します。
    /// プレハブのGUIDを与えることで、そのプレハブに元から追加してあるコンポーネントを許可されているものとして無視します。
    /// 値の確認は定数のみ UdonSharpで定義しているときは private const で UdonNodeで定義している場合は値を直接指定する方法のみサポート
    /// </remarks>
    internal class UdonAssemblyCallbackRule : BaseUdonBehaviourRule
    {

        private readonly HashSet<string> _ignorePrefabs;

        /// <summary>
        /// コンストラクタ。
        /// </summary>
        /// <param name="name">ルール名</param>
        public UdonAssemblyCallbackRule(string name): base(name)
        {

        }

        protected override void ComponentLogic(UdonBehaviour component)
        {
            if (component.programSource == null) return;
            
            // UdonProgramName
            var programName = component.programSource.name;

            // プログラム
            var program = GetUdonProgram(component);

            Debug.Log(program);

            // コード
            var code = GetDisassembleCode(program);

            Debug.Log(code);
        }

    }
}
#endif
