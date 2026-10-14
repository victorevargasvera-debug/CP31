using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A5 RID: 421
	public class SimpleValueVector : global::NPOI.SS.Formula.Functions.ValueVector
	{
		// Token: 0x06000B80 RID: 2944 RVA: 0x0001F253 File Offset: 0x0001D453
		public SimpleValueVector(global::NPOI.SS.Formula.Eval.ValueEval[] values)
		{
			this._values = values;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001F262 File Offset: 0x0001D462
		public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
		{
			return this._values[index];
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0001F26C File Offset: 0x0001D46C
		public int Size
		{
			get
			{
				return this._values.Length;
			}
		}

		// Token: 0x04000572 RID: 1394
		private global::NPOI.SS.Formula.Eval.ValueEval[] _values;
	}
}
