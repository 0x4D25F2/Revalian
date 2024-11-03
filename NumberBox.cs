using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace Revalian
{
    public partial class NumberBox : TextBox
    {
        public enum TypeEnum
        {
            Double = 0,
            Integer = 1
        }

        #region 属性
        public float? DefaultValue { get; set; }
        public float? Value { get; set; }
        public bool IsNull { get; set; }
        public bool IsNullable { get; set; }
        public bool IsCalc { get; set; }
        public TypeEnum ValueType { get; set; }
        public float? MaxValue { get; set; } = null;
        public float? MinValue { get; set; } = null;
        #endregion

        public NumberBox()
        {
            InitializeComponent();
            PlaceholderText = "--";
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (MaxValue == null) MaxValue = ValueType == TypeEnum.Double ? float.MaxValue : int.MaxValue;
            if (MaxValue == null) MinValue = ValueType == TypeEnum.Double ? float.MinValue : int.MinValue;
            if (DefaultValue >= MaxValue) DefaultValue = MaxValue;
            else if (DefaultValue <= MinValue) DefaultValue = MinValue;
            if (IsNull && IsNullable) Value = null;
            else Value = DefaultValue;
            Text = Value.ToString();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (Text == string.Empty)
                if (IsNullable)
                    Value = null;
                else
                {
                    Value = DefaultValue;
                    Text = Value.ToString();
                }
            else
            {
                Value = CalcWithoutValue();
                if (Value == null)
                {
                    if (!IsCalc || Calc(1) == null)
                    {
                        Value = DefaultValue;
                        Text = Value.ToString();
                    }
                }
                else Text = Value.ToString();
            }
        }

        public float? Calc(int val)
        {
            if (Text == string.Empty && IsNullable) return null;
            try
            {
                var parameter = Expression.Parameter(typeof(int), "i");
                var lambdaExpr = DynamicExpressionParser.ParseLambda([parameter], typeof(double), Text);
                var func = (Func<int, double>)lambdaExpr.Compile();
                var result = (float)func(val);
                if (float.IsNaN(result)) return null;
                if (result < MinValue || result > MaxValue) return DefaultValue;
                if (ValueType == TypeEnum.Integer) result = (int)result;
                return result;
            }
            catch (System.Linq.Dynamic.Core.Exceptions.ParseException) { return null; }
            catch (DivideByZeroException) { return float.PositiveInfinity; }
        }

        private float? CalcWithoutValue()
        {
            try
            {
                var lambdaExpr = DynamicExpressionParser.ParseLambda(typeof(double), Text);
                var func = (Func<double>)lambdaExpr.Compile();
                var result = (float)func();
                if (float.IsNaN(result)) return null;
                if (result < MinValue || result > MaxValue) return DefaultValue;
                if (ValueType == TypeEnum.Integer) result = (int)result;
                return result;
            }
            catch (System.Linq.Dynamic.Core.Exceptions.ParseException) { return null; }
            catch (DivideByZeroException) { return null; }
        }
    }
}
