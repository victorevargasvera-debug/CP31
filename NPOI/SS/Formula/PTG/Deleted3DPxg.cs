using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000ED RID: 237
	public class Deleted3DPxg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.PTG.Pxg
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x00016168 File Offset: 0x00014368
		public Deleted3DPxg(int externalWorkbookNumber, string sheetName)
		{
			this.externalWorkbookNumber = externalWorkbookNumber;
			this.sheetName = sheetName;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00016185 File Offset: 0x00014385
		public Deleted3DPxg(string sheetName) : this(-1, sheetName)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00016190 File Offset: 0x00014390
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append(" [");
				stringBuilder.Append("workbook=").Append(this.ExternalWorkbookNumber);
				stringBuilder.Append("] ");
			}
			if (this.sheetName != null)
			{
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.sheetName);
			}
			stringBuilder.Append(" ! ");
			stringBuilder.Append(global::NPOI.SS.UserModel.FormulaError.REF.String);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001623C File Offset: 0x0001443C
		public int ExternalWorkbookNumber
		{
			get
			{
				return this.externalWorkbookNumber;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00016244 File Offset: 0x00014444
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0001624C File Offset: 0x0001444C
		public string SheetName
		{
			get
			{
				return this.sheetName;
			}
			set
			{
				this.sheetName = value;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00016258 File Offset: 0x00014458
		public override string ToFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(this.externalWorkbookNumber);
				stringBuilder.Append(']');
			}
			if (this.sheetName != null)
			{
				stringBuilder.Append(this.sheetName);
			}
			stringBuilder.Append('!');
			stringBuilder.Append(global::NPOI.SS.UserModel.FormulaError.REF.String);
			return stringBuilder.ToString();
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001615C File Offset: 0x0001435C
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			throw new global::System.InvalidOperationException("XSSF-only Ptg, should not be serialised");
		}

		// Token: 0x04000436 RID: 1078
		private int externalWorkbookNumber = -1;

		// Token: 0x04000437 RID: 1079
		private string sheetName;
	}
}
