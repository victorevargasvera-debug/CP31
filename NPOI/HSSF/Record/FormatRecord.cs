using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E0 RID: 992
	public class FormatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600238F RID: 9103 RVA: 0x0006B71D File Offset: 0x0006991D
		private FormatRecord(global::NPOI.HSSF.Record.FormatRecord other)
		{
			this.field_1_index_code = other.field_1_index_code;
			this.field_3_hasMultibyte = other.field_3_hasMultibyte;
			this.field_4_formatstring = other.field_4_formatstring;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0006B749 File Offset: 0x00069949
		public FormatRecord(int indexCode, string fs)
		{
			this.field_1_index_code = indexCode;
			this.field_4_formatstring = fs;
			this.field_3_hasMultibyte = global::NPOI.Util.StringUtil.HasMultibyte(fs);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0006B76C File Offset: 0x0006996C
		public FormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_index_code = (int)in1.ReadShort();
			int requestedLength = (int)in1.ReadShort();
			this.field_3_hasMultibyte = ((in1.ReadByte() & 1) != 0);
			if (this.field_3_hasMultibyte)
			{
				this.field_4_formatstring = in1.ReadUnicodeLEString(requestedLength);
				return;
			}
			this.field_4_formatstring = in1.ReadCompressedUnicode(requestedLength);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0006B7C6 File Offset: 0x000699C6
		public int IndexCode
		{
			get
			{
				return this.field_1_index_code;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0006B7CE File Offset: 0x000699CE
		public string FormatString
		{
			get
			{
				return this.field_4_formatstring;
			}
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0006B7D8 File Offset: 0x000699D8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FORMAT]\n");
			stringBuilder.Append("    .indexcode       = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.IndexCode)).Append("\n");
			stringBuilder.Append("    .isUnicode       = ").Append(this.field_3_hasMultibyte).Append("\n");
			stringBuilder.Append("    .formatstring    = ").Append(this.FormatString).Append("\n");
			stringBuilder.Append("[/FORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0006B870 File Offset: 0x00069A70
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			string formatString = this.FormatString;
			out1.WriteShort(this.IndexCode);
			out1.WriteShort(formatString.Length);
			out1.WriteByte(this.field_3_hasMultibyte ? 1 : 0);
			if (this.field_3_hasMultibyte)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(formatString, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(formatString, out1);
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0006B8C5 File Offset: 0x00069AC5
		protected override int DataSize
		{
			get
			{
				return 5 + this.FormatString.Length * (this.field_3_hasMultibyte ? 2 : 1);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0006B8E1 File Offset: 0x00069AE1
		public override short Sid
		{
			get
			{
				return 1054;
			}
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FormatRecord(this);
		}

		// Token: 0x04000EF7 RID: 3831
		public const short sid = 1054;

		// Token: 0x04000EF8 RID: 3832
		private int field_1_index_code;

		// Token: 0x04000EF9 RID: 3833
		private bool field_3_hasMultibyte;

		// Token: 0x04000EFA RID: 3834
		private string field_4_formatstring;
	}
}
