using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x02000269 RID: 617
	public class HexDump
	{
		// Token: 0x06001018 RID: 4120 RVA: 0x0000253E File Offset: 0x0000073E
		private HexDump()
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00031538 File Offset: 0x0002F738
		private static string Dump(byte value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Length = 0;
			for (int i = 0; i < 2; i++)
			{
				stringBuilder.Append(global::NPOI.Util.HexDump._hexcodes[value >> global::NPOI.Util.HexDump._shifts[i + 6] & 15]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00031584 File Offset: 0x0002F784
		private static string Dump(long value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Length = 0;
			for (int i = 0; i < 8; i++)
			{
				stringBuilder.Append(global::NPOI.Util.HexDump._hexcodes[(int)(value >> global::NPOI.Util.HexDump._shifts[i + global::NPOI.Util.HexDump._shifts.Length - 8]) & 15]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000315D7 File Offset: 0x0002F7D7
		public static string Dump(byte[] data, long offset, int index)
		{
			return global::NPOI.Util.HexDump.Dump(data, offset, index, int.MaxValue);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000315E8 File Offset: 0x0002F7E8
		public static string Dump(byte[] data, long offset, int index, int length)
		{
			if (data == null || data.Length == 0)
			{
				return "No Data" + global::NPOI.Util.HexDump.EOL;
			}
			int num = (length == int.MaxValue || length < 0 || index + length < 0) ? data.Length : global::System.Math.Min(data.Length, index + length);
			if (index < 0 || index >= data.Length)
			{
				throw new global::System.IndexOutOfRangeException("illegal index: " + index.ToString() + " into array of length " + data.Length.ToString());
			}
			long num2 = offset + (long)index;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(74);
			for (int i = index; i < num; i += 16)
			{
				int num3 = num - i;
				if (num3 > 16)
				{
					num3 = 16;
				}
				stringBuilder.Append(global::NPOI.Util.HexDump.Dump(num2)).Append(' ');
				for (int j = 0; j < 16; j++)
				{
					if (j < num3)
					{
						stringBuilder.Append(global::NPOI.Util.HexDump.Dump(data[j + i])).Append(' ');
					}
					else
					{
						stringBuilder.Append("   ");
					}
				}
				for (int k = 0; k < num3; k++)
				{
					stringBuilder.Append(global::NPOI.Util.HexDump.ToAscii((int)data[k + i]));
				}
				stringBuilder.Append(global::NPOI.Util.HexDump.EOL);
				num2 += (long)num3;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00031724 File Offset: 0x0002F924
		public static char ToAscii(int dataB)
		{
			char c = (char)(dataB & 255);
			if (char.IsControl(c))
			{
				return '.';
			}
			byte b = (byte)c;
			if (b == 221 || b == 255)
			{
				c = '.';
			}
			return c;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0003175C File Offset: 0x0002F95C
		public static void Dump(byte[] data, long offset, global::System.IO.Stream stream, int index)
		{
			global::NPOI.Util.HexDump.Dump(data, offset, stream, index, data.Length - index);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0003176C File Offset: 0x0002F96C
		public static void Dump(global::System.IO.Stream inStream, int start, int bytesToDump)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				if (bytesToDump == -1)
				{
					for (int num = inStream.ReadByte(); num != -1; num = inStream.ReadByte())
					{
						memoryStream.WriteByte((byte)num);
					}
				}
				else
				{
					int num2 = bytesToDump;
					while (num2-- > 0)
					{
						int num3 = inStream.ReadByte();
						if (num3 == -1)
						{
							break;
						}
						memoryStream.WriteByte((byte)num3);
					}
				}
				byte[] array = memoryStream.ToArray();
				global::NPOI.Util.HexDump.Dump(array, 0L, null, start, array.Length);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000317F4 File Offset: 0x0002F9F4
		public static void Dump(byte[] data, long offset, global::System.IO.Stream stream, int index, int length)
		{
			if (data.Length == 0)
			{
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "No Data{0}", new object[]
				{
					global::NPOI.Util.HexDump.EOL
				}));
				if (stream != null)
				{
					stream.Write(bytes, 0, bytes.Length);
					stream.Flush();
				}
				return;
			}
			if (index < 0 || index >= data.Length)
			{
				throw new global::System.IndexOutOfRangeException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "illegal index: {0} into array of length {1}", new object[]
				{
					index,
					data.Length
				}));
			}
			if (data.Length != 0)
			{
				long num = offset + (long)index;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(74);
				int num2 = global::System.Math.Min(data.Length, index + length);
				for (int i = index; i < num2; i += 16)
				{
					int num3 = num2 - i;
					if (num3 > 16)
					{
						num3 = 16;
					}
					stringBuilder.Append(global::NPOI.Util.HexDump.Dump(num)).Append(' ');
					for (int j = 0; j < 16; j++)
					{
						if (j < num3)
						{
							stringBuilder.Append(global::NPOI.Util.HexDump.Dump(data[j + i]));
						}
						else
						{
							stringBuilder.Append("  ");
						}
						stringBuilder.Append(' ');
					}
					for (int k = 0; k < num3; k++)
					{
						if (data[k + i] >= 32 && data[k + i] < 127)
						{
							stringBuilder.Append((char)data[k + i]);
						}
						else
						{
							stringBuilder.Append('.');
						}
					}
					stringBuilder.Append(global::NPOI.Util.HexDump.EOL);
					byte[] bytes2 = global::System.Text.Encoding.UTF8.GetBytes(stringBuilder.ToString());
					if (stream != null)
					{
						stream.Write(bytes2, 0, bytes2.Length);
						stream.Flush();
					}
					stringBuilder.Length = 0;
					num += (long)num3;
				}
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0003199C File Offset: 0x0002FB9C
		public static void Dump(global::System.IO.Stream in1, global::System.IO.Stream out1, int start, int bytesToDump)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			if (bytesToDump == -1)
			{
				for (int num = in1.ReadByte(); num != -1; num = in1.ReadByte())
				{
					memoryStream.WriteByte((byte)num);
				}
			}
			else
			{
				int num2 = bytesToDump;
				while (num2-- > 0)
				{
					int num3 = in1.ReadByte();
					if (num3 == -1)
					{
						break;
					}
					memoryStream.WriteByte((byte)num3);
				}
			}
			byte[] array = memoryStream.ToArray();
			global::NPOI.Util.HexDump.Dump(array, 0L, out1, start, array.Length);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00031A07 File Offset: 0x0002FC07
		public static char[] ShortToHex(int value)
		{
			return global::NPOI.Util.HexDump.ToHexChars((long)value, 2);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00031A11 File Offset: 0x0002FC11
		public static char[] ByteToHex(int value)
		{
			return global::NPOI.Util.HexDump.ToHexChars((long)value, 1);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00031A1B File Offset: 0x0002FC1B
		public static char[] IntToHex(int value)
		{
			return global::NPOI.Util.HexDump.ToHexChars((long)value, 4);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00031A25 File Offset: 0x0002FC25
		public static char[] LongToHex(long value)
		{
			return global::NPOI.Util.HexDump.ToHexChars(value, 8);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00031A30 File Offset: 0x0002FC30
		private static char[] ToHexChars(long pValue, int nBytes)
		{
			int num = 2 + nBytes * 2;
			char[] array = new char[num];
			long num2 = pValue;
			do
			{
				array[--num] = global::NPOI.Util.HexDump._hexcodes[(int)(num2 & 15L)];
				num2 >>= 4;
			}
			while (num > 1);
			array[0] = '0';
			array[1] = 'x';
			return array;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00031A72 File Offset: 0x0002FC72
		public static string ToHex(byte value)
		{
			return global::NPOI.Util.HexDump.ToHex((long)((ulong)value), 2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00031A7C File Offset: 0x0002FC7C
		public static string ToHex(short value)
		{
			return global::NPOI.Util.HexDump.ToHex((long)value, 4);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00031A86 File Offset: 0x0002FC86
		public static string ToHex(int value)
		{
			return global::NPOI.Util.HexDump.ToHex((long)value, 8);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00031A90 File Offset: 0x0002FC90
		public static string ToHex(long value)
		{
			return global::NPOI.Util.HexDump.ToHex(value, 16);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00031A9C File Offset: 0x0002FC9C
		public static string ToHex(byte[] value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			if (value != null && value.Length != 0)
			{
				for (int i = 0; i < value.Length; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(value[i]));
				}
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00031AFC File Offset: 0x0002FCFC
		public static string ToHex(short[] value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			for (int i = 0; i < value.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(value[i]));
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00031B54 File Offset: 0x0002FD54
		private static string ToHex(long value, int digits)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(digits);
			for (int i = 0; i < digits; i++)
			{
				stringBuilder.Append(global::NPOI.Util.HexDump._hexcodes[(int)(value >> global::NPOI.Util.HexDump._shifts[i + (16 - digits)] & 15L)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00031BA0 File Offset: 0x0002FDA0
		public static string ToHex(byte[] value, int bytesPerLine)
		{
			int num = (value.Length == 0) ? 0 : ((int)global::System.Math.Round(global::System.Math.Log((double)value.Length) / global::System.Math.Log(10.0) + 0.50000001));
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append('0');
			}
			stringBuilder.Append(": ");
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			stringBuilder2.Append(0.0.ToString(stringBuilder.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
			if (value.Length == 0)
			{
				stringBuilder2.Append("0");
			}
			int num2 = -1;
			for (int j = 0; j < value.Length; j++)
			{
				if (++num2 == bytesPerLine)
				{
					stringBuilder2.Append('\n');
					stringBuilder2.Append(((double)j).ToString(stringBuilder.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
					num2 = 0;
				}
				else if (j > 0)
				{
					stringBuilder2.Append(", ");
				}
				stringBuilder2.Append(global::NPOI.Util.HexDump.ToHex(value[j]));
			}
			return stringBuilder2.ToString();
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		public static string EncodeHexString(byte[] data)
		{
			return new string(global::NPOI.Util.HexDump.EncodeHex(data));
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00031CBD File Offset: 0x0002FEBD
		public static char[] EncodeHex(byte[] data)
		{
			return global::NPOI.Util.HexDump.EncodeHex(data, true);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00031CC6 File Offset: 0x0002FEC6
		public static char[] EncodeHex(byte[] data, bool toLowerCase)
		{
			return global::NPOI.Util.HexDump.EncodeHex(data, toLowerCase ? global::NPOI.Util.HexDump.DIGITS_LOWER : global::NPOI.Util.HexDump.DIGITS_UPPER);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00031CE0 File Offset: 0x0002FEE0
		protected static char[] EncodeHex(byte[] data, char[] toDigits)
		{
			int num = data.Length;
			char[] array = new char[num << 1];
			int i = 0;
			int num2 = 0;
			while (i < num)
			{
				array[num2++] = toDigits[(240 & data[i]) >> 4];
				array[num2++] = toDigits[(int)(15 & data[i])];
				i++;
			}
			return array;
		}

		// Token: 0x04000726 RID: 1830
		private static readonly char[] _hexcodes = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'\0',
			'\0'
		};

		// Token: 0x04000727 RID: 1831
		private static readonly int[] _shifts = new int[]
		{
			60,
			56,
			52,
			48,
			44,
			40,
			36,
			32,
			28,
			24,
			20,
			16,
			12,
			8,
			4,
			0
		};

		// Token: 0x04000728 RID: 1832
		public static readonly string EOL = global::System.Environment.NewLine;

		// Token: 0x04000729 RID: 1833
		private static char[] DIGITS_LOWER = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'a',
			'b',
			'c',
			'd',
			'e',
			'f'
		};

		// Token: 0x0400072A RID: 1834
		private static char[] DIGITS_UPPER = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};
	}
}
