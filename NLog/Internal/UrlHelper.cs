using System;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x0200012F RID: 303
	internal static class UrlHelper
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x000231A4 File Offset: 0x000213A4
		public static void EscapeDataEncode(string source, global::System.Text.StringBuilder target, global::NLog.Internal.UrlHelper.EscapeEncodingFlag flags)
		{
			if (string.IsNullOrEmpty(source))
			{
				return;
			}
			bool flag = (flags & global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LowerCaseHex) == global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LowerCaseHex;
			bool flag2 = (flags & global::NLog.Internal.UrlHelper.EscapeEncodingFlag.SpaceAsPlus) == global::NLog.Internal.UrlHelper.EscapeEncodingFlag.SpaceAsPlus;
			bool flag3 = (flags & global::NLog.Internal.UrlHelper.EscapeEncodingFlag.NLogLegacy) == global::NLog.Internal.UrlHelper.EscapeEncodingFlag.NLogLegacy;
			char[] array = null;
			byte[] array2 = null;
			char[] hexChars = flag ? global::NLog.Internal.UrlHelper.hexLowerChars : global::NLog.Internal.UrlHelper.hexUpperChars;
			foreach (char c in source)
			{
				target.Append(c);
				if (!global::NLog.Internal.UrlHelper.IsSimpleCharOrNumber(c))
				{
					if (flag2 && c == ' ')
					{
						target[target.Length - 1] = '+';
					}
					else if (!global::NLog.Internal.UrlHelper.IsAllowedChar(flags, c))
					{
						if (flag3)
						{
							global::NLog.Internal.UrlHelper.HandleLegacyEncoding(target, c, hexChars);
						}
						else
						{
							if (array == null)
							{
								array = new char[1];
							}
							array[0] = c;
							if (array2 == null)
							{
								array2 = new byte[8];
							}
							global::NLog.Internal.UrlHelper.WriteWideChars(target, array, array2, hexChars);
						}
					}
				}
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00023270 File Offset: 0x00021470
		private static void WriteWideChars(global::System.Text.StringBuilder target, char[] charArray, byte[] byteArray, char[] hexChars)
		{
			int bytes = global::System.Text.Encoding.UTF8.GetBytes(charArray, 0, 1, byteArray, 0);
			for (int i = 0; i < bytes; i++)
			{
				byte b = byteArray[i];
				if (i == 0)
				{
					target[target.Length - 1] = '%';
				}
				else
				{
					target.Append('%');
				}
				target.Append(hexChars[(b & 240) >> 4]);
				target.Append(hexChars[(int)(b & 15)]);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000232DC File Offset: 0x000214DC
		private static void HandleLegacyEncoding(global::System.Text.StringBuilder target, char ch, char[] hexChars)
		{
			if (ch < 'Ā')
			{
				target[target.Length - 1] = '%';
				target.Append(hexChars[(int)(ch >> 4 & '\u000f')]);
				target.Append(hexChars[(int)(ch & '\u000f')]);
				return;
			}
			target[target.Length - 1] = '%';
			target.Append('u');
			target.Append(hexChars[(int)(ch >> 12 & '\u000f')]);
			target.Append(hexChars[(int)(ch >> 8 & '\u000f')]);
			target.Append(hexChars[(int)(ch >> 4 & '\u000f')]);
			target.Append(hexChars[(int)(ch & '\u000f')]);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00023374 File Offset: 0x00021574
		private static bool IsAllowedChar(global::NLog.Internal.UrlHelper.EscapeEncodingFlag flags, char ch)
		{
			bool flag = (flags & global::NLog.Internal.UrlHelper.EscapeEncodingFlag.UriString) == global::NLog.Internal.UrlHelper.EscapeEncodingFlag.UriString;
			bool flag2 = (flags & global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LegacyRfc2396) == global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LegacyRfc2396;
			if (flag)
			{
				if (!flag2 && "-._~".IndexOf(ch) >= 0)
				{
					return true;
				}
				if (flag2 && "-_.!~*'()".IndexOf(ch) >= 0)
				{
					return true;
				}
			}
			else
			{
				if (!flag2 && ":/?#[]@!$&'()*+,;=".IndexOf(ch) >= 0)
				{
					return true;
				}
				if (flag2 && ";/?:@&=+$,".IndexOf(ch) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000233DD File Offset: 0x000215DD
		private static bool IsSimpleCharOrNumber(char ch)
		{
			return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9');
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00023404 File Offset: 0x00021604
		public static global::NLog.Internal.UrlHelper.EscapeEncodingFlag GetUriStringEncodingFlags(bool escapeDataNLogLegacy, bool spaceAsPlus, bool escapeDataRfc3986)
		{
			global::NLog.Internal.UrlHelper.EscapeEncodingFlag escapeEncodingFlag = global::NLog.Internal.UrlHelper.EscapeEncodingFlag.UriString;
			if (escapeDataNLogLegacy)
			{
				escapeEncodingFlag |= global::NLog.Internal.UrlHelper.EscapeEncodingFlag.NLogLegacy;
			}
			else if (!escapeDataRfc3986)
			{
				escapeEncodingFlag |= (global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LegacyRfc2396 | global::NLog.Internal.UrlHelper.EscapeEncodingFlag.LowerCaseHex);
			}
			if (spaceAsPlus)
			{
				escapeEncodingFlag |= global::NLog.Internal.UrlHelper.EscapeEncodingFlag.SpaceAsPlus;
			}
			return escapeEncodingFlag;
		}

		// Token: 0x040003CF RID: 975
		private const string RFC2396ReservedMarks = ";/?:@&=+$,";

		// Token: 0x040003D0 RID: 976
		private const string RFC3986ReservedMarks = ":/?#[]@!$&'()*+,;=";

		// Token: 0x040003D1 RID: 977
		private const string RFC2396UnreservedMarks = "-_.!~*'()";

		// Token: 0x040003D2 RID: 978
		private const string RFC3986UnreservedMarks = "-._~";

		// Token: 0x040003D3 RID: 979
		private static readonly char[] hexUpperChars = new char[]
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

		// Token: 0x040003D4 RID: 980
		private static readonly char[] hexLowerChars = new char[]
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

		// Token: 0x0200021F RID: 543
		[global::System.Flags]
		public enum EscapeEncodingFlag
		{
			// Token: 0x04000628 RID: 1576
			None = 0,
			// Token: 0x04000629 RID: 1577
			UriString = 1,
			// Token: 0x0400062A RID: 1578
			LegacyRfc2396 = 2,
			// Token: 0x0400062B RID: 1579
			LowerCaseHex = 4,
			// Token: 0x0400062C RID: 1580
			SpaceAsPlus = 8,
			// Token: 0x0400062D RID: 1581
			NLogLegacy = 23
		}
	}
}
