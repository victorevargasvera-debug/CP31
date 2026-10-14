using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FA RID: 1274
	public class CodePageString
	{
		// Token: 0x06002FD1 RID: 12241 RVA: 0x00090CA4 File Offset: 0x0008EEA4
		public CodePageString(byte[] data, int startOffset)
		{
			int @int = global::NPOI.Util.LittleEndian.GetInt(data, startOffset);
			int offset = startOffset + 4;
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset, @int);
			if (@int != 0 && this._value[@int - 1] != 0)
			{
				global::System.Console.WriteLine("CodePageString started at offset #" + offset.ToString() + " is not NULL-terminated");
			}
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00090CFD File Offset: 0x0008EEFD
		public CodePageString(string aString, int codepage)
		{
			this.SetJavaValue(aString, codepage);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00090D10 File Offset: 0x0008EF10
		public string GetJavaValue(int codepage)
		{
			string @string;
			if (codepage == -1)
			{
				@string = global::System.Text.Encoding.UTF8.GetString(this._value);
			}
			else
			{
				@string = global::System.Text.Encoding.GetEncoding(codepage).GetString(this._value);
			}
			int num = @string.IndexOf('\0');
			if (num == -1)
			{
				return @string;
			}
			int num2 = @string.Length - 1;
			return @string.Substring(0, num);
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x00090D67 File Offset: 0x0008EF67
		public int Size
		{
			get
			{
				return 4 + this._value.Length;
			}
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00090D74 File Offset: 0x0008EF74
		public void SetJavaValue(string aString, int codepage)
		{
			string text = aString + "\0";
			if (codepage == -1)
			{
				this._value = global::System.Text.Encoding.UTF8.GetBytes(text);
				return;
			}
			this._value = global::NPOI.Util.CodePageUtil.GetBytesInCodePage(text, codepage);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00090DB0 File Offset: 0x0008EFB0
		public int Write(global::System.IO.Stream out1)
		{
			global::NPOI.Util.LittleEndian.PutInt(this._value.Length, out1);
			out1.Write(this._value, 0, this._value.Length);
			return 4 + this._value.Length;
		}

		// Token: 0x04001565 RID: 5477
		private byte[] _value;
	}
}
