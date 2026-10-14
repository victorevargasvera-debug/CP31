using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A4 RID: 932
	public class FtCblsSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x00062E4F File Offset: 0x0006104F
		public FtCblsSubRecord()
		{
			this.reserved = new byte[20];
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00062E64 File Offset: 0x00061064
		public FtCblsSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != 20)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + size.ToString() + ")");
			}
			byte[] buf = new byte[size];
			in1.ReadFully(buf);
			this.reserved = buf;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00062EB0 File Offset: 0x000610B0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FtCbls ]").Append("\n");
			stringBuilder.Append("  size     = ").Append(this.DataSize).Append("\n");
			stringBuilder.Append("  reserved = ").Append(global::NPOI.Util.HexDump.ToHex(this.reserved)).Append("\n");
			stringBuilder.Append("[/FtCbls ]").Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00062F3A File Offset: 0x0006113A
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(12);
			out1.WriteShort(this.reserved.Length);
			out1.Write(this.reserved);
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00062F5E File Offset: 0x0006115E
		public override int DataSize
		{
			get
			{
				return this.reserved.Length;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x000184AD File Offset: 0x000166AD
		public override short Sid
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00062F68 File Offset: 0x00061168
		public override object Clone()
		{
			global::NPOI.HSSF.Record.FtCblsSubRecord ftCblsSubRecord = new global::NPOI.HSSF.Record.FtCblsSubRecord();
			byte[] array = new byte[this.reserved.Length];
			global::System.Array.Copy(this.reserved, 0, array, 0, array.Length);
			ftCblsSubRecord.reserved = array;
			return ftCblsSubRecord;
		}

		// Token: 0x04000C84 RID: 3204
		public const short sid = 12;

		// Token: 0x04000C85 RID: 3205
		private const int ENCODED_SIZE = 20;

		// Token: 0x04000C86 RID: 3206
		private byte[] reserved;
	}
}
