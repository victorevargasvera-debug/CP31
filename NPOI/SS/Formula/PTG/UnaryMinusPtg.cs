using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012B RID: 299
	public class UnaryMinusPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x000169F7 File Offset: 0x00014BF7
		private UnaryMinusPtg()
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000199B2 File Offset: 0x00017BB2
		protected override byte Sid
		{
			get
			{
				return 19;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00008875 File Offset: 0x00006A75
		public override int NumberOfOperands
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000199B6 File Offset: 0x00017BB6
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("-");
			stringBuilder.Append(operands[0]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004F9 RID: 1273
		public const byte sid = 19;

		// Token: 0x040004FA RID: 1274
		private const string MINUS = "-";

		// Token: 0x040004FB RID: 1275
		public static readonly global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.UnaryMinusPtg();
	}
}
