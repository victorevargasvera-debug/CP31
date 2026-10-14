using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000394 RID: 916
	public abstract class CFHeaderBase : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06001F35 RID: 7989 RVA: 0x0005FE49 File Offset: 0x0005E049
		protected CFHeaderBase()
		{
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0005FE54 File Offset: 0x0005E054
		protected CFHeaderBase(global::NPOI.SS.Util.CellRangeAddress[] regions, int nRules)
		{
			global::NPOI.SS.Util.CellRangeAddress[] cellRanges = global::NPOI.SS.Util.CellRangeUtil.MergeCellRanges(regions);
			this.CellRanges = cellRanges;
			this.field_1_numcf = nRules;
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0005FE7C File Offset: 0x0005E07C
		protected void CreateEmpty()
		{
			this.field_3_enclosing_cell_range = new global::NPOI.SS.Util.CellRangeAddress(0, 0, 0, 0);
			this.field_4_cell_ranges = new global::NPOI.SS.Util.CellRangeAddressList();
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0005FE98 File Offset: 0x0005E098
		protected void Read(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_numcf = (int)in1.ReadShort();
			this.field_2_need_recalculation_and_id = (int)in1.ReadShort();
			this.field_3_enclosing_cell_range = new global::NPOI.SS.Util.CellRangeAddress(in1);
			this.field_4_cell_ranges = new global::NPOI.SS.Util.CellRangeAddressList(in1);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0005FECA File Offset: 0x0005E0CA
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0005FED2 File Offset: 0x0005E0D2
		public int NumberOfConditionalFormats
		{
			get
			{
				return this.field_1_numcf;
			}
			set
			{
				this.field_1_numcf = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0005FEDB File Offset: 0x0005E0DB
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0005FEE8 File Offset: 0x0005E0E8
		public bool NeedRecalculation
		{
			get
			{
				return (this.field_2_need_recalculation_and_id & 1) == 1;
			}
			set
			{
				if (value == this.NeedRecalculation)
				{
					return;
				}
				if (value)
				{
					this.field_2_need_recalculation_and_id++;
					return;
				}
				this.field_2_need_recalculation_and_id--;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0005FF14 File Offset: 0x0005E114
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x0005FF1E File Offset: 0x0005E11E
		public int ID
		{
			get
			{
				return this.field_2_need_recalculation_and_id >> 1;
			}
			set
			{
				bool needRecalculation = this.NeedRecalculation;
				this.field_2_need_recalculation_and_id = value << 1;
				if (needRecalculation)
				{
					this.field_2_need_recalculation_and_id++;
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0005FF3F File Offset: 0x0005E13F
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x0005FF47 File Offset: 0x0005E147
		public global::NPOI.SS.Util.CellRangeAddress EnclosingCellRange
		{
			get
			{
				return this.field_3_enclosing_cell_range;
			}
			set
			{
				this.field_3_enclosing_cell_range = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0005FF50 File Offset: 0x0005E150
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x0005FF60 File Offset: 0x0005E160
		public global::NPOI.SS.Util.CellRangeAddress[] CellRanges
		{
			get
			{
				return this.field_4_cell_ranges.CellRangeAddresses;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentException("cellRanges must not be null");
				}
				global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList = new global::NPOI.SS.Util.CellRangeAddressList();
				global::NPOI.SS.Util.CellRangeAddress crB = null;
				for (int i = 0; i < value.Length; i++)
				{
					global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = value[i];
					crB = global::NPOI.SS.Util.CellRangeUtil.CreateEnclosingCellRange(cellRangeAddress, crB);
					cellRangeAddressList.AddCellRangeAddress(cellRangeAddress);
				}
				this.field_3_enclosing_cell_range = crB;
				this.field_4_cell_ranges = cellRangeAddressList;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001F43 RID: 8003
		protected abstract string RecordName { get; }

		// Token: 0x06001F44 RID: 8004 RVA: 0x0005FFB4 File Offset: 0x0005E1B4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[").Append(this.RecordName).Append("]\n");
			stringBuilder.Append("\t.numCF             = ").Append(this.NumberOfConditionalFormats).Append("\n");
			stringBuilder.Append("\t.needRecalc        = ").Append(this.NeedRecalculation).Append("\n");
			stringBuilder.Append("\t.id                = ").Append(this.ID).Append("\n");
			stringBuilder.Append("\t.enclosingCellRange= ").Append(this.EnclosingCellRange).Append("\n");
			stringBuilder.Append("\t.CFranges=[");
			for (int i = 0; i < this.field_4_cell_ranges.CountRanges(); i++)
			{
				stringBuilder.Append((i == 0) ? "" : ",").Append(this.field_4_cell_ranges.GetCellRangeAddress(i).ToString());
			}
			stringBuilder.Append("]\n");
			stringBuilder.Append("[/").Append(this.RecordName).Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000600ED File Offset: 0x0005E2ED
		protected override int DataSize
		{
			get
			{
				return 12 + this.field_4_cell_ranges.Size;
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000600FD File Offset: 0x0005E2FD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_numcf);
			out1.WriteShort(this.field_2_need_recalculation_and_id);
			this.field_3_enclosing_cell_range.Serialize(out1);
			this.field_4_cell_ranges.Serialize(out1);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0006012F File Offset: 0x0005E32F
		protected void CopyTo(global::NPOI.HSSF.Record.CFHeaderBase result)
		{
			result.field_1_numcf = this.field_1_numcf;
			result.field_2_need_recalculation_and_id = this.field_2_need_recalculation_and_id;
			result.field_3_enclosing_cell_range = this.field_3_enclosing_cell_range.Copy();
			result.field_4_cell_ranges = this.field_4_cell_ranges.Copy();
		}

		// Token: 0x04000BCF RID: 3023
		private int field_1_numcf;

		// Token: 0x04000BD0 RID: 3024
		private int field_2_need_recalculation_and_id;

		// Token: 0x04000BD1 RID: 3025
		private global::NPOI.SS.Util.CellRangeAddress field_3_enclosing_cell_range;

		// Token: 0x04000BD2 RID: 3026
		private global::NPOI.SS.Util.CellRangeAddressList field_4_cell_ranges;
	}
}
