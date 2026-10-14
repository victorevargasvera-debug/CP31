using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000399 RID: 921
	public class FtCfSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x000618AB File Offset: 0x0005FAAB
		public FtCfSubRecord()
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000618B3 File Offset: 0x0005FAB3
		public FtCfSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != 2)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + size.ToString() + ")");
			}
			this.flags = in1.ReadShort();
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000618E8 File Offset: 0x0005FAE8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FtCf ]\n");
			stringBuilder.Append("  size     = ").Append(2).Append("\n");
			stringBuilder.Append("  flags    = ").Append(global::NPOI.Util.HexDump.ToHex(this.flags)).Append("\n");
			stringBuilder.Append("[/FtCf ]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00061959 File Offset: 0x0005FB59
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(7);
			out1.WriteShort(2);
			out1.WriteShort((int)this.flags);
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00017F33 File Offset: 0x00016133
		public override short Sid
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00061975 File Offset: 0x0005FB75
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FtCfSubRecord
			{
				flags = this.flags
			};
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x00061988 File Offset: 0x0005FB88
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x00061990 File Offset: 0x0005FB90
		public short Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		// Token: 0x04000C32 RID: 3122
		public const short sid = 7;

		// Token: 0x04000C33 RID: 3123
		public const short length = 2;

		// Token: 0x04000C34 RID: 3124
		public static short METAFILE_BIT = 2;

		// Token: 0x04000C35 RID: 3125
		public static short BITMAP_BIT = 9;

		// Token: 0x04000C36 RID: 3126
		public static short UNSPECIFIED_BIT = -1;

		// Token: 0x04000C37 RID: 3127
		private short flags;
	}
}
