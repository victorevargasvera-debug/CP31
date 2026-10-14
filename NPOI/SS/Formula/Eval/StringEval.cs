using System;
using System.Text;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021F RID: 543
	public class StringEval : global::NPOI.SS.Formula.Eval.StringValueEval, global::NPOI.SS.Formula.Eval.ValueEval
	{
		// Token: 0x06000D67 RID: 3431 RVA: 0x0002588A File Offset: 0x00023A8A
		public StringEval(global::NPOI.SS.Formula.PTG.Ptg ptg) : this(((global::NPOI.SS.Formula.PTG.StringPtg)ptg).Value)
		{
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0002589D File Offset: 0x00023A9D
		public StringEval(string value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentException("value must not be null");
			}
			this.value = value;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000258BA File Offset: 0x00023ABA
		public string StringValue
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000258C4 File Offset: 0x00023AC4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.value);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000608 RID: 1544
		public static readonly global::NPOI.SS.Formula.Eval.StringEval EMPTY_INSTANCE = new global::NPOI.SS.Formula.Eval.StringEval("");

		// Token: 0x04000609 RID: 1545
		private string value;
	}
}
