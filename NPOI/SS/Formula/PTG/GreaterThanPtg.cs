using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010C RID: 268
	public class GreaterThanPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x000169F7 File Offset: 0x00014BF7
		private GreaterThanPtg()
		{
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x000184E9 File Offset: 0x000166E9
		protected override byte Sid
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000184ED File Offset: 0x000166ED
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(">");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x0400049D RID: 1181
		public const byte sid = 13;

		// Token: 0x0400049E RID: 1182
		private const string GREATERTHAN = ">";

		// Token: 0x0400049F RID: 1183
		public static readonly global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.GreaterThanPtg();
	}
}
