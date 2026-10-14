using System;
using System.Collections.Generic;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x02000290 RID: 656
	public class StringUtil
	{
		// Token: 0x060011E8 RID: 4584 RVA: 0x0000253E File Offset: 0x0000073E
		private StringUtil()
		{
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00035B47 File Offset: 0x00033D47
		public static string GetFromUnicodeLE(byte[] str, int offset, int len)
		{
			if (offset < 0 || offset >= str.Length)
			{
				throw new global::System.IndexOutOfRangeException("Illegal offset");
			}
			if (len < 0 || (str.Length - offset) / 2 < len)
			{
				throw new global::System.ArgumentException("Illegal Length");
			}
			return global::NPOI.Util.StringUtil.UTF16LE.GetString(str, offset, len * 2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00035B86 File Offset: 0x00033D86
		public static string GetFromUnicodeLE(byte[] str)
		{
			if (str.Length == 0)
			{
				return "";
			}
			return global::NPOI.Util.StringUtil.GetFromUnicodeLE(str, 0, str.Length / 2);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00035B9E File Offset: 0x00033D9E
		public static byte[] GetToUnicodeLE(string string1)
		{
			return global::NPOI.Util.StringUtil.UTF16LE.GetBytes(string1);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00035BAC File Offset: 0x00033DAC
		public static string GetFromUnicodeBE(byte[] str, int offset, int len)
		{
			if (offset < 0 || offset >= str.Length)
			{
				throw new global::System.IndexOutOfRangeException("Illegal offset");
			}
			if (len < 0 || (str.Length - offset) / 2 < len)
			{
				throw new global::System.ArgumentException("Illegal Length");
			}
			string @string;
			try
			{
				@string = global::System.Text.Encoding.GetEncoding("UTF-16BE").GetString(str, offset, len * 2);
			}
			catch
			{
				throw new global::System.InvalidOperationException();
			}
			return @string;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00035C18 File Offset: 0x00033E18
		public static string GetFromUnicodeBE(byte[] str)
		{
			if (str.Length == 0)
			{
				return "";
			}
			return global::NPOI.Util.StringUtil.GetFromUnicodeBE(str, 0, str.Length / 2);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00035C30 File Offset: 0x00033E30
		public static string GetFromCompressedUnicode(byte[] str, int offset, int len)
		{
			int count = global::System.Math.Min(len, str.Length - offset);
			return global::NPOI.Util.StringUtil.ISO_8859_1.GetString(str, offset, count);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00035C58 File Offset: 0x00033E58
		public static void PutCompressedUnicode(string input, byte[] output, int offset)
		{
			byte[] bytes = global::NPOI.Util.StringUtil.ISO_8859_1.GetBytes(input);
			global::System.Array.Copy(bytes, 0, output, offset, bytes.Length);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00035C80 File Offset: 0x00033E80
		public static void PutCompressedUnicode(string input, global::NPOI.Util.ILittleEndianOutput out1)
		{
			byte[] bytes = global::NPOI.Util.StringUtil.ISO_8859_1.GetBytes(input);
			out1.Write(bytes);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00035CA0 File Offset: 0x00033EA0
		public static void PutUnicodeLE(string input, byte[] output, int offset)
		{
			byte[] bytes = global::NPOI.Util.StringUtil.UTF16LE.GetBytes(input);
			global::System.Array.Copy(bytes, 0, output, offset, bytes.Length);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00035CC8 File Offset: 0x00033EC8
		public static void PutUnicodeLE(string input, global::NPOI.Util.ILittleEndianOutput out1)
		{
			byte[] bytes = global::NPOI.Util.StringUtil.UTF16LE.GetBytes(input);
			out1.Write(bytes);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00035CE8 File Offset: 0x00033EE8
		public static void PutUnicodeBE(string input, byte[] output, int offset)
		{
			try
			{
				byte[] bytes = global::System.Text.Encoding.GetEncoding("UTF-16BE").GetBytes(input);
				global::System.Array.Copy(bytes, 0, output, offset, bytes.Length);
			}
			catch
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00035D2C File Offset: 0x00033F2C
		public static string GetPreferredEncoding()
		{
			return global::NPOI.Util.StringUtil.ISO_8859_1.WebName;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00035D38 File Offset: 0x00033F38
		public static bool HasMultibyte(string value)
		{
			if (value == null)
			{
				return false;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i] > 'ÿ')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00035D70 File Offset: 0x00033F70
		public static string ReadCompressedUnicode(global::NPOI.Util.ILittleEndianInput in1, int nChars)
		{
			byte[] array = new byte[nChars];
			in1.ReadFully(array);
			return global::NPOI.Util.StringUtil.ISO_8859_1.GetString(array);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00035D98 File Offset: 0x00033F98
		public static string ReadUnicodeLE(global::NPOI.Util.ILittleEndianInput in1, int nChars)
		{
			byte[] array = new byte[nChars * 2];
			in1.ReadFully(array);
			return global::NPOI.Util.StringUtil.UTF16LE.GetString(array);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00035DC0 File Offset: 0x00033FC0
		public static string ReadUnicodeString(global::NPOI.Util.ILittleEndianInput in1)
		{
			int nChars = in1.ReadUShort();
			if (((byte)in1.ReadByte() & 1) == 0)
			{
				return global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, nChars);
			}
			return global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, nChars);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00035DEE File Offset: 0x00033FEE
		public static string ReadUnicodeString(global::NPOI.Util.ILittleEndianInput in1, int nChars)
		{
			if (((byte)in1.ReadByte() & 1) == 0)
			{
				return global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, nChars);
			}
			return global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, nChars);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00035E0C File Offset: 0x0003400C
		public static void WriteUnicodeString(global::NPOI.Util.ILittleEndianOutput out1, string value)
		{
			int length = value.Length;
			out1.WriteShort(length);
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(value);
			out1.WriteByte(flag ? 1 : 0);
			if (flag)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(value, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(value, out1);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00035E50 File Offset: 0x00034050
		public static void WriteUnicodeStringFlagAndData(global::NPOI.Util.ILittleEndianOutput out1, string value)
		{
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(value);
			out1.WriteByte(flag ? 1 : 0);
			if (flag)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(value, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(value, out1);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00035E83 File Offset: 0x00034083
		public static int GetEncodedSize(string value)
		{
			return 3 + value.Length * (global::NPOI.Util.StringUtil.HasMultibyte(value) ? 2 : 1);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00035E9A File Offset: 0x0003409A
		public static bool IsUnicodeString(string value)
		{
			return !value.Equals(global::NPOI.Util.StringUtil.ISO_8859_1.GetString(global::NPOI.Util.StringUtil.ISO_8859_1.GetBytes(value)));
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00035EBC File Offset: 0x000340BC
		public static string ToHexString(string s)
		{
			char[] array = s.ToCharArray();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				if (global::NPOI.Util.StringUtil.NeedToEncode(array[i]))
				{
					string value = global::NPOI.Util.StringUtil.ToHexString(array[i]);
					stringBuilder.Append(value);
				}
				else
				{
					stringBuilder.Append(array[i]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00035F11 File Offset: 0x00034111
		public static string ToHexString(char chr)
		{
			return global::System.Convert.ToString((int)chr, 16);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00035F1B File Offset: 0x0003411B
		public static string ToHexString(short chr)
		{
			return global::NPOI.Util.StringUtil.ToHexString((char)chr);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00035F1B File Offset: 0x0003411B
		public static string ToHexString(int chr)
		{
			return global::NPOI.Util.StringUtil.ToHexString((char)chr);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00035F1B File Offset: 0x0003411B
		public static string ToHexString(long chr)
		{
			return global::NPOI.Util.StringUtil.ToHexString((char)chr);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00035F24 File Offset: 0x00034124
		private static bool NeedToEncode(char chr)
		{
			string text = "$-_.+!*'(),@=&";
			return chr > '\u007f' || (!char.IsLetterOrDigit(chr) && text.IndexOf(chr) < 0);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00035F54 File Offset: 0x00034154
		public static string MapMsCodepointString(string string1)
		{
			if (string1 == null || "".Equals(string1))
			{
				return string1;
			}
			global::NPOI.Util.StringUtil.InitMsCodepointMap();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int length = string1.Length;
			int num;
			for (int i = 0; i < length; i += global::NPOI.Util.StringUtil.CharCount(num))
			{
				num = char.ConvertToUtf32(string1, i);
				int utf = global::NPOI.Util.StringUtil.msCodepointToUnicode[num];
				stringBuilder.Append(char.ConvertFromUtf32(utf));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00035FBF File Offset: 0x000341BF
		public static int toCodePoint(char high, char low)
		{
			return (int)(((int)high << 10) + low) + (65536 - (int)((int)global::NPOI.Util.StringUtil.MIN_HIGH_SURROGATE << 10) - (int)global::NPOI.Util.StringUtil.MIN_LOW_SURROGATE);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00035FDC File Offset: 0x000341DC
		private static int codePointAt(char[] a, int index, int limit)
		{
			char c = a[index];
			if (char.IsHighSurrogate(c) && ++index < limit)
			{
				char c2 = a[index];
				if (char.IsLowSurrogate(c2))
				{
					return global::NPOI.Util.StringUtil.toCodePoint(c, c2);
				}
			}
			return (int)c;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00036013 File Offset: 0x00034213
		public static int CharCount(int codePoint)
		{
			if (codePoint < 65536)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00036020 File Offset: 0x00034220
		public static void mapMsCodepoint(int msCodepoint, int unicodeCodepoint)
		{
			global::NPOI.Util.StringUtil.InitMsCodepointMap();
			global::NPOI.Util.StringUtil.msCodepointToUnicode.Add(msCodepoint, unicodeCodepoint);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00036034 File Offset: 0x00034234
		private static void InitMsCodepointMap()
		{
			if (global::NPOI.Util.StringUtil.msCodepointToUnicode != null)
			{
				return;
			}
			global::NPOI.Util.StringUtil.msCodepointToUnicode = new global::System.Collections.Generic.Dictionary<int, int>();
			int num = 61472;
			foreach (int value in global::NPOI.Util.StringUtil.symbolMap_f020)
			{
				global::NPOI.Util.StringUtil.msCodepointToUnicode.Add(num++, value);
			}
			num = 61600;
			foreach (int value2 in global::NPOI.Util.StringUtil.symbolMap_f0a0)
			{
				global::NPOI.Util.StringUtil.msCodepointToUnicode.Add(num++, value2);
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000360B4 File Offset: 0x000342B4
		public static string Join(object[] array, string separator)
		{
			if (array.Length == 0)
			{
				return "";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				stringBuilder.Append(separator).Append(array[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000360FF File Offset: 0x000342FF
		public static string Join(string separator, params object[] array)
		{
			return global::NPOI.Util.StringUtil.Join(array, separator);
		}

		// Token: 0x0400076F RID: 1903
		private static global::System.Text.Encoding ISO_8859_1 = global::System.Text.Encoding.GetEncoding("ISO-8859-1");

		// Token: 0x04000770 RID: 1904
		private static global::System.Text.Encoding UTF16LE = global::System.Text.Encoding.Unicode;

		// Token: 0x04000771 RID: 1905
		private static global::System.Collections.Generic.Dictionary<int, int> msCodepointToUnicode;

		// Token: 0x04000772 RID: 1906
		public static char MIN_HIGH_SURROGATE = '\ud800';

		// Token: 0x04000773 RID: 1907
		public static char MAX_HIGH_SURROGATE = '\udbff';

		// Token: 0x04000774 RID: 1908
		public static char MIN_LOW_SURROGATE = '\udc00';

		// Token: 0x04000775 RID: 1909
		public static char MAX_LOW_SURROGATE = '\udfff';

		// Token: 0x04000776 RID: 1910
		public const int MIN_SUPPLEMENTARY_CODE_POINT = 65536;

		// Token: 0x04000777 RID: 1911
		private static int[] symbolMap_f020 = new int[]
		{
			32,
			33,
			8704,
			35,
			8707,
			37,
			38,
			8717,
			40,
			41,
			8727,
			43,
			44,
			8722,
			46,
			47,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			62,
			63,
			8773,
			913,
			914,
			935,
			916,
			917,
			934,
			915,
			919,
			921,
			977,
			922,
			923,
			924,
			925,
			927,
			928,
			920,
			929,
			931,
			932,
			933,
			962,
			937,
			926,
			936,
			918,
			91,
			8765,
			93,
			8869,
			95,
			32,
			945,
			946,
			967,
			948,
			949,
			966,
			947,
			951,
			953,
			981,
			954,
			955,
			956,
			957,
			959,
			960,
			952,
			961,
			963,
			964,
			965,
			982,
			969,
			958,
			968,
			950,
			123,
			124,
			125,
			8764,
			32
		};

		// Token: 0x04000778 RID: 1912
		private static int[] symbolMap_f0a0 = new int[]
		{
			8364,
			978,
			8242,
			8804,
			8260,
			8734,
			402,
			9827,
			9830,
			9829,
			9824,
			8596,
			8591,
			8593,
			8594,
			8595,
			176,
			177,
			8243,
			8805,
			215,
			181,
			8706,
			8729,
			247,
			8800,
			8801,
			8776,
			8230,
			9168,
			9135,
			8629,
			8501,
			8475,
			8476,
			8472,
			8855,
			8853,
			8709,
			8745,
			8746,
			8835,
			8839,
			8836,
			8834,
			8838,
			8712,
			8713,
			8736,
			8711,
			174,
			169,
			8482,
			8719,
			8730,
			8901,
			172,
			8743,
			8744,
			8660,
			8656,
			8657,
			8658,
			8659,
			9674,
			9001,
			174,
			169,
			8482,
			8721,
			9115,
			9116,
			9117,
			9121,
			9122,
			9123,
			9127,
			9128,
			9129,
			9130,
			32,
			9002,
			8747,
			8992,
			9134,
			8993,
			9118,
			9119,
			9120,
			9124,
			9125,
			9126,
			9131,
			9132,
			9133,
			32
		};
	}
}
