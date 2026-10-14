using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E6 RID: 998
	public abstract class HeaderFooterBase : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060023EB RID: 9195 RVA: 0x0006C2F4 File Offset: 0x0006A4F4
		protected HeaderFooterBase(string text)
		{
			this.Text = text;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0006C304 File Offset: 0x0006A504
		protected HeaderFooterBase(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (in1.Remaining <= 0)
			{
				this.field_3_text = "";
				return;
			}
			int requestedLength = (int)in1.ReadShort();
			this.field_2_hasMultibyte = (in1.ReadByte() != 0);
			if (this.field_2_hasMultibyte)
			{
				this.field_3_text = in1.ReadUnicodeLEString(requestedLength);
				return;
			}
			this.field_3_text = in1.ReadCompressedUnicode(requestedLength);
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x0006C365 File Offset: 0x0006A565
		private int TextLength
		{
			get
			{
				return this.field_3_text.Length;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0006C372 File Offset: 0x0006A572
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0006C37C File Offset: 0x0006A57C
		public string Text
		{
			get
			{
				return this.field_3_text;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentException("text must not be null");
				}
				this.field_2_hasMultibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
				this.field_3_text = value;
				if (this.DataSize > 8224)
				{
					throw new global::System.ArgumentException("Header/Footer string too long (limit is " + 8224.ToString() + " bytes)");
				}
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0006C3DC File Offset: 0x0006A5DC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			if (this.TextLength > 0)
			{
				out1.WriteShort(this.TextLength);
				out1.WriteByte(this.field_2_hasMultibyte ? 1 : 0);
				if (this.field_2_hasMultibyte)
				{
					global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_3_text, out1);
					return;
				}
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_3_text, out1);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0006C431 File Offset: 0x0006A631
		protected override int DataSize
		{
			get
			{
				if (this.TextLength < 1)
				{
					return 0;
				}
				return 3 + this.TextLength * (this.field_2_hasMultibyte ? 2 : 1);
			}
		}

		// Token: 0x04000F16 RID: 3862
		private bool field_2_hasMultibyte;

		// Token: 0x04000F17 RID: 3863
		private string field_3_text;
	}
}
