using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041C RID: 1052
	public class SelectionRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x00073EF3 File Offset: 0x000720F3
		public SelectionRecord(int activeCellRow, int activeCellCol)
		{
			this.field_1_pane = 3;
			this.field_2_row_active_cell = activeCellRow;
			this.field_3_col_active_cell = activeCellCol;
			this.field_4_ref_active_cell = 0;
			this.field_6_refs = new global::NPOI.SS.Util.CellRangeAddress8Bit[]
			{
				new global::NPOI.SS.Util.CellRangeAddress8Bit(activeCellRow, activeCellRow, activeCellCol, activeCellCol)
			};
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00073F30 File Offset: 0x00072130
		public SelectionRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_pane = (byte)in1.ReadByte();
			this.field_2_row_active_cell = in1.ReadUShort();
			this.field_3_col_active_cell = (int)in1.ReadShort();
			this.field_4_ref_active_cell = (int)in1.ReadShort();
			int num = in1.ReadUShort();
			this.field_6_refs = new global::NPOI.SS.Util.CellRangeAddress8Bit[num];
			for (int i = 0; i < num; i++)
			{
				this.field_6_refs[i] = new global::NPOI.SS.Util.CellRangeAddress8Bit(in1);
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x00073FA1 File Offset: 0x000721A1
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x00073FA9 File Offset: 0x000721A9
		public byte Pane
		{
			get
			{
				return this.field_1_pane;
			}
			set
			{
				this.field_1_pane = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x00073FB2 File Offset: 0x000721B2
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x00073FBA File Offset: 0x000721BA
		public int ActiveCellRow
		{
			get
			{
				return this.field_2_row_active_cell;
			}
			set
			{
				this.field_2_row_active_cell = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x00073FC3 File Offset: 0x000721C3
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x00073FCB File Offset: 0x000721CB
		public int ActiveCellCol
		{
			get
			{
				return this.field_3_col_active_cell;
			}
			set
			{
				this.field_3_col_active_cell = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x00073FD4 File Offset: 0x000721D4
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x00073FDC File Offset: 0x000721DC
		public int ActiveCellRef
		{
			get
			{
				return this.field_4_ref_active_cell;
			}
			set
			{
				this.field_4_ref_active_cell = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x00073FE5 File Offset: 0x000721E5
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x00073FED File Offset: 0x000721ED
		public global::NPOI.SS.Util.CellRangeAddress8Bit[] CellReferences
		{
			get
			{
				return this.field_6_refs;
			}
			set
			{
				this.field_6_refs = value;
			}
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00073FF8 File Offset: 0x000721F8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SELECTION]\n");
			stringBuilder.Append("    .pane            = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.Pane)).Append("\n");
			stringBuilder.Append("    .activecellrow   = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ActiveCellRow)).Append("\n");
			stringBuilder.Append("    .activecellcol   = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ActiveCellCol)).Append("\n");
			stringBuilder.Append("    .activecellref   = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ActiveCellRef)).Append("\n");
			stringBuilder.Append("    .numrefs         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_6_refs.Length)).Append("\n");
			stringBuilder.Append("[/SELECTION]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000740E8 File Offset: 0x000722E8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.Pane);
			out1.WriteShort(this.ActiveCellRow);
			out1.WriteShort(this.ActiveCellCol);
			out1.WriteShort(this.ActiveCellRef);
			int v = this.field_6_refs.Length;
			out1.WriteShort(v);
			for (int i = 0; i < this.field_6_refs.Length; i++)
			{
				this.field_6_refs[i].Serialize(out1);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x00074156 File Offset: 0x00072356
		protected override int DataSize
		{
			get
			{
				return 9 + global::NPOI.SS.Util.CellRangeAddress8Bit.GetEncodedSize(this.field_6_refs.Length);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x00074168 File Offset: 0x00072368
		public override short Sid
		{
			get
			{
				return 29;
			}
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0007416C File Offset: 0x0007236C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.SelectionRecord(this.field_2_row_active_cell, this.field_3_col_active_cell)
			{
				field_1_pane = this.field_1_pane,
				field_4_ref_active_cell = this.field_4_ref_active_cell,
				field_6_refs = this.field_6_refs
			};
		}

		// Token: 0x04001023 RID: 4131
		public const short sid = 29;

		// Token: 0x04001024 RID: 4132
		private byte field_1_pane;

		// Token: 0x04001025 RID: 4133
		private int field_2_row_active_cell;

		// Token: 0x04001026 RID: 4134
		private int field_3_col_active_cell;

		// Token: 0x04001027 RID: 4135
		private int field_4_ref_active_cell;

		// Token: 0x04001028 RID: 4136
		private global::NPOI.SS.Util.CellRangeAddress8Bit[] field_6_refs;
	}
}
