using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F6 RID: 246
	[global::System.Serializable]
	public class Area3DPtg : global::NPOI.SS.Formula.PTG.AreaPtgBase, global::NPOI.SS.Formula.WorkbookDependentFormula, global::NPOI.SS.Formula.IExternSheetReferenceToken
	{
		// Token: 0x0600083E RID: 2110 RVA: 0x00016AFA File Offset: 0x00014CFA
		public Area3DPtg(string arearef, int externIdx) : base(arearef)
		{
			this.ExternSheetIndex = externIdx;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00016B2A File Offset: 0x00014D2A
		public Area3DPtg(global::NPOI.SS.Util.AreaReference arearef, int externIdx) : base(arearef)
		{
			this.ExternSheetIndex = externIdx;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00016B5A File Offset: 0x00014D5A
		public Area3DPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_index_extern_sheet = (int)in1.ReadShort();
			base.ReadCoordinates(in1);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00016B98 File Offset: 0x00014D98
		public Area3DPtg(int firstRow, int lastRow, int firstColumn, int lastColumn, bool firstRowRelative, bool lastRowRelative, bool firstColRelative, bool lastColRelative, int externalSheetIndex) : base(firstRow, lastRow, firstColumn, lastColumn, firstRowRelative, lastRowRelative, firstColRelative, lastColRelative)
		{
			this.ExternSheetIndex = externalSheetIndex;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00016BE0 File Offset: 0x00014DE0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			stringBuilder.Append("sheetIx=").Append(this.ExternSheetIndex);
			stringBuilder.Append(" ! ");
			stringBuilder.Append(base.FormatReferenceAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00016C51 File Offset: 0x00014E51
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(59 + base.PtgClass));
			out1.WriteShort(this.field_1_index_extern_sheet);
			base.WriteCoordinates(out1);
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00016C75 File Offset: 0x00014E75
		public override int Size
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00016C79 File Offset: 0x00014E79
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00016C81 File Offset: 0x00014E81
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

		// Token: 0x06000847 RID: 2119 RVA: 0x00016C8C File Offset: 0x00014E8C
		public void SetArea(string ref1)
		{
			global::NPOI.SS.Util.AreaReference areaReference = new global::NPOI.SS.Util.AreaReference(ref1);
			global::NPOI.SS.Util.CellReference firstCell = areaReference.FirstCell;
			global::NPOI.SS.Util.CellReference lastCell = areaReference.LastCell;
			this.FirstRow = (int)((short)firstCell.Row);
			this.FirstColumn = (int)firstCell.Col;
			this.LastRow = (int)((short)lastCell.Row);
			this.LastColumn = (int)lastCell.Col;
			this.IsFirstColRelative = !firstCell.IsColAbsolute;
			this.IsLastColRelative = !lastCell.IsColAbsolute;
			this.IsFirstRowRelative = !firstCell.IsRowAbsolute;
			this.IsLastRowRelative = !lastCell.IsRowAbsolute;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00016D1A File Offset: 0x00014F1A
		public override string ToFormulaString()
		{
			throw new global::System.NotImplementedException("3D references need a workbook to determine formula text");
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00016D26 File Offset: 0x00014F26
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return global::NPOI.SS.Formula.PTG.ExternSheetNameResolver.PrependSheetName(book, this.field_1_index_extern_sheet, base.FormatReferenceAsString());
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0400044A RID: 1098
		public const byte sid = 59;

		// Token: 0x0400044B RID: 1099
		private const int SIZE = 11;

		// Token: 0x0400044C RID: 1100
		private int field_1_index_extern_sheet;

		// Token: 0x0400044D RID: 1101
		private global::NPOI.Util.BitField rowRelative = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x0400044E RID: 1102
		private global::NPOI.Util.BitField colRelative = global::NPOI.Util.BitFieldFactory.GetInstance(16384);
	}
}
