using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010D RID: 269
	public class IntersectionPtg : global::NPOI.SS.Formula.PTG.OperationPtg
	{
		// Token: 0x060008FA RID: 2298 RVA: 0x00018525 File Offset: 0x00016725
		private IntersectionPtg()
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001852D File Offset: 0x0001672D
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(15 + base.PtgClass));
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001853E File Offset: 0x0001673E
		public override string ToFormulaString()
		{
			return " ";
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00018545 File Offset: 0x00016745
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(" ");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x040004A0 RID: 1184
		public const byte sid = 15;

		// Token: 0x040004A1 RID: 1185
		public static global::NPOI.SS.Formula.PTG.OperationPtg instance = new global::NPOI.SS.Formula.PTG.IntersectionPtg();
	}
}
