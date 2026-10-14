using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039B RID: 923
	public abstract class OldCellRecord
	{
		// Token: 0x06001FC8 RID: 8136 RVA: 0x00061B24 File Offset: 0x0005FD24
		protected OldCellRecord(global::NPOI.HSSF.Record.RecordInputStream in1, bool isBiff2)
		{
			this.sid = in1.Sid;
			this.isBiff2 = isBiff2;
			this.field_1_row = in1.ReadUShort();
			this.field_2_column = in1.ReadShort();
			if (isBiff2)
			{
				this.field_3_cell_attrs = in1.ReadUShort() << 8;
				this.field_3_cell_attrs += in1.ReadUByte();
				return;
			}
			this.field_3_xf_index = in1.ReadShort();
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00061B93 File Offset: 0x0005FD93
		public int Row
		{
			get
			{
				return this.field_1_row;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00061B9B File Offset: 0x0005FD9B
		public short Column
		{
			get
			{
				return this.field_2_column;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00061BA3 File Offset: 0x0005FDA3
		public short XFIndex
		{
			get
			{
				return this.field_3_xf_index;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00061BAB File Offset: 0x0005FDAB
		public int CellAttrs
		{
			get
			{
				return this.field_3_cell_attrs;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00061BB3 File Offset: 0x0005FDB3
		public virtual bool IsBiff2
		{
			get
			{
				return this.isBiff2;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00061BBB File Offset: 0x0005FDBB
		public virtual short Sid
		{
			get
			{
				return this.sid;
			}
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00061BC4 File Offset: 0x0005FDC4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string recordName = this.RecordName;
			stringBuilder.Append("[").Append(recordName).Append("]\n");
			stringBuilder.Append("    .row    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Row)).Append("\n");
			stringBuilder.Append("    .col    = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.Column)).Append("\n");
			if (this.IsBiff2)
			{
				stringBuilder.Append("    .cellattrs = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.CellAttrs)).Append("\n");
			}
			else
			{
				stringBuilder.Append("    .xFindex   = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.XFIndex)).Append("\n");
			}
			this.AppendValueText(stringBuilder);
			stringBuilder.Append("\n");
			stringBuilder.Append("[/").Append(recordName).Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001FD0 RID: 8144
		protected abstract void AppendValueText(global::System.Text.StringBuilder sb);

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001FD1 RID: 8145
		protected abstract string RecordName { get; }

		// Token: 0x04000C44 RID: 3140
		private short sid;

		// Token: 0x04000C45 RID: 3141
		private bool isBiff2;

		// Token: 0x04000C46 RID: 3142
		private int field_1_row;

		// Token: 0x04000C47 RID: 3143
		private short field_2_column;

		// Token: 0x04000C48 RID: 3144
		private int field_3_cell_attrs;

		// Token: 0x04000C49 RID: 3145
		private short field_3_xf_index;
	}
}
