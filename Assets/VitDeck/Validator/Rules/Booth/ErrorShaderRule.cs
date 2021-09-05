using UnityEngine;
using System.Linq;
using VitDeck.Language;

namespace VitDeck.Validator
{
    /// <summary>
    /// エラーシェーダーの検出ルール
    /// </summary>
    /// <remarks>シェーダーエラーの存在するオブジェクトを検出する。</remarks>
    public class ErrorShaderRule : BaseRule
    {
        /// <summary>
        /// コンストラクタ。
        /// </summary>
        /// <param name="name">ルール名</param>
        public ErrorShaderRule(string name) : base(name) { }

        protected override void Logic(ValidationTarget target)
        {
            foreach (var obj in target.GetAllObjects())
            {
                if (obj.GetComponent<Renderer>() == null)
                    continue;

                var materials = obj.GetComponent<Renderer>().sharedMaterials;

                foreach (var material in materials)
                {
                    if (material == null)
                    {
                        AddIssue(new Issue(obj, IssueLevel.Info, LocalizedMessage.Get("Booth.ErrorShaderRule.noMaterialError"), string.Empty, string.Empty));
                        continue;
                    }

                    if (material.shader.name == "Hidden/InternalErrorShader")
                    {
                        AddIssue(new Issue(obj, IssueLevel.Error, LocalizedMessage.Get("Booth.ErrorShaderRule.shaderReferenceError"), string.Empty, string.Empty));
                        continue;
                    }

                    if (material.shader.name == string.Empty || material.shader.name == null)
                    {
                        AddIssue(new Issue(obj, IssueLevel.Error, LocalizedMessage.Get("Booth.ErrorShaderRule.shaderError"), string.Empty, string.Empty));
                    }
                }
            }
        }
    }
}
