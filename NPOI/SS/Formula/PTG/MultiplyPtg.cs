using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000115 RID: 277
	public class MultiplyPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x000169F7 File Offset: 0x00014BF7
		private MultiplyPtg()
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x000181D5 File Offset: 0x000163D5
		protected override byte Sid
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001884E File Offset: 0x00016A4E
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("*");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004B8 RID: 1208
		public const byte sid = 5;

		// Token: 0x040004B9 RID: 1209
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.MultiplyPtg();
	}
}
