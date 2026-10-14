using System;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000126 RID: 294
	[global::System.Serializable]
	public abstract class RefPtgBase : global::NPOI.SS.Formula.PTG.OperandPtg
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x00016E6E File Offset: 0x0001506E
		protected RefPtgBase()
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000194AC File Offset: 0x000176AC
		protected RefPtgBase(string cellref)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(cellref);
			this.Row = cellReference.Row;
			this.Column = (int)cellReference.Col;
			this.IsColRelative = !cellReference.IsColAbsolute;
			this.IsRowRelative = !cellReference.IsRowAbsolute;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000194FC File Offset: 0x000176FC
		protected RefPtgBase(global::NPOI.SS.Util.CellReference c)
		{
			this.Row = c.Row;
			this.Column = (int)c.Col;
			this.IsColRelative = !c.IsColAbsolute;
			this.IsRowRelative = !c.IsRowAbsolute;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001953A File Offset: 0x0001773A
		protected RefPtgBase(int row, int column, bool isRowRelative, bool isColumnRelative)
		{
			this.Row = row;
			this.Column = column;
			this.IsRowRelative = isRowRelative;
			this.IsColRelative = isColumnRelative;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001955F File Offset: 0x0001775F
		protected RefPtgBase(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_row = in1.ReadUShort();
			this.field_2_col = in1.ReadUShort();
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001957F File Offset: 0x0001777F
		protected void ReadCoordinates(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_row = in1.ReadUShort();
			this.field_2_col = in1.ReadUShort();
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00019599 File Offset: 0x00017799
		protected void WriteCoordinates(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_row);
			out1.WriteShort(this.field_2_col);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000195B3 File Offset: 0x000177B3
		protected void WriteCoordinates(byte[] array, int offset)
		{
			global::NPOI.Util.LittleEndian.PutUShort(array, offset, this.field_1_row);
			global::NPOI.Util.LittleEndian.PutUShort(array, offset + 2, this.field_2_col);
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000195D1 File Offset: 0x000177D1
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000195D9 File Offset: 0x000177D9
		public int Row
		{
			get
			{
				return this.field_1_row;
			}
			set
			{
				this.field_1_row = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000195D1 File Offset: 0x000177D1
		public int RowAsInt
		{
			get
			{
				return this.field_1_row;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000195E2 File Offset: 0x000177E2
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x000195F4 File Offset: 0x000177F4
		public bool IsRowRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.RefPtgBase.rowRelative.IsSet(this.field_2_col);
			}
			set
			{
				this.field_2_col = global::NPOI.SS.Formula.PTG.RefPtgBase.rowRelative.SetBoolean(this.field_2_col, value);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0001960D File Offset: 0x0001780D
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0001961F File Offset: 0x0001781F
		public bool IsColRelative
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.RefPtgBase.colRelative.IsSet(this.field_2_col);
			}
			set
			{
				this.field_2_col = global::NPOI.SS.Formula.PTG.RefPtgBase.colRelative.SetBoolean(this.field_2_col, value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00019638 File Offset: 0x00017838
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00019640 File Offset: 0x00017840
		public int ColumnRawX
		{
			get
			{
				return this.field_2_col;
			}
			set
			{
				this.field_2_col = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00019649 File Offset: 0x00017849
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0001965B File Offset: 0x0001785B
		public int Column
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.RefPtgBase.column.GetValue(this.field_2_col);
			}
			set
			{
				this.field_2_col = global::NPOI.SS.Formula.PTG.RefPtgBase.column.SetValue(this.field_2_col, value);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00019674 File Offset: 0x00017874
		public string FormatReferenceAsString()
		{
			return new global::NPOI.SS.Util.CellReference(this.Row, this.Column, !this.IsRowRelative, !this.IsColRelative).FormatAsString();
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x040004E7 RID: 1255
		private int field_1_row;

		// Token: 0x040004E8 RID: 1256
		private int field_2_col;

		// Token: 0x040004E9 RID: 1257
		private static global::NPOI.Util.BitField rowRelative = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x040004EA RID: 1258
		private static global::NPOI.Util.BitField colRelative = global::NPOI.Util.BitFieldFactory.GetInstance(16384);

		// Token: 0x040004EB RID: 1259
		private static global::NPOI.Util.BitField column = global::NPOI.Util.BitFieldFactory.GetInstance(16383);
	}
}
