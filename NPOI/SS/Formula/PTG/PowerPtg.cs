using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011E RID: 286
	public class PowerPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x000169F7 File Offset: 0x00014BF7
		private PowerPtg()
		{
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00017F33 File Offset: 0x00016133
		protected override byte Sid
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00018AD2 File Offset: 0x00016CD2
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("^");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004D2 RID: 1234
		public const byte sid = 7;

		// Token: 0x040004D3 RID: 1235
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.PowerPtg();
	}
}
