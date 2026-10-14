using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BC RID: 1212
	public class SeriesTextRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D6B RID: 11627 RVA: 0x000865DC File Offset: 0x000847DC
		public SeriesTextRecord()
		{
			this.field_4_text = "";
			this.is16bit = false;
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000865F8 File Offset: 0x000847F8
		public SeriesTextRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_id = in1.ReadShort();
			int requestedLength = (int)((byte)in1.ReadByte());
			this.is16bit = ((in1.ReadUByte() & 1) != 0);
			if (this.is16bit)
			{
				this.field_4_text = in1.ReadUnicodeLEString(requestedLength);
				return;
			}
			this.field_4_text = in1.ReadCompressedUnicode(requestedLength);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00086654 File Offset: 0x00084854
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SERIESTEXT]\n");
			stringBuilder.Append("    .id                   = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append(" (").Append(this.Id).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .textLength           = ").Append(this.field_4_text.Length);
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .is16bit         = ").Append(this.is16bit);
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .text                 = ").Append(" (").Append(this.Text).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SERIESTEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00086758 File Offset: 0x00084958
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_id);
			out1.WriteByte(this.field_4_text.Length);
			if (this.is16bit)
			{
				out1.WriteByte(1);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_4_text, out1);
				return;
			}
			out1.WriteByte(0);
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_4_text, out1);
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000867B1 File Offset: 0x000849B1
		protected override int DataSize
		{
			get
			{
				return 4 + this.field_4_text.Length * (this.is16bit ? 2 : 1);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000867CD File Offset: 0x000849CD
		public override short Sid
		{
			get
			{
				return 4109;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000867D4 File Offset: 0x000849D4
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesTextRecord
			{
				field_1_id = this.field_1_id,
				is16bit = this.is16bit,
				field_4_text = this.field_4_text
			};
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000867FF File Offset: 0x000849FF
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x00086807 File Offset: 0x00084A07
		public short Id
		{
			get
			{
				return this.field_1_id;
			}
			set
			{
				this.field_1_id = value;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x00086810 File Offset: 0x00084A10
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x00086818 File Offset: 0x00084A18
		public string Text
		{
			get
			{
				return this.field_4_text;
			}
			set
			{
				if (value.Length > 255)
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Text is too long (",
						value.Length.ToString(),
						">",
						255.ToString(),
						")"
					}));
				}
				this.field_4_text = value;
				this.is16bit = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x040013EA RID: 5098
		private const int MAX_LEN = 255;

		// Token: 0x040013EB RID: 5099
		public const short sid = 4109;

		// Token: 0x040013EC RID: 5100
		private short field_1_id;

		// Token: 0x040013ED RID: 5101
		private bool is16bit;

		// Token: 0x040013EE RID: 5102
		private string field_4_text;
	}
}
