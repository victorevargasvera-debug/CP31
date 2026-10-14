using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000100 RID: 256
	public class ConcatPtg : global::NPOI.SS.Formula.PTG.ValueOperatorPtg
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x000169F7 File Offset: 0x00014BF7
		private ConcatPtg()
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override byte Sid
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00017DF7 File Offset: 0x00015FF7
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append("&");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x04000479 RID: 1145
		public const byte sid = 8;

		// Token: 0x0400047A RID: 1146
		private const string CONCAT = "&";

		// Token: 0x0400047B RID: 1147
		public static readonly global::NPOI.SS.Formula.PTG.ValueOperatorPtg instance = new global::NPOI.SS.Formula.PTG.ConcatPtg();
	}
}
