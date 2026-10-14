using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039A RID: 922
	public class FtPioGrbitSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06001FBC RID: 8124 RVA: 0x000618AB File Offset: 0x0005FAAB
		public FtPioGrbitSubRecord()
		{
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000619AE File Offset: 0x0005FBAE
		public FtPioGrbitSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != 2)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + size.ToString() + ")");
			}
			this.flags = in1.ReadShort();
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000619E2 File Offset: 0x0005FBE2
		public void SetFlagByBit(int bitmask, bool enabled)
		{
			if (enabled)
			{
				this.flags |= (short)bitmask;
				return;
			}
			this.flags &= (short)(65535 ^ bitmask);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00061A0E File Offset: 0x0005FC0E
		public bool GetFlagByBit(int bitmask)
		{
			return ((int)this.flags & bitmask) != 0;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00061A1C File Offset: 0x0005FC1C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FtPioGrbit ]\n");
			stringBuilder.Append("  size     = ").Append(2).Append("\n");
			stringBuilder.Append("  flags    = ").Append(global::NPOI.Util.HexDump.ToHex(this.flags)).Append("\n");
			stringBuilder.Append("[/FtPioGrbit ]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00061A8D File Offset: 0x0005FC8D
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(8);
			out1.WriteShort(2);
			out1.WriteShort((int)this.flags);
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public override short Sid
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00061AA9 File Offset: 0x0005FCA9
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FtPioGrbitSubRecord
			{
				flags = this.flags
			};
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00061ABC File Offset: 0x0005FCBC
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00061AC4 File Offset: 0x0005FCC4
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

		// Token: 0x04000C38 RID: 3128
		public const short sid = 8;

		// Token: 0x04000C39 RID: 3129
		public const short length = 2;

		// Token: 0x04000C3A RID: 3130
		public static int AUTO_PICT_BIT = 1;

		// Token: 0x04000C3B RID: 3131
		public static int DDE_BIT = 2;

		// Token: 0x04000C3C RID: 3132
		public static int PRINT_CALC_BIT = 4;

		// Token: 0x04000C3D RID: 3133
		public static int ICON_BIT = 8;

		// Token: 0x04000C3E RID: 3134
		public static int CTL_BIT = 16;

		// Token: 0x04000C3F RID: 3135
		public static int PRSTM_BIT = 32;

		// Token: 0x04000C40 RID: 3136
		public static int CAMERA_BIT = 128;

		// Token: 0x04000C41 RID: 3137
		public static int DEFAULT_SIZE_BIT = 256;

		// Token: 0x04000C42 RID: 3138
		public static int AUTO_LOAD_BIT = 512;

		// Token: 0x04000C43 RID: 3139
		private short flags;
	}
}
