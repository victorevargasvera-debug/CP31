using System;
using System.Globalization;
using System.IO;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036A RID: 874
	[global::System.Serializable]
	public class HSSFCell : global::NPOI.SS.UserModel.ICell
	{
		// Token: 0x06001AAC RID: 6828 RVA: 0x00051A47 File Offset: 0x0004FC47
		public HSSFCell(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int row, short col) : this(book, sheet, row, col, global::NPOI.SS.UserModel.CellType.Blank)
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00051A58 File Offset: 0x0004FC58
		public HSSFCell(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int row, short col, global::NPOI.SS.UserModel.CellType type)
		{
			this.CheckBounds((int)col);
			this.cellType = global::NPOI.SS.UserModel.CellType.Unknown;
			this.stringValue = null;
			this.book = book;
			this._sheet = sheet;
			short xfindexForColAt = sheet.Sheet.GetXFIndexForColAt(col);
			this.SetCellType(type, false, row, (int)col, xfindexForColAt);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00051AAC File Offset: 0x0004FCAC
		public HSSFCell(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.CellValueRecordInterface cval)
		{
			this._record = cval;
			this.cellType = this.DetermineType(cval);
			this.stringValue = null;
			this.book = book;
			this._sheet = sheet;
			switch (this.cellType)
			{
			case global::NPOI.SS.UserModel.CellType.String:
				this.stringValue = new global::NPOI.HSSF.UserModel.HSSFRichTextString(book.Workbook, (global::NPOI.HSSF.Record.LabelSSTRecord)cval);
				return;
			case global::NPOI.SS.UserModel.CellType.Formula:
				this.stringValue = new global::NPOI.HSSF.UserModel.HSSFRichTextString(((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)cval).StringValue);
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				break;
			default:
				return;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000253E File Offset: 0x0000073E
		private HSSFCell()
		{
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00051B34 File Offset: 0x0004FD34
		private global::NPOI.SS.UserModel.CellType DetermineType(global::NPOI.HSSF.Record.CellValueRecordInterface cval)
		{
			if (cval is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)
			{
				return global::NPOI.SS.UserModel.CellType.Formula;
			}
			global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)cval;
			int sid = (int)record.Sid;
			if (sid == -2000)
			{
				return global::NPOI.SS.UserModel.CellType.Formula;
			}
			if (sid != 253)
			{
				switch (sid)
				{
				case 513:
					return global::NPOI.SS.UserModel.CellType.Blank;
				case 515:
					return global::NPOI.SS.UserModel.CellType.Numeric;
				case 517:
					if (!((global::NPOI.HSSF.Record.BoolErrRecord)record).IsBoolean)
					{
						return global::NPOI.SS.UserModel.CellType.Error;
					}
					return global::NPOI.SS.UserModel.CellType.Boolean;
				}
				throw new global::System.Exception("Bad cell value rec (" + cval.GetType().Name + ")");
			}
			return global::NPOI.SS.UserModel.CellType.String;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00051BC3 File Offset: 0x0004FDC3
		public global::NPOI.HSSF.Model.InternalWorkbook BoundWorkbook
		{
			get
			{
				return this.book.Workbook;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00051BD8 File Offset: 0x0004FDD8
		public global::NPOI.SS.UserModel.IRow Row
		{
			get
			{
				int rowIndex = this.RowIndex;
				return this._sheet.GetRow(rowIndex);
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		public void SetCellType(global::NPOI.SS.UserModel.CellType cellType)
		{
			this.NotifyFormulaChanging();
			if (this.IsPartOfArrayFormulaGroup)
			{
				this.NotifyArrayFormulaChanging();
			}
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			this.SetCellType(cellType, true, row, column, xfindex);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00051C48 File Offset: 0x0004FE48
		private void SetCellType(global::NPOI.SS.UserModel.CellType cellType, bool setValue, int row, int col, short styleIndex)
		{
			if (cellType > global::NPOI.SS.UserModel.CellType.Error)
			{
				throw new global::System.Exception("I have no idea what type that Is!");
			}
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
			{
				global::NPOI.HSSF.Record.NumberRecord numberRecord;
				if (cellType != this.cellType)
				{
					numberRecord = new global::NPOI.HSSF.Record.NumberRecord();
				}
				else
				{
					numberRecord = (global::NPOI.HSSF.Record.NumberRecord)this._record;
				}
				numberRecord.Column = col;
				if (setValue)
				{
					numberRecord.Value = this.NumericCellValue;
				}
				numberRecord.XFIndex = styleIndex;
				numberRecord.Row = row;
				this._record = numberRecord;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.String:
			{
				global::NPOI.HSSF.Record.LabelSSTRecord labelSSTRecord;
				if (cellType != this.cellType)
				{
					labelSSTRecord = new global::NPOI.HSSF.Record.LabelSSTRecord();
				}
				else
				{
					labelSSTRecord = (global::NPOI.HSSF.Record.LabelSSTRecord)this._record;
				}
				labelSSTRecord.Column = col;
				labelSSTRecord.Row = row;
				labelSSTRecord.XFIndex = styleIndex;
				if (setValue)
				{
					string text = this.ConvertCellValueToString();
					if (text == null)
					{
						this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank, false, row, col, styleIndex);
						return;
					}
					int num = this.book.Workbook.AddSSTString(new global::NPOI.HSSF.Record.UnicodeString(text));
					labelSSTRecord.SSTIndex = num;
					global::NPOI.HSSF.Record.UnicodeString sststring = this.book.Workbook.GetSSTString(num);
					this.stringValue = new global::NPOI.HSSF.UserModel.HSSFRichTextString();
					this.stringValue.UnicodeString = sststring;
				}
				this._record = labelSSTRecord;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
			{
				global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate formulaRecordAggregate;
				if (cellType != this.cellType)
				{
					formulaRecordAggregate = this._sheet.Sheet.RowsAggregate.CreateFormula(row, col);
				}
				else
				{
					formulaRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record;
				}
				formulaRecordAggregate.Column = col;
				if (setValue)
				{
					formulaRecordAggregate.FormulaRecord.Value = this.NumericCellValue;
				}
				formulaRecordAggregate.XFIndex = styleIndex;
				formulaRecordAggregate.Row = row;
				this._record = formulaRecordAggregate;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Blank:
			{
				global::NPOI.HSSF.Record.BlankRecord blankRecord;
				if (cellType != this.cellType)
				{
					blankRecord = new global::NPOI.HSSF.Record.BlankRecord();
				}
				else
				{
					blankRecord = (global::NPOI.HSSF.Record.BlankRecord)this._record;
				}
				blankRecord.Column = col;
				blankRecord.XFIndex = styleIndex;
				blankRecord.Row = row;
				this._record = blankRecord;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Boolean:
			{
				global::NPOI.HSSF.Record.BoolErrRecord boolErrRecord;
				if (cellType != this.cellType)
				{
					boolErrRecord = new global::NPOI.HSSF.Record.BoolErrRecord();
				}
				else
				{
					boolErrRecord = (global::NPOI.HSSF.Record.BoolErrRecord)this._record;
				}
				boolErrRecord.Column = col;
				if (setValue)
				{
					boolErrRecord.SetValue(this.ConvertCellValueToBoolean());
				}
				boolErrRecord.XFIndex = styleIndex;
				boolErrRecord.Row = row;
				this._record = boolErrRecord;
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Error:
			{
				global::NPOI.HSSF.Record.BoolErrRecord boolErrRecord2;
				if (cellType != this.cellType)
				{
					boolErrRecord2 = new global::NPOI.HSSF.Record.BoolErrRecord();
				}
				else
				{
					boolErrRecord2 = (global::NPOI.HSSF.Record.BoolErrRecord)this._record;
				}
				boolErrRecord2.Column = col;
				if (setValue)
				{
					boolErrRecord2.SetValue(global::NPOI.SS.UserModel.FormulaError.VALUE.Code);
				}
				boolErrRecord2.XFIndex = styleIndex;
				boolErrRecord2.Row = row;
				this._record = boolErrRecord2;
				break;
			}
			default:
				throw new global::System.InvalidOperationException("Invalid cell type: " + cellType.ToString());
			}
			if (cellType != this.cellType && this.cellType != global::NPOI.SS.UserModel.CellType.Unknown)
			{
				this._sheet.Sheet.ReplaceValueRecord(this._record);
			}
			this.cellType = cellType;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00051F2B File Offset: 0x0005012B
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this.cellType;
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00051F34 File Offset: 0x00050134
		private string ConvertCellValueToString()
		{
			switch (this.cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return global::NPOI.SS.Util.NumberToTextConverter.ToText(((global::NPOI.HSSF.Record.NumberRecord)this._record).Value);
			case global::NPOI.SS.UserModel.CellType.String:
			{
				int sstindex = ((global::NPOI.HSSF.Record.LabelSSTRecord)this._record).SSTIndex;
				return this.book.Workbook.GetSSTString(sstindex).String;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
			{
				global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate formulaRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record;
				global::NPOI.HSSF.Record.FormulaRecord formulaRecord = formulaRecordAggregate.FormulaRecord;
				switch (formulaRecord.CachedResultType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
					return global::NPOI.SS.Util.NumberToTextConverter.ToText(formulaRecord.Value);
				case global::NPOI.SS.UserModel.CellType.String:
					return formulaRecordAggregate.StringValue;
				case global::NPOI.SS.UserModel.CellType.Boolean:
					if (!formulaRecord.CachedBooleanValue)
					{
						return "FALSE";
					}
					return "TRUE";
				case global::NPOI.SS.UserModel.CellType.Error:
					return global::NPOI.SS.UserModel.FormulaError.ForInt(formulaRecord.CachedErrorValue).String;
				}
				throw new global::System.IO.InvalidDataException("Unexpected formula result type (" + this.cellType.ToString() + ")");
			}
			case global::NPOI.SS.UserModel.CellType.Blank:
				return "";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!((global::NPOI.HSSF.Record.BoolErrRecord)this._record).BooleanValue)
				{
					return "FALSE";
				}
				return "TRUE";
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.UserModel.FormulaError.ForInt(((global::NPOI.HSSF.Record.BoolErrRecord)this._record).ErrorValue).String;
			default:
				throw new global::System.IO.InvalidDataException("Unexpected cell type (" + this.cellType.ToString() + ")");
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000520A4 File Offset: 0x000502A4
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
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			global::NPOI.SS.UserModel.CellType cellType = this.cellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Numeric)
			{
				((global::NPOI.HSSF.Record.NumberRecord)this._record).Value = value;
				return;
			}
			if (cellType != global::NPOI.SS.UserModel.CellType.Formula)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Numeric, false, row, column, xfindex);
				((global::NPOI.HSSF.Record.NumberRecord)this._record).Value = value;
				return;
			}
			((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).SetCachedDoubleResult(value);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00052157 File Offset: 0x00050357
		public void SetCellValue(global::System.DateTime value)
		{
			this.SetCellValue(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(value, this.book.IsDate1904()));
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00052170 File Offset: 0x00050370
		public void SetCellValue(string value)
		{
			global::NPOI.HSSF.UserModel.HSSFRichTextString cellValue = (value == null) ? null : new global::NPOI.HSSF.UserModel.HSSFRichTextString(value);
			this.SetCellValue(cellValue);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00052194 File Offset: 0x00050394
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link #setCellErrorValue(FormulaError)} instead.")]
		public void SetCellErrorValue(byte errorCode)
		{
			global::NPOI.SS.UserModel.FormulaError cellErrorValue = global::NPOI.SS.UserModel.FormulaError.ForInt(errorCode);
			this.SetCellErrorValue(cellErrorValue);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x000521B0 File Offset: 0x000503B0
		public void SetCellErrorValue(global::NPOI.SS.UserModel.FormulaError error)
		{
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			global::NPOI.SS.UserModel.CellType cellType = this.cellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).SetCachedErrorResult(error);
				return;
			}
			if (cellType == global::NPOI.SS.UserModel.CellType.Error)
			{
				((global::NPOI.HSSF.Record.BoolErrRecord)this._record).SetValue(error);
				return;
			}
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Error, false, row, column, xfindex);
			((global::NPOI.HSSF.Record.BoolErrRecord)this._record).SetValue(error);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00052230 File Offset: 0x00050430
		public void SetCellValue(global::NPOI.SS.UserModel.IRichTextString value)
		{
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			if (value == null)
			{
				this.NotifyFormulaChanging();
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank, false, row, column, xfindex);
				return;
			}
			if (value.Length > global::NPOI.SS.SpreadsheetVersion.EXCEL97.MaxTextLength)
			{
				throw new global::System.ArgumentException("The maximum length of cell contents (text) is 32,767 characters");
			}
			if (this.cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).SetCachedStringResult(value.String);
				this.stringValue = new global::NPOI.HSSF.UserModel.HSSFRichTextString(value.String);
				return;
			}
			if (this.cellType != global::NPOI.SS.UserModel.CellType.String)
			{
				this.SetCellType(global::NPOI.SS.UserModel.CellType.String, false, row, column, xfindex);
			}
			global::NPOI.HSSF.UserModel.HSSFRichTextString hssfrichTextString = (global::NPOI.HSSF.UserModel.HSSFRichTextString)value;
			global::NPOI.HSSF.Record.UnicodeString unicodeString = hssfrichTextString.UnicodeString;
			int num = this.book.Workbook.AddSSTString(unicodeString);
			((global::NPOI.HSSF.Record.LabelSSTRecord)this._record).SSTIndex = num;
			this.stringValue = hssfrichTextString;
			this.stringValue.SetWorkbookReferences(this.book.Workbook, (global::NPOI.HSSF.Record.LabelSSTRecord)this._record);
			this.stringValue.UnicodeString = this.book.Workbook.GetSSTString(num);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00052354 File Offset: 0x00050554
		private void NotifyFormulaChanging()
		{
			if (this._record is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)
			{
				((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).NotifyFormulaChanging();
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00052373 File Offset: 0x00050573
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x000523AC File Offset: 0x000505AC
		public string CellFormula
		{
			get
			{
				if (!(this._record is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate))
				{
					throw this.TypeMismatch(global::NPOI.SS.UserModel.CellType.Formula, this.cellType, true);
				}
				return global::NPOI.HSSF.Model.HSSFFormulaParser.ToFormulaString(this.book, ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaTokens);
			}
			set
			{
				this.SetCellFormula(value);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000523B8 File Offset: 0x000505B8
		public void SetCellFormula(string formula)
		{
			if (this.IsPartOfArrayFormulaGroup)
			{
				this.NotifyArrayFormulaChanging();
			}
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			if (string.IsNullOrEmpty(formula))
			{
				this.NotifyFormulaChanging();
				this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank, false, row, column, xfindex);
				return;
			}
			int sheetIndex = this.book.GetSheetIndex(this._sheet);
			global::NPOI.SS.Formula.PTG.Ptg[] parsedExpression = global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, this.book, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex);
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Formula, false, row, column, xfindex);
			global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate formulaRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record;
			global::NPOI.HSSF.Record.FormulaRecord formulaRecord = formulaRecordAggregate.FormulaRecord;
			formulaRecord.Options = 2;
			formulaRecord.Value = 0.0;
			if (formulaRecordAggregate.XFIndex == 0)
			{
				formulaRecordAggregate.XFIndex = 15;
			}
			formulaRecordAggregate.SetParsedExpression(parsedExpression);
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00052484 File Offset: 0x00050684
		public double NumericCellValue
		{
			get
			{
				switch (this.cellType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
					return ((global::NPOI.HSSF.Record.NumberRecord)this._record).Value;
				case global::NPOI.SS.UserModel.CellType.Formula:
				{
					global::NPOI.HSSF.Record.FormulaRecord formulaRecord = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaRecord;
					this.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.Numeric, formulaRecord);
					return formulaRecord.Value;
				}
				case global::NPOI.SS.UserModel.CellType.Blank:
					return 0.0;
				}
				throw this.TypeMismatch(global::NPOI.SS.UserModel.CellType.Numeric, this.cellType, false);
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000524FC File Offset: 0x000506FC
		private string GetCellTypeName(global::NPOI.SS.UserModel.CellType cellTypeCode)
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
				return "boolean";
			case global::NPOI.SS.UserModel.CellType.Error:
				return "error";
			default:
				return "#unknown cell type (" + cellTypeCode.ToString() + ")#";
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0005256C File Offset: 0x0005076C
		private global::System.Exception TypeMismatch(global::NPOI.SS.UserModel.CellType expectedTypeCode, global::NPOI.SS.UserModel.CellType actualTypeCode, bool isFormulaCell)
		{
			return new global::System.InvalidOperationException(string.Concat(new string[]
			{
				"Cannot get a ",
				this.GetCellTypeName(expectedTypeCode),
				" value from a ",
				this.GetCellTypeName(actualTypeCode),
				" ",
				isFormulaCell ? "formula " : "",
				"cell"
			}));
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000525D0 File Offset: 0x000507D0
		private void CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType expectedTypeCode, global::NPOI.HSSF.Record.FormulaRecord fr)
		{
			global::NPOI.SS.UserModel.CellType cachedResultType = fr.CachedResultType;
			if (cachedResultType != expectedTypeCode)
			{
				throw this.TypeMismatch(expectedTypeCode, cachedResultType, true);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x000525F4 File Offset: 0x000507F4
		public global::System.DateTime DateCellValue
		{
			get
			{
				if (this.cellType == global::NPOI.SS.UserModel.CellType.Blank)
				{
					return global::System.DateTime.MaxValue;
				}
				if (this.cellType == global::NPOI.SS.UserModel.CellType.String)
				{
					throw new global::System.IO.InvalidDataException("You cannot get a date value from a String based cell");
				}
				if (this.cellType == global::NPOI.SS.UserModel.CellType.Boolean)
				{
					throw new global::System.IO.InvalidDataException("You cannot get a date value from a bool cell");
				}
				if (this.cellType == global::NPOI.SS.UserModel.CellType.Error)
				{
					throw new global::System.IO.InvalidDataException("You cannot get a date value from an error cell");
				}
				double numericCellValue = this.NumericCellValue;
				if (this.book.IsDate1904())
				{
					return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(numericCellValue, true);
				}
				return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(numericCellValue, false);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0005266F File Offset: 0x0005086F
		public string StringCellValue
		{
			get
			{
				return this.RichStringCellValue.String;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0005267C File Offset: 0x0005087C
		public global::NPOI.SS.UserModel.IRichTextString RichStringCellValue
		{
			get
			{
				switch (this.cellType)
				{
				case global::NPOI.SS.UserModel.CellType.String:
					return this.stringValue;
				case global::NPOI.SS.UserModel.CellType.Formula:
				{
					global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate formulaRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record;
					this.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.String, formulaRecordAggregate.FormulaRecord);
					string text = formulaRecordAggregate.StringValue;
					return new global::NPOI.HSSF.UserModel.HSSFRichTextString((text == null) ? "" : text);
				}
				case global::NPOI.SS.UserModel.CellType.Blank:
					return new global::NPOI.HSSF.UserModel.HSSFRichTextString("");
				default:
					throw this.TypeMismatch(global::NPOI.SS.UserModel.CellType.String, this.cellType, false);
				}
			}
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x000526F8 File Offset: 0x000508F8
		public void SetCellValue(bool value)
		{
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			global::NPOI.SS.UserModel.CellType cellType = this.cellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).SetCachedBooleanResult(value);
				return;
			}
			if (cellType == global::NPOI.SS.UserModel.CellType.Boolean)
			{
				((global::NPOI.HSSF.Record.BoolErrRecord)this._record).SetValue(value);
				return;
			}
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Boolean, false, row, column, xfindex);
			((global::NPOI.HSSF.Record.BoolErrRecord)this._record).SetValue(value);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00052778 File Offset: 0x00050978
		private bool ConvertCellValueToBoolean()
		{
			switch (this.cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return ((global::NPOI.HSSF.Record.NumberRecord)this._record).Value != 0.0;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				int sstindex = ((global::NPOI.HSSF.Record.LabelSSTRecord)this._record).SSTIndex;
				return global::System.Convert.ToBoolean(this.book.Workbook.GetSSTString(sstindex).String, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
			{
				global::NPOI.HSSF.Record.FormulaRecord formulaRecord = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaRecord;
				this.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.Boolean, formulaRecord);
				return formulaRecord.CachedBooleanValue;
			}
			case global::NPOI.SS.UserModel.CellType.Blank:
			case global::NPOI.SS.UserModel.CellType.Error:
				return false;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return ((global::NPOI.HSSF.Record.BoolErrRecord)this._record).BooleanValue;
			default:
				throw new global::System.Exception("Unexpected cell type (" + this.cellType.ToString() + ")");
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00052858 File Offset: 0x00050A58
		public bool BooleanCellValue
		{
			get
			{
				switch (this.cellType)
				{
				case global::NPOI.SS.UserModel.CellType.Formula:
				{
					global::NPOI.HSSF.Record.FormulaRecord formulaRecord = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaRecord;
					this.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.Boolean, formulaRecord);
					return formulaRecord.CachedBooleanValue;
				}
				case global::NPOI.SS.UserModel.CellType.Blank:
					return false;
				case global::NPOI.SS.UserModel.CellType.Boolean:
					return ((global::NPOI.HSSF.Record.BoolErrRecord)this._record).BooleanValue;
				default:
					throw this.TypeMismatch(global::NPOI.SS.UserModel.CellType.Boolean, this.cellType, false);
				}
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000528C4 File Offset: 0x00050AC4
		public byte ErrorCellValue
		{
			get
			{
				global::NPOI.SS.UserModel.CellType cellType = this.cellType;
				if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
				{
					global::NPOI.HSSF.Record.FormulaRecord formulaRecord = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaRecord;
					this.CheckFormulaCachedValueType(global::NPOI.SS.UserModel.CellType.Error, formulaRecord);
					return (byte)formulaRecord.CachedErrorValue;
				}
				if (cellType == global::NPOI.SS.UserModel.CellType.Error)
				{
					return ((global::NPOI.HSSF.Record.BoolErrRecord)this._record).ErrorValue;
				}
				throw this.TypeMismatch(global::NPOI.SS.UserModel.CellType.Error, this.cellType, false);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00052920 File Offset: 0x00050B20
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x00052958 File Offset: 0x00050B58
		public global::NPOI.SS.UserModel.ICellStyle CellStyle
		{
			get
			{
				short xfindex = this._record.XFIndex;
				global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = this.book.Workbook.GetExFormatAt((int)xfindex);
				return new global::NPOI.HSSF.UserModel.HSSFCellStyle(xfindex, exFormatAt, this.book);
			}
			set
			{
				if (value == null)
				{
					this._record.XFIndex = 15;
					return;
				}
				((global::NPOI.HSSF.UserModel.HSSFCellStyle)value).VerifyBelongsToWorkbook(this.book);
				short xfindex;
				if (((global::NPOI.HSSF.UserModel.HSSFCellStyle)value).UserStyleName != null)
				{
					xfindex = this.ApplyUserCellStyle((global::NPOI.HSSF.UserModel.HSSFCellStyle)value);
				}
				else
				{
					xfindex = value.Index;
				}
				this._record.XFIndex = xfindex;
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000529B8 File Offset: 0x00050BB8
		private short ApplyUserCellStyle(global::NPOI.HSSF.UserModel.HSSFCellStyle style)
		{
			if (style.UserStyleName == null)
			{
				throw new global::System.ArgumentException("Expected user-defined style");
			}
			global::NPOI.HSSF.Model.InternalWorkbook workbook = this.book.Workbook;
			short num = -1;
			int numExFormats = workbook.NumExFormats;
			short num2 = 0;
			while ((int)num2 < numExFormats)
			{
				global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = workbook.GetExFormatAt((int)num2);
				if (exFormatAt.XFType == 0 && exFormatAt.ParentIndex == style.Index)
				{
					num = num2;
					break;
				}
				num2 += 1;
			}
			short result;
			if (num == -1)
			{
				global::NPOI.HSSF.Record.ExtendedFormatRecord extendedFormatRecord = workbook.CreateCellXF();
				extendedFormatRecord.CloneStyleFrom(workbook.GetExFormatAt((int)style.Index));
				extendedFormatRecord.IndentionOptions = 0;
				extendedFormatRecord.XFType = 0;
				extendedFormatRecord.ParentIndex = style.Index;
				result = (short)numExFormats;
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00052A62 File Offset: 0x00050C62
		public global::NPOI.HSSF.Record.CellValueRecordInterface CellValueRecord
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00052A6C File Offset: 0x00050C6C
		private void CheckBounds(int cellIndex)
		{
			if (cellIndex < 0 || cellIndex > global::NPOI.HSSF.UserModel.HSSFCell.LAST_COLUMN_NUMBER)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid column index (",
					cellIndex.ToString(),
					").  Allowable column range for BIFF8 is (0..",
					global::NPOI.HSSF.UserModel.HSSFCell.LAST_COLUMN_NUMBER.ToString(),
					") or ('A'..'",
					global::NPOI.HSSF.UserModel.HSSFCell.LAST_COLUMN_NAME,
					"')"
				}));
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00052AD8 File Offset: 0x00050CD8
		public void SetAsActiveCell()
		{
			int row = this._record.Row;
			int column = this._record.Column;
			this._sheet.Sheet.SetActiveCell(row, column);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00052B10 File Offset: 0x00050D10
		public override string ToString()
		{
			switch (this.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				this.CellStyle.GetDataFormatString();
				return new global::NPOI.SS.UserModel.DataFormatter().FormatCellValue(this);
			case global::NPOI.SS.UserModel.CellType.String:
				return this.StringCellValue;
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
				return global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)((global::NPOI.HSSF.Record.BoolErrRecord)this._record).ErrorValue);
			default:
				return "Unknown Cell Type: " + this.CellType.ToString();
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00052BB8 File Offset: 0x00050DB8
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x00052BEF File Offset: 0x00050DEF
		public global::NPOI.SS.UserModel.IComment CellComment
		{
			get
			{
				if (this.comment == null)
				{
					this.comment = this._sheet.FindCellComment(this._record.Row, this._record.Column);
				}
				return this.comment;
			}
			set
			{
				if (value == null)
				{
					this.RemoveCellComment();
					return;
				}
				value.Row = this._record.Row;
				value.Column = this._record.Column;
				this.comment = value;
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00052C24 File Offset: 0x00050E24
		public void RemoveCellComment()
		{
			global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = this._sheet.FindCellComment(this._record.Row, this._record.Column);
			this.comment = null;
			if (hssfcomment == null)
			{
				return;
			}
			(this._sheet.DrawingPatriarch as global::NPOI.HSSF.UserModel.HSSFPatriarch).RemoveShape(hssfcomment);
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00052C75 File Offset: 0x00050E75
		public int ColumnIndex
		{
			get
			{
				return this._record.Column & 65535;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00052C88 File Offset: 0x00050E88
		public global::NPOI.SS.Util.CellAddress Address
		{
			get
			{
				return new global::NPOI.SS.Util.CellAddress(this);
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00052C90 File Offset: 0x00050E90
		internal void UpdateCellNum(int num)
		{
			this._record.Column = num;
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00052C9E File Offset: 0x00050E9E
		public int RowIndex
		{
			get
			{
				return this._record.Row;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00052CAB File Offset: 0x00050EAB
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x00052CD0 File Offset: 0x00050ED0
		public global::NPOI.SS.UserModel.IHyperlink Hyperlink
		{
			get
			{
				return this._sheet.GetHyperlink(this._record.Row, this._record.Column);
			}
			set
			{
				if (value == null)
				{
					this.RemoveHyperlink();
					return;
				}
				global::NPOI.HSSF.UserModel.HSSFHyperlink hssfhyperlink = (global::NPOI.HSSF.UserModel.HSSFHyperlink)value;
				value.FirstRow = this._record.Row;
				value.LastRow = this._record.Row;
				value.FirstColumn = this._record.Column;
				value.LastColumn = this._record.Column;
				switch (hssfhyperlink.Type)
				{
				case global::NPOI.SS.UserModel.HyperlinkType.Url:
				case global::NPOI.SS.UserModel.HyperlinkType.Email:
					value.Label = "url";
					break;
				case global::NPOI.SS.UserModel.HyperlinkType.Document:
					value.Label = "place";
					break;
				case global::NPOI.SS.UserModel.HyperlinkType.File:
					value.Label = "file";
					break;
				}
				int index = this._sheet.Sheet.FindFirstRecordLocBySid(10);
				this._sheet.Sheet.Records.Insert(index, hssfhyperlink.record);
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00052DA8 File Offset: 0x00050FA8
		public void RemoveHyperlink()
		{
			global::NPOI.HSSF.Record.RecordBase recordBase = null;
			foreach (global::NPOI.HSSF.Record.RecordBase recordBase2 in this._sheet.Sheet.Records)
			{
				if (recordBase2 is global::NPOI.HSSF.Record.HyperlinkRecord)
				{
					global::NPOI.HSSF.Record.HyperlinkRecord hyperlinkRecord = (global::NPOI.HSSF.Record.HyperlinkRecord)recordBase2;
					if (hyperlinkRecord.FirstColumn == this._record.Column && hyperlinkRecord.FirstRow == this._record.Row)
					{
						recordBase = recordBase2;
						break;
					}
				}
			}
			if (recordBase != null)
			{
				this._sheet.Sheet.Records.Remove(recordBase);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00052E36 File Offset: 0x00051036
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				if (this.cellType != global::NPOI.SS.UserModel.CellType.Formula)
				{
					throw new global::System.InvalidOperationException("Only formula cells have cached results");
				}
				return ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).FormulaRecord.CachedResultType;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00052E61 File Offset: 0x00051061
		public bool IsPartOfArrayFormulaGroup
		{
			get
			{
				return this.cellType == global::NPOI.SS.UserModel.CellType.Formula && ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).IsPartOfArrayFormula;
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00052E80 File Offset: 0x00051080
		internal void SetCellArrayFormula(global::NPOI.SS.Util.CellRangeAddress range)
		{
			int row = this._record.Row;
			int column = this._record.Column;
			short xfindex = this._record.XFIndex;
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Formula, false, row, column, xfindex);
			global::NPOI.SS.Formula.PTG.Ptg[] parsedExpression = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				new global::NPOI.SS.Formula.PTG.ExpPtg(range.FirstRow, range.FirstColumn)
			};
			((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).SetParsedExpression(parsedExpression);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x00052EE8 File Offset: 0x000510E8
		public global::NPOI.SS.Util.CellRangeAddress ArrayFormulaRange
		{
			get
			{
				if (this.cellType != global::NPOI.SS.UserModel.CellType.Formula)
				{
					string str = new global::NPOI.SS.Util.CellReference(this).FormatAsString();
					throw new global::System.InvalidOperationException("Cell " + str + " is not part of an array formula.");
				}
				return ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)this._record).GetArrayFormulaRange();
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00052F30 File Offset: 0x00051130
		public global::NPOI.SS.UserModel.ICell CopyCellTo(int targetIndex)
		{
			return this.Row.CopyCell(this.ColumnIndex, targetIndex);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00052F44 File Offset: 0x00051144
		internal void NotifyArrayFormulaChanging(string msg)
		{
			if (this.ArrayFormulaRange.NumberOfCells > 1)
			{
				throw new global::System.InvalidOperationException(msg);
			}
			this.Row.Sheet.RemoveArrayFormula(this);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00052F70 File Offset: 0x00051170
		internal void NotifyArrayFormulaChanging()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this);
			string msg = "Cell " + cellReference.FormatAsString() + " is part of a multi-cell array formula. You cannot change part of an array.";
			this.NotifyArrayFormulaChanging(msg);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00008C75 File Offset: 0x00006E75
		public global::NPOI.SS.UserModel.CellType GetCachedFormulaResultTypeEnum()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00052FA1 File Offset: 0x000511A1
		public void SetBlank()
		{
			this.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00052FAC File Offset: 0x000511AC
		public bool IsMergedCell
		{
			get
			{
				foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this._sheet.Sheet.MergedRecords.MergedRegions)
				{
					if (cellRangeAddress.FirstColumn <= this.ColumnIndex && cellRangeAddress.LastColumn >= this.ColumnIndex && cellRangeAddress.FirstRow <= this.RowIndex && cellRangeAddress.LastRow >= this.RowIndex)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x04000B21 RID: 2849
		public const short ENCODING_UNCHANGED = -1;

		// Token: 0x04000B22 RID: 2850
		public const short ENCODING_COMPRESSED_UNICODE = 0;

		// Token: 0x04000B23 RID: 2851
		public const short ENCODING_UTF_16 = 1;

		// Token: 0x04000B24 RID: 2852
		private global::NPOI.SS.UserModel.CellType cellType;

		// Token: 0x04000B25 RID: 2853
		private global::NPOI.HSSF.UserModel.HSSFRichTextString stringValue;

		// Token: 0x04000B26 RID: 2854
		private global::NPOI.HSSF.UserModel.HSSFWorkbook book;

		// Token: 0x04000B27 RID: 2855
		private global::NPOI.HSSF.UserModel.HSSFSheet _sheet;

		// Token: 0x04000B28 RID: 2856
		private global::NPOI.HSSF.Record.CellValueRecordInterface _record;

		// Token: 0x04000B29 RID: 2857
		private global::NPOI.SS.UserModel.IComment comment;

		// Token: 0x04000B2A RID: 2858
		private const string FILE_FORMAT_NAME = "BIFF8";

		// Token: 0x04000B2B RID: 2859
		public static readonly int LAST_COLUMN_NUMBER = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex;

		// Token: 0x04000B2C RID: 2860
		private static readonly string LAST_COLUMN_NAME = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnName;
	}
}
