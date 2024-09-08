using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revalian
{
    public partial class NumberBox : TextBox
    {
        #region 属性
        public float? DefaultValue { get; set; }
        public float? Value { get; set; }
        public bool IsNull { get; set; }
        public bool IsNullable { get; set; }
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
                bool result = float.TryParse(Text, out float v);
                if (result)
                {
                    Value = v;
                    Text = Value.ToString();
                }
                else Text = DefaultValue.ToString();
            }
        }
    }
}
