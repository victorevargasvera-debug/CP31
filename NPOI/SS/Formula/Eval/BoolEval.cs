using System;
using System.Text;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000206 RID: 518
	public class BoolEval : global::NPOI.SS.Formula.Eval.NumericValueEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.Eval.StringValueEval
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x0002350D File Offset: 0x0002170D
		public static global::NPOI.SS.Formula.Eval.BoolEval ValueOf(bool b)
		{
			if (!b)
			{
				return global::NPOI.SS.Formula.Eval.BoolEval.FALSE;
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.TRUE;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0002351D File Offset: 0x0002171D
		public BoolEval(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			this.value = ((global::NPOI.SS.Formula.PTG.BoolPtg)ptg).Value;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00023536 File Offset: 0x00021736
		private BoolEval(bool value)
		{
			this.value = value;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00023545 File Offset: 0x00021745
		public bool BooleanValue
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002354D File Offset: 0x0002174D
		public double NumberValue
		{
			get
			{
				return (double)(this.value ? 1 : 0);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0002355C File Offset: 0x0002175C
		public string StringValue
		{
			get
			{
				if (!this.value)
				{
					return "FALSE";
				}
				return "TRUE";
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00023574 File Offset: 0x00021774
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.StringValue);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040005E0 RID: 1504
		private bool value;

		// Token: 0x040005E1 RID: 1505
		public static readonly global::NPOI.SS.Formula.Eval.BoolEval FALSE = new global::NPOI.SS.Formula.Eval.BoolEval(false);

		// Token: 0x040005E2 RID: 1506
		public static readonly global::NPOI.SS.Formula.Eval.BoolEval TRUE = new global::NPOI.SS.Formula.Eval.BoolEval(true);
	}
}
