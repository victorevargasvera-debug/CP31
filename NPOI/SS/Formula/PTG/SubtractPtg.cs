using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000129 RID: 297
	public class SubtractPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x000169F7 File Offset: 0x00014BF7
		private SubtractPtg()
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00018498 File Offset: 0x00016698
		protected override byte Sid
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000198B7 File Offset: 0x00017AB7
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("-");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004F3 RID: 1267
		public const byte sid = 4;

		// Token: 0x040004F4 RID: 1268
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.SubtractPtg();
	}
}
