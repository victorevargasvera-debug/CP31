using System;
using NPOI.HSSF.Record;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FC RID: 252
	[global::System.Serializable]
	public abstract class AreaPtgBase : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.PTG.AreaI
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x00016E62 File Offset: 0x00015062
		protected global::System.Exception NotImplemented()
		{
			return new global::System.NotImplementedException("Coding Error: This method should never be called. This ptg should be Converted");
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00016E6E File Offset: 0x0001506E
		protected AreaPtgBase()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00016E76 File Offset: 0x00015076
		protected AreaPtgBase(string arearef) : this(new global::NPOI.SS.Util.AreaReference(arearef))
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00016E84 File Offset: 0x00015084
		protected AreaPtgBase(global::NPOI.SS.Util.AreaReference ar)
		{
			global::NPOI.SS.Util.CellReference firstCell = ar.FirstCell;
			global::NPOI.SS.Util.CellReference lastCell = ar.LastCell;
			this.FirstRow = firstCell.Row;
			this.FirstColumn = (int)((firstCell.Col == -1) ? 0 : firstCell.Col);
			this.LastRow = lastCell.Row;
			this.LastColumn = (int)((lastCell.Col == -1) ? 255 : lastCell.Col);
			this.IsFirstColRelative = !firstCell.IsColAbsolute;
			this.IsLastColRelative = !lastCell.IsColAbsolute;
			this.IsFirstRowRelative = !firstCell.IsRowAbsolute;
			this.IsLastRowRelative = !lastCell.IsRowAbsolute;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00016F30 File Offset: 0x00015130
		protected AreaPtgBase(int firstRow, int lastRow, int firstColumn, int lastColumn, bool firstRowRelative, bool lastRowRelative, bool firstColRelative, bool lastColRelative)
		{
			if (lastRow >= firstRow)
			{
				this.FirstRow = firstRow;
				this.LastRow = lastRow;
				this.IsFirstRowRelative = firstRowRelative;
				this.IsLastRowRelative = lastRowRelative;
			}
			else
			{
				this.FirstRow = lastRow;
				this.LastRow = firstRow;
				this.IsFirstRowRelative = lastRowRelative;
				this.IsLastRowRelative = firstRowRelative;
			}
			if (lastColumn >= firstColumn)
			{
				this.FirstColumn = firstColumn;
				this.LastColumn = lastColumn;
				this.IsFirstColRelative = firstColRelative;
				this.IsLastColRelative = lastColRelative;
				return;
			}
			this.FirstColumn = lastColumn;
			this.LastColumn = firstColumn;
			this.IsFirstColRelative = lastColRelative;
			this.IsLastColRelative = firstColRelative;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00016FCC File Offset: 0x000151CC
		public void SortTopLeftToBottomRight()
		{
			if (this.FirstRow > this.LastRow)
			{
				int firstRow = this.FirstRow;
				bool isFirstRowRelative = this.IsFirstRowRelative;
				this.FirstRow = this.LastRow;
				this.IsFirstRowRelative = this.IsLastRowRelative;
				this.LastRow = firstRow;
				this.IsLastRowRelative = isFirstRowRelative;
			}
			if (this.FirstColumn > this.LastColumn)
			{
				int firstColumn = this.FirstColumn;
				bool isFirstColRelative = this.IsFirstColRelative;
				this.FirstColumn = this.LastColumn;
				this.IsFirstColRelative = this.IsLastColRelative;
				this.LastColumn = firstColumn;
				this.IsLastColRelative = isFirstColRelative;
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001705D File Offset: 0x0001525D
		protected void ReadCoordinates(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_first_row = in1.ReadUShort();
			this.field_2_last_row = in1.ReadUShort();
			this.field_3_first_column = in1.ReadUShort();
			this.field_4_last_column = in1.ReadUShort();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001708F File Offset: 0x0001528F
		protected void WriteCoordinates(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_first_row);
			out1.WriteShort(this.field_2_last_row);
			out1.WriteShort(this.field_3_first_column);
			out1.WriteShort(this.field_4_last_column);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000170C1 File Offset: 0x000152C1
		protected void WriteCoordinates(byte[] array, int offset)
		{
			global::NPOI.Util.LittleEndian.PutUShort(array, offset, this.field_1_first_row);
			global::NPOI.Util.LittleEndian.PutUShort(array, offset + 2, this.field_2_last_row);
			global::NPOI.Util.LittleEndian.PutUShort(array, offset + 4, this.field_3_first_column);
			global::NPOI.Util.LittleEndian.PutUShort(array, offset + 6, this.field_4_last_column);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000170FD File Offset: 0x000152FD
		protected AreaPtgBase(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_first_row = in1.ReadUShort();
			this.field_2_last_row = in1.ReadUShort();
			this.field_3_first_column = in1.ReadUShort();
			this.field_4_last_column = in1.ReadUShort();
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00017135 File Offset: 0x00015335
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0001713D File Offset: 0x0001533D
		public virtual int FirstRow
		{
			get
			{
				return this.field_1_first_row;
			}
			set
			{
				this.field_1_first_row = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00017146 File Offset: 0x00015346
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0001714E File Offset: 0x0001534E
		public virtual int LastRow
		{
			get
			{
				return this.field_2_last_row;
			}
			set
			{
				this.field_2_last_row = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00017157 File Offset: 0x00015357
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00017169 File Offset: 0x00015369
		public virtual int FirstColumn
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.columnMask.GetValue(this.field_3_first_column);
			}
			set
			{
				this.field_3_first_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.columnMask.SetValue(this.field_3_first_column, value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00017182 File Offset: 0x00015382
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00017194 File Offset: 0x00015394
		public virtual bool IsFirstRowRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.rowRelative.IsSet(this.field_3_first_column);
			}
			set
			{
				this.field_3_first_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.rowRelative.SetBoolean(this.field_3_first_column, value);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000171AD File Offset: 0x000153AD
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x000171BF File Offset: 0x000153BF
		public virtual bool IsFirstColRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.colRelative.IsSet(this.field_3_first_column);
			}
			set
			{
				this.field_3_first_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.colRelative.SetBoolean(this.field_3_first_column, value);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000171D8 File Offset: 0x000153D8
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x000171EA File Offset: 0x000153EA
		public virtual int LastColumn
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.columnMask.GetValue(this.field_4_last_column);
			}
			set
			{
				this.field_4_last_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.columnMask.SetValue(this.field_4_last_column, value);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00017203 File Offset: 0x00015403
		public virtual short LastColumnRaw
		{
			get
			{
				return (short)this.field_4_last_column;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0001720C File Offset: 0x0001540C
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x0001721E File Offset: 0x0001541E
		public virtual bool IsLastRowRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.rowRelative.IsSet(this.field_4_last_column);
			}
			set
			{
				this.field_4_last_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.rowRelative.SetBoolean(this.field_4_last_column, value);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00017237 File Offset: 0x00015437
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00017249 File Offset: 0x00015449
		public virtual bool IsLastColRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AreaPtgBase.colRelative.IsSet(this.field_4_last_column);
			}
			set
			{
				this.field_4_last_column = global::NPOI.SS.Formula.PTG.AreaPtgBase.colRelative.SetBoolean(this.field_4_last_column, value);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00017262 File Offset: 0x00015462
		public void SetLastColumnRaw(short column)
		{
			this.field_4_last_column = (int)column;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000160D4 File Offset: 0x000142D4
		public override string ToFormulaString()
		{
			return this.FormatReferenceAsString();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001726C File Offset: 0x0001546C
		protected string FormatReferenceAsString()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this.FirstRow, this.FirstColumn, !this.IsFirstRowRelative, !this.IsFirstColRelative);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(this.LastRow, this.LastColumn, !this.IsLastRowRelative, !this.IsLastColRelative);
			if (global::NPOI.SS.Util.AreaReference.IsWholeColumnReference(global::NPOI.SS.SpreadsheetVersion.EXCEL97, cellReference, cellReference2))
			{
				return new global::NPOI.SS.Util.AreaReference(cellReference, cellReference2).FormatAsString();
			}
			return cellReference.FormatAsString() + ":" + cellReference2.FormatAsString();
		}

		// Token: 0x04000458 RID: 1112
		private int field_1_first_row;

		// Token: 0x04000459 RID: 1113
		private int field_2_last_row;

		// Token: 0x0400045A RID: 1114
		private int field_3_first_column;

		// Token: 0x0400045B RID: 1115
		private int field_4_last_column;

		// Token: 0x0400045C RID: 1116
		private static global::NPOI.Util.BitField rowRelative = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x0400045D RID: 1117
		private static global::NPOI.Util.BitField colRelative = global::NPOI.Util.BitFieldFactory.GetInstance(16384);

		// Token: 0x0400045E RID: 1118
		private static global::NPOI.Util.BitField columnMask = global::NPOI.Util.BitFieldFactory.GetInstance(16383);
	}
}
