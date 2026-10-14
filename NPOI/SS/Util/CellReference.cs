using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x02000019 RID: 25
	public class CellReference
	{
		// Token: 0x06000102 RID: 258 RVA: 0x000054F8 File Offset: 0x000036F8
		public CellReference(string cellRef)
		{
			if (cellRef.EndsWith("#REF!", global::System.StringComparison.InvariantCulture))
			{
				throw new global::System.ArgumentException("Cell reference invalid: " + cellRef);
			}
			global::NPOI.SS.Util.CellReference.CellRefPartsInner cellRefPartsInner = global::NPOI.SS.Util.CellReference.SeparateRefParts(cellRef);
			this._sheetName = cellRefPartsInner.sheetName;
			string text = cellRefPartsInner.colRef;
			this._isColAbs = (text.Length > 0 && text[0] == '$');
			if (this._isColAbs)
			{
				text = text.Substring(1);
			}
			if (text.Length == 0)
			{
				this._colIndex = -1;
			}
			else
			{
				this._colIndex = global::NPOI.SS.Util.CellReference.ConvertColStringToIndex(text);
			}
			string text2 = cellRefPartsInner.rowRef;
			this._isRowAbs = (text2.Length > 0 && text2[0] == '$');
			if (this._isRowAbs)
			{
				text2 = text2.Substring(1);
			}
			if (text2.Length == 0)
			{
				this._rowIndex = -1;
				return;
			}
			this._rowIndex = int.Parse(text2, global::System.Globalization.CultureInfo.InvariantCulture) - 1;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000055E5 File Offset: 0x000037E5
		public CellReference(global::NPOI.SS.UserModel.ICell cell) : this(cell.RowIndex, cell.ColumnIndex, false, false)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000055FB File Offset: 0x000037FB
		public CellReference(int pRow, int pCol) : this(pRow, pCol, false, false)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005607 File Offset: 0x00003807
		public CellReference(int pRow, short pCol) : this(pRow, (int)pCol & 65535, false, false)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005619 File Offset: 0x00003819
		public CellReference(int pRow, int pCol, bool pAbsRow, bool pAbsCol) : this(null, pRow, pCol, pAbsRow, pAbsCol)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005628 File Offset: 0x00003828
		public CellReference(string pSheetName, int pRow, int pCol, bool pAbsRow, bool pAbsCol)
		{
			if (pRow < -1)
			{
				throw new global::System.ArgumentException("row index may not be negative, but had " + pRow.ToString());
			}
			if (pCol < -1)
			{
				throw new global::System.ArgumentException("column index may not be negative, but had " + pCol.ToString());
			}
			this._sheetName = pSheetName;
			this._rowIndex = pRow;
			this._colIndex = pCol;
			this._isRowAbs = pAbsRow;
			this._isColAbs = pAbsCol;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005696 File Offset: 0x00003896
		public int Row
		{
			get
			{
				return this._rowIndex;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000569E File Offset: 0x0000389E
		public short Col
		{
			get
			{
				return (short)this._colIndex;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000056A7 File Offset: 0x000038A7
		public bool IsRowAbsolute
		{
			get
			{
				return this._isRowAbs;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000056AF File Offset: 0x000038AF
		public bool IsColAbsolute
		{
			get
			{
				return this._isColAbs;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000056B7 File Offset: 0x000038B7
		public string SheetName
		{
			get
			{
				return this._sheetName;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000056C0 File Offset: 0x000038C0
		public static int ConvertColStringToIndex(string ref1)
		{
			int num = 0;
			char[] array = ref1.ToUpper().ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				char c = array[i];
				if (c == '$')
				{
					if (i != 0)
					{
						throw new global::System.ArgumentException("Bad col ref format '" + ref1 + "'");
					}
				}
				else
				{
					num = num * 26 + (int)(c - 'A' + '\u0001');
				}
			}
			return num - 1;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000571A File Offset: 0x0000391A
		public static bool IsPartAbsolute(string part)
		{
			return part[0] == '$';
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005728 File Offset: 0x00003928
		public static global::NPOI.SS.Util.NameType ClassifyCellReference(string str, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			int length = str.Length;
			if (length < 1)
			{
				throw new global::System.ArgumentException("Empty string not allowed");
			}
			char c = str[0];
			if (c != '$' && c != '.' && c != '_' && !char.IsLetter(c) && !char.IsDigit(c))
			{
				throw new global::System.ArgumentException("Invalid first char (" + c.ToString() + ") of cell reference or named range.  Letter expected");
			}
			if (!char.IsDigit(str[length - 1]))
			{
				return global::NPOI.SS.Util.CellReference.ValidateNamedRangeName(str, ssVersion);
			}
			global::System.Text.RegularExpressions.Regex strictly_CELL_REF_PATTERN = global::NPOI.SS.Util.CellReference.STRICTLY_CELL_REF_PATTERN;
			if (!strictly_CELL_REF_PATTERN.IsMatch(str))
			{
				return global::NPOI.SS.Util.CellReference.ValidateNamedRangeName(str, ssVersion);
			}
			global::System.Text.RegularExpressions.MatchCollection matchCollection = strictly_CELL_REF_PATTERN.Matches(str);
			string value = matchCollection[0].Groups[1].Value;
			string value2 = matchCollection[0].Groups[2].Value;
			if (global::NPOI.SS.Util.CellReference.CellReferenceIsWithinRange(value, value2, ssVersion))
			{
				return global::NPOI.SS.Util.NameType.Cell;
			}
			if (str.IndexOf('$') >= 0)
			{
				return global::NPOI.SS.Util.NameType.BadCellOrNamedRange;
			}
			return global::NPOI.SS.Util.NameType.NamedRange;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005810 File Offset: 0x00003A10
		private static global::NPOI.SS.Util.NameType ValidateNamedRangeName(string str, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			global::System.Text.RegularExpressions.Regex column_REF_PATTERN = global::NPOI.SS.Util.CellReference.COLUMN_REF_PATTERN;
			if (column_REF_PATTERN.IsMatch(str) && global::NPOI.SS.Util.CellReference.IsColumnWithinRange(column_REF_PATTERN.Matches(str)[0].Groups[1].Value, ssVersion))
			{
				return global::NPOI.SS.Util.NameType.Column;
			}
			global::System.Text.RegularExpressions.Regex row_REF_PATTERN = global::NPOI.SS.Util.CellReference.ROW_REF_PATTERN;
			if (row_REF_PATTERN.IsMatch(str) && global::NPOI.SS.Util.CellReference.IsRowWithinRange(row_REF_PATTERN.Matches(str)[0].Groups[1].Value, ssVersion))
			{
				return global::NPOI.SS.Util.NameType.Row;
			}
			if (!global::NPOI.SS.Util.CellReference.NAMED_RANGE_NAME_PATTERN.IsMatch(str))
			{
				return global::NPOI.SS.Util.NameType.BadCellOrNamedRange;
			}
			return global::NPOI.SS.Util.NameType.NamedRange;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000589C File Offset: 0x00003A9C
		public static string ConvertNumToColString(int col)
		{
			int num = col + 1;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(2);
			int i = num;
			while (i > 0)
			{
				int num2 = i % 26;
				if (num2 == 0)
				{
					num2 = 26;
				}
				i = (i - num2) / 26;
				char value = (char)(num2 + 64);
				stringBuilder.Insert(0, value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000058E4 File Offset: 0x00003AE4
		private static global::NPOI.SS.Util.CellReference.CellRefPartsInner SeparateRefParts(string reference)
		{
			int num = reference.LastIndexOf('!');
			string sheetName = global::NPOI.SS.Util.CellReference.ParseSheetName(reference, num);
			string input = reference.Substring(num + 1).ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.Util.CellReference.CELL_REF_PATTERN.Match(input);
			if (!match.Success)
			{
				throw new global::System.ArgumentException("Invalid CellReference: " + reference);
			}
			string value = match.Groups[1].Value;
			string value2 = match.Groups[2].Value;
			return new global::NPOI.SS.Util.CellReference.CellRefPartsInner(sheetName, value2, value);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005964 File Offset: 0x00003B64
		private static string ParseSheetName(string reference, int indexOfSheetNameDelimiter)
		{
			if (indexOfSheetNameDelimiter < 0)
			{
				return null;
			}
			if (reference[0] != '\'')
			{
				if (reference.IndexOf(' ') == -1)
				{
					return reference.Substring(0, indexOfSheetNameDelimiter);
				}
				throw new global::System.ArgumentException("Sheet names containing spaces must be quoted: (" + reference + ")");
			}
			else
			{
				int num = indexOfSheetNameDelimiter - 1;
				if (reference[num] != '\'')
				{
					throw new global::System.ArgumentException("Mismatched quotes: (" + reference + ")");
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(indexOfSheetNameDelimiter);
				for (int i = 1; i < num; i++)
				{
					char c = reference[i];
					if (c != '\'')
					{
						stringBuilder.Append(c);
					}
					else
					{
						if (i >= num || reference[i + 1] != '\'')
						{
							throw new global::System.ArgumentException("Bad sheet name quote escaping: (" + reference + ")");
						}
						i++;
						stringBuilder.Append(c);
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005A38 File Offset: 0x00003C38
		public string FormatAsString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
			if (this._sheetName != null)
			{
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this._sheetName);
				stringBuilder.Append('!');
			}
			this.AppendCellReference(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005A78 File Offset: 0x00003C78
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005AC8 File Offset: 0x00003CC8
		public string[] CellRefParts
		{
			get
			{
				return new string[]
				{
					this._sheetName,
					(this._rowIndex + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
					global::NPOI.SS.Util.CellReference.ConvertNumToColString(this._colIndex)
				};
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005B0C File Offset: 0x00003D0C
		public void AppendCellReference(global::System.Text.StringBuilder sb)
		{
			if (this._colIndex != -1)
			{
				if (this._isColAbs)
				{
					sb.Append('$');
				}
				sb.Append(global::NPOI.SS.Util.CellReference.ConvertNumToColString(this._colIndex));
			}
			if (this._rowIndex != -1)
			{
				if (this._isRowAbs)
				{
					sb.Append('$');
				}
				sb.Append(this._rowIndex + 1);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005B6E File Offset: 0x00003D6E
		public static bool CellReferenceIsWithinRange(string colStr, string rowStr, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			return global::NPOI.SS.Util.CellReference.IsColumnWithinRange(colStr, ssVersion) && global::NPOI.SS.Util.CellReference.IsRowWithinRange(rowStr, ssVersion);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005B82 File Offset: 0x00003D82
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link #isColumnWithinRange}.")]
		public static bool IsColumnWithnRange(string colStr, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			return global::NPOI.SS.Util.CellReference.IsColumnWithinRange(colStr, ssVersion);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005B8C File Offset: 0x00003D8C
		public static bool IsRowWithinRange(string rowStr, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			int num = int.Parse(rowStr) - 1;
			return 0 <= num && num <= ssVersion.LastRowIndex;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005BB4 File Offset: 0x00003DB4
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link #isRowWithinRange}")]
		public static bool isRowWithnRange(string rowStr, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			return global::NPOI.SS.Util.CellReference.IsRowWithinRange(rowStr, ssVersion);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005BC0 File Offset: 0x00003DC0
		public static bool IsColumnWithinRange(string colStr, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			string lastColumnName = ssVersion.LastColumnName;
			int length = lastColumnName.Length;
			int length2 = colStr.Length;
			return length2 <= length && (length2 != length || string.Compare(colStr.ToUpper(), lastColumnName, global::System.StringComparison.Ordinal) <= 0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005C00 File Offset: 0x00003E00
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (!(o is global::NPOI.SS.Util.CellReference))
			{
				return false;
			}
			global::NPOI.SS.Util.CellReference cellReference = (global::NPOI.SS.Util.CellReference)o;
			if (this._rowIndex != cellReference._rowIndex || this._colIndex != cellReference._colIndex || this._isRowAbs != cellReference._isRowAbs || this._isColAbs != cellReference._isColAbs)
			{
				return false;
			}
			if (this._sheetName != null)
			{
				return this._sheetName.Equals(cellReference._sheetName);
			}
			return cellReference._sheetName == null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005C84 File Offset: 0x00003E84
		public override int GetHashCode()
		{
			int num = 17;
			num = 31 * num + this._rowIndex;
			num = 31 * num + this._colIndex;
			num = 31 * num + (this._isRowAbs ? 1 : 0);
			num = 31 * num + (this._isColAbs ? 1 : 0);
			return 31 * num + ((this._sheetName == null) ? 0 : this._sheetName.GetHashCode());
		}

		// Token: 0x0400003F RID: 63
		private const char ABSOLUTE_REFERENCE_MARKER = '$';

		// Token: 0x04000040 RID: 64
		private const char SHEET_NAME_DELIMITER = '!';

		// Token: 0x04000041 RID: 65
		private const char SPECIAL_NAME_DELIMITER = '\'';

		// Token: 0x04000042 RID: 66
		private static global::System.Text.RegularExpressions.Regex CELL_REF_PATTERN = new global::System.Text.RegularExpressions.Regex("(\\$?[A-Z]+)?(\\$?[0-9]+)?", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);

		// Token: 0x04000043 RID: 67
		private static global::System.Text.RegularExpressions.Regex STRICTLY_CELL_REF_PATTERN = new global::System.Text.RegularExpressions.Regex("^\\$?([A-Z]+)\\$?([0-9]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);

		// Token: 0x04000044 RID: 68
		private static global::System.Text.RegularExpressions.Regex COLUMN_REF_PATTERN = new global::System.Text.RegularExpressions.Regex("^\\$?([A-Za-z]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);

		// Token: 0x04000045 RID: 69
		private static global::System.Text.RegularExpressions.Regex ROW_REF_PATTERN = new global::System.Text.RegularExpressions.Regex("^\\$?([0-9]+)$");

		// Token: 0x04000046 RID: 70
		private static global::System.Text.RegularExpressions.Regex NAMED_RANGE_NAME_PATTERN = new global::System.Text.RegularExpressions.Regex("^[_A-Za-z][_.A-Za-z0-9]*$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);

		// Token: 0x04000047 RID: 71
		private string _sheetName;

		// Token: 0x04000048 RID: 72
		private int _rowIndex;

		// Token: 0x04000049 RID: 73
		private int _colIndex;

		// Token: 0x0400004A RID: 74
		private bool _isRowAbs;

		// Token: 0x0400004B RID: 75
		private bool _isColAbs;

		// Token: 0x02000552 RID: 1362
		internal class CellRefPartsInner
		{
			// Token: 0x06003368 RID: 13160 RVA: 0x000A0FC2 File Offset: 0x0009F1C2
			public CellRefPartsInner(string sheetName, string rowRef, string colRef)
			{
				this.sheetName = sheetName;
				this.rowRef = (rowRef ?? "");
				this.colRef = (colRef ?? "");
			}

			// Token: 0x04001863 RID: 6243
			public string sheetName;

			// Token: 0x04001864 RID: 6244
			public string rowRef;

			// Token: 0x04001865 RID: 6245
			public string colRef;
		}
	}
}
