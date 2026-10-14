using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001AE RID: 430
	public class SingleValueVector : global::NPOI.SS.Formula.Functions.ValueVector
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x0001F9EA File Offset: 0x0001DBEA
		public SingleValueVector(global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			this._value = value;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001F9F9 File Offset: 0x0001DBF9
		public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
		{
			if (index != 0)
			{
				throw new global::System.ArgumentException("Invalid index (" + index.ToString() + ") only zero is allowed");
			}
			return this._value;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00008875 File Offset: 0x00006A75
		public int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0400057F RID: 1407
		private global::NPOI.SS.Formula.Eval.ValueEval _value;
	}
}
