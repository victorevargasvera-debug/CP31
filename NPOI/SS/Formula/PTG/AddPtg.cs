using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F4 RID: 244
	public class AddPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x000169F7 File Offset: 0x00014BF7
		private AddPtg()
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000169FF File Offset: 0x00014BFF
		protected override byte Sid
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00016A05 File Offset: 0x00014C05
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(global::NPOI.SS.Formula.PTG.AddPtg.Add);
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x04000446 RID: 1094
		public const byte sid = 3;

		// Token: 0x04000447 RID: 1095
		private static string Add = "+";

		// Token: 0x04000448 RID: 1096
		public static global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.AddPtg();
	}
}
