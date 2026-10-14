using System;
using System.Collections;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x02000013 RID: 19
	public class AreaReference
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00004574 File Offset: 0x00002774
		[global::System.Obsolete("deprecated since NPOI 2.5.1 Prefer supplying a spreadsheet version.")]
		public AreaReference(string reference) : this(reference, global::NPOI.SS.Util.AreaReference.DEFAULT_SPREADSHEET_VERSION)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004584 File Offset: 0x00002784
		public AreaReference(string reference, global::NPOI.SS.SpreadsheetVersion version)
		{
			this._version = ((version != null) ? version : global::NPOI.SS.Util.AreaReference.DEFAULT_SPREADSHEET_VERSION);
			if (!global::NPOI.SS.Util.AreaReference.IsContiguous(reference))
			{
				throw new global::System.ArgumentException("References passed to the AreaReference must be contiguous, use generateContiguous(ref) if you have non-contiguous references");
			}
			string[] array = global::NPOI.SS.Util.AreaReference.SeparateAreaRefs(reference);
			string text = array[0];
			if (array.Length == 1)
			{
				this._firstCell = new global::NPOI.SS.Util.CellReference(text);
				this._lastCell = this._firstCell;
				this._isSingleCell = true;
				return;
			}
			if (array.Length != 2)
			{
				throw new global::System.ArgumentException("Bad area ref '" + reference + "'");
			}
			string text2 = array[1];
			if (!global::NPOI.SS.Util.AreaReference.IsPlainColumn(text))
			{
				this._firstCell = new global::NPOI.SS.Util.CellReference(text);
				this._lastCell = new global::NPOI.SS.Util.CellReference(text2);
				this._isSingleCell = text.Equals(text2);
				return;
			}
			if (!global::NPOI.SS.Util.AreaReference.IsPlainColumn(text2))
			{
				throw new global::System.Exception("Bad area ref '" + reference + "'");
			}
			bool pAbsCol = global::NPOI.SS.Util.CellReference.IsPartAbsolute(text);
			bool pAbsCol2 = global::NPOI.SS.Util.CellReference.IsPartAbsolute(text2);
			int pCol = global::NPOI.SS.Util.CellReference.ConvertColStringToIndex(text);
			int pCol2 = global::NPOI.SS.Util.CellReference.ConvertColStringToIndex(text2);
			this._firstCell = new global::NPOI.SS.Util.CellReference(0, pCol, true, pAbsCol);
			this._lastCell = new global::NPOI.SS.Util.CellReference(65535, pCol2, true, pAbsCol2);
			this._isSingleCell = false;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000046A4 File Offset: 0x000028A4
		private static bool IsPlainColumn(string refPart)
		{
			for (int i = refPart.Length - 1; i >= 0; i--)
			{
				int num = (int)refPart[i];
				if ((num != 36 || i != 0) && (num < 65 || num > 90))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000046E1 File Offset: 0x000028E1
		public static global::NPOI.SS.Util.AreaReference GetWholeRow(global::NPOI.SS.SpreadsheetVersion version, string start, string end)
		{
			if (version == null)
			{
				version = global::NPOI.SS.Util.AreaReference.DEFAULT_SPREADSHEET_VERSION;
			}
			return new global::NPOI.SS.Util.AreaReference(string.Concat(new string[]
			{
				"$A",
				start,
				":$",
				version.LastColumnName,
				end
			}), version);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004720 File Offset: 0x00002920
		public static global::NPOI.SS.Util.AreaReference GetWholeColumn(global::NPOI.SS.SpreadsheetVersion version, string start, string end)
		{
			if (version == null)
			{
				version = global::NPOI.SS.Util.AreaReference.DEFAULT_SPREADSHEET_VERSION;
			}
			return new global::NPOI.SS.Util.AreaReference(string.Concat(new string[]
			{
				start,
				"$1:",
				end,
				"$",
				version.MaxRows.ToString()
			}), version);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004774 File Offset: 0x00002974
		public AreaReference(global::NPOI.SS.Util.CellReference topLeft, global::NPOI.SS.Util.CellReference botRight)
		{
			this._version = global::NPOI.SS.Util.AreaReference.DEFAULT_SPREADSHEET_VERSION;
			bool flag = topLeft.Row > botRight.Row;
			bool flag2 = topLeft.Col > botRight.Col;
			if (flag || flag2)
			{
				int row;
				bool isRowAbsolute;
				int row2;
				bool isRowAbsolute2;
				if (flag)
				{
					row = botRight.Row;
					isRowAbsolute = botRight.IsRowAbsolute;
					row2 = topLeft.Row;
					isRowAbsolute2 = topLeft.IsRowAbsolute;
				}
				else
				{
					row = topLeft.Row;
					isRowAbsolute = topLeft.IsRowAbsolute;
					row2 = botRight.Row;
					isRowAbsolute2 = botRight.IsRowAbsolute;
				}
				int col;
				bool isColAbsolute;
				int col2;
				bool isColAbsolute2;
				if (flag2)
				{
					col = (int)botRight.Col;
					isColAbsolute = botRight.IsColAbsolute;
					col2 = (int)topLeft.Col;
					isColAbsolute2 = topLeft.IsColAbsolute;
				}
				else
				{
					col = (int)topLeft.Col;
					isColAbsolute = topLeft.IsColAbsolute;
					col2 = (int)botRight.Col;
					isColAbsolute2 = botRight.IsColAbsolute;
				}
				this._firstCell = new global::NPOI.SS.Util.CellReference(row, col, isRowAbsolute, isColAbsolute);
				this._lastCell = new global::NPOI.SS.Util.CellReference(row2, col2, isRowAbsolute2, isColAbsolute2);
			}
			else
			{
				this._firstCell = topLeft;
				this._lastCell = botRight;
			}
			this._isSingleCell = false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000487C File Offset: 0x00002A7C
		public static bool IsContiguous(string reference)
		{
			int num = reference.IndexOf('!');
			if (num != -1)
			{
				reference = reference.Substring(num);
			}
			return reference.IndexOf(',') == -1;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000048AD File Offset: 0x00002AAD
		public static bool IsWholeColumnReference(global::NPOI.SS.SpreadsheetVersion version, global::NPOI.SS.Util.CellReference topLeft, global::NPOI.SS.Util.CellReference botRight)
		{
			if (version == null)
			{
				version = global::NPOI.SS.SpreadsheetVersion.EXCEL97;
			}
			return topLeft.Row == 0 && topLeft.IsRowAbsolute && botRight.Row == version.LastRowIndex && botRight.IsRowAbsolute;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000048E2 File Offset: 0x00002AE2
		public bool IsWholeColumnReference()
		{
			return global::NPOI.SS.Util.AreaReference.IsWholeColumnReference(this._version, this._firstCell, this._lastCell);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000048FC File Offset: 0x00002AFC
		public static global::NPOI.SS.Util.AreaReference[] GenerateContiguous(string reference)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			foreach (string reference2 in reference.Split(new char[]
			{
				','
			}))
			{
				arrayList.Add(new global::NPOI.SS.Util.AreaReference(reference2));
			}
			return (global::NPOI.SS.Util.AreaReference[])arrayList.ToArray(typeof(global::NPOI.SS.Util.AreaReference));
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004955 File Offset: 0x00002B55
		public bool IsSingleCell
		{
			get
			{
				return this._isSingleCell;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000495D File Offset: 0x00002B5D
		public global::NPOI.SS.Util.CellReference FirstCell
		{
			get
			{
				return this._firstCell;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004965 File Offset: 0x00002B65
		public global::NPOI.SS.Util.CellReference LastCell
		{
			get
			{
				return this._lastCell;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004970 File Offset: 0x00002B70
		public global::NPOI.SS.Util.CellReference[] GetAllReferencedCells()
		{
			if (this._isSingleCell)
			{
				return new global::NPOI.SS.Util.CellReference[]
				{
					this._firstCell
				};
			}
			int num = global::System.Math.Min(this._firstCell.Row, this._lastCell.Row);
			int num2 = global::System.Math.Max(this._firstCell.Row, this._lastCell.Row);
			int num3 = (int)global::System.Math.Min(this._firstCell.Col, this._lastCell.Col);
			int num4 = (int)global::System.Math.Max(this._firstCell.Col, this._lastCell.Col);
			string sheetName = this._firstCell.SheetName;
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					global::NPOI.SS.Util.CellReference value = new global::NPOI.SS.Util.CellReference(sheetName, i, j, this._firstCell.IsRowAbsolute, this._firstCell.IsColAbsolute);
					arrayList.Add(value);
				}
			}
			return (global::NPOI.SS.Util.CellReference[])arrayList.ToArray(typeof(global::NPOI.SS.Util.CellReference));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004A78 File Offset: 0x00002C78
		public string FormatAsString()
		{
			if (this.IsWholeColumnReference())
			{
				return global::NPOI.SS.Util.CellReference.ConvertNumToColString((int)this._firstCell.Col) + ":" + global::NPOI.SS.Util.CellReference.ConvertNumToColString((int)this._lastCell.Col);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
			stringBuilder.Append(this._firstCell.FormatAsString());
			if (!this._isSingleCell)
			{
				stringBuilder.Append(':');
				if (this._lastCell.SheetName == null)
				{
					stringBuilder.Append(this._lastCell.FormatAsString());
				}
				else
				{
					this._lastCell.AppendCellReference(stringBuilder);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004B18 File Offset: 0x00002D18
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004B68 File Offset: 0x00002D68
		private static string[] SeparateAreaRefs(string reference)
		{
			int length = reference.Length;
			int num = -1;
			bool flag = false;
			for (int i = 0; i < length; i++)
			{
				char c = reference[i];
				if (c != '\'')
				{
					if (c == ':' && !flag)
					{
						if (num >= 0)
						{
							throw new global::System.ArgumentException("More than one cell delimiter ':' appears in area reference '" + reference + "'");
						}
						num = i;
					}
				}
				else if (!flag)
				{
					flag = true;
				}
				else
				{
					if (i >= length - 1)
					{
						throw new global::System.ArgumentException("Area reference '" + reference + "' ends with special name delimiter '''");
					}
					if (reference[i + 1] == '\'')
					{
						i++;
					}
					else
					{
						flag = false;
					}
				}
			}
			if (num < 0)
			{
				return new string[]
				{
					reference
				};
			}
			string text = reference.Substring(0, num);
			string text2 = reference.Substring(num + 1);
			if (text2.IndexOf('!') >= 0)
			{
				throw new global::System.Exception("Unexpected ! in second cell reference of '" + reference + "'");
			}
			int num2 = text.LastIndexOf('!');
			if (num2 < 0)
			{
				return new string[]
				{
					text,
					text2
				};
			}
			string str = text.Substring(0, num2 + 1);
			return new string[]
			{
				text,
				str + text2
			};
		}

		// Token: 0x04000029 RID: 41
		private const char SHEET_NAME_DELIMITER = '!';

		// Token: 0x0400002A RID: 42
		private const char CELL_DELIMITER = ':';

		// Token: 0x0400002B RID: 43
		private const char SPECIAL_NAME_DELIMITER = '\'';

		// Token: 0x0400002C RID: 44
		private static global::NPOI.SS.SpreadsheetVersion DEFAULT_SPREADSHEET_VERSION = global::NPOI.SS.SpreadsheetVersion.EXCEL97;

		// Token: 0x0400002D RID: 45
		private global::NPOI.SS.Util.CellReference _firstCell;

		// Token: 0x0400002E RID: 46
		private global::NPOI.SS.Util.CellReference _lastCell;

		// Token: 0x0400002F RID: 47
		private bool _isSingleCell;

		// Token: 0x04000030 RID: 48
		private global::NPOI.SS.SpreadsheetVersion _version;
	}
}
