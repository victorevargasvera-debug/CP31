using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000429 RID: 1065
	public class GroupMarkerSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06002729 RID: 10025 RVA: 0x00075BBE File Offset: 0x00073DBE
		public GroupMarkerSubRecord()
		{
			this.reserved = global::NPOI.HSSF.Record.GroupMarkerSubRecord.EMPTY_BYTE_ARRAY;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00075BD4 File Offset: 0x00073DD4
		public GroupMarkerSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			byte[] buf = new byte[size];
			in1.ReadFully(buf);
			this.reserved = buf;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00075BFC File Offset: 0x00073DFC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string newLine = global::System.Environment.NewLine;
			stringBuilder.Append("[ftGmo]" + newLine);
			stringBuilder.Append("  reserved = ").Append(global::NPOI.Util.HexDump.ToHex(this.reserved)).Append(newLine);
			stringBuilder.Append("[/ftGmo]" + newLine);
			return stringBuilder.ToString();
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00075C5F File Offset: 0x00073E5F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(6);
			out1.WriteShort(this.reserved.Length);
			out1.Write(this.reserved);
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00075C82 File Offset: 0x00073E82
		public override int DataSize
		{
			get
			{
				return this.reserved.Length;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x00017F5F File Offset: 0x0001615F
		public override short Sid
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00075C8C File Offset: 0x00073E8C
		public override object Clone()
		{
			global::NPOI.HSSF.Record.GroupMarkerSubRecord groupMarkerSubRecord = new global::NPOI.HSSF.Record.GroupMarkerSubRecord();
			groupMarkerSubRecord.reserved = new byte[this.reserved.Length];
			for (int i = 0; i < this.reserved.Length; i++)
			{
				groupMarkerSubRecord.reserved[i] = this.reserved[i];
			}
			return groupMarkerSubRecord;
		}

		// Token: 0x04001082 RID: 4226
		public const short sid = 6;

		// Token: 0x04001083 RID: 4227
		private byte[] reserved;

		// Token: 0x04001084 RID: 4228
		private static byte[] EMPTY_BYTE_ARRAY = new byte[0];
	}
}
