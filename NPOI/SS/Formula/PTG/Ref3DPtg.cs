using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000122 RID: 290
	public class Ref3DPtg : global::NPOI.SS.Formula.PTG.RefPtgBase, global::NPOI.SS.Formula.WorkbookDependentFormula, global::NPOI.SS.Formula.IExternSheetReferenceToken
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x000191EA File Offset: 0x000173EA
		public Ref3DPtg()
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00019212 File Offset: 0x00017412
		public Ref3DPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_index_extern_sheet = (int)in1.ReadShort();
			base.ReadCoordinates(in1);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00019250 File Offset: 0x00017450
		public Ref3DPtg(string cellref, int externIdx)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(cellref);
			base.Row = cellReference.Row;
			base.Column = (int)cellReference.Col;
			base.IsColRelative = !cellReference.IsColAbsolute;
			base.IsRowRelative = !cellReference.IsRowAbsolute;
			this.ExternSheetIndex = externIdx;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000192C7 File Offset: 0x000174C7
		public Ref3DPtg(global::NPOI.SS.Util.CellReference cr, int externIdx) : base(cr)
		{
			this.ExternSheetIndex = externIdx;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000192F8 File Offset: 0x000174F8
		public override string ToString()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(base.Row, base.Column, !base.IsRowRelative, !base.IsColRelative);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			stringBuilder.Append("sheetIx=").Append(this.ExternSheetIndex);
			stringBuilder.Append(" ! ");
			stringBuilder.Append(cellReference.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001938D File Offset: 0x0001758D
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(58 + base.PtgClass));
			out1.WriteShort(this.ExternSheetIndex);
			base.WriteCoordinates(out1);
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00017F33 File Offset: 0x00016133
		public override int Size
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000193B1 File Offset: 0x000175B1
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000193B9 File Offset: 0x000175B9
		public int ExternSheetIndex
		{
			get
			{
				return this.field_1_index_extern_sheet;
			}
			set
			{
				this.field_1_index_extern_sheet = value;
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000193C2 File Offset: 0x000175C2
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return global::NPOI.SS.Formula.PTG.ExternSheetNameResolver.PrependSheetName(book, this.field_1_index_extern_sheet, base.FormatReferenceAsString());
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00016D1A File Offset: 0x00014F1A
		public override string ToFormulaString()
		{
			throw new global::System.NotImplementedException("3D references need a workbook to determine formula text");
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x040004DD RID: 1245
		public const byte sid = 58;

		// Token: 0x040004DE RID: 1246
		private const int SIZE = 7;

		// Token: 0x040004DF RID: 1247
		private int field_1_index_extern_sheet;

		// Token: 0x040004E0 RID: 1248
		private global::NPOI.Util.BitField rowRelative = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x040004E1 RID: 1249
		private global::NPOI.Util.BitField colRelative = global::NPOI.Util.BitFieldFactory.GetInstance(16384);
	}
}
