using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010B RID: 267
	public class GreaterEqualPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x000169F7 File Offset: 0x00014BF7
		private GreaterEqualPtg()
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000184AD File Offset: 0x000166AD
		protected override byte Sid
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000184B1 File Offset: 0x000166B1
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(">=");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x0400049A RID: 1178
		public const int SIZE = 1;

		// Token: 0x0400049B RID: 1179
		public const byte sid = 12;

		// Token: 0x0400049C RID: 1180
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.GreaterEqualPtg();
	}
}
