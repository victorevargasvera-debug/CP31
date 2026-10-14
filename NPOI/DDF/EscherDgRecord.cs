using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053B RID: 1339
	public class EscherDgRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x06003284 RID: 12932 RVA: 0x0009A070 File Offset: 0x00098270
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			base.ReadHeader(data, offset);
			int num = offset + 8;
			int num2 = 0;
			this.field_1_numShapes = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			this.field_2_lastMSOSPID = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			return this.RecordSize;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0009A0B8 File Offset: 0x000982B8
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, 8);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 8, this.field_1_numShapes);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 12, this.field_2_lastMSOSPID);
			listener.AfterRecordSerialize(offset + 16, this.RecordId, this.RecordSize, this);
			return this.RecordSize;
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public override int RecordSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x0009A135 File Offset: 0x00098335
		public override short RecordId
		{
			get
			{
				return -4088;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0009A13C File Offset: 0x0009833C
		public override string RecordName
		{
			get
			{
				return "Dg";
			}
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x0009A144 File Offset: 0x00098344
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4088),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  NumShapes: ",
				this.field_1_numShapes.ToString(),
				newLine,
				"  LastMSOSPID: ",
				this.field_2_lastMSOSPID.ToString(),
				newLine
			});
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x0009A208 File Offset: 0x00098408
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<NumShapes>").Append(this.field_1_numShapes).Append("</NumShapes>\n").Append(tab).Append("\t").Append("<LastMSOSPID>").Append(this.field_2_lastMSOSPID).Append("</LastMSOSPID>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x0009A2E8 File Offset: 0x000984E8
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x0009A2F0 File Offset: 0x000984F0
		public int NumShapes
		{
			get
			{
				return this.field_1_numShapes;
			}
			set
			{
				this.field_1_numShapes = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x0009A2F9 File Offset: 0x000984F9
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x0009A301 File Offset: 0x00098501
		public int LastMSOSPID
		{
			get
			{
				return this.field_2_lastMSOSPID;
			}
			set
			{
				this.field_2_lastMSOSPID = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x0009A30A File Offset: 0x0009850A
		public short DrawingGroupId
		{
			get
			{
				return (short)(this.Options >> 4);
			}
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x0009A315 File Offset: 0x00098515
		public void IncrementShapeCount()
		{
			this.field_1_numShapes++;
		}

		// Token: 0x0400168A RID: 5770
		public const short RECORD_ID = -4088;

		// Token: 0x0400168B RID: 5771
		public const string RECORD_DESCRIPTION = "MsofbtDg";

		// Token: 0x0400168C RID: 5772
		private int field_1_numShapes;

		// Token: 0x0400168D RID: 5773
		private int field_2_lastMSOSPID;
	}
}
