using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000105 RID: 261
	public class EqualPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x000169F7 File Offset: 0x00014BF7
		private EqualPtg()
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00016C75 File Offset: 0x00014E75
		protected override byte Sid
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00017F9A File Offset: 0x0001619A
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("=");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x04000485 RID: 1157
		public const byte sid = 11;

		// Token: 0x04000486 RID: 1158
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.EqualPtg();
	}
}
