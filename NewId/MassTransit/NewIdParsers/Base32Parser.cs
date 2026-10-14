using System;
using System.Threading;

namespace MassTransit.NewIdParsers
{
	// Token: 0x02000014 RID: 20
	public class Base32Parser : global::MassTransit.INewIdParser
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000313C File Offset: 0x0000133C
		public Base32Parser()
		{
			string text = "abcdefghijklmnopqrstuvwxyz234567ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
			this..ctor(text);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003157 File Offset: 0x00001357
		public Base32Parser(in string chars)
		{
			if (chars.Length % 32 != 0)
			{
				throw new global::System.ArgumentException("The characters must be a multiple of 32", "chars");
			}
			this._chars = chars;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003184 File Offset: 0x00001384
		public global::MassTransit.NewId Parse(in string text)
		{
			if (text.Length != 26)
			{
				throw new global::System.ArgumentException("The input string must be 26 characters", "text");
			}
			char[] value = global::MassTransit.NewIdParsers.Base32Parser._buffer.Value;
			int num = 0;
			int num2 = 0;
			long num3;
			for (int i = 0; i < 6; i++)
			{
				num3 = 0L;
				for (int j = 0; j < 4; j++)
				{
					int num4 = this._chars.IndexOf(text[num2 + j]);
					if (num4 < 0)
					{
						throw new global::System.ArgumentException("The input string contains invalid characters");
					}
					num3 = num3 * 32L + (long)(num4 % 32);
				}
				global::MassTransit.NewIdParsers.Base32Parser.ConvertLongToBase16(value, num, num3, 5);
				num2 += 4;
				num += 5;
			}
			num3 = 0L;
			for (int k = 0; k < 2; k++)
			{
				int num5 = this._chars.IndexOf(text[num2 + k]);
				if (num5 < 0)
				{
					throw new global::System.ArgumentException("The input string contains invalid characters");
				}
				num3 = num3 * 32L + (long)(num5 % 32);
			}
			global::MassTransit.NewIdParsers.Base32Parser.ConvertLongToBase16(value, num, num3, 2);
			string text2 = new string(value, 0, 32);
			return new global::MassTransit.NewId(ref text2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000328C File Offset: 0x0000148C
		private static void ConvertLongToBase16(in char[] buffer, int offset, long value, int count)
		{
			for (int i = count - 1; i >= 0; i--)
			{
				int index = (int)(value % 16L);
				buffer[offset + i] = "0123456789ABCDEF"[index];
				value /= 16L;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000032E2 File Offset: 0x000014E2
		global::MassTransit.NewId global::MassTransit.INewIdParser.Parse(in string text)
		{
			return this.Parse(text);
		}

		// Token: 0x0400001C RID: 28
		private const string ConvertChars = "abcdefghijklmnopqrstuvwxyz234567ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

		// Token: 0x0400001D RID: 29
		private const string HexChars = "0123456789ABCDEF";

		// Token: 0x0400001E RID: 30
		private const string InvalidInputString = "The input string contains invalid characters";

		// Token: 0x0400001F RID: 31
		private static readonly global::System.Threading.ThreadLocal<char[]> _buffer = new global::System.Threading.ThreadLocal<char[]>(() => new char[32]);

		// Token: 0x04000020 RID: 32
		private readonly string _chars;
	}
}
