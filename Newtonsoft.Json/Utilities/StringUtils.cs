using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006C RID: 108
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class StringUtils
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x00018F17 File Offset: 0x00017117
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static bool IsNullOrEmpty([global::System.Diagnostics.CodeAnalysis.NotNullWhen(false)] string value)
		{
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00018F1F File Offset: 0x0001711F
		public static string FormatWith(this string format, global::System.IFormatProvider provider, [global::System.Runtime.CompilerServices.Nullable(2)] object arg0)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0
			});
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00018F32 File Offset: 0x00017132
		public static string FormatWith(this string format, global::System.IFormatProvider provider, [global::System.Runtime.CompilerServices.Nullable(2)] object arg0, [global::System.Runtime.CompilerServices.Nullable(2)] object arg1)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1
			});
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00018F49 File Offset: 0x00017149
		public static string FormatWith(this string format, global::System.IFormatProvider provider, [global::System.Runtime.CompilerServices.Nullable(2)] object arg0, [global::System.Runtime.CompilerServices.Nullable(2)] object arg1, [global::System.Runtime.CompilerServices.Nullable(2)] object arg2)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2
			});
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00018F65 File Offset: 0x00017165
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public static string FormatWith([global::System.Runtime.CompilerServices.Nullable(1)] this string format, [global::System.Runtime.CompilerServices.Nullable(1)] global::System.IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00018F86 File Offset: 0x00017186
		private static string FormatWith(this string format, global::System.IFormatProvider provider, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(format, "format");
			return string.Format(provider, format, args);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00018F9C File Offset: 0x0001719C
		public static bool IsWhiteSpace(string s)
		{
			if (s == null)
			{
				throw new global::System.ArgumentNullException("s");
			}
			if (s.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!char.IsWhiteSpace(s[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00018FE3 File Offset: 0x000171E3
		public static global::System.IO.StringWriter CreateStringWriter(int capacity)
		{
			return new global::System.IO.StringWriter(new global::System.Text.StringBuilder(capacity), global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00018FF8 File Offset: 0x000171F8
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			buffer[0] = '\\';
			buffer[1] = 'u';
			buffer[2] = global::Newtonsoft.Json.Utilities.MathUtils.IntToHex((int)(c >> 12 & '\u000f'));
			buffer[3] = global::Newtonsoft.Json.Utilities.MathUtils.IntToHex((int)(c >> 8 & '\u000f'));
			buffer[4] = global::Newtonsoft.Json.Utilities.MathUtils.IntToHex((int)(c >> 4 & '\u000f'));
			buffer[5] = global::Newtonsoft.Json.Utilities.MathUtils.IntToHex((int)(c & '\u000f'));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00019048 File Offset: 0x00017248
		public static TSource ForgivingCaseSensitiveFind<[global::System.Runtime.CompilerServices.Nullable(2)] TSource>(this global::System.Collections.Generic.IEnumerable<TSource> source, global::System.Func<TSource, string> valueSelector, string testValue)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (valueSelector == null)
			{
				throw new global::System.ArgumentNullException("valueSelector");
			}
			global::System.Collections.Generic.IEnumerable<TSource> source2 = from s in source
			where string.Equals(valueSelector(s), testValue, global::System.StringComparison.OrdinalIgnoreCase)
			select s;
			if (source2.Count<TSource>() <= 1)
			{
				return source2.SingleOrDefault<TSource>();
			}
			return (from s in source
			where string.Equals(valueSelector(s), testValue, global::System.StringComparison.Ordinal)
			select s).SingleOrDefault<TSource>();
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000190C4 File Offset: 0x000172C4
		public static string ToCamelCase(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s) || !char.IsUpper(s[0]))
			{
				return s;
			}
			char[] array = s.ToCharArray();
			int num = 0;
			while (num < array.Length && (num != 1 || char.IsUpper(array[num])))
			{
				bool flag = num + 1 < array.Length;
				if (num > 0 && flag && !char.IsUpper(array[num + 1]))
				{
					if (char.IsSeparator(array[num + 1]))
					{
						array[num] = global::Newtonsoft.Json.Utilities.StringUtils.ToLower(array[num]);
						break;
					}
					break;
				}
				else
				{
					array[num] = global::Newtonsoft.Json.Utilities.StringUtils.ToLower(array[num]);
					num++;
				}
			}
			return new string(array);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00019153 File Offset: 0x00017353
		private static char ToLower(char c)
		{
			c = char.ToLower(c, global::System.Globalization.CultureInfo.InvariantCulture);
			return c;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00019163 File Offset: 0x00017363
		public static string ToSnakeCase(string s)
		{
			return global::Newtonsoft.Json.Utilities.StringUtils.ToSeparatedCase(s, '_');
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001916D File Offset: 0x0001736D
		public static string ToKebabCase(string s)
		{
			return global::Newtonsoft.Json.Utilities.StringUtils.ToSeparatedCase(s, '-');
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00019178 File Offset: 0x00017378
		private static string ToSeparatedCase(string s, char separator)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				return s;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState separatedCaseState = global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Start;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ')
				{
					if (separatedCaseState != global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Start)
					{
						separatedCaseState = global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.NewWord;
					}
				}
				else if (char.IsUpper(s[i]))
				{
					switch (separatedCaseState)
					{
					case global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Lower:
					case global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.NewWord:
						stringBuilder.Append(separator);
						break;
					case global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Upper:
					{
						bool flag = i + 1 < s.Length;
						if (i > 0 && flag)
						{
							char c = s[i + 1];
							if (!char.IsUpper(c) && c != separator)
							{
								stringBuilder.Append(separator);
							}
						}
						break;
					}
					}
					char value = char.ToLower(s[i], global::System.Globalization.CultureInfo.InvariantCulture);
					stringBuilder.Append(value);
					separatedCaseState = global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Upper;
				}
				else if (s[i] == separator)
				{
					stringBuilder.Append(separator);
					separatedCaseState = global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Start;
				}
				else
				{
					if (separatedCaseState == global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.NewWord)
					{
						stringBuilder.Append(separator);
					}
					stringBuilder.Append(s[i]);
					separatedCaseState = global::Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState.Lower;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00019281 File Offset: 0x00017481
		public static bool IsHighSurrogate(char c)
		{
			return char.IsHighSurrogate(c);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00019289 File Offset: 0x00017489
		public static bool IsLowSurrogate(char c)
		{
			return char.IsLowSurrogate(c);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00019291 File Offset: 0x00017491
		public static bool StartsWith(this string source, char value)
		{
			return source.Length > 0 && source[0] == value;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000192A8 File Offset: 0x000174A8
		public static bool EndsWith(this string source, char value)
		{
			return source.Length > 0 && source[source.Length - 1] == value;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000192C8 File Offset: 0x000174C8
		public static string Trim(this string s, int start, int length)
		{
			if (s == null)
			{
				throw new global::System.ArgumentNullException();
			}
			if (start < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("start");
			}
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = start + length - 1;
			if (num >= s.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			while (start < num)
			{
				if (!char.IsWhiteSpace(s[start]))
				{
					IL_6C:
					while (num >= start && char.IsWhiteSpace(s[num]))
					{
						num--;
					}
					return s.Substring(start, num - start + 1);
				}
				start++;
			}
			goto IL_6C;
		}

		// Token: 0x04000206 RID: 518
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x04000207 RID: 519
		public const string Empty = "";

		// Token: 0x04000208 RID: 520
		public const char CarriageReturn = '\r';

		// Token: 0x04000209 RID: 521
		public const char LineFeed = '\n';

		// Token: 0x0400020A RID: 522
		public const char Tab = '\t';

		// Token: 0x02000197 RID: 407
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		private enum SeparatedCaseState
		{
			// Token: 0x040006FD RID: 1789
			Start,
			// Token: 0x040006FE RID: 1790
			Lower,
			// Token: 0x040006FF RID: 1791
			Upper,
			// Token: 0x04000700 RID: 1792
			NewWord
		}
	}
}
