using System;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000103 RID: 259
	public class DeletedRef3DPtg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.WorkbookDependentFormula
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00017EE5 File Offset: 0x000160E5
		public DeletedRef3DPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_index_extern_sheet = in1.ReadUShort();
			this.unused1 = in1.ReadInt();
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00017F05 File Offset: 0x00016105
		public DeletedRef3DPtg(int externSheetIndex)
		{
			this.field_1_index_extern_sheet = externSheetIndex;
			this.unused1 = 0;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00017F1B File Offset: 0x0001611B
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return global::NPOI.SS.Formula.PTG.ExternSheetNameResolver.PrependSheetName(book, this.field_1_index_extern_sheet, global::NPOI.SS.UserModel.FormulaError.REF.String);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00017EA4 File Offset: 0x000160A4
		public override string ToFormulaString()
		{
			throw new global::System.Exception("3D references need a workbook to determine formula text");
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00017F33 File Offset: 0x00016133
		public override int Size
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00017F36 File Offset: 0x00016136
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(60 + base.PtgClass));
			out1.WriteShort(this.field_1_index_extern_sheet);
			out1.WriteInt(this.unused1);
		}

		// Token: 0x04000480 RID: 1152
		public const byte sid = 60;

		// Token: 0x04000481 RID: 1153
		private int field_1_index_extern_sheet;

		// Token: 0x04000482 RID: 1154
		private int unused1;
	}
}
