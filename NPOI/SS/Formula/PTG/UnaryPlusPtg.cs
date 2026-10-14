using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012C RID: 300
	public class UnaryPlusPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x000169F7 File Offset: 0x00014BF7
		private UnaryPlusPtg()
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override byte Sid
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00008875 File Offset: 0x00006A75
		public override int NumberOfOperands
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000199E8 File Offset: 0x00017BE8
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(global::NPOI.SS.Formula.PTG.UnaryPlusPtg.Add);
			stringBuilder.Append(operands[0]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004FC RID: 1276
		public const byte sid = 18;

		// Token: 0x040004FD RID: 1277
		private static string Add = "+";

		// Token: 0x040004FE RID: 1278
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.UnaryPlusPtg();
	}
}
