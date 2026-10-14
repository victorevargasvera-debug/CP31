using System;
using NPOI.SS.Util;

namespace NPOI.SS
{
	// Token: 0x0200000C RID: 12
	public class SpreadsheetVersion
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002AE0 File Offset: 0x00000CE0
		private SpreadsheetVersion(string defaultExtension, int maxRows, int maxColumns, int maxFunctionArgs, int maxCondFormats, int maxCellStyles, int maxText, string name)
		{
			this._defaultExtension = defaultExtension;
			this._maxRows = maxRows;
			this._maxColumns = maxColumns;
			this._maxFunctionArgs = maxFunctionArgs;
			this._maxCondFormats = maxCondFormats;
			this._maxCellStyles = maxCellStyles;
			this._maxTextLength = maxText;
			this._name = name;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002B30 File Offset: 0x00000D30
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002B38 File Offset: 0x00000D38
		public string DefaultExtension
		{
			get
			{
				return this._defaultExtension;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002B40 File Offset: 0x00000D40
		public int MaxRows
		{
			get
			{
				return this._maxRows;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002B48 File Offset: 0x00000D48
		public int LastRowIndex
		{
			get
			{
				return this._maxRows - 1;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002B52 File Offset: 0x00000D52
		public int MaxColumns
		{
			get
			{
				return this._maxColumns;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002B5A File Offset: 0x00000D5A
		public int LastColumnIndex
		{
			get
			{
				return this._maxColumns - 1;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002B64 File Offset: 0x00000D64
		public int MaxFunctionArgs
		{
			get
			{
				return this._maxFunctionArgs;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002B6C File Offset: 0x00000D6C
		public int MaxConditionalFormats
		{
			get
			{
				return this._maxCondFormats;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002B74 File Offset: 0x00000D74
		public string LastColumnName
		{
			get
			{
				return global::NPOI.SS.Util.CellReference.ConvertNumToColString(this.LastColumnIndex);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002B81 File Offset: 0x00000D81
		public int MaxCellStyles
		{
			get
			{
				return this._maxCellStyles;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002B89 File Offset: 0x00000D89
		public int MaxTextLength
		{
			get
			{
				return this._maxTextLength;
			}
		}

		// Token: 0x04000011 RID: 17
		public static global::NPOI.SS.SpreadsheetVersion EXCEL97 = new global::NPOI.SS.SpreadsheetVersion("xls", 65536, 256, 30, 3, 4000, 32767, "EXCEL97");

		// Token: 0x04000012 RID: 18
		public static global::NPOI.SS.SpreadsheetVersion EXCEL2007 = new global::NPOI.SS.SpreadsheetVersion("xlsx", 1048576, 16384, 255, int.MaxValue, 64000, 32767, "EXCEL2007");

		// Token: 0x04000013 RID: 19
		private string _defaultExtension;

		// Token: 0x04000014 RID: 20
		private int _maxRows;

		// Token: 0x04000015 RID: 21
		private int _maxColumns;

		// Token: 0x04000016 RID: 22
		private int _maxFunctionArgs;

		// Token: 0x04000017 RID: 23
		private int _maxCondFormats;

		// Token: 0x04000018 RID: 24
		private int _maxCellStyles;

		// Token: 0x04000019 RID: 25
		private int _maxTextLength;

		// Token: 0x0400001A RID: 26
		private string _name;
	}
}
