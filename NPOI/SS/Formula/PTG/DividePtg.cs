using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000104 RID: 260
	public class DividePtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x000169F7 File Offset: 0x00014BF7
		private DividePtg()
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00017F5F File Offset: 0x0001615F
		protected override byte Sid
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00017F62 File Offset: 0x00016162
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("/");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x04000483 RID: 1155
		public const byte sid = 6;

		// Token: 0x04000484 RID: 1156
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.DividePtg();
	}
}
