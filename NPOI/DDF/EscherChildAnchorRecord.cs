using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000535 RID: 1333
	public class EscherChildAnchorRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x0600321B RID: 12827 RVA: 0x0009832C File Offset: 0x0009652C
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			base.ReadHeader(data, offset);
			int num = offset + 8;
			int num2 = 0;
			this.field_1_dx1 = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			this.field_2_dy1 = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			this.field_3_dx2 = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			this.field_4_dy2 = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			return 8 + num2;
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00098398 File Offset: 0x00096598
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			int num = offset + 2;
			global::NPOI.Util.LittleEndian.PutShort(data, num, this.RecordId);
			num += 2;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.RecordSize - 8);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_1_dx1);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_2_dy1);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_dx2);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_4_dy2);
			num += 4;
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			return num - offset;
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
		public override int RecordSize
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x00098442 File Offset: 0x00096642
		public override short RecordId
		{
			get
			{
				return -4081;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x00098449 File Offset: 0x00096649
		public override string RecordName
		{
			get
			{
				return "ChildAnchor";
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00098450 File Offset: 0x00096650
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4081),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  X1: ",
				this.field_1_dx1.ToString(),
				newLine,
				"  Y1: ",
				this.field_2_dy1.ToString(),
				newLine,
				"  X2: ",
				this.field_3_dx2.ToString(),
				newLine,
				"  Y2: ",
				this.field_4_dy2.ToString(),
				newLine
			});
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00098550 File Offset: 0x00096750
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<X1>").Append(this.field_1_dx1).Append("</X1>\n").Append(tab).Append("\t").Append("<Y1>").Append(this.field_2_dy1).Append("</Y1>\n").Append(tab).Append("\t").Append("<X2>").Append(this.field_3_dx2).Append("</X2>\n").Append(tab).Append("\t").Append("<Y2>").Append(this.field_4_dy2).Append("</Y2>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x0009868E File Offset: 0x0009688E
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x00098696 File Offset: 0x00096896
		public int Dx1
		{
			get
			{
				return this.field_1_dx1;
			}
			set
			{
				this.field_1_dx1 = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x0009869F File Offset: 0x0009689F
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x000986A7 File Offset: 0x000968A7
		public int Dy1
		{
			get
			{
				return this.field_2_dy1;
			}
			set
			{
				this.field_2_dy1 = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x000986B0 File Offset: 0x000968B0
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x000986B8 File Offset: 0x000968B8
		public int Dx2
		{
			get
			{
				return this.field_3_dx2;
			}
			set
			{
				this.field_3_dx2 = value;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x000986C1 File Offset: 0x000968C1
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x000986C9 File Offset: 0x000968C9
		public int Dy2
		{
			get
			{
				return this.field_4_dy2;
			}
			set
			{
				this.field_4_dy2 = value;
			}
		}

		// Token: 0x04001663 RID: 5731
		public const short RECORD_ID = -4081;

		// Token: 0x04001664 RID: 5732
		public const string RECORD_DESCRIPTION = "MsofbtChildAnchor";

		// Token: 0x04001665 RID: 5733
		private int field_1_dx1;

		// Token: 0x04001666 RID: 5734
		private int field_2_dy1;

		// Token: 0x04001667 RID: 5735
		private int field_3_dx2;

		// Token: 0x04001668 RID: 5736
		private int field_4_dy2;
	}
}
