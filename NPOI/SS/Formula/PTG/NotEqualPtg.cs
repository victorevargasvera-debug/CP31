using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000118 RID: 280
	public class NotEqualPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x000169F7 File Offset: 0x00014BF7
		private NotEqualPtg()
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00018987 File Offset: 0x00016B87
		protected override byte Sid
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001898B File Offset: 0x00016B8B
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("<>");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004C3 RID: 1219
		public const byte sid = 14;

		// Token: 0x040004C4 RID: 1220
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.NotEqualPtg();
	}
}
