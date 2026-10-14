using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000110 RID: 272
	public class LessThanPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x0600090F RID: 2319 RVA: 0x000169F7 File Offset: 0x00014BF7
		private LessThanPtg()
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00016AA5 File Offset: 0x00014CA5
		protected override byte Sid
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001869E File Offset: 0x0001689E
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("<");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x040004A9 RID: 1193
		public const byte sid = 9;

		// Token: 0x040004AA RID: 1194
		private const string LESSTHAN = "<";

		// Token: 0x040004AB RID: 1195
		public static readonly global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.LessThanPtg();
	}
}
