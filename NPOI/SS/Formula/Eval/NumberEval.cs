using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000210 RID: 528
	public class NumberEval : global::NPOI.SS.Formula.Eval.NumericValueEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.Eval.StringValueEval
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x00024F53 File Offset: 0x00023153
		public NumberEval(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.IntPtg)
			{
				this._value = (double)((global::NPOI.SS.Formula.PTG.IntPtg)ptg).Value;
				return;
			}
			if (ptg is global::NPOI.SS.Formula.PTG.NumberPtg)
			{
				this._value = ((global::NPOI.SS.Formula.PTG.NumberPtg)ptg).Value;
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00024F8F File Offset: 0x0002318F
		public NumberEval(double value)
		{
			this._value = value;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00024F9E File Offset: 0x0002319E
		public double NumberValue
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00024FA6 File Offset: 0x000231A6
		public string StringValue
		{
			get
			{
				if (this._stringValue == null)
				{
					this._stringValue = global::NPOI.SS.Util.NumberToTextConverter.ToText(this._value);
				}
				return this._stringValue;
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00024FC8 File Offset: 0x000231C8
		protected void MakeString()
		{
			if (!double.IsNaN(this._value))
			{
				double num = global::System.Math.Round(this._value);
				if (num == this._value)
				{
					this._stringValue = num.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					return;
				}
				this._stringValue = this._value.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00025020 File Offset: 0x00023220
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.StringValue);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040005F6 RID: 1526
		public static readonly global::NPOI.SS.Formula.Eval.NumberEval ZERO = new global::NPOI.SS.Formula.Eval.NumberEval(0.0);

		// Token: 0x040005F7 RID: 1527
		private double _value;

		// Token: 0x040005F8 RID: 1528
		private string _stringValue;
	}
}
