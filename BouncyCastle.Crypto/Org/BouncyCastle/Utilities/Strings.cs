using System;
using System.Text;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x0200003B RID: 59
	public abstract class Strings
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000C99C File Offset: 0x0000AB9C
		public static string ToUpperCase(string original)
		{
			bool changed = false;
			char[] chars = original.ToCharArray();
			for (int i = 0; i != chars.Length; i++)
			{
				char ch = chars[i];
				if ('a' <= ch && 'z' >= ch)
				{
					changed = true;
					chars[i] = ch - 'a' + 'A';
				}
			}
			if (changed)
			{
				return new string(chars);
			}
			return original;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		internal static bool IsOneOf(string s, params string[] candidates)
		{
			foreach (string candidate in candidates)
			{
				if (s == candidate)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000CA18 File Offset: 0x0000AC18
		public static string FromByteArray(byte[] bs)
		{
			char[] cs = new char[bs.Length];
			for (int i = 0; i < cs.Length; i++)
			{
				cs[i] = global::System.Convert.ToChar(bs[i]);
			}
			return new string(cs);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000CA50 File Offset: 0x0000AC50
		public static byte[] ToByteArray(char[] cs)
		{
			byte[] bs = new byte[cs.Length];
			for (int i = 0; i < bs.Length; i++)
			{
				bs[i] = global::System.Convert.ToByte(cs[i]);
			}
			return bs;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public static byte[] ToByteArray(string s)
		{
			byte[] bs = new byte[s.Length];
			for (int i = 0; i < bs.Length; i++)
			{
				bs[i] = global::System.Convert.ToByte(s[i]);
			}
			return bs;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000CAB7 File Offset: 0x0000ACB7
		public static string FromAsciiByteArray(byte[] bytes)
		{
			return global::System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		public static byte[] ToAsciiByteArray(char[] cs)
		{
			return global::System.Text.Encoding.ASCII.GetBytes(cs);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000CAD5 File Offset: 0x0000ACD5
		public static byte[] ToAsciiByteArray(string s)
		{
			return global::System.Text.Encoding.ASCII.GetBytes(s);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000CAE2 File Offset: 0x0000ACE2
		public static string FromUtf8ByteArray(byte[] bytes)
		{
			return global::System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000CAF3 File Offset: 0x0000ACF3
		public static byte[] ToUtf8ByteArray(char[] cs)
		{
			return global::System.Text.Encoding.UTF8.GetBytes(cs);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000CB00 File Offset: 0x0000AD00
		public static byte[] ToUtf8ByteArray(string s)
		{
			return global::System.Text.Encoding.UTF8.GetBytes(s);
		}
	}
}
