using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C3 RID: 963
	public class DBCellRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x00066D2B File Offset: 0x00064F2B
		public DBCellRecord()
		{
			this.field_2_cell_offsets = new short[0];
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00066D40 File Offset: 0x00064F40
		public DBCellRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row_offset = in1.ReadUShort();
			int remaining = in1.Remaining;
			this.field_2_cell_offsets = new short[remaining / 2];
			for (int i = 0; i < this.field_2_cell_offsets.Length; i++)
			{
				this.field_2_cell_offsets[i] = in1.ReadShort();
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00066D95 File Offset: 0x00064F95
		public DBCellRecord(int rowOffset, short[] cellOffsets)
		{
			this.field_1_row_offset = rowOffset;
			this.field_2_cell_offsets = cellOffsets;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00066DAC File Offset: 0x00064FAC
		public void AddCellOffset(short offset)
		{
			if (this.field_2_cell_offsets == null)
			{
				this.field_2_cell_offsets = new short[1];
			}
			else
			{
				short[] destinationArray = new short[this.field_2_cell_offsets.Length + 1];
				global::System.Array.Copy(this.field_2_cell_offsets, 0, destinationArray, 0, this.field_2_cell_offsets.Length);
				this.field_2_cell_offsets = destinationArray;
			}
			this.field_2_cell_offsets[this.field_2_cell_offsets.Length - 1] = offset;
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00066E0E File Offset: 0x0006500E
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00066E16 File Offset: 0x00065016
		public int RowOffset
		{
			get
			{
				return this.field_1_row_offset;
			}
			set
			{
				this.field_1_row_offset = value;
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00066E1F File Offset: 0x0006501F
		public short GetCellOffsetAt(int index)
		{
			return this.field_2_cell_offsets[index];
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00066E29 File Offset: 0x00065029
		public int NumCellOffsets
		{
			get
			{
				return this.field_2_cell_offsets.Length;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00066E34 File Offset: 0x00065034
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DBCELL]\n");
			stringBuilder.Append("    .rowoffset       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RowOffset)).Append("\n");
			for (int i = 0; i < this.field_2_cell_offsets.Length; i++)
			{
				stringBuilder.Append("    .cell_").Append(i).Append(" = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.field_2_cell_offsets[i])).Append("\n");
			}
			stringBuilder.Append("[/DBCELL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00066ED8 File Offset: 0x000650D8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_row_offset);
			for (int i = 0; i < this.field_2_cell_offsets.Length; i++)
			{
				out1.WriteShort((int)this.field_2_cell_offsets[i]);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00066F12 File Offset: 0x00065112
		protected override int DataSize
		{
			get
			{
				return 4 + this.field_2_cell_offsets.Length * 2;
			}
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00066F20 File Offset: 0x00065120
		public static int CalculateSizeOfRecords(int nBlocks, int nRows)
		{
			return nBlocks * 8 + nRows * 2;
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00066F29 File Offset: 0x00065129
		public override short Sid
		{
			get
			{
				return 215;
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x04000D43 RID: 3395
		public const int BLOCK_SIZE = 32;

		// Token: 0x04000D44 RID: 3396
		public const short sid = 215;

		// Token: 0x04000D45 RID: 3397
		private int field_1_row_offset;

		// Token: 0x04000D46 RID: 3398
		private short[] field_2_cell_offsets;
	}
}
