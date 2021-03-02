namespace VitDeck.Validator.RuleSets
{
    /// <summary>
    /// サンプルルールセット
    /// </summary>
    public class ExceptionRuleSet : BaseRuleSet
    {
        public override string RuleSetName
        {
            get { return "例外テストルールセット"; }
        }
        [Validation]
        public IRule exceptionRule= new ExceptionRule("例外テストルール");
    }
}