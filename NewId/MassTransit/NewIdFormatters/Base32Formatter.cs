using System;
using System.Threading;

namespace MassTransit.NewIdFormatters
{
	// Token: 0x02000016 RID: 22
	public class Base32Formatter : global::MassTransit.INewIdFormatter
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00003311 File Offset: 0x00001511
		public Base32Formatter(bool upperCase = false)
		{
			this._chars = (upperCase ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567" : "abcdefghijklmnopqrstuvwxyz234567");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000332E File Offset: 0x0000152E
		public Base32Formatter(in string chars)
		{
			if (chars.Length != 32)
			{
				throw new global::System.ArgumentException("The character string must be exactly 32 characters", "chars");
			}
			this._chars = chars;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000335C File Offset: 0x0000155C
		public string Format(in byte[] bytes)
		{
			char[] value = global::MassTransit.NewIdFormatters.Base32Formatter._formatBuffer.Value;
			int num = 0;
			for (int i = 0; i < 3; i++)
			{
				int num2 = i * 5;
				long value2 = (long)((int)bytes[num2] << 12 | (int)bytes[num2 + 1] << 4 | bytes[num2 + 2] >> 4);
				global::MassTransit.NewIdFormatters.Base32Formatter.ConvertLongToBase32(value, num, value2, 4, this._chars);
				num += 4;
				value2 = (long)((int)(bytes[num2 + 2] & 15) << 16 | (int)bytes[num2 + 3] << 8 | (int)bytes[num2 + 4]);
				global::MassTransit.NewIdFormatters.Base32Formatter.ConvertLongToBase32(value, num, value2, 4, this._chars);
				num += 4;
			}
			global::MassTransit.NewIdFormatters.Base32Formatter.ConvertLongToBase32(value, num, (long)((ulong)bytes[15]), 2, this._chars);
			return new string(value, 0, 26);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000340C File Offset: 0x0000160C
		private static void ConvertLongToBase32(in char[] buffer, int offset, long value, int count, string chars)
		{
			for (int i = count - 1; i >= 0; i--)
			{
				int index = (int)(value % 32L);
				buffer[offset + i] = chars[index];
				value /= 32L;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000345F File Offset: 0x0000165F
		string global::MassTransit.INewIdFormatter.Format(in byte[] bytes)
		{
			return this.Format(bytes);
		}

		// Token: 0x04000023 RID: 35
		private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz234567";

		// Token: 0x04000024 RID: 36
		private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

		// Token: 0x04000025 RID: 37
		private readonly string _chars;

		// Token: 0x04000026 RID: 38
		private static readonly global::System.Threading.ThreadLocal<char[]> _formatBuffer = new global::System.Threading.ThreadLocal<char[]>(() => new char[26]);
	}
}
