using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DD RID: 221
	public class SheetNameFormatter
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x0000253E File Offset: 0x0000073E
		private SheetNameFormatter()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00013F78 File Offset: 0x00012178
		public static string Format(string rawSheetName)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(rawSheetName.Length + 2);
			global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, rawSheetName);
			return stringBuilder.ToString();
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00013F93 File Offset: 0x00012193
		public static void AppendFormat(global::System.Text.StringBuilder out1, string rawSheetName)
		{
			if (global::NPOI.SS.Formula.SheetNameFormatter.NeedsDelimiting(rawSheetName))
			{
				out1.Append('\'');
				global::NPOI.SS.Formula.SheetNameFormatter.AppendAndEscape(out1, rawSheetName);
				out1.Append('\'');
				return;
			}
			out1.Append(rawSheetName);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00013FC0 File Offset: 0x000121C0
		public static void AppendFormat(global::System.Text.StringBuilder out1, string workbookName, string rawSheetName)
		{
			if (global::NPOI.SS.Formula.SheetNameFormatter.NeedsDelimiting(workbookName) || global::NPOI.SS.Formula.SheetNameFormatter.NeedsDelimiting(rawSheetName))
			{
				out1.Append('\'');
				out1.Append('[');
				global::NPOI.SS.Formula.SheetNameFormatter.AppendAndEscape(out1, workbookName.Replace('[', '(').Replace(']', ')'));
				out1.Append(']');
				global::NPOI.SS.Formula.SheetNameFormatter.AppendAndEscape(out1, rawSheetName);
				out1.Append('\'');
				return;
			}
			out1.Append('[');
			out1.Append(workbookName);
			out1.Append(']');
			out1.Append(rawSheetName);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00014048 File Offset: 0x00012248
		private static void AppendAndEscape(global::System.Text.StringBuilder sb, string rawSheetName)
		{
			int length = rawSheetName.Length;
			for (int i = 0; i < length; i++)
			{
				char c = rawSheetName[i];
				if (c == '\'')
				{
					sb.Append('\'');
				}
				sb.Append(c);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00014088 File Offset: 0x00012288
		private static bool NeedsDelimiting(string rawSheetName)
		{
			int length = rawSheetName.Length;
			if (length < 1)
			{
				throw new global::System.Exception("Zero Length string is an invalid sheet name");
			}
			if (char.IsDigit(rawSheetName[0]))
			{
				return true;
			}
			for (int i = 0; i < length; i++)
			{
				if (global::NPOI.SS.Formula.SheetNameFormatter.IsSpecialChar(rawSheetName[i]))
				{
					return true;
				}
			}
			return (char.IsLetter(rawSheetName[0]) && char.IsDigit(rawSheetName[length - 1]) && global::NPOI.SS.Formula.SheetNameFormatter.NameLooksLikePlainCellReference(rawSheetName)) || global::NPOI.SS.Formula.SheetNameFormatter.NameLooksLikeBooleanLiteral(rawSheetName);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001410C File Offset: 0x0001230C
		private static bool NameLooksLikeBooleanLiteral(string rawSheetName)
		{
			char c = rawSheetName[0];
			if (c <= 'T')
			{
				if (c == 'F')
				{
					goto IL_30;
				}
				if (c != 'T')
				{
					return false;
				}
			}
			else
			{
				if (c == 'f')
				{
					goto IL_30;
				}
				if (c != 't')
				{
					return false;
				}
			}
			return "TRUE".Equals(rawSheetName, global::System.StringComparison.OrdinalIgnoreCase);
			IL_30:
			return "FALSE".Equals(rawSheetName, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00014158 File Offset: 0x00012358
		private static bool IsSpecialChar(char ch)
		{
			if (char.IsLetterOrDigit(ch))
			{
				return false;
			}
			switch (ch)
			{
			case '\t':
			case '\n':
			case '\r':
				throw new global::System.Exception("Illegal Char (0x" + global::NPOI.Util.StringUtil.ToHexString(ch) + ") found in sheet name");
			case '\v':
			case '\f':
				break;
			default:
				if (ch == '.' || ch == '_')
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000141B4 File Offset: 0x000123B4
		public static bool CellReferenceIsWithinRange(string lettersPrefix, string numbersSuffix)
		{
			return global::NPOI.SS.Util.CellReference.CellReferenceIsWithinRange(lettersPrefix, numbersSuffix, global::NPOI.SS.SpreadsheetVersion.EXCEL97);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000141C4 File Offset: 0x000123C4
		public static bool NameLooksLikePlainCellReference(string rawSheetName)
		{
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^([A-Za-z]+)([0-9]+)$");
			if (!regex.IsMatch(rawSheetName))
			{
				return false;
			}
			global::System.Text.RegularExpressions.Match match = regex.Matches(rawSheetName)[0];
			string value = match.Groups[1].Value;
			string value2 = match.Groups[2].Value;
			return global::NPOI.SS.Formula.SheetNameFormatter.CellReferenceIsWithinRange(value, value2);
		}

		// Token: 0x040003ED RID: 1005
		private const string BIFF8_LAST_COLUMN = "IV";

		// Token: 0x040003EE RID: 1006
		private const int BIFF8_LAST_COLUMN_TEXT_LEN = 2;

		// Token: 0x040003EF RID: 1007
		private static readonly string BIFF8_LAST_ROW = 65536.ToString(global::System.Globalization.CultureInfo.InvariantCulture);

		// Token: 0x040003F0 RID: 1008
		private static readonly int BIFF8_LAST_ROW_TEXT_LEN = global::NPOI.SS.Formula.SheetNameFormatter.BIFF8_LAST_ROW.Length;

		// Token: 0x040003F1 RID: 1009
		private const char DELIMITER = '\'';

		// Token: 0x040003F2 RID: 1010
		private const string CELL_REF_PATTERN = "^([A-Za-z]+)([0-9]+)$";
	}
}
