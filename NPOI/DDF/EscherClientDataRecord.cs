using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000537 RID: 1335
	public class EscherClientDataRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x06003247 RID: 12871 RVA: 0x00098E88 File Offset: 0x00097088
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int sourceIndex = offset + 8;
			this.remainingData = new byte[num];
			global::System.Array.Copy(data, sourceIndex, this.remainingData, 0, num);
			return 8 + num;
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00098EC0 File Offset: 0x000970C0
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			if (this.remainingData == null)
			{
				this.remainingData = new byte[0];
			}
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, this.remainingData.Length);
			global::System.Array.Copy(this.remainingData, 0, data, offset + 8, this.remainingData.Length);
			int num = offset + 8 + this.remainingData.Length;
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			return num - offset;
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x00098F55 File Offset: 0x00097155
		public override int RecordSize
		{
			get
			{
				return 8 + ((this.remainingData == null) ? 0 : this.remainingData.Length);
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x00098F6C File Offset: 0x0009716C
		public override short RecordId
		{
			get
			{
				return -4079;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x00098F73 File Offset: 0x00097173
		public override string RecordName
		{
			get
			{
				return "ClientData";
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x00098F7C File Offset: 0x0009717C
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string text = global::NPOI.Util.HexDump.Dump(this.remainingData, 0L, 0);
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4079),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  Extra Data:",
				newLine,
				text
			});
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00099028 File Offset: 0x00097228
		public override string ToXml(string tab)
		{
			string value = global::NPOI.Util.HexDump.Dump(this.remainingData, 0L, 0).Trim();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x000990E8 File Offset: 0x000972E8
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x000990F0 File Offset: 0x000972F0
		public byte[] RemainingData
		{
			get
			{
				return this.remainingData;
			}
			set
			{
				this.remainingData = ((value == null) ? new byte[0] : ((byte[])value.Clone()));
			}
		}

		// Token: 0x04001676 RID: 5750
		public const short RECORD_ID = -4079;

		// Token: 0x04001677 RID: 5751
		public const string RECORD_DESCRIPTION = "MsofbtClientData";

		// Token: 0x04001678 RID: 5752
		private byte[] remainingData;
	}
}
