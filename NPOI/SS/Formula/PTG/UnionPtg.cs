using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012D RID: 301
	public class UnionPtg : global::NPOI.SS.Formula.PTG.OperationPtg
	{
		// Token: 0x060009E4 RID: 2532 RVA: 0x00018525 File Offset: 0x00016725
		private UnionPtg()
		{
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00019A20 File Offset: 0x00017C20
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(16 + base.PtgClass));
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00019A31 File Offset: 0x00017C31
		public override string ToFormulaString()
		{
			return ",";
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00019A38 File Offset: 0x00017C38
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(",");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x040004FF RID: 1279
		public const byte sid = 16;

		// Token: 0x04000500 RID: 1280
		public static global::NPOI.SS.Formula.PTG.OperationPtg instance = new global::NPOI.SS.Formula.PTG.UnionPtg();
	}
}
