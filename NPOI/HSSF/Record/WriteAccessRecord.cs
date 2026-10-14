using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000440 RID: 1088
	public class WriteAccessRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002861 RID: 10337 RVA: 0x000798AA File Offset: 0x00077AAA
		static WriteAccessRecord()
		{
			global::NPOI.Util.Arrays.Fill(global::NPOI.HSSF.Record.WriteAccessRecord.PADDING, 32);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000798C4 File Offset: 0x00077AC4
		public WriteAccessRecord()
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000798D8 File Offset: 0x00077AD8
		public WriteAccessRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (in1.Remaining > 112)
			{
				throw new global::NPOI.Util.RecordFormatException(string.Concat(new string[]
				{
					"Expected data size (",
					112.ToString(),
					") but got (",
					in1.Remaining.ToString(),
					")"
				}));
			}
			int num = in1.ReadUShort();
			int num2 = in1.ReadUByte();
			if (num > 112 || (num2 & 254) != 0)
			{
				byte[] array = new byte[3 + in1.Remaining];
				global::NPOI.Util.LittleEndian.PutUShort(array, 0, num);
				global::NPOI.Util.LittleEndian.PutByte(array, 2, num2);
				in1.ReadFully(array, 3, array.Length - 3);
				char[] array2 = new char[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = (char)array[i];
				}
				string text = new string(array2);
				this.Username = text.Trim();
				return;
			}
			string text2;
			if ((num2 & 1) == 0)
			{
				text2 = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, num);
			}
			else
			{
				text2 = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, num);
			}
			this.field_1_username = text2.Trim();
			for (int j = in1.Remaining; j > 0; j--)
			{
				in1.ReadUByte();
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x00079A0F File Offset: 0x00077C0F
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x00079A18 File Offset: 0x00077C18
		public string Username
		{
			get
			{
				return this.field_1_username;
			}
			set
			{
				bool flag = global::NPOI.Util.StringUtil.HasMultibyte(value);
				int num = 3 + this.Username.Length * (flag ? 2 : 1);
				if (112 - num < 0)
				{
					throw new global::System.ArgumentException("Name is too long: " + value);
				}
				this.field_1_username = value;
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00079A64 File Offset: 0x00077C64
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WriteACCESS]\n");
			stringBuilder.Append("    .name            = ").Append(this.field_1_username).Append("\n");
			stringBuilder.Append("[/WriteACCESS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00079AB4 File Offset: 0x00077CB4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			string username = this.Username;
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(username);
			out1.WriteShort(username.Length);
			out1.WriteByte(flag ? 1 : 0);
			if (flag)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(username, out1);
			}
			else
			{
				global::NPOI.Util.StringUtil.PutCompressedUnicode(username, out1);
			}
			int num = 3 + username.Length * (flag ? 2 : 1);
			int len = 112 - num;
			out1.Write(global::NPOI.HSSF.Record.WriteAccessRecord.PADDING, 0, len);
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x00079B1E File Offset: 0x00077D1E
		protected override int DataSize
		{
			get
			{
				return 112;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x00079B22 File Offset: 0x00077D22
		public override short Sid
		{
			get
			{
				return 92;
			}
		}

		// Token: 0x04001126 RID: 4390
		public const short sid = 92;

		// Token: 0x04001127 RID: 4391
		private string field_1_username = string.Empty;

		// Token: 0x04001128 RID: 4392
		private const byte PAD_CHAR = 32;

		// Token: 0x04001129 RID: 4393
		private const int DATA_SIZE = 112;

		// Token: 0x0400112A RID: 4394
		private static byte[] PADDING = new byte[112];
	}
}
