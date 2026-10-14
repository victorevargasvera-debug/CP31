using System;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000102 RID: 258
	public class DeletedArea3DPtg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.WorkbookDependentFormula
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00017E43 File Offset: 0x00016043
		public DeletedArea3DPtg(int externSheetIndex)
		{
			this.field_1_index_extern_sheet = externSheetIndex;
			this.unused1 = 0;
			this.unused2 = 0;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00017E60 File Offset: 0x00016060
		public DeletedArea3DPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_index_extern_sheet = in1.ReadUShort();
			this.unused1 = in1.ReadInt();
			this.unused2 = in1.ReadInt();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00017E8C File Offset: 0x0001608C
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return global::NPOI.SS.Formula.PTG.ExternSheetNameResolver.PrependSheetName(book, this.field_1_index_extern_sheet, global::NPOI.SS.UserModel.FormulaError.REF.String);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00017EA4 File Offset: 0x000160A4
		public override string ToFormulaString()
		{
			throw new global::System.Exception("3D references need a workbook to determine formula text");
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00016C75 File Offset: 0x00014E75
		public override int Size
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00017EB0 File Offset: 0x000160B0
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(61 + base.PtgClass));
			out1.WriteShort(this.field_1_index_extern_sheet);
			out1.WriteInt(this.unused1);
			out1.WriteInt(this.unused2);
		}

		// Token: 0x0400047C RID: 1148
		public const byte sid = 61;

		// Token: 0x0400047D RID: 1149
		private int field_1_index_extern_sheet;

		// Token: 0x0400047E RID: 1150
		private int unused1;

		// Token: 0x0400047F RID: 1151
		private int unused2;
	}
}
