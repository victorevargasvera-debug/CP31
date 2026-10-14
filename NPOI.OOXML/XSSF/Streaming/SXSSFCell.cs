using System;
using NPOI.SS;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Streaming.Properties;
using NPOI.XSSF.Streaming.Values;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C5 RID: 197
	public class SXSSFCell : global::NPOI.SS.UserModel.ICell
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x0002D089 File Offset: 0x0002B289
		public SXSSFCell(global::NPOI.XSSF.Streaming.SXSSFRow row, global::NPOI.SS.UserModel.CellType cellType)
		{
			this._row = row;
			this.SetType(cellType);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.Util.CellRangeAddress ArrayFormulaRange
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		public bool BooleanCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType type = this._value.GetType();
				switch (type)
				{
				case global::NPOI.SS.UserModel.CellType.Formula:
					if (((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() != global::NPOI.SS.UserModel.CellType.Boolean)
					{
						throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Boolean, global::NPOI.SS.UserModel.CellType.Formula, false);
					}
					return ((global::NPOI.XSSF.Streaming.Values.BooleanFormulaValue)this._value).PreEvaluatedValue;
				case global::NPOI.SS.UserModel.CellType.Blank:
					return false;
				case global::NPOI.SS.UserModel.CellType.Boolean:
					return ((global::NPOI.XSSF.Streaming.Values.BooleanValue)this._value).Value;
				default:
					throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Boolean, type, false);
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0002D117 File Offset: 0x0002B317
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				return this.GetCachedFormulaResultTypeEnum();
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0002D11F File Offset: 0x0002B31F
		public global::NPOI.SS.UserModel.CellType GetCachedFormulaResultTypeEnum()
		{
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.Formula)
			{
				throw new global::System.InvalidOperationException("Only formula cells have cached results");
			}
			return ((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType();
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0002D14A File Offset: 0x0002B34A
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0002D158 File Offset: 0x0002B358
		public global::NPOI.SS.UserModel.IComment CellComment
		{
			get
			{
				return (global::NPOI.SS.UserModel.IComment)this.GetPropertyValue(1);
			}
			set
			{
				this.SetProperty(1, value);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0002D162 File Offset: 0x0002B362
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0002D195 File Offset: 0x0002B395
		public string CellFormula
		{
			get
			{
				if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.Formula)
				{
					throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Formula, this._value.GetType(), false);
				}
				return ((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).Value;
			}
			set
			{
				if (value == null)
				{
					this.SetType(global::NPOI.SS.UserModel.CellType.Blank);
					return;
				}
				this.EnsureFormulaType(this.ComputeTypeFromFormula(value));
				((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).Value = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0002D1EC File Offset: 0x0002B3EC
		public global::NPOI.SS.UserModel.ICellStyle CellStyle
		{
			get
			{
				if (this._style == null)
				{
					return ((global::NPOI.XSSF.Streaming.SXSSFWorkbook)this.Row.Sheet.Workbook).GetCellStyleAt(0);
				}
				return this._style;
			}
			set
			{
				this._style = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0002D1F5 File Offset: 0x0002B3F5
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._value.GetType();
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0002D202 File Offset: 0x0002B402
		public int ColumnIndex
		{
			get
			{
				return this._row.GetCellIndex(this);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0002D210 File Offset: 0x0002B410
		public global::System.DateTime DateCellValue
		{
			get
			{
				if (this._value.GetType() == global::NPOI.SS.UserModel.CellType.Blank)
				{
					return default(global::System.DateTime);
				}
				double numericCellValue = this.NumericCellValue;
				bool use1904windowing = this.Sheet.Workbook.IsDate1904();
				return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(numericCellValue, use1904windowing);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0002D254 File Offset: 0x0002B454
		public byte ErrorCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType type = this._value.GetType();
				switch (type)
				{
				case global::NPOI.SS.UserModel.CellType.Formula:
					if (((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() != global::NPOI.SS.UserModel.CellType.Error)
					{
						throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Error, global::NPOI.SS.UserModel.CellType.Formula, false);
					}
					return ((global::NPOI.XSSF.Streaming.Values.ErrorFormulaValue)this._value).PreEvaluatedValue;
				case global::NPOI.SS.UserModel.CellType.Blank:
					return 0;
				case global::NPOI.SS.UserModel.CellType.Error:
					return ((global::NPOI.XSSF.Streaming.Values.ErrorValue)this._value).Value;
				}
				throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Error, type, false);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0002D2CF File Offset: 0x0002B4CF
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
		public global::NPOI.SS.UserModel.IHyperlink Hyperlink
		{
			get
			{
				return (global::NPOI.SS.UserModel.IHyperlink)this.GetPropertyValue(2);
			}
			set
			{
				if (value == null)
				{
					this.RemoveHyperlink();
					return;
				}
				this.SetProperty(2, value);
				global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink = (global::NPOI.XSSF.UserModel.XSSFHyperlink)value;
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this.RowIndex, this.ColumnIndex);
				xssfhyperlink.GetCTHyperlink().@ref = cellReference.FormatAsString();
				((global::NPOI.XSSF.Streaming.SXSSFSheet)this.Sheet)._sh.AddHyperlink(xssfhyperlink);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool IsMergedCell
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00005008 File Offset: 0x00003208
		public bool IsPartOfArrayFormulaGroup
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0002D340 File Offset: 0x0002B540
		public double NumericCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType type = this._value.GetType();
				switch (type)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
					return ((global::NPOI.XSSF.Streaming.Values.NumericValue)this._value).Value;
				case global::NPOI.SS.UserModel.CellType.Formula:
					if (((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() != global::NPOI.SS.UserModel.CellType.Numeric)
					{
						throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Numeric, global::NPOI.SS.UserModel.CellType.Formula, false);
					}
					return ((global::NPOI.XSSF.Streaming.Values.NumericFormulaValue)this._value).PreEvaluatedValue;
				case global::NPOI.SS.UserModel.CellType.Blank:
					return 0.0;
				}
				throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.Numeric, type, false);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		public global::NPOI.SS.UserModel.IRichTextString RichStringCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType type = this._value.GetType();
				if (type != global::NPOI.SS.UserModel.CellType.String)
				{
					throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.String, type, false);
				}
				if (((global::NPOI.XSSF.Streaming.Values.StringValue)this._value).IsRichText())
				{
					return ((global::NPOI.XSSF.Streaming.Values.RichTextValue)this._value).Value;
				}
				string stringCellValue = this.StringCellValue;
				return this.Sheet.Workbook.GetCreationHelper().CreateRichTextString(stringCellValue);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0002D426 File Offset: 0x0002B626
		public global::NPOI.SS.UserModel.IRow Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002D42E File Offset: 0x0002B62E
		public int RowIndex
		{
			get
			{
				return this._row.RowNum;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00011C89 File Offset: 0x0000FE89
		public global::NPOI.SS.Util.CellAddress Address
		{
			get
			{
				return new global::NPOI.SS.Util.CellAddress(this);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0002D43B File Offset: 0x0002B63B
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this._row.Sheet;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0002D448 File Offset: 0x0002B648
		public string StringCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType type = this._value.GetType();
				switch (type)
				{
				case global::NPOI.SS.UserModel.CellType.String:
					if (((global::NPOI.XSSF.Streaming.Values.StringValue)this._value).IsRichText())
					{
						return ((global::NPOI.XSSF.Streaming.Values.RichTextValue)this._value).Value.String;
					}
					return ((global::NPOI.XSSF.Streaming.Values.PlainStringValue)this._value).Value;
				case global::NPOI.SS.UserModel.CellType.Formula:
					if (((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() != global::NPOI.SS.UserModel.CellType.String)
					{
						throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.String, global::NPOI.SS.UserModel.CellType.Formula, false);
					}
					return ((global::NPOI.XSSF.Streaming.Values.StringFormulaValue)this._value).PreEvaluatedValue;
				case global::NPOI.SS.UserModel.CellType.Blank:
					return "";
				default:
					throw global::NPOI.XSSF.Streaming.SXSSFCell.typeMismatch(global::NPOI.SS.UserModel.CellType.String, type, false);
				}
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.ICell CopyCellTo(int targetIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0002D4EB File Offset: 0x0002B6EB
		public void RemoveCellComment()
		{
			this.RemoveProperty(1);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		public void RemoveHyperlink()
		{
			this.RemoveProperty(2);
			((global::NPOI.XSSF.Streaming.SXSSFSheet)this.Sheet)._sh.RemoveHyperlink(this.RowIndex, this.ColumnIndex);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0002D51E File Offset: 0x0002B71E
		public void SetAsActiveCell()
		{
			this.Sheet.ActiveCell = this.Address;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0002D531 File Offset: 0x0002B731
		public void SetCellErrorValue(byte value)
		{
			this.EnsureType(global::NPOI.SS.UserModel.CellType.Error);
			if (this._value.GetType() == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.Streaming.Values.ErrorFormulaValue)this._value).PreEvaluatedValue = value;
				return;
			}
			((global::NPOI.XSSF.Streaming.Values.ErrorValue)this._value).Value = value;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0002D195 File Offset: 0x0002B395
		public void SetCellFormula(string formula)
		{
			if (formula == null)
			{
				this.SetType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			this.EnsureFormulaType(this.ComputeTypeFromFormula(formula));
			((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).Value = formula;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002D56B File Offset: 0x0002B76B
		public void SetCellType(global::NPOI.SS.UserModel.CellType cellType)
		{
			this.EnsureType(cellType);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002D574 File Offset: 0x0002B774
		public void SetCellValue(string value)
		{
			if (value == null)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			this.EnsureTypeOrFormulaType(global::NPOI.SS.UserModel.CellType.String);
			if (value.Length > global::NPOI.SS.SpreadsheetVersion.EXCEL2007.MaxTextLength)
			{
				throw new global::System.ArgumentException("The maximum length of cell contents (text) is 32,767 characters");
			}
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.Streaming.Values.PlainStringValue)this._value).Value = value;
				return;
			}
			if (this._value is global::NPOI.XSSF.Streaming.Values.NumericFormulaValue)
			{
				((global::NPOI.XSSF.Streaming.Values.NumericFormulaValue)this._value).PreEvaluatedValue = double.Parse(value);
				return;
			}
			((global::NPOI.XSSF.Streaming.Values.StringFormulaValue)this._value).PreEvaluatedValue = value;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0002D605 File Offset: 0x0002B805
		public void SetCellValue(bool value)
		{
			this.EnsureTypeOrFormulaType(global::NPOI.SS.UserModel.CellType.Boolean);
			if (this._value.GetType() == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.Streaming.Values.BooleanFormulaValue)this._value).PreEvaluatedValue = value;
				return;
			}
			((global::NPOI.XSSF.Streaming.Values.BooleanValue)this._value).Value = value;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002D640 File Offset: 0x0002B840
		public void SetCellValue(global::NPOI.SS.UserModel.IRichTextString value)
		{
			global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = (global::NPOI.XSSF.UserModel.XSSFRichTextString)value;
			if (xssfrichTextString == null || xssfrichTextString.String == null)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			this.EnsureRichTextStringType();
			if (xssfrichTextString.Length > global::NPOI.SS.SpreadsheetVersion.EXCEL2007.MaxTextLength)
			{
				throw new global::System.InvalidOperationException("The maximum length of cell contents (text) is 32,767 characters");
			}
			if (xssfrichTextString.HasFormatting())
			{
				global::NPOI.XSSF.Streaming.SXSSFCell.logger.Log(5, "SXSSF doesn't support Shared Strings, rich text formatting information has be lost");
			}
			((global::NPOI.XSSF.Streaming.Values.RichTextValue)this._value).Value = xssfrichTextString;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		public void SetCellValue(global::System.DateTime? value)
		{
			if (value == null)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			bool use1904windowing = ((global::NPOI.XSSF.Streaming.SXSSFWorkbook)this.Sheet.Workbook).XssfWorkbook.IsDate1904();
			this.SetCellValue(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(value.Value, use1904windowing));
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0002D700 File Offset: 0x0002B900
		public void SetCellValue(double value)
		{
			if (double.IsInfinity(value))
			{
				this.SetCellErrorValue(global::NPOI.SS.UserModel.FormulaError.DIV0.Code);
				return;
			}
			if (double.IsNaN(value))
			{
				this.SetCellErrorValue(global::NPOI.SS.UserModel.FormulaError.NUM.Code);
				return;
			}
			this.EnsureTypeOrFormulaType(global::NPOI.SS.UserModel.CellType.Numeric);
			if (this._value.GetType() == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.Streaming.Values.NumericFormulaValue)this._value).PreEvaluatedValue = value;
				return;
			}
			((global::NPOI.XSSF.Streaming.Values.NumericValue)this._value).Value = value;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0002D778 File Offset: 0x0002B978
		public override string ToString()
		{
			switch (this.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				if (global::NPOI.SS.UserModel.DateUtil.IsCellDateFormatted(this))
				{
					return new global::NPOI.SS.Util.SimpleDateFormat("dd-MMM-yyyy").Format(this.DateCellValue);
				}
				return this.NumericCellValue.ToString() ?? "";
			case global::NPOI.SS.UserModel.CellType.String:
				return this.RichStringCellValue.ToString();
			case global::NPOI.SS.UserModel.CellType.Formula:
				return this.CellFormula;
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!this.BooleanCellValue)
				{
					return "FALSE";
				}
				return "TRUE";
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)this.ErrorCellValue);
			default:
				return "Unknown Cell Type: " + this.CellType.ToString();
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0002D840 File Offset: 0x0002BA40
		private void RemoveProperty(int type)
		{
			global::NPOI.XSSF.Streaming.Properties.Property property = this._firstProperty;
			global::NPOI.XSSF.Streaming.Properties.Property property2 = null;
			while (property != null && property.GetType() != type)
			{
				property2 = property;
				property = property._next;
			}
			if (property != null)
			{
				if (property2 != null)
				{
					property2._next = property._next;
					return;
				}
				this._firstProperty = property._next;
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0002D88C File Offset: 0x0002BA8C
		private void SetProperty(int type, object value)
		{
			global::NPOI.XSSF.Streaming.Properties.Property property = this._firstProperty;
			global::NPOI.XSSF.Streaming.Properties.Property property2 = null;
			while (property != null && property.GetType() != type)
			{
				property2 = property;
				property = property._next;
			}
			if (property != null)
			{
				property._value = value;
				return;
			}
			if (type != 1)
			{
				if (type != 2)
				{
					throw new global::System.ArgumentException("Invalid type: " + type.ToString());
				}
				property = new global::NPOI.XSSF.Streaming.Properties.HyperlinkProperty(value);
			}
			else
			{
				property = new global::NPOI.XSSF.Streaming.Properties.CommentProperty(value);
			}
			if (property2 != null)
			{
				property2._next = property;
				return;
			}
			this._firstProperty = property;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0002D909 File Offset: 0x0002BB09
		private object GetPropertyValue(int type)
		{
			return this.GetPropertyValue(type, null);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0002D914 File Offset: 0x0002BB14
		private object GetPropertyValue(int type, string defaultValue)
		{
			global::NPOI.XSSF.Streaming.Properties.Property property = this._firstProperty;
			while (property != null && property.GetType() != type)
			{
				property = property._next;
			}
			if (property != null)
			{
				return property._value;
			}
			return defaultValue;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0002D948 File Offset: 0x0002BB48
		private void EnsurePlainStringType()
		{
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.String || ((global::NPOI.XSSF.Streaming.Values.StringValue)this._value).IsRichText())
			{
				this._value = new global::NPOI.XSSF.Streaming.Values.PlainStringValue();
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0002D975 File Offset: 0x0002BB75
		private void EnsureRichTextStringType()
		{
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.String || !((global::NPOI.XSSF.Streaming.Values.StringValue)this._value).IsRichText())
			{
				this._value = new global::NPOI.XSSF.Streaming.Values.RichTextValue();
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0002D9A2 File Offset: 0x0002BBA2
		private void EnsureType(global::NPOI.SS.UserModel.CellType type)
		{
			if (this._value.GetType() != type)
			{
				this.SetType(type);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0002D9B9 File Offset: 0x0002BBB9
		private void EnsureFormulaType(global::NPOI.SS.UserModel.CellType type)
		{
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.Formula || ((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() != type)
			{
				this.setFormulaType(type);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		private void EnsureTypeOrFormulaType(global::NPOI.SS.UserModel.CellType type)
		{
			if (this._value.GetType() == type)
			{
				if (type == global::NPOI.SS.UserModel.CellType.String && ((global::NPOI.XSSF.Streaming.Values.StringValue)this._value).IsRichText())
				{
					this.SetType(global::NPOI.SS.UserModel.CellType.String);
				}
				return;
			}
			if (this._value.GetType() != global::NPOI.SS.UserModel.CellType.Formula)
			{
				this.SetType(type);
				return;
			}
			if (((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).GetFormulaType() == type)
			{
				return;
			}
			this.setFormulaType(type);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002DA50 File Offset: 0x0002BC50
		private void SetType(global::NPOI.SS.UserModel.CellType type)
		{
			switch (type)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				this._value = new global::NPOI.XSSF.Streaming.Values.NumericValue();
				return;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				global::NPOI.XSSF.Streaming.Values.PlainStringValue plainStringValue = new global::NPOI.XSSF.Streaming.Values.PlainStringValue();
				if (this._value != null)
				{
					string value = this.ConvertCellValueToString();
					plainStringValue.Value = value;
				}
				this._value = plainStringValue;
				return;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
				this._value = new global::NPOI.XSSF.Streaming.Values.NumericFormulaValue();
				return;
			case global::NPOI.SS.UserModel.CellType.Blank:
				this._value = new global::NPOI.XSSF.Streaming.Values.BlankValue();
				return;
			case global::NPOI.SS.UserModel.CellType.Boolean:
			{
				global::NPOI.XSSF.Streaming.Values.BooleanValue booleanValue = new global::NPOI.XSSF.Streaming.Values.BooleanValue();
				if (this._value != null)
				{
					bool value2 = this.convertCellValueToBoolean();
					booleanValue.Value = value2;
				}
				this._value = booleanValue;
				return;
			}
			case global::NPOI.SS.UserModel.CellType.Error:
				this._value = new global::NPOI.XSSF.Streaming.Values.ErrorValue();
				return;
			default:
				throw new global::System.ArgumentException("Illegal type " + type.ToString());
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0002DB14 File Offset: 0x0002BD14
		private void setFormulaType(global::NPOI.SS.UserModel.CellType type)
		{
			global::NPOI.XSSF.Streaming.Values.Value value = this._value;
			switch (type)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				this._value = new global::NPOI.XSSF.Streaming.Values.NumericFormulaValue();
				goto IL_78;
			case global::NPOI.SS.UserModel.CellType.String:
				this._value = new global::NPOI.XSSF.Streaming.Values.StringFormulaValue();
				goto IL_78;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				this._value = new global::NPOI.XSSF.Streaming.Values.BooleanFormulaValue();
				goto IL_78;
			case global::NPOI.SS.UserModel.CellType.Error:
				this._value = new global::NPOI.XSSF.Streaming.Values.ErrorFormulaValue();
				goto IL_78;
			}
			throw new global::System.ArgumentException("Illegal type " + type.ToString());
			IL_78:
			if (value is global::NPOI.XSSF.Streaming.Values.FormulaValue)
			{
				((global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value).Value = ((global::NPOI.XSSF.Streaming.Values.FormulaValue)value).Value;
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00005008 File Offset: 0x00003208
		private global::NPOI.SS.UserModel.CellType ComputeTypeFromFormula(string formula)
		{
			return global::NPOI.SS.UserModel.CellType.Numeric;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0002DBBC File Offset: 0x0002BDBC
		private static global::System.InvalidOperationException typeMismatch(global::NPOI.SS.UserModel.CellType expectedTypeCode, global::NPOI.SS.UserModel.CellType actualTypeCode, bool isFormulaCell)
		{
			return new global::System.InvalidOperationException(string.Concat(new string[]
			{
				"Cannot get a ",
				expectedTypeCode.ToString(),
				" value from a ",
				actualTypeCode.ToString(),
				" ",
				isFormulaCell ? "formula " : "",
				"cell"
			}));
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		private bool convertCellValueToBoolean()
		{
			global::NPOI.SS.UserModel.CellType cellType = this._value.GetType();
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				cellType = this.GetCachedFormulaResultTypeEnum();
			}
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return this.NumericCellValue != 0.0;
			case global::NPOI.SS.UserModel.CellType.String:
				return bool.Parse(this.StringCellValue);
			case global::NPOI.SS.UserModel.CellType.Blank:
			case global::NPOI.SS.UserModel.CellType.Error:
				return false;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return this.BooleanCellValue;
			}
			throw new global::NPOI.Util.RuntimeException("Unexpected cell type (" + cellType.ToString() + ")");
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		private string ConvertCellValueToString()
		{
			global::NPOI.SS.UserModel.CellType type = this._value.GetType();
			return this.ConvertCellValueToString(type);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0002DCDC File Offset: 0x0002BEDC
		private string ConvertCellValueToString(global::NPOI.SS.UserModel.CellType cellType)
		{
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return this.NumericCellValue.ToString();
			case global::NPOI.SS.UserModel.CellType.String:
				return this.StringCellValue;
			case global::NPOI.SS.UserModel.CellType.Formula:
				if (this._value != null)
				{
					global::NPOI.XSSF.Streaming.Values.FormulaValue formulaValue = (global::NPOI.XSSF.Streaming.Values.FormulaValue)this._value;
					if (formulaValue.GetFormulaType() != global::NPOI.SS.UserModel.CellType.Formula)
					{
						return this.ConvertCellValueToString(formulaValue.GetFormulaType());
					}
				}
				return "";
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!this.BooleanCellValue)
				{
					return "FALSE";
				}
				return "TRUE";
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.UserModel.FormulaError.ForInt(this.ErrorCellValue).String;
			default:
				throw new global::System.InvalidOperationException("Unexpected cell type (" + cellType.ToString() + ")");
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0002DD9B File Offset: 0x0002BF9B
		public void SetCellValue(global::System.DateTime value)
		{
			this.SetCellValue(new global::System.DateTime?(value));
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002DDA9 File Offset: 0x0002BFA9
		public void SetBlank()
		{
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x040003DD RID: 989
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.Streaming.SXSSFCell));

		// Token: 0x040003DE RID: 990
		private global::NPOI.XSSF.Streaming.SXSSFRow _row;

		// Token: 0x040003DF RID: 991
		private global::NPOI.XSSF.Streaming.Values.Value _value;

		// Token: 0x040003E0 RID: 992
		private global::NPOI.SS.UserModel.ICellStyle _style;

		// Token: 0x040003E1 RID: 993
		private global::NPOI.XSSF.Streaming.Properties.Property _firstProperty;
	}
}
