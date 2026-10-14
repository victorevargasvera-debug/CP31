using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042C RID: 1068
	public class NoteStructureSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06002742 RID: 10050 RVA: 0x000763D9 File Offset: 0x000745D9
		public NoteStructureSubRecord()
		{
			this.reserved = new byte[22];
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000763F0 File Offset: 0x000745F0
		public NoteStructureSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != 22)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + size.ToString() + ")");
			}
			byte[] buf = new byte[size];
			in1.ReadFully(buf);
			this.reserved = buf;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0007643C File Offset: 0x0007463C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string newLine = global::System.Environment.NewLine;
			stringBuilder.Append("[ftNts ]" + newLine);
			stringBuilder.Append("  size     = ").Append(this.DataSize).Append(newLine);
			stringBuilder.Append("  reserved = ").Append(global::NPOI.Util.HexDump.ToHex(this.reserved)).Append(newLine);
			stringBuilder.Append("[/ftNts ]" + newLine);
			return stringBuilder.ToString();
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000764BC File Offset: 0x000746BC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(13);
			out1.WriteShort(this.reserved.Length);
			out1.Write(this.reserved);
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000764E0 File Offset: 0x000746E0
		public override int DataSize
		{
			get
			{
				return this.reserved.Length;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x000184E9 File Offset: 0x000166E9
		public override short Sid
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000764EC File Offset: 0x000746EC
		public override object Clone()
		{
			global::NPOI.HSSF.Record.NoteStructureSubRecord noteStructureSubRecord = new global::NPOI.HSSF.Record.NoteStructureSubRecord();
			byte[] array = new byte[this.reserved.Length];
			global::System.Array.Copy(this.reserved, 0, array, 0, array.Length);
			noteStructureSubRecord.reserved = array;
			return noteStructureSubRecord;
		}

		// Token: 0x04001099 RID: 4249
		public const short sid = 13;

		// Token: 0x0400109A RID: 4250
		private const int ENCODED_SIZE = 22;

		// Token: 0x0400109B RID: 4251
		private byte[] reserved;
	}
}
