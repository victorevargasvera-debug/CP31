using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010F RID: 271
	public class LessEqualPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x000169F7 File Offset: 0x00014BF7
		private LessEqualPtg()
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00018662 File Offset: 0x00016862
		protected override byte Sid
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00018666 File Offset: 0x00016866
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("<=");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004A7 RID: 1191
		public const byte sid = 10;

		// Token: 0x040004A8 RID: 1192
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.LessEqualPtg();
	}
}
