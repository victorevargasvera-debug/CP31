using System;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F7 RID: 247
	public class AreaErrPtg : global::NPOI.SS.Formula.PTG.OperandPtg
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x00016D3A File Offset: 0x00014F3A
		public AreaErrPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.unused1 = in1.ReadInt();
			this.unused2 = in1.ReadInt();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00016D5A File Offset: 0x00014F5A
		public AreaErrPtg()
		{
			this.unused1 = 0;
			this.unused2 = 0;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00016D70 File Offset: 0x00014F70
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(43 + base.PtgClass));
			out1.WriteInt(this.unused1);
			out1.WriteInt(this.unused2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00016D99 File Offset: 0x00014F99
		public override string ToFormulaString()
		{
			return global::NPOI.SS.UserModel.FormulaError.REF.String;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public override int Size
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x0400044F RID: 1103
		public const byte sid = 43;

		// Token: 0x04000450 RID: 1104
		private int unused1;

		// Token: 0x04000451 RID: 1105
		private int unused2;
	}
}
