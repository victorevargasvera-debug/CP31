using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FE RID: 1534
	internal static class StringUtil
	{
		// Token: 0x06004B32 RID: 19250 RVA: 0x001093C8 File Offset: 0x001075C8
		internal static string BuildDelimitedList<T>(global::System.Collections.Generic.IEnumerable<T> values, global::System.Data.Entity.Core.Common.Utils.StringUtil.ToStringConverter<T> converter, string delimiter)
		{
			if (values == null)
			{
				return string.Empty;
			}
			if (converter == null)
			{
				converter = new global::System.Data.Entity.Core.Common.Utils.StringUtil.ToStringConverter<T>(global::System.Data.Entity.Core.Common.Utils.StringUtil.InvariantConvertToString<T>);
			}
			if (delimiter == null)
			{
				delimiter = ", ";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (T value in values)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(delimiter);
				}
				stringBuilder.Append(converter(value));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00109458 File Offset: 0x00107658
		internal static string ToCommaSeparatedString(global::System.Collections.IEnumerable list)
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(list, ", ", string.Empty);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0010946A File Offset: 0x0010766A
		internal static string ToSeparatedString(global::System.Collections.IEnumerable list, string separator, string nullValue)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(stringBuilder, list, separator, nullValue);
			return stringBuilder.ToString();
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x0010947F File Offset: 0x0010767F
		internal static string ToCommaSeparatedStringSorted(global::System.Collections.IEnumerable list)
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringSorted(list, ", ", string.Empty);
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00109491 File Offset: 0x00107691
		internal static string ToSeparatedStringSorted(global::System.Collections.IEnumerable list, string separator, string nullValue)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(stringBuilder, list, separator, nullValue, true);
			return stringBuilder.ToString();
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x001094A7 File Offset: 0x001076A7
		internal static string MembersToCommaSeparatedString(global::System.Collections.IEnumerable members)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("{");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(stringBuilder, members);
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x001094D2 File Offset: 0x001076D2
		internal static void ToCommaSeparatedString(global::System.Text.StringBuilder builder, global::System.Collections.IEnumerable list)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(builder, list, ", ", string.Empty, false);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x001094E6 File Offset: 0x001076E6
		internal static void ToCommaSeparatedStringSorted(global::System.Text.StringBuilder builder, global::System.Collections.IEnumerable list)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(builder, list, ", ", string.Empty, true);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x001094FA File Offset: 0x001076FA
		internal static void ToSeparatedString(global::System.Text.StringBuilder builder, global::System.Collections.IEnumerable list, string separator)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(builder, list, separator, string.Empty, false);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x0010950A File Offset: 0x0010770A
		internal static void ToSeparatedStringSorted(global::System.Text.StringBuilder builder, global::System.Collections.IEnumerable list, string separator)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(builder, list, separator, string.Empty, true);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0010951A File Offset: 0x0010771A
		internal static void ToSeparatedString(global::System.Text.StringBuilder stringBuilder, global::System.Collections.IEnumerable list, string separator, string nullValue)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringPrivate(stringBuilder, list, separator, nullValue, false);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00109528 File Offset: 0x00107728
		private static void ToSeparatedStringPrivate(global::System.Text.StringBuilder stringBuilder, global::System.Collections.IEnumerable list, string separator, string nullValue, bool toSort)
		{
			if (list == null)
			{
				return;
			}
			bool flag = true;
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			foreach (object obj in list)
			{
				string item;
				if (obj == null)
				{
					item = nullValue;
				}
				else
				{
					item = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
					{
						obj
					});
				}
				list2.Add(item);
			}
			if (toSort)
			{
				list2.Sort(global::System.StringComparer.Ordinal);
			}
			foreach (string value in list2)
			{
				if (!flag)
				{
					stringBuilder.Append(separator);
				}
				stringBuilder.Append(value);
				flag = false;
			}
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00109604 File Offset: 0x00107804
		internal static string FormatInvariant(string format, params object[] args)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args);
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00109612 File Offset: 0x00107812
		internal static global::System.Text.StringBuilder FormatStringBuilder(global::System.Text.StringBuilder builder, string format, params object[] args)
		{
			builder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, format, args);
			return builder;
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00109624 File Offset: 0x00107824
		internal static global::System.Text.StringBuilder IndentNewLine(global::System.Text.StringBuilder builder, int indent)
		{
			builder.AppendLine();
			for (int i = 0; i < indent; i++)
			{
				builder.Append("    ");
			}
			return builder;
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x00109651 File Offset: 0x00107851
		internal static string FormatIndex(string arrayVarName, int index)
		{
			return new global::System.Text.StringBuilder(arrayVarName.Length + 10 + 2).Append(arrayVarName).Append('[').Append(index).Append(']').ToString();
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x00109682 File Offset: 0x00107882
		private static string InvariantConvertToString<T>(T value)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				value
			});
		}

		// Token: 0x04001A51 RID: 6737
		private const string s_defaultDelimiter = ", ";

		// Token: 0x02000C48 RID: 3144
		// (Invoke) Token: 0x06006A76 RID: 27254
		internal delegate string ToStringConverter<T>(T value);
	}
}
