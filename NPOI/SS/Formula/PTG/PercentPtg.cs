using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011D RID: 285
	public class PercentPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x000169F7 File Offset: 0x00014BF7
		private PercentPtg()
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override byte Sid
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00008875 File Offset: 0x00006A75
		public override int NumberOfOperands
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00018AA4 File Offset: 0x00016CA4
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("%");
			return stringBuilder.ToString();
		}

		// Token: 0x040004CE RID: 1230
		public const int SIZE = 1;

		// Token: 0x040004CF RID: 1231
		public const byte sid = 20;

		// Token: 0x040004D0 RID: 1232
		private const string PERCENT = "%";

		// Token: 0x040004D1 RID: 1233
		public static readonly global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.PercentPtg();
	}
}
