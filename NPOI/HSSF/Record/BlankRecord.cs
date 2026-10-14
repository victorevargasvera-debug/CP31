using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003AA RID: 938
	public class BlankRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.CellValueRecordInterface, global::System.IComparable, global::System.ICloneable
	{
		// Token: 0x0600206C RID: 8300 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BlankRecord()
		{
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00063A43 File Offset: 0x00061C43
		public BlankRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row = in1.ReadUShort();
			this.field_2_col = (int)in1.ReadShort();
			this.field_3_xf = in1.ReadShort();
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00063A6F File Offset: 0x00061C6F
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00063A77 File Offset: 0x00061C77
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

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00063A80 File Offset: 0x00061C80
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00063A88 File Offset: 0x00061C88
		public int Column
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00063A9A File Offset: 0x00061C9A
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00063A91 File Offset: 0x00061C91
		public short XFIndex
		{
			get
			{
				return this.field_3_xf;
			}
			set
			{
				this.field_3_xf = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00063AA2 File Offset: 0x00061CA2
		public override short Sid
		{
			get
			{
				return 513;
			}
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00063AAC File Offset: 0x00061CAC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BLANK]\n");
			stringBuilder.Append("row       = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Row)).Append("\n");
			stringBuilder.Append("col       = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Column)).Append("\n");
			stringBuilder.Append("xf        = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.XFIndex)).Append("\n");
			stringBuilder.Append("[/BLANK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00017F5F File Offset: 0x0001615F
		protected override int DataSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00063B4D File Offset: 0x00061D4D
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.Row);
			out1.WriteShort(this.Column);
			out1.WriteShort((int)this.XFIndex);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00063B74 File Offset: 0x00061D74
		public int CompareTo(object obj)
		{
			global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = (global::NPOI.HSSF.Record.CellValueRecordInterface)obj;
			if (this.Row == cellValueRecordInterface.Row && this.Column == cellValueRecordInterface.Column)
			{
				return 0;
			}
			if (this.Row < cellValueRecordInterface.Row)
			{
				return -1;
			}
			if (this.Row > cellValueRecordInterface.Row)
			{
				return 1;
			}
			if (this.Column < cellValueRecordInterface.Column)
			{
				return -1;
			}
			if (this.Column > cellValueRecordInterface.Column)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00063BE7 File Offset: 0x00061DE7
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.BlankRecord
			{
				field_1_row = this.field_1_row,
				field_2_col = this.field_2_col,
				field_3_xf = this.field_3_xf
			};
		}

		// Token: 0x04000C9F RID: 3231
		public const short sid = 513;

		// Token: 0x04000CA0 RID: 3232
		private int field_1_row;

		// Token: 0x04000CA1 RID: 3233
		private int field_2_col;

		// Token: 0x04000CA2 RID: 3234
		private short field_3_xf;
	}
}
