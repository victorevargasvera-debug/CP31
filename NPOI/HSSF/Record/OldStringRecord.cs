using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039F RID: 927
	public class OldStringRecord
	{
		// Token: 0x06001FEB RID: 8171 RVA: 0x00062080 File Offset: 0x00060280
		public OldStringRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.sid = in1.Sid;
			if (in1.Sid == 7)
			{
				this.field_1_string_len = (short)in1.ReadUByte();
			}
			else
			{
				this.field_1_string_len = in1.ReadShort();
			}
			this.field_2_bytes = new byte[(int)this.field_1_string_len];
			in1.Read(this.field_2_bytes, 0, (int)this.field_1_string_len);
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x000620E8 File Offset: 0x000602E8
		public bool IsBiff2
		{
			get
			{
				return this.sid == 7;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000620F3 File Offset: 0x000602F3
		public short Sid
		{
			get
			{
				return this.sid;
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000620FB File Offset: 0x000602FB
		public void SetCodePage(global::NPOI.HSSF.Record.CodepageRecord codepage)
		{
			this.codepage = codepage;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00062104 File Offset: 0x00060304
		public string GetString()
		{
			return global::NPOI.HSSF.Record.OldStringRecord.GetString(this.field_2_bytes, this.codepage);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00062118 File Offset: 0x00060318
		protected internal static string GetString(byte[] data, global::NPOI.HSSF.Record.CodepageRecord codepage)
		{
			int num = 28591;
			if (codepage != null)
			{
				num = ((int)codepage.Codepage & 65535);
			}
			string stringFromCodePage;
			try
			{
				stringFromCodePage = global::NPOI.Util.CodePageUtil.GetStringFromCodePage(data, num);
			}
			catch (global::System.Text.EncoderFallbackException innerException)
			{
				throw new global::System.ArgumentException("Unsupported codepage requested", innerException);
			}
			return stringFromCodePage;
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00062164 File Offset: 0x00060364
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[OLD STRING]\n");
			stringBuilder.Append("    .string            = ").Append(this.GetString()).Append("\n");
			stringBuilder.Append("[/OLD STRING]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04000C5E RID: 3166
		public const short biff2_sid = 7;

		// Token: 0x04000C5F RID: 3167
		public const short biff345_sid = 519;

		// Token: 0x04000C60 RID: 3168
		private short sid;

		// Token: 0x04000C61 RID: 3169
		private short field_1_string_len;

		// Token: 0x04000C62 RID: 3170
		private byte[] field_2_bytes;

		// Token: 0x04000C63 RID: 3171
		private global::NPOI.HSSF.Record.CodepageRecord codepage;
	}
}
