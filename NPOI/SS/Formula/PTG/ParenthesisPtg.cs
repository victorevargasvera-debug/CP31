using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011C RID: 284
	public class ParenthesisPtg : global::NPOI.SS.Formula.PTG.ControlPtg
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x00018A60 File Offset: 0x00016C60
		private ParenthesisPtg()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00018A68 File Offset: 0x00016C68
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(21 + base.PtgClass));
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00018A79 File Offset: 0x00016C79
		public override string ToFormulaString()
		{
			return "()";
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00018A80 File Offset: 0x00016C80
		public string ToFormulaString(string[] operands)
		{
			return "(" + operands[0] + ")";
		}

		// Token: 0x040004CB RID: 1227
		private const int SIZE = 1;

		// Token: 0x040004CC RID: 1228
		public const byte sid = 21;

		// Token: 0x040004CD RID: 1229
		public static global::NPOI.SS.Formula.PTG.ControlPtg instance = new global::NPOI.SS.Formula.PTG.ParenthesisPtg();
	}
}
