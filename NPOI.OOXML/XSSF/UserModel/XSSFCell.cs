using System;
using System.Globalization;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000069 RID: 105
	public class XSSFCell : global::NPOI.SS.UserModel.ICell
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x000113F4 File Offset: 0x0000F5F4
		public XSSFCell(global::NPOI.XSSF.UserModel.XSSFRow row, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell cell)
		{
			this._cell = cell;
			this._row = row;
			if (cell.r != null)
			{
				this._cellNum = (int)new global::NPOI.SS.Util.CellReference(cell.r).Col;
			}
			else
			{
				int lastCellNum = (int)row.LastCellNum;
				if (lastCellNum != -1)
				{
					this._cellNum = row.GetCell(lastCellNum - 1, global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK).ColumnIndex + 1;
				}
			}
			this._sharedStringSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)row.Sheet.Workbook).GetSharedStringSource();
			this._stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)row.Sheet.Workbook).GetStylesSource();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00011490 File Offset: 0x0000F690
		public void CopyCellFrom(global::NPOI.SS.UserModel.ICell srcCell, global::NPOI.SS.UserModel.CellCopyPolicy policy)
		{
			if (policy.IsCopyCellValue)
			{
				if (srcCell != null)
				{
					global::NPOI.SS.UserModel.CellType cellType = srcCell.CellType;
					if (cellType == global::NPOI.SS.UserModel.CellType.Formula && !policy.IsCopyCellFormula)
					{
						cellType = srcCell.CachedFormulaResultType;
					}
					switch (cellType)
					{
					case global::NPOI.SS.UserModel.CellType.Numeric:
						if (global::NPOI.SS.UserModel.DateUtil.IsCellDateFormatted(srcCell))
						{
							this.SetCellValue(srcCell.DateCellValue);
						}
						else
						{
							this.SetCellValue(srcCell.NumericCellValue);
						}
						break;
					case global::NPOI.SS.UserModel.CellType.String:
						this.SetCellValue(srcCell.StringCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Formula:
						this.SetCellFormula(srcCell.CellFormula);
						break;
					case global::NPOI.SS.UserModel.CellType.Blank:
						this.SetBlankInternal();
						break;
					case global::NPOI.SS.UserModel.CellType.Boolean:
						this.SetCellValue(srcCell.BooleanCellValue);
						break;
					case global::NPOI.SS.UserModel.CellType.Error:
						this.SetCellErrorValue(srcCell.ErrorCellValue);
						break;
					default:
						throw new global::System.ArgumentException("Invalid cell type " + srcCell.CellType.ToString());
					}
				}
				else
				{
					this.SetBlankInternal();
				}
			}
			if (policy.IsCopyCellStyle)
			{
				if (srcCell != null)
				{
					this.CellStyle = srcCell.CellStyle;
				}
				else
				{
					this.CellStyle = null;
				}
			}
			if (policy.IsMergeHyperlink)
			{
				global::NPOI.SS.UserModel.IHyperlink hyperlink = srcCell.Hyperlink;
				if (hyperlink != null)
				{
					this.Hyperlink = new global::NPOI.XSSF.UserModel.XSSFHyperlink(hyperlink);
					return;
				}
			}
			else if (policy.IsCopyHyperlink)
			{
				global::NPOI.SS.UserModel.IHyperlink hyperlink2 = srcCell.Hyperlink;
				if (hyperlink2 == null)
				{
					this.Hyperlink = null;
					return;
				}
				this.Hyperlink = new global::NPOI.XSSF.UserModel.XSSFHyperlink(hyperlink2);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000115DE File Offset: 0x0000F7DE
		protected global::NPOI.XSSF.Model.SharedStringsTable GetSharedStringSource()
		{
			return this._sharedStringSource;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000115E6 File Offset: 0x0000F7E6
		protected global::NPOI.XSSF.Model.StylesTable GetStylesSource()
		{
			return this._stylesSource;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000115EE File Offset: 0x0000F7EE
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this._row.Sheet;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000115FB File Offset: 0x0000F7FB
		public global::NPOI.SS.UserModel.IRow Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00011604 File Offset: 0x0000F804
		public bool BooleanCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType cellType = this.CellType;
				switch (cellType)
				{
				case global::NPOI.SS.UserModel.CellType.Formula:
					return this._cell.IsSetV() && global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING.Equals(this._cell.v);
				case global::NPOI.SS.UserModel.CellType.Blank:
					return false;
				case global::NPOI.SS.UserModel.CellType.Boolean:
					return this._cell.IsSetV() && global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING.Equals(this._cell.v);
				default:
					throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.Boolean, cellType, false);
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00011682 File Offset: 0x0000F882
		public void SetCellValue(bool value)
		{
			this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.b;
			this._cell.v = (value ? global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING : global::NPOI.XSSF.UserModel.XSSFCell.FALSE_AS_STRING);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000116AC File Offset: 0x0000F8AC
		public double NumericCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType cellType = this.CellType;
				switch (cellType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
				case global::NPOI.SS.UserModel.CellType.Formula:
					if (this._cell.IsSetV())
					{
						if (string.IsNullOrEmpty(this._cell.v))
						{
							return 0.0;
						}
						try
						{
							return double.Parse(this._cell.v, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						catch (global::System.FormatException)
						{
							throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.Numeric, global::NPOI.SS.UserModel.CellType.String, false);
						}
					}
					return 0.0;
				case global::NPOI.SS.UserModel.CellType.Blank:
					return 0.0;
				}
				throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.Numeric, cellType, false);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00011754 File Offset: 0x0000F954
		public void SetCellValue(double value)
		{
			if (double.IsInfinity(value))
			{
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.e;
				this._cell.v = global::NPOI.SS.UserModel.FormulaError.DIV0.String;
				return;
			}
			if (double.IsNaN(value))
			{
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.e;
				this._cell.v = global::NPOI.SS.UserModel.FormulaError.NUM.String;
				return;
			}
			this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n;
			this._cell.v = value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000117D8 File Offset: 0x0000F9D8
		public string StringCellValue
		{
			get
			{
				return this.RichStringCellValue.String;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000117E8 File Offset: 0x0000F9E8
		public global::NPOI.SS.UserModel.IRichTextString RichStringCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType cellType = this.CellType;
				global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString;
				switch (cellType)
				{
				case global::NPOI.SS.UserModel.CellType.String:
					if (this._cell.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.inlineStr)
					{
						if (this._cell.IsSetIs())
						{
							xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._cell.@is);
						}
						else if (this._cell.IsSetV())
						{
							xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._cell.v);
						}
						else
						{
							xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString("");
						}
					}
					else if (this._cell.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.str)
					{
						xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._cell.IsSetV() ? this._cell.v : "");
					}
					else if (this._cell.IsSetV())
					{
						int idx = int.Parse(this._cell.v);
						xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._sharedStringSource.GetEntryAt(idx));
					}
					else
					{
						xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString("");
					}
					break;
				case global::NPOI.SS.UserModel.CellType.Formula:
					global::NPOI.XSSF.UserModel.XSSFCell.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.String, this.GetBaseCellType(false));
					xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._cell.IsSetV() ? this._cell.v : "");
					break;
				case global::NPOI.SS.UserModel.CellType.Blank:
					xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString("");
					break;
				default:
					throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.String, cellType, false);
				}
				xssfrichTextString.SetStylesTableReference(this._stylesSource);
				return xssfrichTextString;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00011947 File Offset: 0x0000FB47
		private static void CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType expectedTypeCode, global::NPOI.SS.UserModel.CellType cachedValueType)
		{
			if (cachedValueType != expectedTypeCode)
			{
				throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(expectedTypeCode, cachedValueType, true);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00011956 File Offset: 0x0000FB56
		public void SetCellValue(string str)
		{
			this.SetCellValue((str == null) ? null : new global::NPOI.XSSF.UserModel.XSSFRichTextString(str));
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001196C File Offset: 0x0000FB6C
		public void SetCellValue(global::NPOI.SS.UserModel.IRichTextString str)
		{
			if (str == null || str.String == null)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			if (str.Length > global::NPOI.SS.SpreadsheetVersion.EXCEL2007.MaxTextLength)
			{
				throw new global::System.ArgumentException("The maximum length of cell contents (text) is 32,767 characters");
			}
			if (this.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				this._cell.v = str.String;
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.str;
				return;
			}
			if (this._cell.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.inlineStr)
			{
				this._cell.v = str.String;
				return;
			}
			this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.s;
			global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = (global::NPOI.XSSF.UserModel.XSSFRichTextString)str;
			xssfrichTextString.SetStylesTableReference(this._stylesSource);
			int num = this._sharedStringSource.AddEntry(xssfrichTextString.GetCTRst());
			this._cell.v = num.ToString();
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00011A33 File Offset: 0x0000FC33
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00011A3C File Offset: 0x0000FC3C
		public string CellFormula
		{
			get
			{
				return this.GetCellFormula(null);
			}
			set
			{
				this.SetCellFormula(value);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00011A48 File Offset: 0x0000FC48
		protected internal string GetCellFormula(global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook fpb)
		{
			global::NPOI.SS.UserModel.CellType cellType = this.CellType;
			if (cellType != global::NPOI.SS.UserModel.CellType.Formula)
			{
				throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.Formula, cellType, false);
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f = this._cell.f;
			if (this.IsPartOfArrayFormulaGroup && f == null)
			{
				return ((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).GetFirstCellInArrayFormula(this).GetCellFormula(fpb);
			}
			if (f.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.shared)
			{
				return this.ConvertSharedFormula((int)f.si, (fpb == null) ? global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(this.Sheet.Workbook) : fpb);
			}
			return f.Value;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00011ACC File Offset: 0x0000FCCC
		private string ConvertSharedFormula(int si, global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook fpb)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula sharedFormula = xssfsheet.GetSharedFormula(si);
			if (sharedFormula == null)
			{
				throw new global::System.InvalidOperationException("Master cell of a shared formula with sid=" + si.ToString() + " was not found");
			}
			string value = sharedFormula.Value;
			global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(sharedFormula.@ref);
			int sheetIndex = xssfsheet.Workbook.GetSheetIndex(xssfsheet);
			global::NPOI.SS.Formula.PTG.SharedFormula sharedFormula2 = new global::NPOI.SS.Formula.PTG.SharedFormula(global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			global::NPOI.SS.Formula.PTG.Ptg[] ptgs = global::NPOI.SS.Formula.FormulaParser.Parse(value, fpb, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex, this.RowIndex);
			global::NPOI.SS.Formula.PTG.Ptg[] ptgs2 = sharedFormula2.ConvertSharedFormulas(ptgs, this.RowIndex - cellRangeAddress.FirstRow, this.ColumnIndex - cellRangeAddress.FirstColumn);
			return global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(fpb, ptgs2);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00011B70 File Offset: 0x0000FD70
		public void SetCellFormula(string formula)
		{
			if (this.IsPartOfArrayFormulaGroup)
			{
				this.NotifyArrayFormulaChanging();
			}
			this.SetFormula(formula, global::NPOI.SS.Formula.FormulaType.Cell);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00011B88 File Offset: 0x0000FD88
		internal void SetCellArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range)
		{
			this.SetFormula(formula, global::NPOI.SS.Formula.FormulaType.Array);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f = this._cell.f;
			f.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.array;
			f.@ref = range.FormatAsString();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		private void SetFormula(string formula, global::NPOI.SS.Formula.FormulaType formulaType)
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = this._row.Sheet.Workbook;
			if (formula == null)
			{
				((global::NPOI.XSSF.UserModel.XSSFWorkbook)workbook).OnDeleteFormula(this);
				if (this._cell.IsSetF())
				{
					this._cell.unsetF();
				}
				return;
			}
			global::NPOI.SS.Formula.IFormulaParsingWorkbook workbook2 = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(workbook);
			global::NPOI.SS.Formula.FormulaParser.Parse(formula, workbook2, formulaType, workbook.GetSheetIndex(this.Sheet), this.RowIndex);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula ct_CellFormula = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula();
			ct_CellFormula.Value = formula;
			this._cell.f = ct_CellFormula;
			if (this._cell.IsSetV())
			{
				this._cell.unsetV();
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00011C49 File Offset: 0x0000FE49
		public int ColumnIndex
		{
			get
			{
				return this._cellNum;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00011C51 File Offset: 0x0000FE51
		public int RowIndex
		{
			get
			{
				return this._row.RowNum;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00011C60 File Offset: 0x0000FE60
		public string GetReference()
		{
			string r = this._cell.r;
			if (r == null)
			{
				return new global::NPOI.SS.Util.CellAddress(this).FormatAsString();
			}
			return r;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00011C89 File Offset: 0x0000FE89
		public global::NPOI.SS.Util.CellAddress Address
		{
			get
			{
				return new global::NPOI.SS.Util.CellAddress(this);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00011C94 File Offset: 0x0000FE94
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		public global::NPOI.SS.UserModel.ICellStyle CellStyle
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFCellStyle result = null;
				if (this._stylesSource != null && this._stylesSource.NumCellStyles > 0)
				{
					long num = (long)((ulong)(this._cell.IsSetS() ? this._cell.s : 0U));
					result = this._stylesSource.GetStyleAt((int)num);
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					if (this._cell.IsSetS())
					{
						this._cell.unsetS();
						return;
					}
				}
				else
				{
					global::NPOI.XSSF.UserModel.XSSFCellStyle xssfcellStyle = (global::NPOI.XSSF.UserModel.XSSFCellStyle)value;
					xssfcellStyle.VerifyBelongsToStylesSource(this._stylesSource);
					long num = (long)this._stylesSource.PutStyle(xssfcellStyle);
					this._cell.s = (uint)num;
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00011D3F File Offset: 0x0000FF3F
		private bool IsFormulaCell
		{
			get
			{
				return this._cell.f != null || ((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).IsCellInArrayFormulaContext(this);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00011D64 File Offset: 0x0000FF64
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				if (this.IsFormulaCell)
				{
					return global::NPOI.SS.UserModel.CellType.Formula;
				}
				return this.GetBaseCellType(true);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00011D77 File Offset: 0x0000FF77
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				if (!this.IsFormulaCell)
				{
					throw new global::System.InvalidOperationException("Only formula cells have cached results");
				}
				return this.GetBaseCellType(false);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00011D94 File Offset: 0x0000FF94
		private global::NPOI.SS.UserModel.CellType GetBaseCellType(bool blankCells)
		{
			switch (this._cell.t)
			{
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.b:
				return global::NPOI.SS.UserModel.CellType.Boolean;
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n:
				if (!this._cell.IsSetV() && blankCells)
				{
					return global::NPOI.SS.UserModel.CellType.Blank;
				}
				return global::NPOI.SS.UserModel.CellType.Numeric;
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.e:
				return global::NPOI.SS.UserModel.CellType.Error;
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.s:
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.str:
			case global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.inlineStr:
				return global::NPOI.SS.UserModel.CellType.String;
			default:
				throw new global::System.InvalidOperationException("Illegal cell type: " + this._cell.t.ToString());
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00011E14 File Offset: 0x00010014
		public global::System.DateTime DateCellValue
		{
			get
			{
				if (this.CellType == global::NPOI.SS.UserModel.CellType.Blank)
				{
					return global::System.DateTime.MinValue;
				}
				double numericCellValue = this.NumericCellValue;
				bool use1904windowing = this.Sheet.Workbook.IsDate1904();
				return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(numericCellValue, use1904windowing);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00011E4D File Offset: 0x0001004D
		public void SetCellValue(global::System.DateTime? value)
		{
			if (value == null)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			}
			this.SetCellValue(value.Value);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00011E70 File Offset: 0x00010070
		public void SetCellValue(global::System.DateTime value)
		{
			bool use1904windowing = this.Sheet.Workbook.IsDate1904();
			this.SetCellValue(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(value, use1904windowing));
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00011E9C File Offset: 0x0001009C
		public string ErrorCellString
		{
			get
			{
				global::NPOI.SS.UserModel.CellType baseCellType = this.GetBaseCellType(true);
				if (baseCellType != global::NPOI.SS.UserModel.CellType.Error)
				{
					throw global::NPOI.XSSF.UserModel.XSSFCell.TypeMismatch(global::NPOI.SS.UserModel.CellType.Error, baseCellType, false);
				}
				return this._cell.v;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00011ECC File Offset: 0x000100CC
		public byte ErrorCellValue
		{
			get
			{
				string errorCellString = this.ErrorCellString;
				if (errorCellString == null)
				{
					return 0;
				}
				return global::NPOI.SS.UserModel.FormulaError.ForString(errorCellString).Code;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00011EF0 File Offset: 0x000100F0
		public void SetCellErrorValue(byte errorCode)
		{
			global::NPOI.SS.UserModel.FormulaError cellErrorValue = global::NPOI.SS.UserModel.FormulaError.ForInt(errorCode);
			this.SetCellErrorValue(cellErrorValue);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00011F0B File Offset: 0x0001010B
		public void SetCellErrorValue(global::NPOI.SS.UserModel.FormulaError error)
		{
			this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.e;
			this._cell.v = error.String;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00011F2A File Offset: 0x0001012A
		public void SetAsActiveCell()
		{
			this.Sheet.ActiveCell = this.Address;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00011F40 File Offset: 0x00010140
		private void SetBlankInternal()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ct_Cell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell();
			ct_Cell.r = this._cell.r;
			if (this._cell.IsSetS())
			{
				ct_Cell.s = this._cell.s;
			}
			this._cell.Set(ct_Cell);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00011F8E File Offset: 0x0001018E
		public void SetBlank()
		{
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00011F98 File Offset: 0x00010198
		internal void SetCellNum(int num)
		{
			global::NPOI.XSSF.UserModel.XSSFCell.CheckBounds(num);
			this._cellNum = num;
			string r = new global::NPOI.SS.Util.CellReference(this.RowIndex, this.ColumnIndex).FormatAsString();
			this._cell.r = r;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00011FD8 File Offset: 0x000101D8
		public void SetCellType(global::NPOI.SS.UserModel.CellType cellType)
		{
			global::NPOI.SS.UserModel.CellType cellType2 = this.CellType;
			if (this.IsPartOfArrayFormulaGroup)
			{
				this.NotifyArrayFormulaChanging();
			}
			if (cellType2 == global::NPOI.SS.UserModel.CellType.Formula && cellType != global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.UserModel.XSSFWorkbook)this.Sheet.Workbook).OnDeleteFormula(this);
			}
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n;
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				if (cellType2 != global::NPOI.SS.UserModel.CellType.String)
				{
					global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this.ConvertCellValueToString());
					xssfrichTextString.SetStylesTableReference(this._stylesSource);
					int num = this._sharedStringSource.AddEntry(xssfrichTextString.GetCTRst());
					this._cell.v = num.ToString();
				}
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.s;
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				if (!this._cell.IsSetF())
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula ct_CellFormula = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula();
					ct_CellFormula.Value = "0";
					this._cell.f = ct_CellFormula;
					if (this._cell.IsSetT())
					{
						this._cell.unsetT();
					}
				}
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				this.SetBlankInternal();
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
			{
				string v = this.ConvertCellValueToBoolean() ? global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING : global::NPOI.XSSF.UserModel.XSSFCell.FALSE_AS_STRING;
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.b;
				this._cell.v = v;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Error:
				this._cell.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.e;
				break;
			default:
				throw new global::System.ArgumentException("Illegal cell type: " + cellType.ToString());
			}
			if (cellType != global::NPOI.SS.UserModel.CellType.Formula && this._cell.IsSetF())
			{
				this._cell.unsetF();
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00012168 File Offset: 0x00010368
		public override string ToString()
		{
			switch (this.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				if (global::NPOI.SS.UserModel.DateUtil.IsCellDateFormatted(this))
				{
					return new global::NPOI.SS.Util.SimpleDateFormat("dd-MMM-yyyy").Format(this.DateCellValue, global::System.Globalization.CultureInfo.CurrentCulture);
				}
				return this.NumericCellValue.ToString();
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

		// Token: 0x06000496 RID: 1174 RVA: 0x0001222A File Offset: 0x0001042A
		public string GetRawValue()
		{
			return this._cell.v;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00012238 File Offset: 0x00010438
		private static string GetCellTypeName(global::NPOI.SS.UserModel.CellType cellTypeCode)
		{
			switch (cellTypeCode)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return "numeric";
			case global::NPOI.SS.UserModel.CellType.String:
				return "text";
			case global::NPOI.SS.UserModel.CellType.Formula:
				return "formula";
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "blank";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return "bool";
			case global::NPOI.SS.UserModel.CellType.Error:
				return "error";
			default:
				return "#unknown cell type (" + cellTypeCode.ToString() + ")#";
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000122A8 File Offset: 0x000104A8
		private static global::System.Exception TypeMismatch(global::NPOI.SS.UserModel.CellType expectedTypeCode, global::NPOI.SS.UserModel.CellType actualTypeCode, bool isFormulaCell)
		{
			return new global::System.InvalidOperationException(string.Concat(new string[]
			{
				"Cannot get a ",
				global::NPOI.XSSF.UserModel.XSSFCell.GetCellTypeName(expectedTypeCode),
				" value from a ",
				global::NPOI.XSSF.UserModel.XSSFCell.GetCellTypeName(actualTypeCode),
				" ",
				isFormulaCell ? "formula " : "",
				"cell"
			}));
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001230C File Offset: 0x0001050C
		private static void CheckBounds(int cellIndex)
		{
			global::NPOI.SS.SpreadsheetVersion excel = global::NPOI.SS.SpreadsheetVersion.EXCEL2007;
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastColumnIndex;
			if (cellIndex < 0 || cellIndex > lastColumnIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid column index (",
					cellIndex.ToString(),
					").  Allowable column range for ",
					excel.ToString(),
					" is (0..",
					lastColumnIndex.ToString(),
					") or ('A'..'",
					excel.LastColumnName,
					"')"
				}));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00012392 File Offset: 0x00010592
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x000123A5 File Offset: 0x000105A5
		public global::NPOI.SS.UserModel.IComment CellComment
		{
			get
			{
				return this.Sheet.GetCellComment(new global::NPOI.SS.Util.CellAddress(this));
			}
			set
			{
				if (value == null)
				{
					this.RemoveCellComment();
					return;
				}
				value.SetAddress(this.RowIndex, this.ColumnIndex);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000123C4 File Offset: 0x000105C4
		public void RemoveCellComment()
		{
			if (this.CellComment != null)
			{
				global::NPOI.SS.Util.CellAddress cellRef = new global::NPOI.SS.Util.CellAddress(this.GetReference());
				global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet;
				xssfsheet.GetCommentsTable(false).RemoveComment(cellRef);
				xssfsheet.GetVMLDrawing(false).RemoveCommentShape(this.RowIndex, this.ColumnIndex);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00012416 File Offset: 0x00010616
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0001243C File Offset: 0x0001063C
		public global::NPOI.SS.UserModel.IHyperlink Hyperlink
		{
			get
			{
				return ((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).GetHyperlink(this._row.RowNum, this._cellNum);
			}
			set
			{
				if (value == null)
				{
					this.RemoveHyperlink();
					return;
				}
				global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink = (global::NPOI.XSSF.UserModel.XSSFHyperlink)value;
				xssfhyperlink.SetCellReference(new global::NPOI.SS.Util.CellReference(this._row.RowNum, this._cellNum).FormatAsString());
				((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).AddHyperlink(xssfhyperlink);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001248C File Offset: 0x0001068C
		public void RemoveHyperlink()
		{
			((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).RemoveHyperlink(this._row.RowNum, this._cellNum);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000124AF File Offset: 0x000106AF
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell GetCTCell()
		{
			return this._cell;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000124B8 File Offset: 0x000106B8
		private bool ConvertCellValueToBoolean()
		{
			global::NPOI.SS.UserModel.CellType cellType = this.CellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				cellType = this.GetBaseCellType(false);
			}
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return double.Parse(this._cell.v, global::System.Globalization.CultureInfo.InvariantCulture) != 0.0;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				int idx = int.Parse(this._cell.v);
				return bool.Parse(new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._sharedStringSource.GetEntryAt(idx)).String);
			}
			case global::NPOI.SS.UserModel.CellType.Blank:
			case global::NPOI.SS.UserModel.CellType.Error:
				return false;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING.Equals(this._cell.v);
			}
			throw new global::NPOI.Util.RuntimeException("Unexpected cell type (" + cellType.ToString() + ")");
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00012584 File Offset: 0x00010784
		private string ConvertCellValueToString()
		{
			global::NPOI.SS.UserModel.CellType cellType = this.CellType;
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
			case global::NPOI.SS.UserModel.CellType.Error:
				return this._cell.v;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				int idx = int.Parse(this._cell.v);
				return new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._sharedStringSource.GetEntryAt(idx)).String;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
			{
				cellType = this.GetBaseCellType(false);
				string v = this._cell.v;
				switch (cellType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
				case global::NPOI.SS.UserModel.CellType.String:
				case global::NPOI.SS.UserModel.CellType.Error:
					return v;
				case global::NPOI.SS.UserModel.CellType.Boolean:
					if (global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING.Equals(v))
					{
						return "TRUE";
					}
					if (global::NPOI.XSSF.UserModel.XSSFCell.FALSE_AS_STRING.Equals(v))
					{
						return "FALSE";
					}
					throw new global::System.InvalidOperationException("Unexpected bool cached formula value '" + v + "'.");
				}
				throw new global::System.InvalidOperationException("Unexpected formula result type (" + cellType.ToString() + ")");
			}
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!global::NPOI.XSSF.UserModel.XSSFCell.TRUE_AS_STRING.Equals(this._cell.v))
				{
					return "FALSE";
				}
				return "TRUE";
			default:
				throw new global::System.InvalidOperationException("Unexpected cell type (" + cellType.ToString() + ")");
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000126CC File Offset: 0x000108CC
		public global::NPOI.SS.Util.CellRangeAddress ArrayFormulaRange
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFCell firstCellInArrayFormula = ((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).GetFirstCellInArrayFormula(this);
				if (firstCellInArrayFormula == null)
				{
					throw new global::System.InvalidOperationException("Cell " + this.GetReference() + " is not part of an array formula.");
				}
				return global::NPOI.SS.Util.CellRangeAddress.ValueOf(firstCellInArrayFormula._cell.f.@ref);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001271C File Offset: 0x0001091C
		public bool IsPartOfArrayFormulaGroup
		{
			get
			{
				return ((global::NPOI.XSSF.UserModel.XSSFSheet)this.Sheet).IsCellInArrayFormulaContext(this);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001272F File Offset: 0x0001092F
		internal void NotifyArrayFormulaChanging(string msg)
		{
			if (this.IsPartOfArrayFormulaGroup)
			{
				if (this.ArrayFormulaRange.NumberOfCells > 1)
				{
					throw new global::System.InvalidOperationException(msg);
				}
				this.Row.Sheet.RemoveArrayFormula(this);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00012760 File Offset: 0x00010960
		internal void NotifyArrayFormulaChanging()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this);
			string msg = "Cell " + cellReference.FormatAsString() + " is part of a multi-cell array formula. You cannot change part of an array.";
			this.NotifyArrayFormulaChanging(msg);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00012791 File Offset: 0x00010991
		public bool IsMergedCell
		{
			get
			{
				return this.Sheet.IsMergedRegion(new global::NPOI.SS.Util.CellRangeAddress(this.RowIndex, this.RowIndex, this.ColumnIndex, this.ColumnIndex));
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000127BB File Offset: 0x000109BB
		public global::NPOI.SS.UserModel.ICell CopyCellTo(int targetIndex)
		{
			return global::NPOI.SS.Util.CellUtil.CopyCell(this.Row, this.ColumnIndex, targetIndex);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.CellType GetCachedFormulaResultTypeEnum()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000296 RID: 662
		private static string FALSE_AS_STRING = "0";

		// Token: 0x04000297 RID: 663
		private static string TRUE_AS_STRING = "1";

		// Token: 0x04000298 RID: 664
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell _cell;

		// Token: 0x04000299 RID: 665
		private global::NPOI.XSSF.UserModel.XSSFRow _row;

		// Token: 0x0400029A RID: 666
		private int _cellNum;

		// Token: 0x0400029B RID: 667
		private global::NPOI.XSSF.Model.SharedStringsTable _sharedStringSource;

		// Token: 0x0400029C RID: 668
		private global::NPOI.XSSF.Model.StylesTable _stylesSource;
	}
}
