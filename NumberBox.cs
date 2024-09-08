using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace Revalian
{
    public partial class NumberBox : TextBox
    {
        #region 属性
        public float? DefaultValue { get; set; }
        public float? Value { get; set; }
        public bool IsNull { get; set; }
        public bool IsNullable { get; set; }
        public bool IsCalc { get; set; }
        #endregion

        public NumberBox()
        {
            InitializeComponent();
            PlaceholderText = "--";
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (IsNull && IsNullable) Value = null;
            else Value = DefaultValue;
            Text = Value.ToString();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (Text == string.Empty && IsNullable) Value = null;
            else
            {
                Value = CalcWithoutValue(Text);
                if (Value == null) {
                    if (!IsCalc || Calc(Text, 1) == null) {
                        Value = DefaultValue;
                        Text = Value.ToString();
                    }                    
                } else Text = Value.ToString();
            }
        }

        public float? Calc(String expr, int val)
        {
            try
            {
                var parameter = Expression.Parameter(typeof(int), "i");
                var lambdaExpr = DynamicExpressionParser.ParseLambda([parameter], typeof(double), expr);
                var func = (Func<int, double>)lambdaExpr.Compile();
                var result = (float)func(val);
                return result;
            }
            catch (System.Linq.Dynamic.Core.Exceptions.ParseException) { return null; }
            catch (DivideByZeroException) { return float.PositiveInfinity; }
        }

        private float? CalcWithoutValue(String expr)
        {
            try
            {
                var lambdaExpr = DynamicExpressionParser.ParseLambda(typeof(double), expr);
                var func = (Func<double>)lambdaExpr.Compile();
                var result = (float)func();
                if (float.IsNaN(result)) return null;
                return result;
            }
            catch (System.Linq.Dynamic.Core.Exceptions.ParseException) { return null; }
            catch (DivideByZeroException) { return null; }
        }
    }
}
