using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel;

namespace NPOI.SS.Converter
{
	// Token: 0x020000F2 RID: 242
	public class ExcelToHtmlConverter
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x0003421C File Offset: 0x0003241C
		public ExcelToHtmlConverter()
		{
			global::System.Xml.XmlDocument document = new global::System.Xml.XmlDocument();
			this.htmlDocumentFacade = new global::NPOI.SS.HtmlDocumentFacade(document);
			this.cssClassTable = this.htmlDocumentFacade.GetOrCreateCssClass("table", "t", "border-collapse:collapse;border-spacing:0;");
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000342A1 File Offset: 0x000324A1
		protected static int GetColumnWidth(global::NPOI.SS.UserModel.ISheet sheet, int columnIndex)
		{
			return global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColumnWidthInPx(sheet.GetColumnWidth(columnIndex));
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000342AF File Offset: 0x000324AF
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x000342B7 File Offset: 0x000324B7
		public bool OutputColumnHeaders
		{
			get
			{
				return this.outputColumnHeaders;
			}
			set
			{
				this.outputColumnHeaders = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000342C0 File Offset: 0x000324C0
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x000342C8 File Offset: 0x000324C8
		public bool OutputHiddenColumns
		{
			get
			{
				return this.outputHiddenColumns;
			}
			set
			{
				this.outputHiddenColumns = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000342D1 File Offset: 0x000324D1
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x000342D9 File Offset: 0x000324D9
		public bool OutputHiddenRows
		{
			get
			{
				return this.outputHiddenRows;
			}
			set
			{
				this.outputHiddenRows = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000342E2 File Offset: 0x000324E2
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x000342EA File Offset: 0x000324EA
		public bool OutputLeadingSpacesAsNonBreaking
		{
			get
			{
				return this.outputLeadingSpacesAsNonBreaking;
			}
			set
			{
				this.outputLeadingSpacesAsNonBreaking = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000342F3 File Offset: 0x000324F3
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x000342FB File Offset: 0x000324FB
		public bool OutputRowNumbers
		{
			get
			{
				return this.outputRowNumbers;
			}
			set
			{
				this.outputRowNumbers = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00034304 File Offset: 0x00032504
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0003430C File Offset: 0x0003250C
		public bool UseDivsToSpan
		{
			get
			{
				return this.useDivsToSpan;
			}
			set
			{
				this.useDivsToSpan = value;
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00034318 File Offset: 0x00032518
		public static global::System.Xml.XmlDocument Process(string excelFile)
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = global::NPOI.SS.UserModel.WorkbookFactory.Create(excelFile, null);
			global::NPOI.SS.Converter.ExcelToHtmlConverter excelToHtmlConverter = new global::NPOI.SS.Converter.ExcelToHtmlConverter();
			excelToHtmlConverter.ProcessWorkbook(workbook);
			return excelToHtmlConverter.Document;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0003433E File Offset: 0x0003253E
		public global::System.Xml.XmlDocument Document
		{
			get
			{
				return this.htmlDocumentFacade.Document;
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0003434C File Offset: 0x0003254C
		public void ProcessWorkbook(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			this.ProcessDocumentInformation(workbook);
			if (this.UseDivsToSpan)
			{
				this.cssClassContainerCell = this.htmlDocumentFacade.GetOrCreateCssClass("td", "c", "padding:0;margin:0;align:left;vertical-align:top;");
				this.cssClassContainerDiv = this.htmlDocumentFacade.GetOrCreateCssClass("div", "d", "position:relative;");
			}
			for (int i = 0; i < workbook.NumberOfSheets; i++)
			{
				global::NPOI.SS.UserModel.ISheet sheetAt = workbook.GetSheetAt(i);
				this.ProcessSheet(sheetAt);
			}
			this.htmlDocumentFacade.UpdateStylesheet();
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000343D4 File Offset: 0x000325D4
		protected void ProcessSheet(global::NPOI.SS.UserModel.ISheet sheet)
		{
			this.ProcessSheetHeader(this.htmlDocumentFacade.Body, sheet);
			int physicalNumberOfRows = sheet.PhysicalNumberOfRows;
			if (physicalNumberOfRows <= 0)
			{
				return;
			}
			global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateTable();
			xmlElement.SetAttribute("class", this.cssClassTable);
			global::System.Xml.XmlElement xmlElement2 = this.htmlDocumentFacade.CreateTableBody();
			global::NPOI.SS.Util.CellRangeAddress[][] mergedRanges = global::NPOI.SS.Converter.ExcelToHtmlUtils.BuildMergedRangesMap(sheet);
			global::System.Collections.Generic.List<global::System.Xml.XmlElement> list = new global::System.Collections.Generic.List<global::System.Xml.XmlElement>(physicalNumberOfRows);
			int num = 1;
			for (int i = 0; i < physicalNumberOfRows; i++)
			{
				global::NPOI.SS.UserModel.IRow row = sheet.GetRow(i);
				if (row != null && (this.OutputHiddenRows || !row.ZeroHeight))
				{
					global::System.Xml.XmlElement xmlElement3 = this.htmlDocumentFacade.CreateTableRow();
					this.htmlDocumentFacade.AddStyleClass(xmlElement3, "r", "height:" + ((float)row.Height / 20f).ToString() + "pt;");
					int num2 = this.ProcessRow(mergedRanges, row, xmlElement3);
					if (num2 == 0)
					{
						list.Add(xmlElement3);
					}
					else
					{
						if (list.Count > 0)
						{
							foreach (global::System.Xml.XmlElement newChild in list)
							{
								xmlElement2.AppendChild(newChild);
							}
							list.Clear();
						}
						xmlElement2.AppendChild(xmlElement3);
					}
					num = global::System.Math.Max(num, num2);
				}
			}
			this.ProcessColumnWidths(sheet, num, xmlElement);
			if (this.OutputColumnHeaders)
			{
				this.ProcessColumnHeaders(sheet, num, xmlElement);
			}
			xmlElement.AppendChild(xmlElement2);
			this.htmlDocumentFacade.Body.AppendChild(xmlElement);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00034578 File Offset: 0x00032778
		protected void ProcessSheetHeader(global::System.Xml.XmlElement htmlBody, global::NPOI.SS.UserModel.ISheet sheet)
		{
			global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateHeader2();
			xmlElement.AppendChild(this.htmlDocumentFacade.CreateText(sheet.SheetName));
			htmlBody.AppendChild(xmlElement);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000345B4 File Offset: 0x000327B4
		protected void ProcessDocumentInformation(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			if (workbook is global::NPOI.HSSF.UserModel.HSSFWorkbook)
			{
				global::NPOI.HPSF.SummaryInformation summaryInformation = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook).SummaryInformation;
				if (summaryInformation != null)
				{
					if (!string.IsNullOrEmpty(summaryInformation.Title))
					{
						this.htmlDocumentFacade.Title = summaryInformation.Title;
					}
					if (!string.IsNullOrEmpty(summaryInformation.Author))
					{
						this.htmlDocumentFacade.AddAuthor(summaryInformation.Author);
					}
					if (!string.IsNullOrEmpty(summaryInformation.Keywords))
					{
						this.htmlDocumentFacade.AddKeywords(summaryInformation.Keywords);
					}
					if (!string.IsNullOrEmpty(summaryInformation.Comments))
					{
						this.htmlDocumentFacade.AddDescription(summaryInformation.Comments);
						return;
					}
				}
			}
			else if (workbook is global::NPOI.XSSF.UserModel.XSSFWorkbook)
			{
				global::NPOI.POIXMLProperties properties = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)workbook).GetProperties();
				if (!string.IsNullOrEmpty(properties.CoreProperties.Title))
				{
					this.htmlDocumentFacade.Title = properties.CoreProperties.Title;
				}
				if (!string.IsNullOrEmpty(properties.CoreProperties.Creator))
				{
					this.htmlDocumentFacade.AddAuthor(properties.CoreProperties.Creator);
				}
				if (!string.IsNullOrEmpty(properties.CoreProperties.Keywords))
				{
					this.htmlDocumentFacade.AddKeywords(properties.CoreProperties.Keywords);
				}
				if (!string.IsNullOrEmpty(properties.CoreProperties.Description))
				{
					this.htmlDocumentFacade.AddDescription(properties.CoreProperties.Description);
				}
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00034714 File Offset: 0x00032914
		protected int ProcessRow(global::NPOI.SS.Util.CellRangeAddress[][] mergedRanges, global::NPOI.SS.UserModel.IRow row, global::System.Xml.XmlElement tableRowElement)
		{
			global::NPOI.SS.UserModel.ISheet sheet = row.Sheet;
			int lastCellNum = (int)row.LastCellNum;
			if (lastCellNum <= 0)
			{
				return 0;
			}
			global::System.Collections.Generic.List<global::System.Xml.XmlElement> list = new global::System.Collections.Generic.List<global::System.Xml.XmlElement>(lastCellNum);
			if (this.OutputRowNumbers)
			{
				global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateTableHeaderCell();
				this.ProcessRowNumber(row, xmlElement);
				list.Add(xmlElement);
			}
			int num = 0;
			for (int i = 0; i < lastCellNum; i++)
			{
				if (this.OutputHiddenColumns || !sheet.IsColumnHidden(i))
				{
					global::NPOI.SS.Util.CellRangeAddress mergedRange = global::NPOI.SS.Converter.ExcelToHtmlUtils.GetMergedRange(mergedRanges, row.RowNum, i);
					if (mergedRange == null || (mergedRange.FirstColumn == i && mergedRange.FirstRow == row.RowNum))
					{
						global::NPOI.SS.UserModel.ICell cell = row.GetCell(i);
						int num2 = 0;
						if (this.UseDivsToSpan)
						{
							num2 = global::NPOI.SS.Converter.ExcelToHtmlConverter.GetColumnWidth(sheet, i);
							bool flag = false;
							for (int j = i + 1; j < lastCellNum; j++)
							{
								if (this.OutputHiddenColumns || !sheet.IsColumnHidden(j))
								{
									if (row.GetCell(j) != null && !this.IsTextEmpty(row.GetCell(j)))
									{
										flag = true;
										break;
									}
									num2 += global::NPOI.SS.Converter.ExcelToHtmlConverter.GetColumnWidth(sheet, j);
								}
							}
							if (!flag)
							{
								num2 = int.MaxValue;
							}
						}
						global::System.Xml.XmlElement xmlElement2 = this.htmlDocumentFacade.CreateTableCell();
						if (mergedRange != null)
						{
							if (mergedRange.FirstColumn != mergedRange.LastColumn)
							{
								xmlElement2.SetAttribute("colspan", (mergedRange.LastColumn - mergedRange.FirstColumn + 1).ToString());
							}
							if (mergedRange.FirstRow != mergedRange.LastRow)
							{
								xmlElement2.SetAttribute("rowspan", (mergedRange.LastRow - mergedRange.FirstRow + 1).ToString());
							}
						}
						bool flag2 = cell == null || this.ProcessCell(cell, xmlElement2, global::NPOI.SS.Converter.ExcelToHtmlConverter.GetColumnWidth(sheet, i), num2, (float)row.Height / 20f);
						if (flag2)
						{
							list.Add(xmlElement2);
						}
						else
						{
							foreach (global::System.Xml.XmlElement newChild in list)
							{
								tableRowElement.AppendChild(newChild);
							}
							list.Clear();
							tableRowElement.AppendChild(xmlElement2);
							num = i;
						}
					}
				}
			}
			return num + 1;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00034954 File Offset: 0x00032B54
		private string GetRowName(global::NPOI.SS.UserModel.IRow row)
		{
			return (row.RowNum + 1).ToString();
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00034974 File Offset: 0x00032B74
		protected void ProcessRowNumber(global::NPOI.SS.UserModel.IRow row, global::System.Xml.XmlElement tableRowNumberCellElement)
		{
			tableRowNumberCellElement.SetAttribute("class", "rownumber");
			global::System.Xml.XmlText newChild = this.htmlDocumentFacade.CreateText(this.GetRowName(row));
			tableRowNumberCellElement.AppendChild(newChild);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000349AC File Offset: 0x00032BAC
		protected void ProcessColumnWidths(global::NPOI.SS.UserModel.ISheet sheet, int maxSheetColumns, global::System.Xml.XmlElement table)
		{
			global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateTableColumnGroup();
			if (this.OutputRowNumbers)
			{
				xmlElement.AppendChild(this.htmlDocumentFacade.CreateTableColumn());
			}
			for (int i = 0; i < maxSheetColumns; i++)
			{
				if (this.OutputHiddenColumns || !sheet.IsColumnHidden(i))
				{
					global::System.Xml.XmlElement xmlElement2 = this.htmlDocumentFacade.CreateTableColumn();
					xmlElement2.SetAttribute("width", global::NPOI.SS.Converter.ExcelToHtmlConverter.GetColumnWidth(sheet, i).ToString());
					xmlElement.AppendChild(xmlElement2);
				}
			}
			table.AppendChild(xmlElement);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00034A34 File Offset: 0x00032C34
		protected void ProcessColumnHeaders(global::NPOI.SS.UserModel.ISheet sheet, int maxSheetColumns, global::System.Xml.XmlElement table)
		{
			global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateTableHeader();
			table.AppendChild(xmlElement);
			global::System.Xml.XmlElement xmlElement2 = this.htmlDocumentFacade.CreateTableRow();
			if (this.OutputRowNumbers)
			{
				xmlElement2.AppendChild(this.htmlDocumentFacade.CreateTableHeaderCell());
			}
			for (int i = 0; i < maxSheetColumns; i++)
			{
				if (this.OutputHiddenColumns || !sheet.IsColumnHidden(i))
				{
					global::System.Xml.XmlElement xmlElement3 = this.htmlDocumentFacade.CreateTableHeaderCell();
					string columnName = this.GetColumnName(i);
					xmlElement3.AppendChild(this.htmlDocumentFacade.CreateText(columnName));
					xmlElement2.AppendChild(xmlElement3);
				}
			}
			xmlElement.AppendChild(xmlElement2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00034AD4 File Offset: 0x00032CD4
		protected string GetColumnName(int columnIndex)
		{
			return (columnIndex + 1).ToString();
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00034AEC File Offset: 0x00032CEC
		protected bool IsTextEmpty(global::NPOI.SS.UserModel.ICell cell)
		{
			string value;
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				value = this._formatter.FormatCellValue(cell);
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				value = cell.RichStringCellValue.String;
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				switch (cell.CachedFormulaResultType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
				{
					global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
					if (cellStyle == null)
					{
						return false;
					}
					value = this._formatter.FormatRawCellContents(cell.NumericCellValue, (int)cellStyle.DataFormat, cellStyle.GetDataFormatString());
					goto IL_112;
				}
				case global::NPOI.SS.UserModel.CellType.String:
				{
					global::NPOI.SS.UserModel.IRichTextString richStringCellValue = cell.RichStringCellValue;
					if (richStringCellValue == null || richStringCellValue.Length <= 0)
					{
						return false;
					}
					value = richStringCellValue.ToString();
					goto IL_112;
				}
				case global::NPOI.SS.UserModel.CellType.Boolean:
					value = cell.BooleanCellValue.ToString();
					goto IL_112;
				case global::NPOI.SS.UserModel.CellType.Error:
					value = global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue);
					goto IL_112;
				}
				value = string.Empty;
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				value = string.Empty;
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				value = cell.BooleanCellValue.ToString();
				break;
			case global::NPOI.SS.UserModel.CellType.Error:
				value = global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue);
				break;
			default:
				return true;
			}
			IL_112:
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00034C14 File Offset: 0x00032E14
		protected bool ProcessCell(global::NPOI.SS.UserModel.ICell cell, global::System.Xml.XmlElement tableCellElement, int normalWidthPx, int maxSpannedWidthPx, float normalHeightPt)
		{
			global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
			string text;
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				text = this._formatter.FormatCellValue(cell);
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				text = cell.RichStringCellValue.String;
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				switch (cell.CachedFormulaResultType)
				{
				case global::NPOI.SS.UserModel.CellType.Numeric:
				{
					global::NPOI.SS.UserModel.ICellStyle cellStyle2 = cellStyle;
					if (cellStyle2 == null)
					{
						text = cell.NumericCellValue.ToString();
						goto IL_1A6;
					}
					text = this._formatter.FormatRawCellContents(cell.NumericCellValue, (int)cellStyle2.DataFormat, cellStyle2.GetDataFormatString());
					goto IL_1A6;
				}
				case global::NPOI.SS.UserModel.CellType.String:
				{
					global::NPOI.SS.UserModel.IRichTextString richStringCellValue = cell.RichStringCellValue;
					if (richStringCellValue != null && richStringCellValue.Length > 0)
					{
						text = richStringCellValue.String;
						goto IL_1A6;
					}
					text = string.Empty;
					goto IL_1A6;
				}
				case global::NPOI.SS.UserModel.CellType.Boolean:
					text = cell.BooleanCellValue.ToString();
					goto IL_1A6;
				case global::NPOI.SS.UserModel.CellType.Error:
					text = global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue);
					goto IL_1A6;
				}
				this.logger.Log(5, "Unexpected cell cachedFormulaResultType (" + cell.CachedFormulaResultType.ToString() + ")");
				text = string.Empty;
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				text = string.Empty;
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				text = cell.BooleanCellValue.ToString();
				break;
			case global::NPOI.SS.UserModel.CellType.Error:
				text = global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue);
				break;
			default:
				this.logger.Log(5, "Unexpected cell type (" + cell.CellType.ToString() + ")");
				return true;
			}
			IL_1A6:
			bool flag = string.IsNullOrEmpty(text);
			bool flag2 = !flag && this.UseDivsToSpan && !cellStyle.WrapText;
			short index = cellStyle.Index;
			if (index != 0)
			{
				global::NPOI.SS.UserModel.IWorkbook workbook = cell.Row.Sheet.Workbook;
				string styleClassName = this.GetStyleClassName(workbook, cellStyle);
				if (flag2)
				{
					tableCellElement.SetAttribute("class", styleClassName + " " + this.cssClassContainerCell);
				}
				else
				{
					tableCellElement.SetAttribute("class", styleClassName);
				}
				if (flag)
				{
					text = "\u00a0";
				}
			}
			if (this.OutputLeadingSpacesAsNonBreaking && text.StartsWith(" "))
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				int num = 0;
				while (num < text.Length && text[num] == ' ')
				{
					stringBuilder.Append('\u00a0');
					num++;
				}
				if (text.Length != stringBuilder.Length)
				{
					stringBuilder.Append(text.Substring(stringBuilder.Length));
				}
				text = stringBuilder.ToString();
			}
			global::System.Xml.XmlText newChild = this.htmlDocumentFacade.CreateText(text);
			if (flag2)
			{
				global::System.Xml.XmlElement xmlElement = this.htmlDocumentFacade.CreateBlock();
				xmlElement.SetAttribute("class", this.cssClassContainerDiv);
				global::System.Xml.XmlElement xmlElement2 = this.htmlDocumentFacade.CreateBlock();
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				stringBuilder2.Append("position:absolute;min-width:");
				stringBuilder2.Append(normalWidthPx);
				stringBuilder2.Append("px;");
				if (maxSpannedWidthPx != 2147483647)
				{
					stringBuilder2.Append("max-width:");
					stringBuilder2.Append(maxSpannedWidthPx);
					stringBuilder2.Append("px;");
				}
				stringBuilder2.Append("overflow:hidden;max-height:");
				stringBuilder2.Append(normalHeightPt);
				stringBuilder2.Append("pt;white-space:nowrap;");
				global::NPOI.SS.Converter.ExcelToHtmlUtils.AppendAlign(stringBuilder2, cellStyle.Alignment);
				this.htmlDocumentFacade.AddStyleClass(xmlElement, "d", stringBuilder2.ToString());
				xmlElement2.AppendChild(newChild);
				xmlElement.AppendChild(xmlElement2);
				tableCellElement.AppendChild(xmlElement);
			}
			else
			{
				tableCellElement.AppendChild(newChild);
			}
			return string.IsNullOrEmpty(text) && index == 0;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00034FD8 File Offset: 0x000331D8
		protected string GetStyleClassName(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.UserModel.ICellStyle cellStyle)
		{
			short index = cellStyle.Index;
			if (this.excelStyleToClass.ContainsKey(index))
			{
				return this.excelStyleToClass[index];
			}
			string style = this.BuildStyle(workbook, cellStyle);
			string orCreateCssClass = this.htmlDocumentFacade.GetOrCreateCssClass("td", "c", style);
			this.excelStyleToClass.Add(index, orCreateCssClass);
			return orCreateCssClass;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00035038 File Offset: 0x00033238
		protected string BuildStyle(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.UserModel.ICellStyle cellStyle)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (workbook is global::NPOI.HSSF.UserModel.HSSFWorkbook)
			{
				global::NPOI.HSSF.UserModel.HSSFPalette customPalette = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook).GetCustomPalette();
				stringBuilder.Append("white-space: pre-wrap; ");
				global::NPOI.SS.Converter.ExcelToHtmlUtils.AppendAlign(stringBuilder, cellStyle.Alignment);
				if (cellStyle.FillPattern != global::NPOI.SS.UserModel.FillPattern.NoFill)
				{
					if (cellStyle.FillPattern == global::NPOI.SS.UserModel.FillPattern.SolidForeground)
					{
						global::NPOI.HSSF.Util.HSSFColor color = customPalette.GetColor(cellStyle.FillForegroundColor);
						if (color != null)
						{
							stringBuilder.AppendFormat("background-color:{0}; ", global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(color));
						}
					}
					else
					{
						global::NPOI.HSSF.Util.HSSFColor color2 = customPalette.GetColor(cellStyle.FillBackgroundColor);
						if (color2 != null)
						{
							stringBuilder.AppendFormat("background-color:{0}; ", global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(color2));
						}
					}
				}
			}
			else
			{
				stringBuilder.Append("white-space: pre-wrap; ");
				global::NPOI.SS.Converter.ExcelToHtmlUtils.AppendAlign(stringBuilder, cellStyle.Alignment);
				if (cellStyle.FillPattern != global::NPOI.SS.UserModel.FillPattern.NoFill)
				{
					if (cellStyle.FillPattern == global::NPOI.SS.UserModel.FillPattern.SolidForeground)
					{
						global::NPOI.SS.UserModel.IndexedColors indexedColors = global::NPOI.SS.UserModel.IndexedColors.ValueOf((int)cellStyle.FillForegroundColor);
						string text = null;
						if (indexedColors != null)
						{
							text = indexedColors.HexString;
						}
						else
						{
							global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = (global::NPOI.XSSF.UserModel.XSSFColor)cellStyle.FillForegroundColorColor;
							if (xssfcolor != null)
							{
								text = global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(xssfcolor);
							}
						}
						if (text != null)
						{
							stringBuilder.AppendFormat("background-color:{0}; ", text);
						}
					}
					else
					{
						global::NPOI.SS.UserModel.IndexedColors indexedColors2 = global::NPOI.SS.UserModel.IndexedColors.ValueOf((int)cellStyle.FillBackgroundColor);
						string text2 = null;
						if (indexedColors2 != null)
						{
							text2 = indexedColors2.HexString;
						}
						else
						{
							global::NPOI.XSSF.UserModel.XSSFColor xssfcolor2 = (global::NPOI.XSSF.UserModel.XSSFColor)cellStyle.FillBackgroundColorColor;
							if (xssfcolor2 != null)
							{
								text2 = global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(xssfcolor2);
							}
						}
						if (text2 != null)
						{
							stringBuilder.AppendFormat("background-color:{0}; ", text2);
						}
					}
				}
			}
			this.BuildStyle_Border(workbook, stringBuilder, "top", cellStyle.BorderTop, cellStyle.TopBorderColor);
			this.BuildStyle_Border(workbook, stringBuilder, "right", cellStyle.BorderRight, cellStyle.RightBorderColor);
			this.BuildStyle_Border(workbook, stringBuilder, "bottom", cellStyle.BorderBottom, cellStyle.BottomBorderColor);
			this.BuildStyle_Border(workbook, stringBuilder, "left", cellStyle.BorderLeft, cellStyle.LeftBorderColor);
			global::NPOI.SS.UserModel.IFont font = cellStyle.GetFont(workbook);
			this.BuildStyle_Font(workbook, stringBuilder, font);
			return stringBuilder.ToString();
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00035224 File Offset: 0x00033424
		private void BuildStyle_Border(global::NPOI.SS.UserModel.IWorkbook workbook, global::System.Text.StringBuilder style, string type, global::NPOI.SS.UserModel.BorderStyle xlsBorder, short borderColor)
		{
			if (xlsBorder == global::NPOI.SS.UserModel.BorderStyle.None)
			{
				return;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(global::NPOI.SS.Converter.ExcelToHtmlUtils.GetBorderWidth(xlsBorder));
			stringBuilder.Append(' ');
			stringBuilder.Append(global::NPOI.SS.Converter.ExcelToHtmlUtils.GetBorderStyle(xlsBorder));
			if (workbook is global::NPOI.HSSF.UserModel.HSSFWorkbook)
			{
				global::NPOI.HSSF.UserModel.HSSFPalette customPalette = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook).GetCustomPalette();
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = null;
				if (customPalette != null)
				{
					hssfcolor = customPalette.GetColor(borderColor);
				}
				if (hssfcolor != null)
				{
					stringBuilder.Append(' ');
					stringBuilder.Append(global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(hssfcolor));
				}
			}
			else
			{
				global::NPOI.SS.UserModel.IndexedColors indexedColors = global::NPOI.SS.UserModel.IndexedColors.ValueOf((int)borderColor);
				if (indexedColors != null)
				{
					stringBuilder.Append(' ');
					stringBuilder.Append(indexedColors.HexString);
				}
				else
				{
					global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = null;
					global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)workbook).GetStylesSource();
					if (stylesSource != null)
					{
						global::NPOI.XSSF.Model.ThemesTable theme = stylesSource.GetTheme();
						if (theme != null)
						{
							xssfcolor = theme.GetThemeColor((int)borderColor);
						}
					}
					if (xssfcolor != null)
					{
						stringBuilder.Append(' ');
						stringBuilder.Append(global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(xssfcolor));
					}
				}
			}
			style.AppendFormat("border-{0}: {1}; ", type, stringBuilder);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0003531C File Offset: 0x0003351C
		private void BuildStyle_Font(global::NPOI.SS.UserModel.IWorkbook workbook, global::System.Text.StringBuilder style, global::NPOI.SS.UserModel.IFont font)
		{
			short boldweight = font.Boldweight;
			if (boldweight != 400 && boldweight == 700)
			{
				style.Append("font-weight: bold; ");
			}
			if (workbook is global::NPOI.HSSF.UserModel.HSSFWorkbook)
			{
				global::NPOI.HSSF.UserModel.HSSFPalette customPalette = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook).GetCustomPalette();
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = null;
				if (customPalette != null)
				{
					hssfcolor = customPalette.GetColor(font.Color);
				}
				if (hssfcolor != null)
				{
					style.AppendFormat("color:{0}; ", global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(hssfcolor));
				}
			}
			else
			{
				global::NPOI.SS.UserModel.IndexedColors indexedColors = global::NPOI.SS.UserModel.IndexedColors.ValueOf((int)font.Color);
				string text = null;
				if (indexedColors != null)
				{
					text = indexedColors.HexString;
				}
				else
				{
					global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)workbook).GetStylesSource();
					global::NPOI.XSSF.UserModel.XSSFColor xssfcolor;
					if (stylesSource != null && stylesSource.GetTheme() != null)
					{
						xssfcolor = stylesSource.GetTheme().GetThemeColor((int)font.Color);
					}
					else
					{
						xssfcolor = ((global::NPOI.XSSF.UserModel.XSSFFont)font).GetXSSFColor();
					}
					if (xssfcolor != null)
					{
						text = global::NPOI.SS.Converter.ExcelToHtmlUtils.GetColor(xssfcolor);
					}
				}
				if (text != null)
				{
					style.AppendFormat("color:{0}; ", text);
				}
			}
			if (font.FontHeightInPoints != 0.0)
			{
				style.Append("font-size: " + font.FontHeightInPoints.ToString() + "pt; ");
			}
			if (font.IsItalic)
			{
				style.Append("font-style: italic; ");
			}
		}

		// Token: 0x04000466 RID: 1126
		private global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.SS.Converter.ExcelToHtmlConverter));

		// Token: 0x04000467 RID: 1127
		private global::NPOI.SS.UserModel.DataFormatter _formatter = new global::NPOI.SS.UserModel.DataFormatter();

		// Token: 0x04000468 RID: 1128
		private string cssClassContainerCell;

		// Token: 0x04000469 RID: 1129
		private string cssClassContainerDiv;

		// Token: 0x0400046A RID: 1130
		private string cssClassTable;

		// Token: 0x0400046B RID: 1131
		private global::System.Collections.Generic.Dictionary<short, string> excelStyleToClass = new global::System.Collections.Generic.Dictionary<short, string>();

		// Token: 0x0400046C RID: 1132
		private global::NPOI.SS.HtmlDocumentFacade htmlDocumentFacade;

		// Token: 0x0400046D RID: 1133
		private bool outputColumnHeaders = true;

		// Token: 0x0400046E RID: 1134
		private bool outputHiddenColumns;

		// Token: 0x0400046F RID: 1135
		private bool outputHiddenRows;

		// Token: 0x04000470 RID: 1136
		private bool outputLeadingSpacesAsNonBreaking = true;

		// Token: 0x04000471 RID: 1137
		private bool outputRowNumbers = true;

		// Token: 0x04000472 RID: 1138
		private bool useDivsToSpan;
	}
}
