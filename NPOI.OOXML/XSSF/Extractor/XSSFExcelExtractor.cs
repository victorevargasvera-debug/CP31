using System;
using System.Globalization;
using System.Text;
using NPOI.HSSF.Extractor;
using NPOI.OpenXml4Net.OPC;
using NPOI.SS.Extractor;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Extractor
{
	// Token: 0x020000EB RID: 235
	public class XSSFExcelExtractor : global::NPOI.POIXMLTextExtractor, global::NPOI.SS.Extractor.IExcelExtractor
	{
		// Token: 0x06000E8A RID: 3722 RVA: 0x000325E6 File Offset: 0x000307E6
		public XSSFExcelExtractor(global::NPOI.OpenXml4Net.OPC.OPCPackage Container) : this(new global::NPOI.XSSF.UserModel.XSSFWorkbook(Container))
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000325F4 File Offset: 0x000307F4
		public XSSFExcelExtractor(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook) : base(workbook)
		{
			this.workbook = workbook;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00032619 File Offset: 0x00030819
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00032621 File Offset: 0x00030821
		public bool IncludeHeaderFooter
		{
			get
			{
				return this.includeHeadersFooters;
			}
			set
			{
				this.includeHeadersFooters = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0003262A File Offset: 0x0003082A
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00032632 File Offset: 0x00030832
		public bool IncludeSheetNames
		{
			get
			{
				return this.includeSheetNames;
			}
			set
			{
				this.includeSheetNames = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0003263B File Offset: 0x0003083B
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00032643 File Offset: 0x00030843
		public bool FormulasNotResults
		{
			get
			{
				return this.formulasNotResults;
			}
			set
			{
				this.formulasNotResults = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0003264C File Offset: 0x0003084C
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00032654 File Offset: 0x00030854
		public bool IncludeCellComments
		{
			get
			{
				return this.includeCellComments;
			}
			set
			{
				this.includeCellComments = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0003265D File Offset: 0x0003085D
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00032665 File Offset: 0x00030865
		public bool IncludeTextBoxes
		{
			get
			{
				return this.includeTextBoxes;
			}
			set
			{
				this.includeTextBoxes = value;
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00032632 File Offset: 0x00030832
		public void SetIncludeSheetNames(bool includeSheetNames)
		{
			this.includeSheetNames = includeSheetNames;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00032643 File Offset: 0x00030843
		public void SetFormulasNotResults(bool formulasNotResults)
		{
			this.formulasNotResults = formulasNotResults;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00032654 File Offset: 0x00030854
		public void SetIncludeCellComments(bool includeCellComments)
		{
			this.includeCellComments = includeCellComments;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00032621 File Offset: 0x00030821
		public void SetIncludeHeadersFooters(bool includeHeadersFooters)
		{
			this.includeHeadersFooters = includeHeadersFooters;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00032665 File Offset: 0x00030865
		public void SetIncludeTextBoxes(bool includeTextBoxes)
		{
			this.includeTextBoxes = includeTextBoxes;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0003266E File Offset: 0x0003086E
		public void SetLocale(global::System.Globalization.CultureInfo locale)
		{
			this.locale = locale;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00032678 File Offset: 0x00030878
		public override string Text
		{
			get
			{
				global::NPOI.SS.UserModel.DataFormatter formatter;
				if (this.locale == null)
				{
					formatter = new global::NPOI.SS.UserModel.DataFormatter();
				}
				else
				{
					formatter = new global::NPOI.SS.UserModel.DataFormatter(this.locale);
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.SS.UserModel.ISheet sheet in this.workbook)
				{
					global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)sheet;
					if (this.includeSheetNames)
					{
						stringBuilder.Append(xssfsheet.SheetName + "\n");
					}
					if (this.includeHeadersFooters)
					{
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.FirstHeader));
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.OddHeader));
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.EvenHeader));
					}
					foreach (object obj in xssfsheet)
					{
						global::NPOI.SS.UserModel.IRow row = (global::NPOI.SS.UserModel.IRow)obj;
						row.GetEnumerator();
						bool flag = true;
						for (int i = 0; i < (int)row.LastCellNum; i++)
						{
							if (!flag)
							{
								stringBuilder.Append("\t");
							}
							else
							{
								flag = false;
							}
							global::NPOI.SS.UserModel.ICell cell = row.GetCell(i);
							if (cell != null)
							{
								if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
								{
									if (this.formulasNotResults)
									{
										stringBuilder.Append(cell.CellFormula);
									}
									else if (cell.CachedFormulaResultType == global::NPOI.SS.UserModel.CellType.String)
									{
										this.HandleStringCell(stringBuilder, cell);
									}
									else
									{
										this.HandleNonStringCell(stringBuilder, cell, formatter);
									}
								}
								else if (cell.CellType == global::NPOI.SS.UserModel.CellType.String)
								{
									this.HandleStringCell(stringBuilder, cell);
								}
								else
								{
									this.HandleNonStringCell(stringBuilder, cell, formatter);
								}
								global::NPOI.SS.UserModel.IComment cellComment = cell.CellComment;
								if (this.includeCellComments && cellComment != null)
								{
									string value = cellComment.String.String.Replace('\n', ' ');
									stringBuilder.Append(" Comment by ").Append(cellComment.Author).Append(": ").Append(value);
								}
							}
						}
						stringBuilder.Append("\n");
					}
					if (this.includeTextBoxes)
					{
						global::NPOI.XSSF.UserModel.XSSFDrawing drawingPatriarch = xssfsheet.GetDrawingPatriarch();
						if (drawingPatriarch != null)
						{
							foreach (global::NPOI.XSSF.UserModel.XSSFShape xssfshape in drawingPatriarch.GetShapes())
							{
								if (xssfshape is global::NPOI.XSSF.UserModel.XSSFSimpleShape)
								{
									string text = ((global::NPOI.XSSF.UserModel.XSSFSimpleShape)xssfshape).Text;
									if (text.Length > 0)
									{
										stringBuilder.Append(text);
										stringBuilder.Append('\n');
									}
								}
							}
						}
					}
					if (this.includeHeadersFooters)
					{
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.FirstFooter));
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.OddFooter));
						stringBuilder.Append(this.ExtractHeaderFooter(xssfsheet.EvenFooter));
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00032998 File Offset: 0x00030B98
		private void HandleStringCell(global::System.Text.StringBuilder text, global::NPOI.SS.UserModel.ICell cell)
		{
			text.Append(cell.RichStringCellValue.String);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000329AC File Offset: 0x00030BAC
		private void HandleNonStringCell(global::System.Text.StringBuilder text, global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.DataFormatter formatter)
		{
			global::NPOI.SS.UserModel.CellType cellType = cell.CellType;
			if (cellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				cellType = cell.CachedFormulaResultType;
			}
			if (cellType == global::NPOI.SS.UserModel.CellType.Numeric)
			{
				global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
				if (cellStyle.GetDataFormatString() != null)
				{
					text.Append(formatter.FormatRawCellContents(cell.NumericCellValue, (int)cellStyle.DataFormat, cellStyle.GetDataFormatString()));
					return;
				}
			}
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)cell;
			text.Append(xssfcell.GetRawValue());
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00032A11 File Offset: 0x00030C11
		private string ExtractHeaderFooter(global::NPOI.SS.UserModel.IHeaderFooter hf)
		{
			return global::NPOI.HSSF.Extractor.ExcelExtractor.ExtractHeaderFooter(hf);
		}

		// Token: 0x04000453 RID: 1107
		public static global::NPOI.XSSF.UserModel.XSSFRelation[] SUPPORTED_TYPES = new global::NPOI.XSSF.UserModel.XSSFRelation[]
		{
			global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK,
			global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_TEMPLATE_WORKBOOK,
			global::NPOI.XSSF.UserModel.XSSFRelation.MACRO_ADDIN_WORKBOOK,
			global::NPOI.XSSF.UserModel.XSSFRelation.TEMPLATE_WORKBOOK,
			global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK
		};

		// Token: 0x04000454 RID: 1108
		private global::NPOI.XSSF.UserModel.XSSFWorkbook workbook;

		// Token: 0x04000455 RID: 1109
		private bool includeSheetNames = true;

		// Token: 0x04000456 RID: 1110
		private bool formulasNotResults;

		// Token: 0x04000457 RID: 1111
		private bool includeCellComments;

		// Token: 0x04000458 RID: 1112
		private bool includeHeadersFooters = true;

		// Token: 0x04000459 RID: 1113
		private bool includeTextBoxes = true;

		// Token: 0x0400045A RID: 1114
		private global::System.Globalization.CultureInfo locale;
	}
}
