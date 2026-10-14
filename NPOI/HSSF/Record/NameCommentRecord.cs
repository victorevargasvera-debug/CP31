using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F9 RID: 1017
	public class NameCommentRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060024BB RID: 9403 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
		public NameCommentRecord(string name, string comment)
		{
			this.field_1_record_type = 0;
			this.field_2_frt_cell_ref_flag = 0;
			this.field_3_reserved = 0L;
			this.field_6_name_text = name;
			this.field_7_comment_text = comment;
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x0006E410 File Offset: 0x0006C610
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int length = this.field_6_name_text.Length;
			int length2 = this.field_7_comment_text.Length;
			out1.WriteShort((int)this.field_1_record_type);
			out1.WriteShort((int)this.field_2_frt_cell_ref_flag);
			out1.WriteLong(this.field_3_reserved);
			out1.WriteShort(length);
			out1.WriteShort(length2);
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(this.field_6_name_text);
			out1.WriteByte(flag ? 1 : 0);
			if (flag)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_6_name_text, out1);
			}
			else
			{
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_6_name_text, out1);
			}
			bool flag2 = global::NPOI.Util.StringUtil.HasMultibyte(this.field_7_comment_text);
			out1.WriteByte(flag2 ? 1 : 0);
			if (flag2)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_7_comment_text, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_7_comment_text, out1);
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0006E4D4 File Offset: 0x0006C6D4
		protected override int DataSize
		{
			get
			{
				return 18 + (global::NPOI.Util.StringUtil.HasMultibyte(this.field_6_name_text) ? (this.field_6_name_text.Length * 2) : this.field_6_name_text.Length) + (global::NPOI.Util.StringUtil.HasMultibyte(this.field_7_comment_text) ? (this.field_7_comment_text.Length * 2) : this.field_7_comment_text.Length);
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0006E534 File Offset: 0x0006C734
		public NameCommentRecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.field_1_record_type = ((global::NPOI.Util.ILittleEndianInput)ris).ReadShort();
			this.field_2_frt_cell_ref_flag = ((global::NPOI.Util.ILittleEndianInput)ris).ReadShort();
			this.field_3_reserved = ((global::NPOI.Util.ILittleEndianInput)ris).ReadLong();
			int nChars = (int)((global::NPOI.Util.ILittleEndianInput)ris).ReadShort();
			int nChars2 = (int)((global::NPOI.Util.ILittleEndianInput)ris).ReadShort();
			if (((global::NPOI.Util.ILittleEndianInput)ris).ReadByte() == 0)
			{
				this.field_6_name_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(ris, nChars);
			}
			else
			{
				this.field_6_name_text = global::NPOI.Util.StringUtil.ReadUnicodeLE(ris, nChars);
			}
			if (((global::NPOI.Util.ILittleEndianInput)ris).ReadByte() == 0)
			{
				this.field_7_comment_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(ris, nChars2);
				return;
			}
			this.field_7_comment_text = global::NPOI.Util.StringUtil.ReadUnicodeLE(ris, nChars2);
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0006E5C2 File Offset: 0x0006C7C2
		public override short Sid
		{
			get
			{
				return 2196;
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0006E5CC File Offset: 0x0006C7CC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[NAMECMT]\n");
			stringBuilder.Append("    .record type            = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.field_1_record_type)).Append("\n");
			stringBuilder.Append("    .frt cell ref flag      = ").Append(global::NPOI.Util.HexDump.ByteToHex((int)this.field_2_frt_cell_ref_flag)).Append("\n");
			stringBuilder.Append("    .reserved               = ").Append(this.field_3_reserved).Append("\n");
			stringBuilder.Append("    .name length            = ").Append(this.field_6_name_text.Length).Append("\n");
			stringBuilder.Append("    .comment length         = ").Append(this.field_7_comment_text.Length).Append("\n");
			stringBuilder.Append("    .name                   = ").Append(this.field_6_name_text).Append("\n");
			stringBuilder.Append("    .comment                = ").Append(this.field_7_comment_text).Append("\n");
			stringBuilder.Append("[/NAMECMT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0006E6F6 File Offset: 0x0006C8F6
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x0006E6FE File Offset: 0x0006C8FE
		public string NameText
		{
			get
			{
				return this.field_6_name_text;
			}
			set
			{
				this.field_6_name_text = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0006E707 File Offset: 0x0006C907
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x0006E70F File Offset: 0x0006C90F
		public string CommentText
		{
			get
			{
				return this.field_7_comment_text;
			}
			set
			{
				this.field_7_comment_text = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0006E718 File Offset: 0x0006C918
		public short RecordType
		{
			get
			{
				return this.field_1_record_type;
			}
		}

		// Token: 0x04000F67 RID: 3943
		public const short sid = 2196;

		// Token: 0x04000F68 RID: 3944
		private short field_1_record_type;

		// Token: 0x04000F69 RID: 3945
		private short field_2_frt_cell_ref_flag;

		// Token: 0x04000F6A RID: 3946
		private long field_3_reserved;

		// Token: 0x04000F6B RID: 3947
		private string field_6_name_text;

		// Token: 0x04000F6C RID: 3948
		private string field_7_comment_text;
	}
}
