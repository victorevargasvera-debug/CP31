using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001AA RID: 426
	internal class BooleanLookupComparer : global::NPOI.SS.Formula.Functions.LookupValueComparerBase
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x0001F8EB File Offset: 0x0001DAEB
		public BooleanLookupComparer(global::NPOI.SS.Formula.Eval.BoolEval be) : base(be)
		{
			this._value = be.BooleanValue;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001F900 File Offset: 0x0001DB00
		protected override global::NPOI.SS.Formula.Functions.CompareResult CompareSameType(global::NPOI.SS.Formula.Eval.ValueEval other)
		{
			bool booleanValue = ((global::NPOI.SS.Formula.Eval.BoolEval)other).BooleanValue;
			if (this._value == booleanValue)
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.Equal;
			}
			if (this._value)
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.GreaterThan;
			}
			return global::NPOI.SS.Formula.Functions.CompareResult.LessThan;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001F93B File Offset: 0x0001DB3B
		protected override string GetValueAsString()
		{
			return this._value.ToString();
		}

		// Token: 0x0400057D RID: 1405
		private bool _value;
	}
}
