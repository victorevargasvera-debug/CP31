using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.POIFS.Crypt;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009E RID: 158
	public class XSSFSheet : global::NPOI.POIXMLDocumentPart, global::NPOI.SS.UserModel.ISheet
	{
		// Token: 0x06000878 RID: 2168 RVA: 0x0001CEC6 File Offset: 0x0001B0C6
		public XSSFSheet()
		{
			this.dataValidationHelper = new global::NPOI.XSSF.UserModel.XSSFDataValidationHelper(this);
			this.OnDocumentCreate();
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0001CEEB File Offset: 0x0001B0EB
		protected internal XSSFSheet(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.dataValidationHelper = new global::NPOI.XSSF.UserModel.XSSFDataValidationHelper(this);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00014400 File Offset: 0x00012600
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		internal XSSFSheet(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0001CF0B File Offset: 0x0001B10B
		public global::NPOI.SS.UserModel.IWorkbook Workbook
		{
			get
			{
				return (global::NPOI.XSSF.UserModel.XSSFWorkbook)base.GetParent();
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001CF18 File Offset: 0x0001B118
		internal override void OnDocumentRead()
		{
			try
			{
				this.Read(base.GetPackagePart().GetInputStream());
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0001CF50 File Offset: 0x0001B150
		internal virtual void Read(global::System.IO.Stream is1)
		{
			try
			{
				global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.worksheet = global::NPOI.OpenXmlFormats.Spreadsheet.WorksheetDocument.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager).GetWorksheet();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			this.InitRows(this.worksheet);
			this.columnHelper = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper(this.worksheet);
			foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
			{
				global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
				if (documentPart is global::NPOI.XSSF.Model.CommentsTable)
				{
					this.sheetComments = (global::NPOI.XSSF.Model.CommentsTable)documentPart;
				}
				if (documentPart is global::NPOI.XSSF.UserModel.XSSFTable)
				{
					this.tables[relationPart.Relationship.Id] = (global::NPOI.XSSF.UserModel.XSSFTable)documentPart;
				}
				if (documentPart is global::NPOI.XSSF.UserModel.XSSFPivotTable)
				{
					this.GetWorkbook().PivotTables.Add((global::NPOI.XSSF.UserModel.XSSFPivotTable)documentPart);
				}
			}
			this.InitHyperlinks();
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001D050 File Offset: 0x0001B250
		internal override void OnDocumentCreate()
		{
			this.worksheet = global::NPOI.XSSF.UserModel.XSSFSheet.NewSheet();
			this.InitRows(this.worksheet);
			this.columnHelper = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper(this.worksheet);
			this.hyperlinks = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFHyperlink>();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001D088 File Offset: 0x0001B288
		private void InitRows(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheetParam)
		{
			this._rows.Clear();
			this.tables = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable>();
			this.sharedFormulas = new global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula>();
			this.arrayFormulas = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
			if (0 < worksheetParam.sheetData.SizeOfRowArray())
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row row in worksheetParam.sheetData.row)
				{
					global::NPOI.XSSF.UserModel.XSSFRow xssfrow = new global::NPOI.XSSF.UserModel.XSSFRow(row, this);
					if (!this._rows.ContainsKey(xssfrow.RowNum))
					{
						this._rows.Add(xssfrow.RowNum, xssfrow);
					}
				}
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0001D140 File Offset: 0x0001B340
		private void InitHyperlinks()
		{
			this.hyperlinks = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFHyperlink>();
			if (!this.worksheet.IsSetHyperlinks())
			{
				return;
			}
			try
			{
				global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType = base.GetPackagePart().GetRelationshipsByType(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_HYPERLINKS.Relation);
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink ct_Hyperlink in this.worksheet.hyperlinks.hyperlink)
				{
					global::NPOI.OpenXml4Net.OPC.PackageRelationship hyperlinkRel = null;
					if (ct_Hyperlink.id != null)
					{
						hyperlinkRel = relationshipsByType.GetRelationshipByID(ct_Hyperlink.id);
					}
					this.hyperlinks.Add(new global::NPOI.XSSF.UserModel.XSSFHyperlink(ct_Hyperlink, hyperlinkRel));
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001D204 File Offset: 0x0001B404
		private static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet NewSheet()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ct_Worksheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet();
			ct_Worksheet.AddNewSheetFormatPr().defaultRowHeight = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_ROW_HEIGHT;
			ct_Worksheet.AddNewSheetViews().AddNewSheetView().workbookViewId = 0U;
			ct_Worksheet.AddNewDimension().@ref = "A1";
			ct_Worksheet.AddNewSheetData();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins ct_PageMargins = ct_Worksheet.AddNewPageMargins();
			ct_PageMargins.bottom = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_BOTTOM;
			ct_PageMargins.footer = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_FOOTER;
			ct_PageMargins.header = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_HEADER;
			ct_PageMargins.left = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_LEFT;
			ct_PageMargins.right = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_RIGHT;
			ct_PageMargins.top = global::NPOI.XSSF.UserModel.XSSFSheet.DEFAULT_MARGIN_TOP;
			return ct_Worksheet;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0001D295 File Offset: 0x0001B495
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet GetCTWorksheet()
		{
			return this.worksheet;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0001D29D File Offset: 0x0001B49D
		public global::NPOI.XSSF.UserModel.Helpers.ColumnHelper GetColumnHelper()
		{
			return this.columnHelper;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0001D2A5 File Offset: 0x0001B4A5
		public string SheetName
		{
			get
			{
				return this.sheet.name;
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001D2B2 File Offset: 0x0001B4B2
		public int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this.AddMergedRegion(region, true);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0001D2BC File Offset: 0x0001B4BC
		public int AddMergedRegionUnsafe(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this.AddMergedRegion(region, false);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		private int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region, bool validate)
		{
			if (region.NumberOfCells < 2)
			{
				throw new global::System.ArgumentException("Merged region " + region.FormatAsString() + " must contain 2 or more cells");
			}
			region.Validate(global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			if (validate)
			{
				this.ValidateArrayFormulas(region);
				this.ValidateMergedRegions(region);
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells ct_MergeCells = this.worksheet.IsSetMergeCells() ? this.worksheet.mergeCells : this.worksheet.AddNewMergeCells();
			ct_MergeCells.AddNewMergeCell().@ref = region.FormatAsString();
			return ct_MergeCells.sizeOfMergeCellArray();
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001D350 File Offset: 0x0001B550
		private void ValidateArrayFormulas(global::NPOI.SS.Util.CellRangeAddress region)
		{
			int firstRow = region.FirstRow;
			int firstColumn = region.FirstColumn;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			for (int i = firstRow; i <= lastRow; i++)
			{
				global::NPOI.SS.UserModel.IRow row = this.GetRow(i);
				if (row != null)
				{
					for (int j = firstColumn; j <= lastColumn; j++)
					{
						global::NPOI.SS.UserModel.ICell cell = row.GetCell(j);
						if (cell != null && cell.IsPartOfArrayFormulaGroup)
						{
							global::NPOI.SS.Util.CellRangeAddress arrayFormulaRange = cell.ArrayFormulaRange;
							if (arrayFormulaRange.NumberOfCells > 1 && region.Intersects(arrayFormulaRange))
							{
								throw new global::System.InvalidOperationException("The range " + region.FormatAsString() + " intersects with a multi-cell array formula. You cannot merge cells of an array.");
							}
						}
					}
				}
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		private void CheckForMergedRegionsIntersectingArrayFormulas()
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress region in this.MergedRegions)
			{
				this.ValidateArrayFormulas(region);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0001D444 File Offset: 0x0001B644
		private void ValidateMergedRegions(global::NPOI.SS.Util.CellRangeAddress candidateRegion)
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.MergedRegions)
			{
				if (cellRangeAddress.Intersects(candidateRegion))
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Cannot add merged region ",
						candidateRegion.FormatAsString(),
						" to sheet because it overlaps with an existing merged region (",
						cellRangeAddress.FormatAsString(),
						")."
					}));
				}
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0001D4D4 File Offset: 0x0001B6D4
		private void CheckForIntersectingMergedRegions()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> mergedRegions = this.MergedRegions;
			int count = mergedRegions.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = mergedRegions[i];
				foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 in mergedRegions.Skip(i + 1))
				{
					if (cellRangeAddress.Intersects(cellRangeAddress2))
					{
						throw new global::System.InvalidOperationException(string.Concat(new string[]
						{
							"The range ",
							cellRangeAddress.FormatAsString(),
							" intersects with another merged region ",
							cellRangeAddress2.FormatAsString(),
							" in this sheet"
						}));
					}
				}
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0001D594 File Offset: 0x0001B794
		public void ValidateMergedRegions()
		{
			this.CheckForMergedRegionsIntersectingArrayFormulas();
			this.CheckForIntersectingMergedRegions();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0001D5A2 File Offset: 0x0001B7A2
		public void AutoSizeColumn(int column)
		{
			this.AutoSizeColumn(column, false);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0001D5AC File Offset: 0x0001B7AC
		public void AutoSizeColumn(int column, bool useMergedCells)
		{
			double num = global::NPOI.SS.Util.SheetUtil.GetColumnWidth(this, column, useMergedCells);
			if (num != -1.0)
			{
				num *= 256.0;
				int num2 = 65280;
				if (num > (double)num2)
				{
					num = (double)num2;
				}
				this.SetColumnWidth(column, (int)num);
				this.columnHelper.SetColBestFit((long)column, true);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0001D600 File Offset: 0x0001B800
		public global::NPOI.XSSF.UserModel.XSSFDrawing GetDrawingPatriarch()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing ctdrawing = this.GetCTDrawing();
			if (ctdrawing != null)
			{
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
				{
					global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
					if (documentPart is global::NPOI.XSSF.UserModel.XSSFDrawing)
					{
						global::NPOI.XSSF.UserModel.XSSFDrawing result = (global::NPOI.XSSF.UserModel.XSSFDrawing)documentPart;
						if (relationPart.Relationship.Id.Equals(ctdrawing.id))
						{
							return result;
						}
						break;
					}
				}
				global::NPOI.XSSF.UserModel.XSSFSheet.logger.Log(7, "Can't find Drawing with id=" + ctdrawing.id + " in the list of the sheet's relationships");
			}
			return null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		public global::NPOI.SS.UserModel.IDrawing CreateDrawingPatriarch()
		{
			if (this.GetCTDrawing() != null)
			{
				return this.GetDrawingPatriarch();
			}
			int idx = base.GetPackagePart().Package.GetPartsByContentType(global::NPOI.XSSF.UserModel.XSSFRelation.DRAWINGS.ContentType).Count + 1;
			global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.DRAWINGS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx, false);
			global::NPOI.XSSF.UserModel.XSSFDrawing result = relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFDrawing;
			string id = relationPart.Relationship.Id;
			this.worksheet.AddNewDrawing().id = id;
			return result;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0001D730 File Offset: 0x0001B930
		internal global::NPOI.XSSF.UserModel.XSSFVMLDrawing GetVMLDrawing(bool autoCreate)
		{
			global::NPOI.XSSF.UserModel.XSSFVMLDrawing xssfvmldrawing = null;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing ct_LegacyDrawing = this.GetCTLegacyDrawing();
			if (ct_LegacyDrawing == null)
			{
				if (autoCreate)
				{
					int idx = base.GetPackagePart().Package.GetPartsByContentType(global::NPOI.XSSF.UserModel.XSSFRelation.VML_DRAWINGS.ContentType).Count + 1;
					global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.VML_DRAWINGS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx, false);
					xssfvmldrawing = (relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFVMLDrawing);
					string id = relationPart.Relationship.Id;
					ct_LegacyDrawing = this.worksheet.AddNewLegacyDrawing();
					ct_LegacyDrawing.id = id;
				}
			}
			else
			{
				string id2 = ct_LegacyDrawing.id;
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart2 in base.RelationParts)
				{
					global::NPOI.POIXMLDocumentPart documentPart = relationPart2.DocumentPart;
					if (documentPart is global::NPOI.XSSF.UserModel.XSSFVMLDrawing)
					{
						global::NPOI.XSSF.UserModel.XSSFVMLDrawing xssfvmldrawing2 = (global::NPOI.XSSF.UserModel.XSSFVMLDrawing)documentPart;
						if (relationPart2.Relationship.Id.Equals(id2))
						{
							xssfvmldrawing = xssfvmldrawing2;
							break;
						}
					}
				}
				if (xssfvmldrawing == null)
				{
					global::NPOI.XSSF.UserModel.XSSFSheet.logger.Log(7, "Can't find VML drawing with id=" + id2 + " in the list of the sheet's relationships");
				}
			}
			return xssfvmldrawing;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0001D850 File Offset: 0x0001BA50
		protected virtual global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing GetCTDrawing()
		{
			return this.worksheet.drawing;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0001D85D File Offset: 0x0001BA5D
		protected virtual global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing GetCTLegacyDrawing()
		{
			return this.worksheet.legacyDrawing;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0001D86A File Offset: 0x0001BA6A
		public void CreateFreezePane(int colSplit, int rowSplit)
		{
			this.CreateFreezePane(colSplit, rowSplit, colSplit, rowSplit);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0001D878 File Offset: 0x0001BA78
		public void CreateFreezePane(int colSplit, int rowSplit, int leftmostColumn, int topRow)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView defaultSheetView = this.GetDefaultSheetView();
			if (colSplit == 0 && rowSplit == 0)
			{
				if (defaultSheetView.IsSetPane())
				{
					defaultSheetView.UnsetPane();
				}
				defaultSheetView.SetSelectionArray(null);
				return;
			}
			if (!defaultSheetView.IsSetPane())
			{
				defaultSheetView.AddNewPane();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane pane = defaultSheetView.pane;
			if (colSplit > 0)
			{
				pane.xSplit = (double)colSplit;
			}
			else if (pane.IsSetXSplit())
			{
				pane.UnsetXSplit();
			}
			if (rowSplit > 0)
			{
				pane.ySplit = (double)rowSplit;
			}
			else if (pane.IsSetYSplit())
			{
				pane.UnsetYSplit();
			}
			pane.state = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState.frozen;
			if (rowSplit == 0)
			{
				pane.topLeftCell = new global::NPOI.SS.Util.CellReference(0, leftmostColumn).FormatAsString();
				pane.activePane = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topRight;
			}
			else if (colSplit == 0)
			{
				pane.topLeftCell = new global::NPOI.SS.Util.CellReference(topRow, 0).FormatAsString();
				pane.activePane = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.bottomLeft;
			}
			else
			{
				pane.topLeftCell = new global::NPOI.SS.Util.CellReference(topRow, leftmostColumn).FormatAsString();
				pane.activePane = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.bottomRight;
			}
			defaultSheetView.selection = null;
			defaultSheetView.AddNewSelection().pane = pane.activePane;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0001D96C File Offset: 0x0001BB6C
		private int GetLastKey(global::System.Collections.Generic.IList<int> keys)
		{
			int count = keys.Count;
			return keys[keys.Count - 1];
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0001D984 File Offset: 0x0001BB84
		private int HeadMapCount(global::System.Collections.Generic.SortedList<int, global::NPOI.XSSF.UserModel.XSSFRow> rows, int rownum)
		{
			int num = 0;
			using (global::System.Collections.Generic.IEnumerator<int> enumerator = rows.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext() && enumerator.Current < rownum)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0001D9D4 File Offset: 0x0001BBD4
		public virtual global::NPOI.SS.UserModel.IRow CreateRow(int rownum)
		{
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow = this._rows.ContainsKey(rownum) ? this._rows[rownum] : null;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row;
			if (xssfrow != null)
			{
				while (xssfrow.FirstCellNum != -1)
				{
					xssfrow.RemoveCell(xssfrow.GetCell((int)xssfrow.FirstCellNum));
				}
				ct_Row = xssfrow.GetCTRow();
				ct_Row.Set(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row());
			}
			else if (this._rows.Count == 0 || rownum > this.GetLastKey(this._rows.Keys))
			{
				ct_Row = this.worksheet.sheetData.AddNewRow();
			}
			else
			{
				int index = this.HeadMapCount(this._rows, rownum);
				ct_Row = this.worksheet.sheetData.InsertNewRow(index);
			}
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow2 = new global::NPOI.XSSF.UserModel.XSSFRow(ct_Row, this);
			xssfrow2.RowNum = rownum;
			this._rows[rownum] = xssfrow2;
			return xssfrow2;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		public void CreateSplitPane(int xSplitPos, int ySplitPos, int leftmostColumn, int topRow, global::NPOI.SS.UserModel.PanePosition activePane)
		{
			this.CreateFreezePane(xSplitPos, ySplitPos, leftmostColumn, topRow);
			this.GetPane().state = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState.split;
			this.GetPane().activePane = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane)activePane;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0001DACA File Offset: 0x0001BCCA
		[global::System.Obsolete("deprecated as of 2015-11-23 (circa POI 3.14beta1). Use {@link #getCellComment(CellAddress)} instead.")]
		public global::NPOI.SS.UserModel.IComment GetCellComment(int row, int column)
		{
			return this.GetCellComment(new global::NPOI.SS.Util.CellAddress(row, column));
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0001DADC File Offset: 0x0001BCDC
		public global::NPOI.SS.UserModel.IComment GetCellComment(global::NPOI.SS.Util.CellAddress address)
		{
			if (this.sheetComments == null)
			{
				return null;
			}
			int row = address.Row;
			int column = address.Column;
			global::NPOI.SS.Util.CellAddress cellRef = new global::NPOI.SS.Util.CellAddress(row, column);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ctcomment = this.sheetComments.GetCTComment(cellRef);
			if (ctcomment == null)
			{
				return null;
			}
			global::NPOI.XSSF.UserModel.XSSFVMLDrawing vmldrawing = this.GetVMLDrawing(false);
			return new global::NPOI.XSSF.UserModel.XSSFComment(this.sheetComments, ctcomment, (vmldrawing == null) ? null : vmldrawing.FindCommentShape(row, column));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0001DB40 File Offset: 0x0001BD40
		public global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> GetCellComments()
		{
			if (this.sheetComments == null)
			{
				return new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment>();
			}
			return this.sheetComments.GetCellComments();
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0001DB5B File Offset: 0x0001BD5B
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(int row, int column)
		{
			return this.GetHyperlink(new global::NPOI.SS.Util.CellAddress(row, column));
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(global::NPOI.SS.Util.CellAddress addr)
		{
			string value = addr.FormatAsString();
			foreach (global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink in this.hyperlinks)
			{
				if (xssfhyperlink.CellRef.Equals(value))
				{
					return xssfhyperlink;
				}
			}
			return null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink> GetHyperlinkList()
		{
			return this.hyperlinks.ToList<global::NPOI.SS.UserModel.IHyperlink>();
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
		public int[] ColumnBreaks
		{
			get
			{
				if (!this.worksheet.IsSetColBreaks() || this.worksheet.colBreaks.sizeOfBrkArray() == 0)
				{
					return new int[0];
				}
				global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brk = this.worksheet.colBreaks.brk;
				int[] array = new int[brk.Count];
				for (int i = 0; i < brk.Count; i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break = brk[i];
					array[i] = (int)(ct_Break.id - 1U);
				}
				return array;
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001DC5C File Offset: 0x0001BE5C
		public int GetColumnWidth(int columnIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)columnIndex, false);
			return (int)(((column == null || !column.IsSetWidth()) ? ((double)this.DefaultColumnWidth) : column.width) * 256.0);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001DC9D File Offset: 0x0001BE9D
		public float GetColumnWidthInPixels(int columnIndex)
		{
			return (float)((double)((float)this.GetColumnWidth(columnIndex)) / 256.0 * (double)global::NPOI.XSSF.UserModel.XSSFWorkbook.DEFAULT_CHARACTER_WIDTH);
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
		public int DefaultColumnWidth
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPr = this.worksheet.sheetFormatPr;
				if (sheetFormatPr != null)
				{
					return (int)sheetFormatPr.baseColWidth;
				}
				return 8;
			}
			set
			{
				this.GetSheetTypeSheetFormatPr().baseColWidth = (uint)value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0001DCEE File Offset: 0x0001BEEE
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x0001DD0F File Offset: 0x0001BF0F
		public short DefaultRowHeight
		{
			get
			{
				return (short)((decimal)this.DefaultRowHeightInPoints * global::NPOI.XSSF.UserModel.XSSFSheet.TWIPS_PER_POINT);
			}
			set
			{
				this.DefaultRowHeightInPoints = (float)value / (float)global::NPOI.XSSF.UserModel.XSSFSheet.TWIPS_PER_POINT;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0001DD20 File Offset: 0x0001BF20
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x0001DD4E File Offset: 0x0001BF4E
		public float DefaultRowHeightInPoints
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetFormatPr = this.worksheet.sheetFormatPr;
				return (float)((sheetFormatPr == null) ? 0.0 : sheetFormatPr.defaultRowHeight);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr sheetTypeSheetFormatPr = this.GetSheetTypeSheetFormatPr();
				sheetTypeSheetFormatPr.defaultRowHeight = (double)value;
				sheetTypeSheetFormatPr.customHeight = true;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0001DD64 File Offset: 0x0001BF64
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr GetSheetTypeSheetFormatPr()
		{
			if (!this.worksheet.IsSetSheetFormatPr())
			{
				return this.worksheet.AddNewSheetFormatPr();
			}
			return this.worksheet.sheetFormatPr;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0001DD8C File Offset: 0x0001BF8C
		public global::NPOI.SS.UserModel.ICellStyle GetColumnStyle(int column)
		{
			int colDefaultStyle = this.columnHelper.GetColDefaultStyle((long)column);
			return this.Workbook.GetCellStyleAt((colDefaultStyle == -1) ? 0 : colDefaultStyle);
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x0001DDDB File Offset: 0x0001BFDB
		public bool RightToLeft
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView defaultSheetView = this.GetDefaultSheetView();
				return defaultSheetView != null && defaultSheetView.rightToLeft;
			}
			set
			{
				this.GetDefaultSheetView().rightToLeft = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x0001DE1C File Offset: 0x0001C01C
		public bool DisplayGuts
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
				return ((sheetTypeSheetPr.outlinePr == null) ? new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr() : sheetTypeSheetPr.outlinePr).showOutlineSymbols;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
				((sheetTypeSheetPr.outlinePr == null) ? sheetTypeSheetPr.AddNewOutlinePr() : sheetTypeSheetPr.outlinePr).showOutlineSymbols = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0001DE4C File Offset: 0x0001C04C
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x0001DE6B File Offset: 0x0001C06B
		public bool DisplayZeros
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView defaultSheetView = this.GetDefaultSheetView();
				return defaultSheetView == null || defaultSheetView.showZeros;
			}
			set
			{
				this.GetSheetTypeSheetView().showZeros = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0001DE7C File Offset: 0x0001C07C
		public int FirstRowNum
		{
			get
			{
				if (this._rows.Count == 0)
				{
					return 0;
				}
				using (global::System.Collections.Generic.IEnumerator<int> enumerator = this._rows.Keys.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return enumerator.Current;
					}
				}
				throw new global::System.ArgumentOutOfRangeException();
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0001DF11 File Offset: 0x0001C111
		public bool FitToPage
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
				return ((sheetTypeSheetPr == null || !sheetTypeSheetPr.IsSetPageSetUpPr()) ? new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr() : sheetTypeSheetPr.pageSetUpPr).fitToPage;
			}
			set
			{
				this.GetSheetTypePageSetUpPr().fitToPage = value;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0001DF1F File Offset: 0x0001C11F
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr GetSheetTypeSheetPr()
		{
			if (this.worksheet.sheetPr == null)
			{
				this.worksheet.sheetPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
			}
			return this.worksheet.sheetPr;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0001DF49 File Offset: 0x0001C149
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter GetSheetTypeHeaderFooter()
		{
			if (this.worksheet.headerFooter == null)
			{
				this.worksheet.headerFooter = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter();
			}
			return this.worksheet.headerFooter;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0001DF73 File Offset: 0x0001C173
		public global::NPOI.SS.UserModel.IFooter Footer
		{
			get
			{
				return this.OddFooter;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0001DF7B File Offset: 0x0001C17B
		public global::NPOI.SS.UserModel.IHeader Header
		{
			get
			{
				return this.OddHeader;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0001DF83 File Offset: 0x0001C183
		public global::NPOI.SS.UserModel.IFooter OddFooter
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFOddFooter(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0001DF90 File Offset: 0x0001C190
		public global::NPOI.SS.UserModel.IFooter EvenFooter
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFEvenFooter(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0001DF9D File Offset: 0x0001C19D
		public global::NPOI.SS.UserModel.IFooter FirstFooter
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFFirstFooter(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0001DFAA File Offset: 0x0001C1AA
		public global::NPOI.SS.UserModel.IHeader OddHeader
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFOddHeader(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0001DFB7 File Offset: 0x0001C1B7
		public global::NPOI.SS.UserModel.IHeader EvenHeader
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFEvenHeader(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		public global::NPOI.SS.UserModel.IHeader FirstHeader
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFFirstHeader(this.GetSheetTypeHeaderFooter());
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
		public bool HorizontallyCenter
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions = this.worksheet.printOptions;
				return printOptions != null && printOptions.horizontalCentered;
			}
			set
			{
				(this.worksheet.IsSetPrintOptions() ? this.worksheet.printOptions : this.worksheet.AddNewPrintOptions()).horizontalCentered = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0001E025 File Offset: 0x0001C225
		public int LastRowNum
		{
			get
			{
				if (this._rows.Count != 0)
				{
					return this.GetLastKey(this._rows.Keys);
				}
				return 0;
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001E048 File Offset: 0x0001C248
		public double GetMargin(global::NPOI.SS.UserModel.MarginType margin)
		{
			if (!this.worksheet.IsSetPageMargins())
			{
				return 0.0;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMargins = this.worksheet.pageMargins;
			switch (margin)
			{
			case global::NPOI.SS.UserModel.MarginType.LeftMargin:
				return pageMargins.left;
			case global::NPOI.SS.UserModel.MarginType.RightMargin:
				return pageMargins.right;
			case global::NPOI.SS.UserModel.MarginType.TopMargin:
				return pageMargins.top;
			case global::NPOI.SS.UserModel.MarginType.BottomMargin:
				return pageMargins.bottom;
			case global::NPOI.SS.UserModel.MarginType.HeaderMargin:
				return pageMargins.header;
			case global::NPOI.SS.UserModel.MarginType.FooterMargin:
				return pageMargins.footer;
			default:
				throw new global::System.ArgumentException("Unknown margin constant:  " + margin.ToString());
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		public void SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins ct_PageMargins = this.worksheet.IsSetPageMargins() ? this.worksheet.pageMargins : this.worksheet.AddNewPageMargins();
			switch (margin)
			{
			case global::NPOI.SS.UserModel.MarginType.LeftMargin:
				ct_PageMargins.left = size;
				return;
			case global::NPOI.SS.UserModel.MarginType.RightMargin:
				ct_PageMargins.right = size;
				return;
			case global::NPOI.SS.UserModel.MarginType.TopMargin:
				ct_PageMargins.top = size;
				return;
			case global::NPOI.SS.UserModel.MarginType.BottomMargin:
				ct_PageMargins.bottom = size;
				return;
			case global::NPOI.SS.UserModel.MarginType.HeaderMargin:
				ct_PageMargins.header = size;
				return;
			case global::NPOI.SS.UserModel.MarginType.FooterMargin:
				ct_PageMargins.footer = size;
				return;
			default:
				throw new global::System.InvalidOperationException("Unknown margin constant:  " + margin.ToString());
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0001E180 File Offset: 0x0001C380
		public global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells = this.worksheet.mergeCells;
			if (mergeCells == null)
			{
				throw new global::System.InvalidOperationException("This worksheet does not contain merged regions");
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell mergeCellArray = mergeCells.GetMergeCellArray(index);
			if (mergeCellArray == null)
			{
				return null;
			}
			return global::NPOI.SS.Util.CellRangeAddress.ValueOf(mergeCellArray.@ref);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		public global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion)
		{
			if (this.worksheet.mergeCells == null || this.worksheet.mergeCells.mergeCell == null)
			{
				return null;
			}
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell ct_MergeCell in this.worksheet.mergeCells.mergeCell)
			{
				if (ct_MergeCell != null && !string.IsNullOrEmpty(ct_MergeCell.@ref))
				{
					global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(ct_MergeCell.@ref);
					if (cellRangeAddress.FirstColumn <= mergedRegion.FirstColumn && cellRangeAddress.LastColumn >= mergedRegion.LastColumn && cellRangeAddress.FirstRow <= mergedRegion.FirstRow && cellRangeAddress.LastRow >= mergedRegion.LastRow)
					{
						return cellRangeAddress;
					}
				}
			}
			return null;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0001E294 File Offset: 0x0001C494
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergedRegions
		{
			get
			{
				global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells = this.worksheet.mergeCells;
				if (mergeCells == null)
				{
					return list;
				}
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell ct_MergeCell in mergeCells.mergeCell)
				{
					string @ref = ct_MergeCell.@ref;
					list.Add(global::NPOI.SS.Util.CellRangeAddress.ValueOf(@ref));
				}
				return list;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0001E30C File Offset: 0x0001C50C
		public int NumMergedRegions
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells = this.worksheet.mergeCells;
				if (mergeCells != null)
				{
					return mergeCells.sizeOfMergeCellArray();
				}
				return 0;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0001E330 File Offset: 0x0001C530
		public int NumHyperlinks
		{
			get
			{
				return this.hyperlinks.Count;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0001E340 File Offset: 0x0001C540
		public global::NPOI.SS.Util.PaneInformation PaneInformation
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane pane = this.GetDefaultSheetView().pane;
				if (pane == null)
				{
					return null;
				}
				global::NPOI.SS.Util.CellReference cellReference = pane.IsSetTopLeftCell() ? new global::NPOI.SS.Util.CellReference(pane.topLeftCell) : null;
				return new global::NPOI.SS.Util.PaneInformation((short)pane.xSplit, (short)pane.ySplit, (cellReference == null) ? 0 : ((short)cellReference.Row), (cellReference == null) ? 0 : cellReference.Col, (byte)pane.activePane, pane.state == global::NPOI.OpenXmlFormats.Spreadsheet.ST_PaneState.frozen);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0001E3B1 File Offset: 0x0001C5B1
		public int PhysicalNumberOfRows
		{
			get
			{
				return this._rows.Count;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0001E3BE File Offset: 0x0001C5BE
		public global::NPOI.SS.UserModel.IPrintSetup PrintSetup
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFPrintSetup(this.worksheet);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0001E3CB File Offset: 0x0001C5CB
		public bool Protect
		{
			get
			{
				return this.IsSheetLocked;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001E3D3 File Offset: 0x0001C5D3
		public void ProtectSheet(string password)
		{
			if (password != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection ct_SheetProtection = this.worksheet.AddNewSheetProtection();
				this.SetSheetPassword(password, null);
				ct_SheetProtection.sheet = true;
				ct_SheetProtection.scenarios = true;
				ct_SheetProtection.objects = true;
				return;
			}
			this.worksheet.UnsetSheetProtection();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001E40B File Offset: 0x0001C60B
		public void SetSheetPassword(string password, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgo)
		{
			if (password == null && !this.IsSheetProtectionEnabled())
			{
				return;
			}
			global::NPOI.XSSF.UserModel.Helpers.XSSFPasswordHelper.SetPassword(this.SafeGetProtectionField(), password, hashAlgo, null);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001E427 File Offset: 0x0001C627
		public bool ValidateSheetPassword(string password)
		{
			if (!this.IsSheetProtectionEnabled())
			{
				return password == null;
			}
			return global::NPOI.XSSF.UserModel.Helpers.XSSFPasswordHelper.ValidatePassword(this.SafeGetProtectionField(), password, null);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001E443 File Offset: 0x0001C643
		public global::NPOI.SS.UserModel.IRow GetRow(int rownum)
		{
			if (this._rows.ContainsKey(rownum))
			{
				return this._rows[rownum];
			}
			return null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001E464 File Offset: 0x0001C664
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFRow> GetRows(int startRowNum, int endRowNum, bool createRowIfMissing)
		{
			if (startRowNum > endRowNum)
			{
				throw new global::System.ArgumentException("getRows: startRowNum must be less than or equal to endRowNum");
			}
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFRow> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFRow>();
			if (createRowIfMissing)
			{
				for (int i = startRowNum; i <= endRowNum; i++)
				{
					global::NPOI.XSSF.UserModel.XSSFRow xssfrow = this.GetRow(i) as global::NPOI.XSSF.UserModel.XSSFRow;
					if (xssfrow == null)
					{
						xssfrow = (this.CreateRow(i) as global::NPOI.XSSF.UserModel.XSSFRow);
					}
					list.Add(xssfrow);
				}
			}
			else
			{
				list.AddRange(from x in this._rows.SkipWhile((global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> x) => x.Key < startRowNum).TakeWhile((global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> x) => x.Key < endRowNum + 1)
				select x.Value);
			}
			return list;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0001E538 File Offset: 0x0001C738
		public int[] RowBreaks
		{
			get
			{
				if (!this.worksheet.IsSetRowBreaks() || this.worksheet.rowBreaks.sizeOfBrkArray() == 0)
				{
					return new int[0];
				}
				global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brk = this.worksheet.rowBreaks.brk;
				int[] array = new int[brk.Count];
				for (int i = 0; i < brk.Count; i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break = brk[i];
					array[i] = (int)(ct_Break.id - 1U);
				}
				return array;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0001E5B0 File Offset: 0x0001C7B0
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0001E5E9 File Offset: 0x0001C7E9
		public bool RowSumsBelow
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPr = this.worksheet.sheetPr;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr ct_OutlinePr = (sheetPr != null && sheetPr.IsSetOutlinePr()) ? sheetPr.outlinePr : null;
				return ct_OutlinePr == null || ct_OutlinePr.summaryBelow;
			}
			set
			{
				this.ensureOutlinePr().summaryBelow = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0001E62E File Offset: 0x0001C82E
		public bool RowSumsRight
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetPr = this.worksheet.sheetPr;
				return ((sheetPr != null && sheetPr.IsSetOutlinePr()) ? sheetPr.outlinePr : new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr()).summaryRight;
			}
			set
			{
				this.ensureOutlinePr().summaryRight = value;
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001E63C File Offset: 0x0001C83C
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr ensureOutlinePr()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = this.worksheet.IsSetSheetPr() ? this.worksheet.sheetPr : this.worksheet.AddNewSheetPr();
			if (!ct_SheetPr.IsSetOutlinePr())
			{
				return ct_SheetPr.AddNewOutlinePr();
			}
			return ct_SheetPr.outlinePr;
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0001E684 File Offset: 0x0001C884
		public bool ScenarioProtect
		{
			get
			{
				return this.worksheet.IsSetSheetProtection() && this.worksheet.sheetProtection.scenarios;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000065E4 File Offset: 0x000047E4
		public short LeftCol
		{
			get
			{
				string topLeftCell = this.GetPane().topLeftCell;
				if (topLeftCell == null)
				{
					return 0;
				}
				return new global::NPOI.SS.Util.CellReference(topLeftCell).Col;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000065E4 File Offset: 0x000047E4
		public short TopRow
		{
			get
			{
				string topLeftCell = this.GetSheetTypeSheetView().topLeftCell;
				if (topLeftCell == null)
				{
					return 0;
				}
				return (short)new global::NPOI.SS.Util.CellReference(topLeftCell).Row;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0001E700 File Offset: 0x0001C900
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0001E724 File Offset: 0x0001C924
		public bool VerticallyCenter
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions = this.worksheet.printOptions;
				return printOptions != null && printOptions.verticalCentered;
			}
			set
			{
				(this.worksheet.IsSetPrintOptions() ? this.worksheet.printOptions : this.worksheet.AddNewPrintOptions()).verticalCentered = value;
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0001E751 File Offset: 0x0001C951
		public void GroupColumn(int fromColumn, int toColumn)
		{
			this.GroupColumn1Based(fromColumn + 1, toColumn + 1);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0001E760 File Offset: 0x0001C960
		private void GroupColumn1Based(int fromColumn, int toColumn)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col2 = this.columnHelper.GetColumn1Based((long)toColumn, false);
			if (ct_Col2 != null)
			{
				ct_Col2 = ct_Col2.Copy();
			}
			ct_Col.min = (uint)fromColumn;
			ct_Col.max = (uint)toColumn;
			this.columnHelper.AddCleanColIntoCols(colsArray, ct_Col);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column1Based = this.columnHelper.GetColumn1Based((long)toColumn, false);
			if (ct_Col2 != null && column1Based != null)
			{
				this.columnHelper.SetColumnAttributes(ct_Col2, column1Based);
			}
			for (int i = fromColumn; i <= toColumn; i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column1Based2 = this.columnHelper.GetColumn1Based((long)i, false);
				short outlineLevel = (short)column1Based2.outlineLevel;
				column1Based2.outlineLevel = (byte)(outlineLevel + 1);
				i = (int)column1Based2.max;
			}
			this.worksheet.SetColsArray(0, colsArray);
			this.SetSheetFormatPrOutlineLevelCol();
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001E824 File Offset: 0x0001CA24
		private void SetColWidthAttribute(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ctCols)
		{
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in ctCols.GetColList())
			{
				if (!ct_Col.IsSetWidth())
				{
					ct_Col.width = (double)this.DefaultColumnWidth;
					ct_Col.customWidth = false;
				}
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public void GroupRow(int fromRow, int toRow)
		{
			for (int i = fromRow; i <= toRow; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i);
				if (xssfrow == null)
				{
					xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.CreateRow(i);
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ctrow = xssfrow.GetCTRow();
				short outlineLevel = (short)ctrow.outlineLevel;
				ctrow.outlineLevel = (byte)(outlineLevel + 1);
			}
			this.SetSheetFormatPrOutlineLevelRow();
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001E8E0 File Offset: 0x0001CAE0
		private short GetMaxOutlineLevelRows()
		{
			short num = 0;
			foreach (global::NPOI.XSSF.UserModel.XSSFRow xssfrow in this._rows.Values)
			{
				num = (((short)xssfrow.GetCTRow().outlineLevel > num) ? ((short)xssfrow.GetCTRow().outlineLevel) : num);
			}
			return num;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001E94C File Offset: 0x0001CB4C
		[global::System.Obsolete]
		private short GetMaxOutlineLevelCols()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			short num = 0;
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in colsArray.GetColList())
			{
				num = (((short)ct_Col.outlineLevel > num) ? ((short)ct_Col.outlineLevel) : num);
			}
			return num;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		public bool IsColumnBroken(int column)
		{
			int[] columnBreaks = this.ColumnBreaks;
			for (int i = 0; i < columnBreaks.Length; i++)
			{
				if (columnBreaks[i] == column)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		public bool IsColumnHidden(int columnIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)columnIndex, false);
			return column != null && column.hidden;
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0001EA0F File Offset: 0x0001CC0F
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		public bool DisplayFormulas
		{
			get
			{
				return this.GetSheetTypeSheetView().showFormulas;
			}
			set
			{
				this.GetSheetTypeSheetView().showFormulas = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0001EA2A File Offset: 0x0001CC2A
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0001EA37 File Offset: 0x0001CC37
		public bool DisplayGridlines
		{
			get
			{
				return this.GetSheetTypeSheetView().showGridLines;
			}
			set
			{
				this.GetSheetTypeSheetView().showGridLines = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0001EA45 File Offset: 0x0001CC45
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0001EA52 File Offset: 0x0001CC52
		public bool DisplayRowColHeadings
		{
			get
			{
				return this.GetSheetTypeSheetView().showRowColHeaders;
			}
			set
			{
				this.GetSheetTypeSheetView().showRowColHeaders = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0001EA60 File Offset: 0x0001CC60
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0001EA84 File Offset: 0x0001CC84
		public bool IsPrintGridlines
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions = this.worksheet.printOptions;
				return printOptions != null && printOptions.gridLines;
			}
			set
			{
				(this.worksheet.IsSetPrintOptions() ? this.worksheet.printOptions : this.worksheet.AddNewPrintOptions()).gridLines = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0001EAB4 File Offset: 0x0001CCB4
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		public bool IsPrintRowAndColumnHeadings
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions printOptions = this.worksheet.printOptions;
				return printOptions != null && printOptions.headings;
			}
			set
			{
				(this.worksheet.IsSetPrintOptions() ? this.worksheet.printOptions : this.worksheet.AddNewPrintOptions()).headings = value;
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001EB08 File Offset: 0x0001CD08
		public bool IsRowBroken(int row)
		{
			int[] rowBreaks = this.RowBreaks;
			for (int i = 0; i < rowBreaks.Length; i++)
			{
				if (rowBreaks[i] == row)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001EB34 File Offset: 0x0001CD34
		public void SetRowBreak(int row)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak ct_PageBreak = this.worksheet.IsSetRowBreaks() ? this.worksheet.rowBreaks : this.worksheet.AddNewRowBreaks();
			if (!this.IsRowBroken(row))
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break = ct_PageBreak.AddNewBrk();
				ct_Break.id = (uint)(row + 1);
				ct_Break.man = true;
				ct_Break.max = (uint)global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastColumnIndex;
				ct_PageBreak.count = (uint)ct_PageBreak.sizeOfBrkArray();
				ct_PageBreak.manualBreakCount = (uint)ct_PageBreak.sizeOfBrkArray();
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		public void RemoveColumnBreak(int column)
		{
			if (!this.worksheet.IsSetColBreaks())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak colBreaks = this.worksheet.colBreaks;
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brk = colBreaks.brk;
			for (int i = 0; i < brk.Count; i++)
			{
				if ((ulong)brk[i].id == (ulong)((long)(column + 1)))
				{
					colBreaks.RemoveBrk(i);
				}
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001EC0C File Offset: 0x0001CE0C
		public void RemoveMergedRegion(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells = this.worksheet.mergeCells;
			int num = mergeCells.sizeOfMergeCellArray();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell[num - 1];
			for (int i = 0; i < num; i++)
			{
				if (i < index)
				{
					array[i] = mergeCells.GetMergeCellArray(i);
				}
				else if (i > index)
				{
					array[i - 1] = mergeCells.GetMergeCellArray(i);
				}
			}
			if (array.Length != 0)
			{
				mergeCells.SetMergeCellArray(array);
				return;
			}
			this.worksheet.UnsetMergeCells();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001EC78 File Offset: 0x0001CE78
		public void RemoveMergedRegions(global::System.Collections.Generic.IList<int> indices)
		{
			if (!this.worksheet.IsSetMergeCells())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells mergeCells = this.worksheet.mergeCells;
			int num = mergeCells.sizeOfMergeCellArray();
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell>(mergeCells.sizeOfMergeCellArray());
			int i = 0;
			int num2 = 0;
			while (i < num)
			{
				if (!indices.Contains(i))
				{
					list.Add(mergeCells.GetMergeCellArray(i));
					num2++;
				}
				i++;
			}
			if (this.ListIsEmpty(list))
			{
				this.worksheet.UnsetMergeCells();
				return;
			}
			mergeCells.SetMergeCellArray(list.ToArray());
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001ED00 File Offset: 0x0001CF00
		private bool ListIsEmpty(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell> list)
		{
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0001ED50 File Offset: 0x0001CF50
		public void RemoveRow(global::NPOI.SS.UserModel.IRow row)
		{
			if (row.Sheet != this)
			{
				throw new global::System.ArgumentException("Specified row does not belong to this sheet");
			}
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFCell> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFCell>();
			foreach (global::NPOI.SS.UserModel.ICell cell in row)
			{
				list.Add((global::NPOI.XSSF.UserModel.XSSFCell)cell);
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFCell cell2 in list)
			{
				row.RemoveCell(cell2);
			}
			int num = this._rows.Count((global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> p) => p.Key < row.RowNum);
			this._rows.Remove(row.RowNum);
			this.worksheet.sheetData.RemoveRow(row.RowNum + 1);
			if (this.sheetComments != null)
			{
				foreach (global::NPOI.SS.Util.CellAddress cellAddress in this.GetCellComments().Keys)
				{
					if (cellAddress.Row == num)
					{
						this.sheetComments.RemoveComment(cellAddress);
					}
				}
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		public void RemoveRowBreak(int row)
		{
			if (!this.worksheet.IsSetRowBreaks())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak rowBreaks = this.worksheet.rowBreaks;
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break> brk = rowBreaks.brk;
			for (int i = 0; i < brk.Count; i++)
			{
				if ((ulong)brk[i].id == (ulong)((long)(row + 1)))
				{
					rowBreaks.RemoveBrk(i);
				}
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0001EF1D File Offset: 0x0001D11D
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0001EF40 File Offset: 0x0001D140
		public bool ForceFormulaRecalculation
		{
			get
			{
				return this.worksheet.IsSetSheetCalcPr() && this.worksheet.sheetCalcPr.fullCalcOnLoad;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr calcPr = (this.Workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook).GetCTWorkbook().calcPr;
				if (this.worksheet.IsSetSheetCalcPr())
				{
					this.worksheet.sheetCalcPr.fullCalcOnLoad = value;
				}
				else if (value)
				{
					this.worksheet.AddNewSheetCalcPr().fullCalcOnLoad = value;
				}
				if (value && calcPr != null && calcPr.calcMode == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.manual)
				{
					calcPr.calcMode = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.auto;
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
		public bool Autobreaks
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
				return ((sheetTypeSheetPr == null || !sheetTypeSheetPr.IsSetPageSetUpPr()) ? new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr() : sheetTypeSheetPr.pageSetUpPr).autoPageBreaks;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
				(sheetTypeSheetPr.IsSetPageSetUpPr() ? sheetTypeSheetPr.pageSetUpPr : sheetTypeSheetPr.AddNewPageSetUpPr()).autoPageBreaks = value;
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0001F010 File Offset: 0x0001D210
		public void SetColumnBreak(int column)
		{
			if (!this.IsColumnBroken(column))
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak ct_PageBreak = this.worksheet.IsSetColBreaks() ? this.worksheet.colBreaks : this.worksheet.AddNewColBreaks();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break ct_Break = ct_PageBreak.AddNewBrk();
				ct_Break.id = (uint)(column + 1);
				ct_Break.man = true;
				ct_Break.max = (uint)global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastRowIndex;
				ct_PageBreak.count = (uint)ct_PageBreak.sizeOfBrkArray();
				ct_PageBreak.manualBreakCount = (uint)ct_PageBreak.sizeOfBrkArray();
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001F087 File Offset: 0x0001D287
		public void SetColumnGroupCollapsed(int columnNumber, bool collapsed)
		{
			if (collapsed)
			{
				this.CollapseColumn(columnNumber);
				return;
			}
			this.ExpandColumn(columnNumber);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001F09C File Offset: 0x0001D29C
		private void CollapseColumn(int columnNumber)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)columnNumber, false);
			int indexOfColumn = this.columnHelper.GetIndexOfColumn(colsArray, column);
			if (indexOfColumn == -1)
			{
				return;
			}
			int num = this.FindStartOfColumnOutlineGroup(indexOfColumn);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(num);
			int num2 = this.SetGroupHidden(num, (int)colArray.outlineLevel, true);
			this.SetColumn(num2 + 1, null, new int?(0), null, null, new bool?(true));
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001F130 File Offset: 0x0001D330
		private void SetColumn(int targetColumnIx, short? xfIndex, int? style, int? level, bool? hidden, bool? collapsed)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = null;
			int i;
			for (i = 0; i < colsArray.sizeOfColArray(); i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(i);
				if ((ulong)colArray.min >= (ulong)((long)targetColumnIx) && (ulong)colArray.max <= (ulong)((long)targetColumnIx))
				{
					ct_Col = colArray;
					break;
				}
				if ((ulong)colArray.min > (ulong)((long)targetColumnIx))
				{
					break;
				}
			}
			if (ct_Col == null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col2 = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col();
				ct_Col2.min = (uint)targetColumnIx;
				ct_Col2.max = (uint)targetColumnIx;
				this.UnsetCollapsed(collapsed.Value, ct_Col2);
				this.columnHelper.AddCleanColIntoCols(colsArray, ct_Col2);
				return;
			}
			bool flag;
			if (style != null)
			{
				uint? style2 = ct_Col.style;
				long? num = (style2 != null) ? new long?((long)((ulong)style2.GetValueOrDefault())) : null;
				int? num2 = style;
				long? num3 = (num2 != null) ? new long?((long)num2.GetValueOrDefault()) : null;
				flag = !(num.GetValueOrDefault() == num3.GetValueOrDefault() & num != null == (num3 != null));
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			bool flag3;
			if (level != null)
			{
				int outlineLevel = (int)ct_Col.outlineLevel;
				int? num2 = level;
				flag3 = !(outlineLevel == num2.GetValueOrDefault() & num2 != null);
			}
			else
			{
				flag3 = false;
			}
			bool flag5;
			if (hidden != null)
			{
				bool hidden2 = ct_Col.hidden;
				bool? flag4 = hidden;
				flag5 = !(hidden2 == flag4.GetValueOrDefault() & flag4 != null);
			}
			else
			{
				flag5 = false;
			}
			bool flag6 = flag5;
			bool flag7;
			if (collapsed != null)
			{
				bool collapsed2 = ct_Col.collapsed;
				bool? flag4 = collapsed;
				flag7 = !(collapsed2 == flag4.GetValueOrDefault() & flag4 != null);
			}
			else
			{
				flag7 = false;
			}
			bool flag8 = flag7;
			if (!flag3 && !flag6 && !flag8 && !flag2)
			{
				return;
			}
			if ((ulong)ct_Col.min == (ulong)((long)targetColumnIx) && (ulong)ct_Col.max == (ulong)((long)targetColumnIx))
			{
				this.UnsetCollapsed(collapsed.Value, ct_Col);
				return;
			}
			if ((ulong)ct_Col.min == (ulong)((long)targetColumnIx) || (ulong)ct_Col.max == (ulong)((long)targetColumnIx))
			{
				if ((ulong)ct_Col.min == (ulong)((long)targetColumnIx))
				{
					ct_Col.min = (uint)(targetColumnIx + 1);
				}
				else
				{
					ct_Col.max = (uint)(targetColumnIx - 1);
					i++;
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col3 = this.columnHelper.CloneCol(colsArray, ct_Col);
				ct_Col3.min = (uint)targetColumnIx;
				this.UnsetCollapsed(collapsed.Value, ct_Col3);
				this.columnHelper.AddCleanColIntoCols(colsArray, ct_Col3);
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col4 = ct_Col;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col5 = this.columnHelper.CloneCol(colsArray, ct_Col);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col6 = this.columnHelper.CloneCol(colsArray, ct_Col);
			int max = (int)ct_Col.max;
			ct_Col4.max = (uint)(targetColumnIx - 1);
			ct_Col5.min = (uint)targetColumnIx;
			ct_Col5.max = (uint)targetColumnIx;
			this.UnsetCollapsed(collapsed.Value, ct_Col5);
			this.columnHelper.AddCleanColIntoCols(colsArray, ct_Col5);
			ct_Col6.min = (uint)(targetColumnIx + 1);
			ct_Col6.max = (uint)max;
			this.columnHelper.AddCleanColIntoCols(colsArray, ct_Col6);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001F3EE File Offset: 0x0001D5EE
		private void UnsetCollapsed(bool collapsed, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ci)
		{
			if (collapsed)
			{
				ci.collapsed = collapsed;
				return;
			}
			ci.UnsetCollapsed();
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001F404 File Offset: 0x0001D604
		private int SetGroupHidden(int pIdx, int level, bool hidden)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			int i = pIdx;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = colsArray.GetColArray(i);
			while (i < colsArray.sizeOfColArray())
			{
				ct_Col.hidden = hidden;
				if (i + 1 < colsArray.sizeOfColArray())
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(i + 1);
					if (!this.IsAdjacentBefore(ct_Col, colArray) || (int)colArray.outlineLevel < level)
					{
						break;
					}
					ct_Col = colArray;
				}
				i++;
			}
			return (int)ct_Col.max;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001F46E File Offset: 0x0001D66E
		private bool IsAdjacentBefore(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col other_col)
		{
			return col.max == other_col.min - 1U;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001F480 File Offset: 0x0001D680
		private int FindStartOfColumnOutlineGroup(int pIdx)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = colsArray.GetColArray(pIdx);
			int outlineLevel = (int)ct_Col.outlineLevel;
			int num = pIdx;
			while (num != 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(num - 1);
				if (!this.IsAdjacentBefore(colArray, ct_Col) || (int)colArray.outlineLevel < outlineLevel)
				{
					break;
				}
				num--;
				ct_Col = colArray;
			}
			return num;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		private int FindEndOfColumnOutlineGroup(int colInfoIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = colsArray.GetColArray(colInfoIndex);
			int outlineLevel = (int)ct_Col.outlineLevel;
			int i = colInfoIndex;
			while (i < colsArray.sizeOfColArray() - 1)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(i + 1);
				if (!this.IsAdjacentBefore(ct_Col, colArray) || (int)colArray.outlineLevel < outlineLevel)
				{
					break;
				}
				i++;
				ct_Col = colArray;
			}
			return i;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001F538 File Offset: 0x0001D738
		private void ExpandColumn(int columnIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)columnIndex, false);
			int indexOfColumn = this.columnHelper.GetIndexOfColumn(colsArray, column);
			int num = this.FindColInfoIdx((int)column.max, indexOfColumn);
			if (num == -1)
			{
				return;
			}
			if (!this.IsColumnGroupCollapsed(num))
			{
				return;
			}
			int num2 = this.FindStartOfColumnOutlineGroup(num);
			int num3 = this.FindEndOfColumnOutlineGroup(num);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(num3);
			if (!this.IsColumnGroupHiddenByParent(num))
			{
				int outlineLevel = (int)colArray.outlineLevel;
				bool flag = false;
				for (int i = num2; i <= num3; i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray2 = colsArray.GetColArray(i);
					if (outlineLevel == (int)colArray2.outlineLevel)
					{
						colArray2.UnsetHidden();
						if (flag)
						{
							flag = false;
							colArray2.collapsed = true;
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			this.SetColumn((int)(colArray.max + 1U), null, null, null, new bool?(false), new bool?(false));
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001F638 File Offset: 0x0001D838
		private bool IsColumnGroupHiddenByParent(int idx)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			int num = 0;
			bool result = false;
			int num2 = this.FindEndOfColumnOutlineGroup(idx);
			if (num2 < colsArray.sizeOfColArray())
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(num2 + 1);
				if (this.IsAdjacentBefore(colsArray.GetColArray(num2), colArray))
				{
					num = (int)colArray.outlineLevel;
					result = colArray.hidden;
				}
			}
			int num3 = 0;
			bool result2 = false;
			int num4 = this.FindStartOfColumnOutlineGroup(idx);
			if (num4 > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray2 = colsArray.GetColArray(num4 - 1);
				if (this.IsAdjacentBefore(colArray2, colsArray.GetColArray(num4)))
				{
					num3 = (int)colArray2.outlineLevel;
					result2 = colArray2.hidden;
				}
			}
			if (num > num3)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		private int FindColInfoIdx(int columnValue, int fromColInfoIdx)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			if (columnValue < 0)
			{
				throw new global::System.ArgumentException("column parameter out of range: " + columnValue.ToString());
			}
			if (fromColInfoIdx < 0)
			{
				throw new global::System.ArgumentException("fromIdx parameter out of range: " + fromColInfoIdx.ToString());
			}
			for (int i = fromColInfoIdx; i < colsArray.sizeOfColArray(); i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(i);
				if (this.ContainsColumn(colArray, columnValue))
				{
					return i;
				}
				if ((ulong)colArray.min > (ulong)((long)fromColInfoIdx))
				{
					break;
				}
			}
			return -1;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0001F761 File Offset: 0x0001D961
		private bool ContainsColumn(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col, int columnIndex)
		{
			return (ulong)col.min <= (ulong)((long)columnIndex) && (long)columnIndex <= (long)((ulong)col.max);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001F780 File Offset: 0x0001D980
		private bool IsColumnGroupCollapsed(int idx)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			int num = this.FindEndOfColumnOutlineGroup(idx);
			int num2 = num + 1;
			if (num2 >= colsArray.sizeOfColArray())
			{
				return false;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray = colsArray.GetColArray(num2);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col colArray2 = colsArray.GetColArray(num);
			return this.IsAdjacentBefore(colArray2, colArray) && colArray.collapsed;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0001F7D5 File Offset: 0x0001D9D5
		public void SetColumnHidden(int columnIndex, bool hidden)
		{
			this.columnHelper.SetColHidden((long)columnIndex, hidden);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001F7E5 File Offset: 0x0001D9E5
		public void SetColumnWidth(int columnIndex, int width)
		{
			if (width > 65280)
			{
				throw new global::System.ArgumentException("The maximum column width for an individual cell is 255 characters.");
			}
			this.columnHelper.SetColWidth((long)columnIndex, (double)width / 256.0);
			this.columnHelper.SetCustomWidth((long)columnIndex, true);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0001F821 File Offset: 0x0001DA21
		public void SetDefaultColumnStyle(int column, global::NPOI.SS.UserModel.ICellStyle style)
		{
			this.columnHelper.SetColDefaultStyle((long)column, style);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0001F831 File Offset: 0x0001DA31
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView GetSheetTypeSheetView()
		{
			if (this.GetDefaultSheetView() == null)
			{
				this.GetSheetTypeSheetViews().SetSheetViewArray(0, new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView());
			}
			return this.GetDefaultSheetView();
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001F852 File Offset: 0x0001DA52
		public void SetRowGroupCollapsed(int rowIndex, bool collapse)
		{
			if (collapse)
			{
				this.CollapseRow(rowIndex);
				return;
			}
			this.ExpandRow(rowIndex);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001F868 File Offset: 0x0001DA68
		private void CollapseRow(int rowIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rowIndex);
			if (xssfrow != null)
			{
				int rowIndex2 = this.FindStartOfRowOutlineGroup(rowIndex);
				int rownum = this.WriteHidden(xssfrow, rowIndex2, true);
				if (this.GetRow(rownum) != null)
				{
					((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rownum)).GetCTRow().collapsed = true;
					return;
				}
				((global::NPOI.XSSF.UserModel.XSSFRow)this.CreateRow(rownum)).GetCTRow().collapsed = true;
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		private int FindStartOfRowOutlineGroup(int rowIndex)
		{
			int outlineLevel = (int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rowIndex)).GetCTRow().outlineLevel;
			int num = rowIndex;
			while (this.GetRow(num) != null)
			{
				if ((int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(num)).GetCTRow().outlineLevel < outlineLevel)
				{
					return num + 1;
				}
				num--;
			}
			return num;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0001F924 File Offset: 0x0001DB24
		private int WriteHidden(global::NPOI.XSSF.UserModel.XSSFRow xRow, int rowIndex, bool hidden)
		{
			int outlineLevel = (int)xRow.GetCTRow().outlineLevel;
			global::System.Collections.IEnumerator rowEnumerator = this.GetRowEnumerator();
			while (rowEnumerator.MoveNext())
			{
				object obj = rowEnumerator.Current;
				xRow = (global::NPOI.XSSF.UserModel.XSSFRow)obj;
				if ((int)xRow.GetCTRow().outlineLevel >= outlineLevel)
				{
					xRow.GetCTRow().hidden = hidden;
					rowIndex++;
				}
			}
			return rowIndex;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001F97C File Offset: 0x0001DB7C
		private void ExpandRow(int rowNumber)
		{
			if (rowNumber == -1)
			{
				return;
			}
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rowNumber);
			if (!xssfrow.GetCTRow().IsSetHidden())
			{
				return;
			}
			int num = this.FindStartOfRowOutlineGroup(rowNumber);
			int num2 = this.FindEndOfRowOutlineGroup(rowNumber);
			if (!this.IsRowGroupHiddenByParent(rowNumber))
			{
				for (int i = num; i < num2; i++)
				{
					if (xssfrow.GetCTRow().outlineLevel == ((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i)).GetCTRow().outlineLevel)
					{
						((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i)).GetCTRow().UnsetHidden();
					}
					else if (!this.IsRowGroupCollapsed(i))
					{
						((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i)).GetCTRow().UnsetHidden();
					}
				}
			}
			xssfrow = (this.GetRow(num2) as global::NPOI.XSSF.UserModel.XSSFRow);
			if (xssfrow != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ctrow = xssfrow.GetCTRow();
				if (ctrow.collapsed)
				{
					ctrow.UnsetCollapsed();
				}
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001FA50 File Offset: 0x0001DC50
		public int FindEndOfRowOutlineGroup(int row)
		{
			int outlineLevel = (int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(row)).GetCTRow().outlineLevel;
			int lastRowNum = this.LastRowNum;
			int num = row;
			while (num < lastRowNum && this.GetRow(num) != null && (int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(num)).GetCTRow().outlineLevel >= outlineLevel)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		private bool IsRowGroupHiddenByParent(int row)
		{
			int rownum = this.FindEndOfRowOutlineGroup(row);
			int num;
			bool result;
			if (this.GetRow(rownum) == null)
			{
				num = 0;
				result = false;
			}
			else
			{
				num = (int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rownum)).GetCTRow().outlineLevel;
				result = ((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rownum)).GetCTRow().hidden;
			}
			int num2 = this.FindStartOfRowOutlineGroup(row);
			int num3;
			bool result2;
			if (num2 < 0 || this.GetRow(num2) == null)
			{
				num3 = 0;
				result2 = false;
			}
			else
			{
				num3 = (int)((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(num2)).GetCTRow().outlineLevel;
				result2 = ((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(num2)).GetCTRow().hidden;
			}
			if (num > num3)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0001FB58 File Offset: 0x0001DD58
		private bool IsRowGroupCollapsed(int row)
		{
			int rownum = this.FindEndOfRowOutlineGroup(row) + 1;
			return this.GetRow(rownum) != null && ((global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(rownum)).GetCTRow().collapsed;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001FB90 File Offset: 0x0001DD90
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #setZoom(int)} instead.")]
		public void SetZoom(int numerator, int denominator)
		{
			int zoom = 100 * numerator / denominator;
			this.SetZoom(zoom);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001FBAB File Offset: 0x0001DDAB
		public void SetZoom(int scale)
		{
			if (scale < 10 || scale > 400)
			{
				throw new global::System.ArgumentException("Valid scale values range from 10 to 400");
			}
			this.GetSheetTypeSheetView().zoomScale = (uint)scale;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		public void CopyRows(global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFRow> srcRows, int destStartRow, global::NPOI.SS.UserModel.CellCopyPolicy policy)
		{
			if (srcRows == null || srcRows.Count == 0)
			{
				throw new global::System.ArgumentException("No rows to copy");
			}
			global::NPOI.SS.UserModel.IRow row = srcRows[0];
			global::NPOI.SS.UserModel.IRow row2 = srcRows[srcRows.Count - 1];
			if (row == null)
			{
				throw new global::System.ArgumentException("copyRows: First row cannot be null");
			}
			int rowNum = row.RowNum;
			int rowNum2 = row2.RowNum;
			int count = srcRows.Count;
			for (int i = 1; i < count; i++)
			{
				global::NPOI.SS.UserModel.IRow row3 = srcRows[i];
				if (row3 == null)
				{
					throw new global::System.ArgumentException("srcRows may not contain null rows. Found null row at index " + i.ToString() + ".");
				}
				if (row.Sheet.Workbook != row3.Sheet.Workbook)
				{
					string[] array = new string[7];
					array[0] = "All rows in srcRows must belong to the same sheet in the same workbook.Expected all rows from same workbook (";
					int num = 1;
					global::NPOI.SS.UserModel.IWorkbook workbook = row.Sheet.Workbook;
					array[num] = ((workbook != null) ? workbook.ToString() : null);
					array[2] = "). Got srcRows[";
					array[3] = i.ToString();
					array[4] = "] from different workbook (";
					int num2 = 5;
					global::NPOI.SS.UserModel.IWorkbook workbook2 = row3.Sheet.Workbook;
					array[num2] = ((workbook2 != null) ? workbook2.ToString() : null);
					array[6] = ").";
					throw new global::System.ArgumentException(string.Concat(array));
				}
				if (row.Sheet != row3.Sheet)
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"All rows in srcRows must belong to the same sheet. Expected all rows from ",
						row.Sheet.SheetName,
						". Got srcRows[",
						i.ToString(),
						"] from ",
						row3.Sheet.SheetName
					}));
				}
			}
			global::NPOI.SS.UserModel.CellCopyPolicy cellCopyPolicy = new global::NPOI.SS.UserModel.CellCopyPolicy(policy);
			cellCopyPolicy.IsCopyMergedRegions = false;
			int num3 = destStartRow;
			foreach (global::NPOI.SS.UserModel.IRow row4 in srcRows)
			{
				int rownum;
				if (policy.IsCondenseRows)
				{
					rownum = num3++;
				}
				else
				{
					int num4 = row4.RowNum - rowNum;
					rownum = destStartRow + num4;
				}
				(this.CreateRow(rownum) as global::NPOI.XSSF.UserModel.XSSFRow).CopyRowFrom(row4, cellCopyPolicy);
			}
			if (policy.IsCopyMergedRegions)
			{
				int num5 = destStartRow - rowNum;
				foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in row.Sheet.MergedRegions)
				{
					if (rowNum <= cellRangeAddress.FirstRow && cellRangeAddress.LastRow <= rowNum2)
					{
						global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 = cellRangeAddress.Copy();
						cellRangeAddress2.FirstRow += num5;
						cellRangeAddress2.LastRow += num5;
						this.AddMergedRegion(cellRangeAddress2);
					}
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001FE7C File Offset: 0x0001E07C
		public void CopyRows(int srcStartRow, int srcEndRow, int destStartRow, global::NPOI.SS.UserModel.CellCopyPolicy cellCopyPolicy)
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFRow> rows = this.GetRows(srcStartRow, srcEndRow, false);
			this.CopyRows(rows, destStartRow, cellCopyPolicy);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001FE9D File Offset: 0x0001E09D
		public void ShiftRows(int startRow, int endRow, int n)
		{
			this.ShiftRows(startRow, endRow, n, false, false);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		public void ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight)
		{
			global::NPOI.XSSF.UserModel.XSSFVMLDrawing vmldrawing = this.GetVMLDrawing(false);
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellAddress> list2 = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellAddress>();
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> list3 = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row>();
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> keyValuePair in this._rows)
			{
				global::NPOI.XSSF.UserModel.XSSFRow value = keyValuePair.Value;
				int rowNum = value.RowNum;
				if (global::NPOI.XSSF.UserModel.XSSFSheet.ShouldRemoveRow(startRow, endRow, n, rowNum))
				{
					int index = this._rows.IndexOfValue(value);
					list3.Add(this.worksheet.sheetData.GetRowArray(index));
					list.Add(keyValuePair.Key);
					list2.Clear();
					if (this.sheetComments != null)
					{
						foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment in this.sheetComments.GetCTComments().commentList.comment)
						{
							global::NPOI.SS.Util.CellAddress cellAddress = new global::NPOI.SS.Util.CellAddress(ct_Comment.@ref);
							if (cellAddress.Row == rowNum)
							{
								list2.Add(cellAddress);
							}
						}
					}
					foreach (global::NPOI.SS.Util.CellAddress cellAddress2 in list2)
					{
						this.sheetComments.RemoveComment(cellAddress2);
						vmldrawing.RemoveCommentShape(cellAddress2.Row, cellAddress2.Column);
					}
					if (this.hyperlinks != null)
					{
						foreach (global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink in new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFHyperlink>(this.hyperlinks))
						{
							if (new global::NPOI.SS.Util.CellReference(xssfhyperlink.CellRef).Row == rowNum)
							{
								this.hyperlinks.Remove(xssfhyperlink);
							}
						}
					}
				}
			}
			foreach (int key in list)
			{
				this._rows.Remove(key);
			}
			this.worksheet.sheetData.RemoveRows(list3);
			global::System.Collections.Generic.SortedDictionary<global::NPOI.XSSF.UserModel.XSSFComment, int> sortedDictionary = new global::System.Collections.Generic.SortedDictionary<global::NPOI.XSSF.UserModel.XSSFComment, int>(new global::NPOI.XSSF.UserModel.XSSFSheet.ShiftCommentComparator(n));
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> keyValuePair2 in this._rows)
			{
				global::NPOI.XSSF.UserModel.XSSFRow value2 = keyValuePair2.Value;
				int rowNum2 = value2.RowNum;
				if (this.sheetComments != null)
				{
					int num = this.ShiftedRowNum(startRow, endRow, n, rowNum2);
					if (num != rowNum2)
					{
						foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment2 in this.sheetComments.GetCTComments().commentList.comment)
						{
							global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(ct_Comment2.@ref);
							if (cellReference.Row == rowNum2)
							{
								global::NPOI.XSSF.UserModel.XSSFComment key2 = new global::NPOI.XSSF.UserModel.XSSFComment(this.sheetComments, ct_Comment2, (vmldrawing == null) ? null : vmldrawing.FindCommentShape(rowNum2, (int)cellReference.Col));
								if (sortedDictionary.ContainsKey(key2))
								{
									sortedDictionary[key2] = num;
								}
								else
								{
									sortedDictionary.Add(key2, num);
								}
							}
						}
					}
				}
				if (rowNum2 >= startRow && rowNum2 <= endRow)
				{
					if (!copyRowHeight)
					{
						value2.Height = -1;
					}
					value2.Shift(n);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.XSSF.UserModel.XSSFComment, int> keyValuePair3 in sortedDictionary)
			{
				keyValuePair3.Key.Row = keyValuePair3.Value;
			}
			global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter xssfrowShifter = new global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter(this);
			int sheetIndex = this.Workbook.GetSheetIndex(this);
			string sheetName = this.Workbook.GetSheetName(sheetIndex);
			global::NPOI.SS.Formula.FormulaShifter shifter = global::NPOI.SS.Formula.FormulaShifter.CreateForRowShift(sheetIndex, sheetName, startRow, endRow, n, global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			xssfrowShifter.UpdateNamedRanges(shifter);
			xssfrowShifter.UpdateFormulas(shifter);
			xssfrowShifter.ShiftMergedRegions(startRow, endRow, n);
			xssfrowShifter.UpdateConditionalFormatting(shifter);
			xssfrowShifter.UpdateHyperlinks(shifter);
			global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.UserModel.XSSFRow> dictionary = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.UserModel.XSSFRow>();
			foreach (global::NPOI.XSSF.UserModel.XSSFRow xssfrow in this._rows.Values)
			{
				dictionary.Add(xssfrow.RowNum, xssfrow);
			}
			this._rows.Clear();
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.UserModel.XSSFRow> keyValuePair4 in dictionary)
			{
				this._rows.Add(keyValuePair4.Key, keyValuePair4.Value);
			}
			if (this.worksheet.sheetData.row != null)
			{
				this.worksheet.sheetData.row.Sort((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row row1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row row2) => row1.r.CompareTo(row2.r));
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0002046C File Offset: 0x0001E66C
		private int ShiftedRowNum(int startRow, int endRow, int n, int rownum)
		{
			if (rownum < startRow && (n > 0 || startRow - rownum > n))
			{
				return rownum;
			}
			if (rownum > endRow && (n < 0 || rownum - endRow > n))
			{
				return rownum;
			}
			if (rownum < startRow)
			{
				return rownum + (endRow - startRow);
			}
			if (rownum > endRow)
			{
				return rownum - (endRow - startRow);
			}
			return rownum + n;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000204BC File Offset: 0x0001E6BC
		public void UngroupColumn(int fromColumn, int toColumn)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			for (int i = fromColumn; i <= toColumn; i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)i, false);
				if (column != null)
				{
					short outlineLevel = (short)column.outlineLevel;
					column.outlineLevel = (byte)(outlineLevel - 1);
					i = (int)column.max;
					if (column.outlineLevel <= 0)
					{
						int indexOfColumn = this.columnHelper.GetIndexOfColumn(colsArray, column);
						this.worksheet.GetColsArray(0).RemoveCol(indexOfColumn);
					}
				}
			}
			this.worksheet.SetColsArray(0, colsArray);
			this.SetSheetFormatPrOutlineLevelCol();
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002054C File Offset: 0x0001E74C
		public void UngroupRow(int fromRow, int toRow)
		{
			for (int i = fromRow; i <= toRow; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i);
				if (xssfrow != null)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ctrow = xssfrow.GetCTRow();
					short outlineLevel = (short)ctrow.outlineLevel;
					ctrow.outlineLevel = (byte)(outlineLevel - 1);
					if (ctrow.outlineLevel == 0 && xssfrow.FirstCellNum == -1)
					{
						this.RemoveRow(xssfrow);
					}
				}
			}
			this.SetSheetFormatPrOutlineLevelRow();
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000205AC File Offset: 0x0001E7AC
		private void SetSheetFormatPrOutlineLevelRow()
		{
			short maxOutlineLevelRows = this.GetMaxOutlineLevelRows();
			this.GetSheetTypeSheetFormatPr().outlineLevelRow = (byte)maxOutlineLevelRows;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000205D0 File Offset: 0x0001E7D0
		private void SetSheetFormatPrOutlineLevelCol()
		{
			short maxOutlineLevelCols = this.GetMaxOutlineLevelCols();
			this.GetSheetTypeSheetFormatPr().outlineLevelCol = (byte)maxOutlineLevelCols;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000205F1 File Offset: 0x0001E7F1
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews GetSheetTypeSheetViews()
		{
			if (this.worksheet.sheetViews == null)
			{
				this.worksheet.sheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews();
				this.worksheet.sheetViews.AddNewSheetView();
			}
			return this.worksheet.sheetViews;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002062C File Offset: 0x0001E82C
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0002064C File Offset: 0x0001E84C
		public bool IsSelected
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView defaultSheetView = this.GetDefaultSheetView();
				return defaultSheetView != null && defaultSheetView.tabSelected;
			}
			set
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView ct_SheetView in this.GetSheetTypeSheetViews().sheetView)
				{
					ct_SheetView.tabSelected = value;
				}
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000206A4 File Offset: 0x0001E8A4
		public void AddHyperlink(global::NPOI.XSSF.UserModel.XSSFHyperlink hyperlink)
		{
			this.hyperlinks.Add(hyperlink);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000206B4 File Offset: 0x0001E8B4
		public void RemoveHyperlink(int row, int column)
		{
			string value = new global::NPOI.SS.Util.CellReference(row, column).FormatAsString();
			for (int i = 0; i < this.hyperlinks.Count; i++)
			{
				if (this.hyperlinks[i].CellRef.Equals(value))
				{
					this.hyperlinks.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002070C File Offset: 0x0001E90C
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00020730 File Offset: 0x0001E930
		public global::NPOI.SS.Util.CellAddress ActiveCell
		{
			get
			{
				string activeCell = this.GetSheetTypeSelection().activeCell;
				if (activeCell == null)
				{
					return null;
				}
				return new global::NPOI.SS.Util.CellAddress(activeCell);
			}
			set
			{
				string text = value.FormatAsString();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection sheetTypeSelection = this.GetSheetTypeSelection();
				sheetTypeSelection.activeCell = text;
				sheetTypeSelection.SetSqref(new string[]
				{
					text
				});
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00020760 File Offset: 0x0001E960
		[global::System.Obsolete("deprecated 3.14beta2 (circa 2015-12-05). Use {@link #setActiveCell(CellAddress)} instead.")]
		public void SetActiveCell(string cellref)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection sheetTypeSelection = this.GetSheetTypeSelection();
			sheetTypeSelection.activeCell = cellref;
			sheetTypeSelection.SetSqref(new string[]
			{
				cellref
			});
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002077E File Offset: 0x0001E97E
		public bool HasComments
		{
			get
			{
				return this.sheetComments != null && this.sheetComments.GetNumberOfComments() > 0;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00020798 File Offset: 0x0001E998
		internal int NumberOfComments
		{
			get
			{
				if (this.sheetComments == null)
				{
					return 0;
				}
				return this.sheetComments.GetNumberOfComments();
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000207AF File Offset: 0x0001E9AF
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Selection GetSheetTypeSelection()
		{
			if (this.GetSheetTypeSheetView().SizeOfSelectionArray() == 0)
			{
				this.GetSheetTypeSheetView().InsertNewSelection(0);
			}
			return this.GetSheetTypeSheetView().GetSelectionArray(0);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000207D8 File Offset: 0x0001E9D8
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView GetDefaultSheetView()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews sheetTypeSheetViews = this.GetSheetTypeSheetViews();
			int num = (sheetTypeSheetViews == null) ? 0 : sheetTypeSheetViews.sizeOfSheetViewArray();
			if (num == 0)
			{
				return null;
			}
			return sheetTypeSheetViews.GetSheetViewArray(num - 1);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00020808 File Offset: 0x0001EA08
		protected internal global::NPOI.XSSF.Model.CommentsTable GetCommentsTable(bool create)
		{
			if (this.sheetComments == null && create)
			{
				try
				{
					this.sheetComments = (global::NPOI.XSSF.Model.CommentsTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_COMMENTS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), (int)this.sheet.sheetId);
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.PartAlreadyExistsException)
				{
					this.sheetComments = (global::NPOI.XSSF.Model.CommentsTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_COMMENTS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), -1);
				}
			}
			return this.sheetComments;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00020880 File Offset: 0x0001EA80
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetUpPr GetSheetTypePageSetUpPr()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr sheetTypeSheetPr = this.GetSheetTypeSheetPr();
			if (!sheetTypeSheetPr.IsSetPageSetUpPr())
			{
				return sheetTypeSheetPr.AddNewPageSetUpPr();
			}
			return sheetTypeSheetPr.pageSetUpPr;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000208A9 File Offset: 0x0001EAA9
		private static bool ShouldRemoveRow(int startRow, int endRow, int n, int rownum)
		{
			if (rownum >= startRow + n && rownum <= endRow + n)
			{
				if (n > 0 && rownum > endRow)
				{
					return true;
				}
				if (n < 0 && rownum < startRow)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000208CC File Offset: 0x0001EACC
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane GetPane()
		{
			if (this.GetDefaultSheetView().pane == null)
			{
				this.GetDefaultSheetView().AddNewPane();
			}
			return this.GetDefaultSheetView().pane;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000208F2 File Offset: 0x0001EAF2
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula GetSharedFormula(int sid)
		{
			return this.sharedFormulas[sid];
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00020900 File Offset: 0x0001EB00
		internal void OnReadCell(global::NPOI.XSSF.UserModel.XSSFCell cell)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f = cell.GetCTCell().f;
			if (f != null && f.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.shared && f.isSetRef() && f.Value != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula ct_CellFormula = f.Copy();
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(ct_CellFormula.@ref);
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(cell);
				if ((int)cellReference.Col > cellRangeAddress.FirstColumn || cellReference.Row > cellRangeAddress.FirstRow)
				{
					string @ref = new global::NPOI.SS.Util.CellRangeAddress(global::System.Math.Max(cellReference.Row, cellRangeAddress.FirstRow), cellRangeAddress.LastRow, global::System.Math.Max((int)cellReference.Col, cellRangeAddress.FirstColumn), cellRangeAddress.LastColumn).FormatAsString();
					ct_CellFormula.@ref = @ref;
				}
				this.sharedFormulas[(int)f.si] = ct_CellFormula;
			}
			if (f != null && f.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.array && f.@ref != null)
			{
				this.arrayFormulas.Add(global::NPOI.SS.Util.CellRangeAddress.ValueOf(f.@ref));
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000209F8 File Offset: 0x0001EBF8
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.Write(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00020A20 File Offset: 0x0001EC20
		internal virtual void Write(global::System.IO.Stream stream)
		{
			bool flag = false;
			if (this.worksheet.sizeOfColsArray() == 1)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
				if (colsArray.sizeOfColArray() == 0)
				{
					flag = true;
					this.worksheet.SetColsArray(null);
				}
				else
				{
					this.SetColWidthAttribute(colsArray);
				}
			}
			if (this.hyperlinks.Count > 0)
			{
				if (this.worksheet.hyperlinks == null)
				{
					this.worksheet.AddNewHyperlinks();
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink[this.hyperlinks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink = this.hyperlinks[i];
					xssfhyperlink.GenerateRelationIfNeeded(base.GetPackagePart());
					array[i] = xssfhyperlink.GetCTHyperlink();
				}
				this.worksheet.hyperlinks.SetHyperlinkArray(array);
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFRow xssfrow in this._rows.Values)
			{
				xssfrow.OnDocumentWrite();
			}
			new global::System.Collections.Generic.Dictionary<string, string>()[global::NPOI.OpenXmlFormats.ST_RelationshipId.NamespaceURI] = "r";
			new global::NPOI.OpenXmlFormats.Spreadsheet.WorksheetDocument(this.worksheet).Save(stream);
			if (flag)
			{
				this.worksheet.AddNewCols();
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00020B60 File Offset: 0x0001ED60
		public bool IsAutoFilterLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().autoFilter;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00020B77 File Offset: 0x0001ED77
		public bool IsDeleteColumnsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().deleteColumns;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00020B8E File Offset: 0x0001ED8E
		public bool IsDeleteRowsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().deleteRows;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00020BA5 File Offset: 0x0001EDA5
		public bool IsFormatCellsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().formatCells;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public bool IsFormatColumnsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().formatColumns;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00020BD3 File Offset: 0x0001EDD3
		public bool IsFormatRowsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().formatRows;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00020BEA File Offset: 0x0001EDEA
		public bool IsInsertColumnsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().insertColumns;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00020C01 File Offset: 0x0001EE01
		public bool IsInsertHyperlinksLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().insertHyperlinks;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00020C18 File Offset: 0x0001EE18
		public bool IsInsertRowsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().insertRows;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00020C2F File Offset: 0x0001EE2F
		public bool IsPivotTablesLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().pivotTables;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00020C46 File Offset: 0x0001EE46
		public bool IsSortLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().sort;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00020C5D File Offset: 0x0001EE5D
		public bool IsObjectsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().objects;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00020C74 File Offset: 0x0001EE74
		public bool IsScenariosLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().scenarios;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00020C8B File Offset: 0x0001EE8B
		public bool IsSelectLockedCellsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().selectLockedCells;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00020CA2 File Offset: 0x0001EEA2
		public bool IsSelectUnlockedCellsLocked
		{
			get
			{
				return this.IsSheetLocked && this.SafeGetProtectionField().selectUnlockedCells;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00020CB9 File Offset: 0x0001EEB9
		public bool IsSheetLocked
		{
			get
			{
				return this.worksheet.IsSetSheetProtection() && this.SafeGetProtectionField().sheet;
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00020CD5 File Offset: 0x0001EED5
		public void EnableLocking()
		{
			this.SafeGetProtectionField().sheet = true;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00020CE3 File Offset: 0x0001EEE3
		public void DisableLocking()
		{
			this.SafeGetProtectionField().sheet = false;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00020CF1 File Offset: 0x0001EEF1
		public void LockAutoFilter(bool enabled)
		{
			this.SafeGetProtectionField().autoFilter = enabled;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00020CFF File Offset: 0x0001EEFF
		public void LockDeleteColumns(bool enabled)
		{
			this.SafeGetProtectionField().deleteColumns = enabled;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00020D0D File Offset: 0x0001EF0D
		public void LockDeleteRows(bool enabled)
		{
			this.SafeGetProtectionField().deleteRows = enabled;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00020D1B File Offset: 0x0001EF1B
		public void LockFormatCells(bool enabled)
		{
			this.SafeGetProtectionField().formatCells = enabled;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00020D29 File Offset: 0x0001EF29
		public void LockFormatColumns(bool enabled)
		{
			this.SafeGetProtectionField().formatColumns = enabled;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00020D37 File Offset: 0x0001EF37
		public void LockFormatRows(bool enabled)
		{
			this.SafeGetProtectionField().formatRows = enabled;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00020D45 File Offset: 0x0001EF45
		public void LockInsertColumns(bool enabled)
		{
			this.SafeGetProtectionField().insertColumns = enabled;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00020D53 File Offset: 0x0001EF53
		public void LockInsertHyperlinks(bool enabled)
		{
			this.SafeGetProtectionField().insertHyperlinks = enabled;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00020D61 File Offset: 0x0001EF61
		public void LockInsertRows(bool enabled)
		{
			this.SafeGetProtectionField().insertRows = enabled;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00020D6F File Offset: 0x0001EF6F
		public void LockPivotTables(bool enabled)
		{
			this.SafeGetProtectionField().pivotTables = enabled;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00020D7D File Offset: 0x0001EF7D
		public void LockSort(bool enabled)
		{
			this.SafeGetProtectionField().sort = enabled;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00020D8B File Offset: 0x0001EF8B
		public void LockObjects(bool enabled)
		{
			this.SafeGetProtectionField().objects = enabled;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00020D99 File Offset: 0x0001EF99
		public void LockScenarios(bool enabled)
		{
			this.SafeGetProtectionField().scenarios = enabled;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00020DA7 File Offset: 0x0001EFA7
		public void LockSelectLockedCells(bool enabled)
		{
			this.SafeGetProtectionField().selectLockedCells = enabled;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00020DB5 File Offset: 0x0001EFB5
		public void LockSelectUnlockedCells(bool enabled)
		{
			this.SafeGetProtectionField().selectUnlockedCells = enabled;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00020DC3 File Offset: 0x0001EFC3
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection SafeGetProtectionField()
		{
			if (!this.IsSheetProtectionEnabled())
			{
				return this.worksheet.AddNewSheetProtection();
			}
			return this.worksheet.sheetProtection;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		private bool IsSheetProtectionEnabled()
		{
			return this.worksheet.IsSetSheetProtection();
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		internal bool IsCellInArrayFormulaContext(global::NPOI.SS.UserModel.ICell cell)
		{
			using (global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>.Enumerator enumerator = this.arrayFormulas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsInRange(cell.RowIndex, cell.ColumnIndex))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00020E5C File Offset: 0x0001F05C
		internal global::NPOI.XSSF.UserModel.XSSFCell GetFirstCellInArrayFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.arrayFormulas)
			{
				if (cellRangeAddress.IsInRange(cell.RowIndex, cell.ColumnIndex))
				{
					return (global::NPOI.XSSF.UserModel.XSSFCell)this.GetRow(cellRangeAddress.FirstRow).GetCell(cellRangeAddress.FirstColumn);
				}
			}
			return null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		private global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> GetCellRange(global::NPOI.SS.Util.CellRangeAddress range)
		{
			int firstRow = range.FirstRow;
			int firstColumn = range.FirstColumn;
			int lastRow = range.LastRow;
			int lastColumn = range.LastColumn;
			int num = lastRow - firstRow + 1;
			int num2 = lastColumn - firstColumn + 1;
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell>(num * num2);
			for (int i = firstRow; i <= lastRow; i++)
			{
				for (int j = firstColumn; j <= lastColumn; j++)
				{
					global::NPOI.SS.UserModel.IRow row = this.GetRow(i);
					if (row == null)
					{
						row = this.CreateRow(i);
					}
					global::NPOI.SS.UserModel.ICell cell = row.GetCell(j);
					if (cell == null)
					{
						cell = row.CreateCell(j);
					}
					list.Add(cell);
				}
			}
			return global::NPOI.SS.Util.SSCellRange<global::NPOI.SS.UserModel.ICell>.Create(firstRow, firstColumn, num, num2, list, typeof(global::NPOI.SS.UserModel.ICell));
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00020F95 File Offset: 0x0001F195
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> SetArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range)
		{
			global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> cellRange = this.GetCellRange(range);
			((global::NPOI.XSSF.UserModel.XSSFCell)cellRange.TopLeftCell).SetCellArrayFormula(formula, range);
			this.arrayFormulas.Add(range);
			return cellRange;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00020FBC File Offset: 0x0001F1BC
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> RemoveArrayFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell.Sheet != this)
			{
				throw new global::System.ArgumentException("Specified cell does not belong to this sheet.");
			}
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.arrayFormulas)
			{
				if (cellRangeAddress.IsInRange(cell.RowIndex, cell.ColumnIndex))
				{
					this.arrayFormulas.Remove(cellRangeAddress);
					global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> cellRange = this.GetCellRange(cellRangeAddress);
					foreach (global::NPOI.SS.UserModel.ICell cell2 in cellRange)
					{
						cell2.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
					}
					return cellRange;
				}
			}
			string r = ((global::NPOI.XSSF.UserModel.XSSFCell)cell).GetCTCell().r;
			throw new global::System.ArgumentException("Cell " + r + " is not part of an array formula.");
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000210B0 File Offset: 0x0001F2B0
		public global::NPOI.SS.UserModel.IDataValidationHelper GetDataValidationHelper()
		{
			return this.dataValidationHelper;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000210B8 File Offset: 0x0001F2B8
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> GetDataValidations()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation>();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations dataValidations = this.worksheet.dataValidations;
			if (dataValidations != null && dataValidations.count > 0U)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ct_DataValidation in dataValidations.dataValidation)
				{
					global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList = new global::NPOI.SS.Util.CellRangeAddressList();
					string[] array = ct_DataValidation.sqref.Split(new char[]
					{
						' '
					});
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].Length != 0)
						{
							string[] array2 = array[i].Split(new char[]
							{
								':'
							});
							global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(array2[0]);
							global::NPOI.SS.Util.CellReference cellReference2 = (array2.Length > 1) ? new global::NPOI.SS.Util.CellReference(array2[1]) : cellReference;
							global::NPOI.SS.Util.CellRangeAddress cra = new global::NPOI.SS.Util.CellRangeAddress(cellReference.Row, cellReference2.Row, (int)cellReference.Col, (int)cellReference2.Col);
							cellRangeAddressList.AddCellRangeAddress(cra);
						}
					}
					global::NPOI.XSSF.UserModel.XSSFDataValidation item = new global::NPOI.XSSF.UserModel.XSSFDataValidation(cellRangeAddressList, ct_DataValidation);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000211E4 File Offset: 0x0001F3E4
		public void AddValidationData(global::NPOI.SS.UserModel.IDataValidation dataValidation)
		{
			global::NPOI.XSSF.UserModel.XSSFDataValidation xssfdataValidation = (global::NPOI.XSSF.UserModel.XSSFDataValidation)dataValidation;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations ct_DataValidations = this.worksheet.dataValidations;
			if (ct_DataValidations == null)
			{
				ct_DataValidations = this.worksheet.AddNewDataValidations();
			}
			int num = ct_DataValidations.sizeOfDataValidationArray();
			ct_DataValidations.AddNewDataValidation().Set(xssfdataValidation.GetCTDataValidation());
			ct_DataValidations.count = (uint)(num + 1);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00021234 File Offset: 0x0001F434
		public global::NPOI.SS.UserModel.IAutoFilter SetAutoFilter(global::NPOI.SS.Util.CellRangeAddress range)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter ct_AutoFilter = this.worksheet.autoFilter;
			if (ct_AutoFilter == null)
			{
				ct_AutoFilter = this.worksheet.AddNewAutoFilter();
			}
			string @ref = new global::NPOI.SS.Util.CellRangeAddress(range.FirstRow, range.LastRow, range.FirstColumn, range.LastColumn).FormatAsString();
			ct_AutoFilter.@ref = @ref;
			global::NPOI.XSSF.UserModel.XSSFWorkbook xssfworkbook = (global::NPOI.XSSF.UserModel.XSSFWorkbook)this.Workbook;
			int sheetIndex = this.Workbook.GetSheetIndex(this);
			global::NPOI.XSSF.UserModel.XSSFName xssfname = xssfworkbook.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_FILTER_DB, sheetIndex);
			if (xssfname == null)
			{
				xssfname = xssfworkbook.CreateBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_FILTER_DB, sheetIndex);
			}
			xssfname.GetCTName().hidden = true;
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this.SheetName, range.FirstRow, range.FirstColumn, true, true);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(null, range.LastRow, range.LastColumn, true, true);
			string refersToFormula = cellReference.FormatAsString() + ":" + cellReference2.FormatAsString();
			xssfname.RefersToFormula = refersToFormula;
			return new global::NPOI.XSSF.UserModel.XSSFAutoFilter(this);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00021324 File Offset: 0x0001F524
		public global::NPOI.XSSF.UserModel.XSSFTable CreateTable()
		{
			if (!this.worksheet.IsSetTableParts())
			{
				this.worksheet.AddNewTableParts();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart ct_TablePart = this.worksheet.tableParts.AddNewTablePart();
			int idx = base.GetPackagePart().Package.GetPartsByContentType(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE.ContentType).Count + 1;
			global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx, false);
			global::NPOI.XSSF.UserModel.XSSFTable xssftable = relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFTable;
			ct_TablePart.id = relationPart.Relationship.Id;
			this.tables[ct_TablePart.id] = xssftable;
			return xssftable;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000213C0 File Offset: 0x0001F5C0
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable> GetTables()
		{
			return new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable>(this.tables.Values);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000213D2 File Offset: 0x0001F5D2
		public global::NPOI.SS.UserModel.ISheetConditionalFormatting SheetConditionalFormatting
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFSheetConditionalFormatting(this);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000213DC File Offset: 0x0001F5DC
		[global::System.Obsolete("deprecated 3.15-beta2. Removed in 3.17. Use {@link #setTabColor(XSSFColor)}.")]
		public void SetTabColor(int colorIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = this.worksheet.sheetPr;
			if (ct_SheetPr == null)
			{
				ct_SheetPr = this.worksheet.AddNewSheetPr();
			}
			ct_SheetPr.tabColor = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
			{
				indexed = (uint)colorIndex
			};
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00021418 File Offset: 0x0001F618
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00021458 File Offset: 0x0001F658
		public global::NPOI.XSSF.UserModel.XSSFColor TabColor
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = this.worksheet.sheetPr;
				if (ct_SheetPr == null)
				{
					ct_SheetPr = this.worksheet.AddNewSheetPr();
				}
				if (!ct_SheetPr.IsSetTabColor())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(ct_SheetPr.tabColor);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr ct_SheetPr = this.worksheet.sheetPr;
				if (ct_SheetPr == null)
				{
					ct_SheetPr = this.worksheet.AddNewSheetPr();
				}
				ct_SheetPr.tabColor = value.GetCTColor();
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0002148C File Offset: 0x0001F68C
		public global::NPOI.SS.UserModel.IDrawing DrawingPatriarch
		{
			get
			{
				if (this.drawing == null)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing ctdrawing = this.GetCTDrawing();
					if (ctdrawing == null)
					{
						return null;
					}
					foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
					{
						global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
						if (documentPart is global::NPOI.XSSF.UserModel.XSSFDrawing)
						{
							global::NPOI.XSSF.UserModel.XSSFDrawing xssfdrawing = (global::NPOI.XSSF.UserModel.XSSFDrawing)documentPart;
							if (relationPart.Relationship.Id.Equals(ctdrawing.id))
							{
								this.drawing = xssfdrawing;
								break;
							}
							break;
						}
					}
				}
				return this.drawing;
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002152C File Offset: 0x0001F72C
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._rows.Values.GetEnumerator();
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002153E File Offset: 0x0001F73E
		public global::System.Collections.IEnumerator GetRowEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00021546 File Offset: 0x0001F746
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0002154E File Offset: 0x0001F74E
		public bool IsActive
		{
			get
			{
				return this.IsSelected;
			}
			set
			{
				this.IsSelected = value;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00021558 File Offset: 0x0001F758
		public bool IsMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion)
		{
			if (this.worksheet.mergeCells == null || this.worksheet.mergeCells.mergeCell == null)
			{
				return false;
			}
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell ct_MergeCell in this.worksheet.mergeCells.mergeCell)
			{
				if (!string.IsNullOrEmpty(ct_MergeCell.@ref))
				{
					global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(ct_MergeCell.@ref);
					if (cellRangeAddress.FirstColumn <= mergedRegion.FirstColumn && cellRangeAddress.LastColumn >= mergedRegion.LastColumn && cellRangeAddress.FirstRow <= mergedRegion.FirstRow && cellRangeAddress.LastRow >= mergedRegion.LastRow)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002154E File Offset: 0x0001F74E
		public void SetActive(bool value)
		{
			this.IsSelected = value;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00021628 File Offset: 0x0001F828
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00021628 File Offset: 0x0001F828
		public short TabColorIndex
		{
			get
			{
				throw new global::System.NotImplementedException("Use XSSFSheet.TabColor instead");
			}
			set
			{
				throw new global::System.NotImplementedException("Use XSSFSheet.TabColor instead");
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00021634 File Offset: 0x0001F834
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0001DDDB File Offset: 0x0001BFDB
		public bool IsRightToLeft
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView defaultSheetView = this.GetDefaultSheetView();
				return defaultSheetView != null && defaultSheetView.rightToLeft;
			}
			set
			{
				this.GetDefaultSheetView().rightToLeft = value;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00021653 File Offset: 0x0001F853
		public global::NPOI.SS.UserModel.IRow CopyRow(int sourceIndex, int targetIndex)
		{
			return global::NPOI.SS.Util.SheetUtil.CopyRow(this, sourceIndex, targetIndex);
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0002165D File Offset: 0x0001F85D
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00021668 File Offset: 0x0001F868
		public global::NPOI.SS.Util.CellRangeAddress RepeatingRows
		{
			get
			{
				return this.GetRepeatingRowsOrColums(true);
			}
			set
			{
				global::NPOI.SS.Util.CellRangeAddress repeatingColumns = this.RepeatingColumns;
				this.SetRepeatingRowsAndColumns(value, repeatingColumns);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00021684 File Offset: 0x0001F884
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00021690 File Offset: 0x0001F890
		public global::NPOI.SS.Util.CellRangeAddress RepeatingColumns
		{
			get
			{
				return this.GetRepeatingRowsOrColums(false);
			}
			set
			{
				global::NPOI.SS.Util.CellRangeAddress repeatingRows = this.RepeatingRows;
				this.SetRepeatingRowsAndColumns(repeatingRows, value);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000208CC File Offset: 0x0001EACC
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane Pane
		{
			get
			{
				if (this.GetDefaultSheetView().pane == null)
				{
					this.GetDefaultSheetView().AddNewPane();
				}
				return this.GetDefaultSheetView().pane;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000216AC File Offset: 0x0001F8AC
		public void ShowInPane(int toprow, int leftcol)
		{
			string topLeftCell = new global::NPOI.SS.Util.CellReference(toprow, leftcol).FormatAsString();
			this.Pane.topLeftCell = topLeftCell;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000216D4 File Offset: 0x0001F8D4
		private void SetRepeatingRowsAndColumns(global::NPOI.SS.Util.CellRangeAddress rowDef, global::NPOI.SS.Util.CellRangeAddress colDef)
		{
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			if (rowDef != null)
			{
				num3 = rowDef.FirstRow;
				num4 = rowDef.LastRow;
				if ((num3 == -1 && num4 != -1) || num3 < -1 || num4 < -1 || num3 > num4)
				{
					throw new global::System.ArgumentException("Invalid row range specification");
				}
			}
			if (colDef != null)
			{
				num = colDef.FirstColumn;
				num2 = colDef.LastColumn;
				if ((num == -1 && num2 != -1) || num < -1 || num2 < -1 || num > num2)
				{
					throw new global::System.ArgumentException("Invalid column range specification");
				}
			}
			int sheetIndex = this.Workbook.GetSheetIndex(this);
			bool flag = rowDef == null && colDef == null;
			global::NPOI.XSSF.UserModel.XSSFWorkbook xssfworkbook = this.Workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook;
			if (xssfworkbook == null)
			{
				throw new global::NPOI.Util.RuntimeException("Workbook should not be null");
			}
			global::NPOI.XSSF.UserModel.XSSFName xssfname = xssfworkbook.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_TITLE, sheetIndex);
			if (flag)
			{
				if (xssfname != null)
				{
					xssfworkbook.RemoveName(xssfname);
				}
				return;
			}
			if (xssfname == null)
			{
				xssfname = xssfworkbook.CreateBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_TITLE, sheetIndex);
			}
			string referenceBuiltInRecord = global::NPOI.XSSF.UserModel.XSSFSheet.GetReferenceBuiltInRecord(xssfname.SheetName, num, num2, num3, num4);
			xssfname.RefersToFormula = referenceBuiltInRecord;
			if (!this.worksheet.IsSetPageSetup() || !this.worksheet.IsSetPageMargins())
			{
				this.PrintSetup.ValidSettings = false;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000217F4 File Offset: 0x0001F9F4
		private static string GetReferenceBuiltInRecord(string sheetName, int startC, int endC, int startR, int endR)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(sheetName, 0, startC, true, true);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(sheetName, 0, endC, true, true);
			global::NPOI.SS.Util.CellReference cellReference3 = new global::NPOI.SS.Util.CellReference(sheetName, startR, 0, true, true);
			global::NPOI.SS.Util.CellReference cellReference4 = new global::NPOI.SS.Util.CellReference(sheetName, endR, 0, true, true);
			string text = global::NPOI.SS.Formula.SheetNameFormatter.Format(sheetName);
			string value = "";
			string text2 = "";
			if (startC != -1 || endC != -1)
			{
				string text3 = cellReference.CellRefParts[2];
				string text4 = cellReference2.CellRefParts[2];
				value = string.Concat(new string[]
				{
					text,
					"!$",
					text3,
					":$",
					text4
				});
			}
			if (startR != -1 || endR != -1)
			{
				string text5 = cellReference3.CellRefParts[1];
				string text6 = cellReference4.CellRefParts[1];
				if (!text5.Equals("0") && !text6.Equals("0"))
				{
					text2 = string.Concat(new string[]
					{
						text,
						"!$",
						text5,
						":$",
						text6
					});
				}
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(value);
			if (stringBuilder.Length > 0 && text2.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append(text2);
			return stringBuilder.ToString();
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00021934 File Offset: 0x0001FB34
		private global::NPOI.SS.Util.CellRangeAddress GetRepeatingRowsOrColums(bool rows)
		{
			int sheetIndex = this.Workbook.GetSheetIndex(this);
			global::NPOI.XSSF.UserModel.XSSFWorkbook xssfworkbook = this.Workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook;
			if (xssfworkbook == null)
			{
				throw new global::NPOI.Util.RuntimeException("Workbook should not be null");
			}
			global::NPOI.XSSF.UserModel.XSSFName builtInName = xssfworkbook.GetBuiltInName(global::NPOI.XSSF.UserModel.XSSFName.BUILTIN_PRINT_TITLE, sheetIndex);
			if (builtInName == null)
			{
				return null;
			}
			string refersToFormula = builtInName.RefersToFormula;
			if (refersToFormula == null)
			{
				return null;
			}
			string[] array = refersToFormula.Split(",".ToCharArray());
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastRowIndex;
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastColumnIndex;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(array2[i]);
				if ((cellRangeAddress.FirstColumn == 0 && cellRangeAddress.LastColumn == lastColumnIndex) || (cellRangeAddress.FirstColumn == -1 && cellRangeAddress.LastColumn == -1))
				{
					if (rows)
					{
						return cellRangeAddress;
					}
				}
				else if (((cellRangeAddress.FirstRow == 0 && cellRangeAddress.LastRow == lastRowIndex) || (cellRangeAddress.FirstRow == -1 && cellRangeAddress.LastRow == -1)) && !rows)
				{
					return cellRangeAddress;
				}
			}
			return null;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00021A28 File Offset: 0x0001FC28
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name)
		{
			return this.CopySheet(Name, true);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00021A34 File Offset: 0x0001FC34
		public global::NPOI.SS.UserModel.ISheet CopySheet(string name, bool copyStyle)
		{
			string uniqueSheetName = global::NPOI.SS.Util.SheetUtil.GetUniqueSheetName(this.Workbook, name);
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.Workbook.CreateSheet(uniqueSheetName);
			try
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					this.Write(memoryStream);
					xssfsheet.Read(new global::System.IO.MemoryStream(memoryStream.ToArray()));
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.POIXMLException("Failed to clone sheet", ex);
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ctworksheet = xssfsheet.GetCTWorksheet();
			if (ctworksheet.IsSetLegacyDrawing())
			{
				global::NPOI.XSSF.UserModel.XSSFSheet.logger.Log(5, "Cloning sheets with comments is not yet supported.");
				ctworksheet.UnsetLegacyDrawing();
			}
			xssfsheet.IsSelected = false;
			global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> relations = base.GetRelations();
			global::NPOI.XSSF.UserModel.XSSFDrawing xssfdrawing = null;
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in relations)
			{
				if (poixmldocumentPart is global::NPOI.XSSF.UserModel.XSSFDrawing)
				{
					xssfdrawing = (global::NPOI.XSSF.UserModel.XSSFDrawing)poixmldocumentPart;
				}
				else if (!poixmldocumentPart.GetPackagePart().PartName.Name.StartsWith("/xl/printerSettings/printerSettings"))
				{
					global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = poixmldocumentPart.GetPackageRelationship();
					xssfsheet.GetPackagePart().AddRelationship(packageRelationship.TargetUri, packageRelationship.TargetMode.Value, packageRelationship.RelationshipType);
					xssfsheet.AddRelation(packageRelationship.Id, poixmldocumentPart);
				}
			}
			xssfsheet.hyperlinks = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFHyperlink>(this.hyperlinks);
			if (xssfdrawing != null)
			{
				if (ctworksheet.IsSetDrawing())
				{
					ctworksheet.UnsetDrawing();
				}
				global::NPOI.XSSF.UserModel.XSSFDrawing xssfdrawing2 = xssfsheet.CreateDrawingPatriarch() as global::NPOI.XSSF.UserModel.XSSFDrawing;
				xssfdrawing2.GetCTDrawing().Set(xssfdrawing.GetCTDrawing());
				xssfdrawing2 = (xssfsheet.CreateDrawingPatriarch() as global::NPOI.XSSF.UserModel.XSSFDrawing);
				foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart2 in xssfdrawing.GetRelations())
				{
					global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship2 = poixmldocumentPart2.GetPackageRelationship();
					xssfdrawing2.AddRelation(packageRelationship2.Id, poixmldocumentPart2);
					xssfdrawing2.GetPackagePart().AddRelationship(packageRelationship2.TargetUri, packageRelationship2.TargetMode.Value, packageRelationship2.RelationshipType, packageRelationship2.Id);
				}
			}
			return xssfsheet;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00021C78 File Offset: 0x0001FE78
		private void CopySheetImages(global::NPOI.XSSF.UserModel.XSSFWorkbook destWorkbook, global::NPOI.XSSF.UserModel.XSSFSheet destSheet)
		{
			global::NPOI.XSSF.UserModel.XSSFDrawing drawingPatriarch = this.GetDrawingPatriarch();
			if (drawingPatriarch != null)
			{
				global::NPOI.SS.UserModel.IDrawing drawing = destSheet.CreateDrawingPatriarch();
				global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> relations = drawingPatriarch.GetRelations();
				global::System.Collections.Generic.Dictionary<string, uint> dictionary = new global::System.Collections.Generic.Dictionary<string, uint>();
				foreach (global::NPOI.OpenXmlFormats.Dml.Spreadsheet.IEG_Anchor ieg_Anchor in drawingPatriarch.GetCTDrawing().CellAnchors)
				{
					global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor ct_TwoCellAnchor = ieg_Anchor as global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TwoCellAnchor;
					if (ct_TwoCellAnchor != null)
					{
						global::NPOI.XSSF.UserModel.XSSFClientAnchor xssfclientAnchor = new global::NPOI.XSSF.UserModel.XSSFClientAnchor((int)ct_TwoCellAnchor.from.colOff, (int)ct_TwoCellAnchor.from.rowOff, (int)ct_TwoCellAnchor.to.colOff, (int)ct_TwoCellAnchor.to.rowOff, ct_TwoCellAnchor.from.col, ct_TwoCellAnchor.from.row, ct_TwoCellAnchor.to.col, ct_TwoCellAnchor.to.row);
						if (ct_TwoCellAnchor.editAsSpecified)
						{
							switch (ct_TwoCellAnchor.editAs)
							{
							case global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.twoCell:
								xssfclientAnchor.AnchorType = global::NPOI.SS.UserModel.AnchorType.MoveAndResize;
								goto IL_103;
							case global::NPOI.OpenXmlFormats.Dml.Spreadsheet.ST_EditAs.oneCell:
								xssfclientAnchor.AnchorType = global::NPOI.SS.UserModel.AnchorType.MoveDontResize;
								goto IL_103;
							}
							xssfclientAnchor.AnchorType = global::NPOI.SS.UserModel.AnchorType.DontMoveAndResize;
						}
						IL_103:
						global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture picture = ieg_Anchor.picture;
						string text;
						if (picture == null)
						{
							text = null;
						}
						else
						{
							global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_BlipFillProperties blipFill = picture.blipFill;
							text = ((blipFill != null) ? blipFill.blip.embed : null);
						}
						string text2 = text;
						if (text2 != null)
						{
							if (!dictionary.ContainsKey(text2))
							{
								global::NPOI.XSSF.UserModel.XSSFPictureData xssfpictureData = this.FindPicture(relations, text2);
								if (xssfpictureData == null || xssfpictureData.PictureType == global::NPOI.SS.UserModel.PictureType.None)
								{
									continue;
								}
								dictionary.Add(text2, (uint)destWorkbook.AddPicture(xssfpictureData.Data, xssfpictureData.PictureType));
							}
							drawing.CreatePicture(xssfclientAnchor, (int)dictionary[text2]);
						}
					}
				}
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00021E3C File Offset: 0x0002003C
		private global::NPOI.XSSF.UserModel.XSSFPictureData FindPicture(global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> sheetPictures, string id)
		{
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in sheetPictures)
			{
				if (poixmldocumentPart.GetPackageRelationship().Id == id)
				{
					return poixmldocumentPart as global::NPOI.XSSF.UserModel.XSSFPictureData;
				}
			}
			return null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00021EA4 File Offset: 0x000200A4
		public void CopyTo(global::NPOI.SS.UserModel.IWorkbook dest, string name, bool copyStyle, bool keepFormulas)
		{
			global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)dest).GetStylesSource();
			if (copyStyle && this.Workbook.NumberOfFonts > 0)
			{
				foreach (global::NPOI.XSSF.UserModel.XSSFFont font in ((global::NPOI.XSSF.UserModel.XSSFWorkbook)this.Workbook).GetStylesSource().GetFonts())
				{
					stylesSource.PutFont(font);
				}
			}
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)dest.CreateSheet(name);
			xssfsheet.sheet.state = this.sheet.state;
			global::System.Collections.Generic.IDictionary<int, global::NPOI.SS.UserModel.ICellStyle> styleMap = copyStyle ? new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.ICellStyle>() : null;
			for (int i = this.FirstRowNum; i <= this.LastRowNum; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)this.GetRow(i);
				global::NPOI.XSSF.UserModel.XSSFRow destRow = (global::NPOI.XSSF.UserModel.XSSFRow)xssfsheet.CreateRow(i);
				if (xssfrow != null)
				{
					global::NPOI.XSSF.UserModel.XSSFSheet.CopyRow(this, xssfsheet, xssfrow, destRow, styleMap, keepFormulas);
				}
			}
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> colsList = this.worksheet.GetColsList();
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols> colsList2 = xssfsheet.worksheet.GetColsList();
			colsList2.Clear();
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols in colsList)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols2 = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in ct_Cols.col)
				{
					ct_Cols2.col.Add(ct_Col.Copy());
				}
				colsList2.Add(ct_Cols2);
			}
			xssfsheet.ForceFormulaRecalculation = true;
			xssfsheet.PrintSetup.Landscape = this.PrintSetup.Landscape;
			xssfsheet.PrintSetup.HResolution = this.PrintSetup.HResolution;
			xssfsheet.PrintSetup.VResolution = this.PrintSetup.VResolution;
			xssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin));
			xssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin));
			xssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin));
			xssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin));
			xssfsheet.PrintSetup.HeaderMargin = this.PrintSetup.HeaderMargin;
			xssfsheet.PrintSetup.FooterMargin = this.PrintSetup.FooterMargin;
			xssfsheet.Header.Left = this.Header.Left;
			xssfsheet.Header.Center = this.Header.Center;
			xssfsheet.Header.Right = this.Header.Right;
			xssfsheet.Footer.Left = this.Footer.Left;
			xssfsheet.Footer.Center = this.Footer.Center;
			xssfsheet.Footer.Right = this.Footer.Right;
			xssfsheet.PrintSetup.Scale = this.PrintSetup.Scale;
			xssfsheet.PrintSetup.FitHeight = this.PrintSetup.FitHeight;
			xssfsheet.PrintSetup.FitWidth = this.PrintSetup.FitWidth;
			xssfsheet.DisplayGridlines = this.DisplayGridlines;
			if (this.worksheet.IsSetSheetPr())
			{
				xssfsheet.worksheet.sheetPr = this.worksheet.sheetPr.Clone();
			}
			if (this.GetDefaultSheetView().pane != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane pane = this.GetDefaultSheetView().pane;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Pane pane2 = xssfsheet.GetPane();
				pane2.activePane = pane.activePane;
				pane2.state = pane.state;
				pane2.topLeftCell = pane.topLeftCell;
				pane2.xSplit = pane.xSplit;
				pane2.ySplit = pane.ySplit;
			}
			this.CopySheetImages(dest as global::NPOI.XSSF.UserModel.XSSFWorkbook, xssfsheet);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00022264 File Offset: 0x00020464
		private static void CopyRow(global::NPOI.XSSF.UserModel.XSSFSheet srcSheet, global::NPOI.XSSF.UserModel.XSSFSheet destSheet, global::NPOI.XSSF.UserModel.XSSFRow srcRow, global::NPOI.XSSF.UserModel.XSSFRow destRow, global::System.Collections.Generic.IDictionary<int, global::NPOI.SS.UserModel.ICellStyle> styleMap, bool keepFormulas)
		{
			destRow.Height = srcRow.Height;
			if (!srcRow.GetCTRow().IsSetCustomHeight())
			{
				destRow.GetCTRow().UnsetCustomHeight();
			}
			destRow.Hidden = srcRow.Hidden;
			destRow.Collapsed = srcRow.Collapsed;
			destRow.OutlineLevel = srcRow.OutlineLevel;
			if (srcRow.FirstCellNum < 0)
			{
				return;
			}
			for (int i = (int)srcRow.FirstCellNum; i <= (int)srcRow.LastCellNum; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)srcRow.GetCell(i);
				global::NPOI.XSSF.UserModel.XSSFCell xssfcell2 = (global::NPOI.XSSF.UserModel.XSSFCell)destRow.GetCell(i);
				if (srcSheet.Workbook == destSheet.Workbook)
				{
					xssfcell2 = (global::NPOI.XSSF.UserModel.XSSFCell)destRow.GetCell(i);
				}
				if (xssfcell != null)
				{
					if (xssfcell2 == null)
					{
						xssfcell2 = (global::NPOI.XSSF.UserModel.XSSFCell)destRow.CreateCell(i);
					}
					global::NPOI.XSSF.UserModel.XSSFSheet.CopyCell(xssfcell, xssfcell2, styleMap, keepFormulas);
					global::NPOI.SS.Util.CellRangeAddress mergedRegion = srcSheet.GetMergedRegion(new global::NPOI.SS.Util.CellRangeAddress(srcRow.RowNum, srcRow.RowNum, (int)((short)xssfcell.ColumnIndex), (int)((short)xssfcell.ColumnIndex)));
					if (mergedRegion != null)
					{
						global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = new global::NPOI.SS.Util.CellRangeAddress(mergedRegion.FirstRow, mergedRegion.LastRow, mergedRegion.FirstColumn, mergedRegion.LastColumn);
						if (!destSheet.IsMergedRegion(cellRangeAddress))
						{
							destSheet.AddMergedRegion(cellRangeAddress);
						}
					}
				}
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00022390 File Offset: 0x00020590
		private static void CopyCell(global::NPOI.SS.UserModel.ICell oldCell, global::NPOI.SS.UserModel.ICell newCell, global::System.Collections.Generic.IDictionary<int, global::NPOI.SS.UserModel.ICellStyle> styleMap, bool keepFormulas)
		{
			if (styleMap != null)
			{
				if (oldCell.CellStyle != null)
				{
					if (oldCell.Sheet.Workbook == newCell.Sheet.Workbook)
					{
						newCell.CellStyle = oldCell.CellStyle;
					}
					else
					{
						int hashCode = oldCell.CellStyle.GetHashCode();
						if (styleMap.ContainsKey(hashCode))
						{
							newCell.CellStyle = styleMap[hashCode];
						}
						else
						{
							global::NPOI.SS.UserModel.ICellStyle cellStyle = newCell.Sheet.Workbook.CreateCellStyle();
							cellStyle.CloneStyleFrom(oldCell.CellStyle);
							newCell.CellStyle = cellStyle;
							styleMap.Add(hashCode, cellStyle);
						}
					}
				}
				else
				{
					newCell.CellStyle = null;
				}
			}
			switch (oldCell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				newCell.SetCellValue(oldCell.NumericCellValue);
				return;
			case global::NPOI.SS.UserModel.CellType.String:
			{
				global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = oldCell.RichStringCellValue as global::NPOI.XSSF.UserModel.XSSFRichTextString;
				newCell.SetCellValue(xssfrichTextString);
				if (xssfrichTextString != null)
				{
					for (int i = 0; i < xssfrichTextString.NumFormattingRuns; i++)
					{
						int indexOfFormattingRun = xssfrichTextString.GetIndexOfFormattingRun(i);
						int endIndex;
						if (i + 1 == xssfrichTextString.NumFormattingRuns)
						{
							endIndex = xssfrichTextString.Length;
						}
						else
						{
							endIndex = xssfrichTextString.GetIndexOfFormattingRun(i + 1);
						}
						global::NPOI.SS.UserModel.IFont font = newCell.Sheet.Workbook.CreateFont();
						font.CloneStyleFrom(xssfrichTextString.GetFontOfFormattingRun(i));
						newCell.RichStringCellValue.ApplyFont(indexOfFormattingRun, endIndex, font);
					}
					return;
				}
				break;
			}
			case global::NPOI.SS.UserModel.CellType.Formula:
				if (keepFormulas)
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Formula);
					newCell.CellFormula = oldCell.CellFormula;
					return;
				}
				try
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Numeric);
					newCell.SetCellValue(oldCell.NumericCellValue);
				}
				catch (global::System.Exception)
				{
					newCell.SetCellType(global::NPOI.SS.UserModel.CellType.String);
					newCell.SetCellValue(oldCell.ToString());
				}
				break;
			case global::NPOI.SS.UserModel.CellType.Blank:
				newCell.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				newCell.SetCellValue(oldCell.BooleanCellValue);
				return;
			case global::NPOI.SS.UserModel.CellType.Error:
				newCell.SetCellValue((double)oldCell.ErrorCellValue);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001CF0B File Offset: 0x0001B10B
		public global::NPOI.XSSF.UserModel.XSSFWorkbook GetWorkbook()
		{
			return (global::NPOI.XSSF.UserModel.XSSFWorkbook)base.GetParent();
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00022564 File Offset: 0x00020764
		private global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable()
		{
			global::NPOI.XSSF.UserModel.XSSFWorkbook workbook = this.GetWorkbook();
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable> pivotTables = workbook.PivotTables;
			int idx = this.GetWorkbook().PivotTables.Count + 1;
			global::NPOI.XSSF.UserModel.XSSFPivotTable xssfpivotTable = (global::NPOI.XSSF.UserModel.XSSFPivotTable)base.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.PIVOT_TABLE, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx);
			xssfpivotTable.SetParentSheet(this);
			pivotTables.Add(xssfpivotTable);
			global::NPOI.XSSF.UserModel.XSSFWorkbook workbook2 = this.GetWorkbook();
			global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition xssfpivotCacheDefinition = (global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition)workbook2.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.PIVOT_CACHE_DEFINITION, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx);
			string relationId = workbook2.GetRelationId(xssfpivotCacheDefinition);
			xssfpivotTable.GetPackagePart().AddRelationship(xssfpivotCacheDefinition.GetPackagePart().PartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, global::NPOI.XSSF.UserModel.XSSFRelation.PIVOT_CACHE_DEFINITION.Relation);
			xssfpivotTable.SetPivotCacheDefinition(xssfpivotCacheDefinition);
			xssfpivotTable.SetPivotCache(new global::NPOI.XSSF.UserModel.XSSFPivotCache(workbook2.AddPivotCache(relationId)));
			global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords part = (global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords)xssfpivotCacheDefinition.CreateRelationship(global::NPOI.XSSF.UserModel.XSSFRelation.PIVOT_CACHE_RECORDS, global::NPOI.XSSF.UserModel.XSSFFactory.GetInstance(), idx);
			xssfpivotTable.GetPivotCacheDefinition().GetCTPivotCacheDefinition().id = xssfpivotCacheDefinition.GetRelationId(part);
			workbook.PivotTables = pivotTables;
			return xssfpivotTable;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00022658 File Offset: 0x00020858
		public global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.Util.AreaReference source, global::NPOI.SS.Util.CellReference position, global::NPOI.SS.UserModel.ISheet sourceSheet)
		{
			string sheetName = source.FirstCell.SheetName;
			if (sheetName != null && !sheetName.Equals(sourceSheet.SheetName, global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				throw new global::System.ArgumentException("The area is referenced in another sheet than the defined source sheet " + sourceSheet.SheetName + ".");
			}
			global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator refConfig = new global::NPOI.XSSF.UserModel.XSSFSheet.PivotTableReferenceConfigurator1(source);
			return this.CreatePivotTable(position, sourceSheet, refConfig);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000226AE File Offset: 0x000208AE
		private global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.Util.CellReference position, global::NPOI.SS.UserModel.ISheet sourceSheet, global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator refConfig)
		{
			global::NPOI.XSSF.UserModel.XSSFPivotTable xssfpivotTable = this.CreatePivotTable();
			xssfpivotTable.SetDefaultPivotTableDefinition();
			xssfpivotTable.CreateSourceReferences(position, sourceSheet, refConfig);
			xssfpivotTable.GetPivotCacheDefinition().CreateCacheFields(sourceSheet);
			xssfpivotTable.CreateDefaultDataColumns();
			return xssfpivotTable;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000226D8 File Offset: 0x000208D8
		public global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.Util.AreaReference source, global::NPOI.SS.Util.CellReference position)
		{
			string sheetName = source.FirstCell.SheetName;
			if (sheetName != null && !sheetName.Equals(this.SheetName, global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				global::NPOI.XSSF.UserModel.XSSFSheet sourceSheet = this.Workbook.GetSheet(sheetName) as global::NPOI.XSSF.UserModel.XSSFSheet;
				return this.CreatePivotTable(source, position, sourceSheet);
			}
			return this.CreatePivotTable(source, position, this);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00022728 File Offset: 0x00020928
		public global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.UserModel.IName source, global::NPOI.SS.Util.CellReference position, global::NPOI.SS.UserModel.ISheet sourceSheet)
		{
			if (source.SheetName != null && !source.SheetName.Equals(sourceSheet.SheetName))
			{
				throw new global::System.ArgumentException("The named range references another sheet than the defined source sheet " + sourceSheet.SheetName + ".");
			}
			return this.CreatePivotTable(position, sourceSheet, new global::NPOI.XSSF.UserModel.XSSFSheet.PivotTableReferenceConfigurator2(source));
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00022779 File Offset: 0x00020979
		public global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.UserModel.IName source, global::NPOI.SS.Util.CellReference position)
		{
			return this.CreatePivotTable(source, position, this.GetWorkbook().GetSheet(source.SheetName));
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00022794 File Offset: 0x00020994
		public global::NPOI.XSSF.UserModel.XSSFPivotTable CreatePivotTable(global::NPOI.SS.UserModel.ITable source, global::NPOI.SS.Util.CellReference position)
		{
			return this.CreatePivotTable(position, this.GetWorkbook().GetSheet(source.SheetName), new global::NPOI.XSSF.UserModel.XSSFSheet.PivotTableReferenceConfigurator3(source));
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000227B4 File Offset: 0x000209B4
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable> GetPivotTables()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFPivotTable>();
			foreach (global::NPOI.XSSF.UserModel.XSSFPivotTable xssfpivotTable in this.GetWorkbook().PivotTables)
			{
				if (xssfpivotTable.GetParent() == this)
				{
					list.Add(xssfpivotTable);
				}
			}
			return list;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0002281C File Offset: 0x00020A1C
		public int GetColumnOutlineLevel(int columnIndex)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col column = this.columnHelper.GetColumn((long)columnIndex, false);
			if (column == null)
			{
				return 0;
			}
			return (int)column.outlineLevel;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool IsDate1904()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00022843 File Offset: 0x00020A43
		public void AddIgnoredErrors(global::NPOI.SS.Util.CellReference cell, params global::NPOI.SS.UserModel.IgnoredErrorType[] ignoredErrorTypes)
		{
			this.AddIgnoredErrors(cell.FormatAsString(), ignoredErrorTypes);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00022852 File Offset: 0x00020A52
		public void AddIgnoredErrors(global::NPOI.SS.Util.CellRangeAddress region, params global::NPOI.SS.UserModel.IgnoredErrorType[] ignoredErrorTypes)
		{
			region.Validate(global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			this.AddIgnoredErrors(region.FormatAsString(), ignoredErrorTypes);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002286C File Offset: 0x00020A6C
		public global::System.Collections.Generic.Dictionary<global::NPOI.SS.UserModel.IgnoredErrorType, global::System.Collections.Generic.ISet<global::NPOI.SS.Util.CellRangeAddress>> GetIgnoredErrors()
		{
			global::System.Collections.Generic.Dictionary<global::NPOI.SS.UserModel.IgnoredErrorType, global::System.Collections.Generic.ISet<global::NPOI.SS.Util.CellRangeAddress>> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.UserModel.IgnoredErrorType, global::System.Collections.Generic.ISet<global::NPOI.SS.Util.CellRangeAddress>>();
			if (this.worksheet.IsSetIgnoredErrors())
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError ct_IgnoredError in this.worksheet.ignoredErrors.ignoredError)
				{
					foreach (global::NPOI.SS.UserModel.IgnoredErrorType key in this.GetErrorTypes(ct_IgnoredError))
					{
						if (!dictionary.ContainsKey(key))
						{
							dictionary.Add(key, new global::System.Collections.Generic.HashSet<global::NPOI.SS.Util.CellRangeAddress>());
						}
						foreach (object obj in ct_IgnoredError.sqref)
						{
							dictionary[key].Add(global::NPOI.SS.Util.CellRangeAddress.ValueOf(obj.ToString()));
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00022984 File Offset: 0x00020B84
		private void AddIgnoredErrors(string ref1, params global::NPOI.SS.UserModel.IgnoredErrorType[] ignoredErrorTypes)
		{
			global::NPOI.XSSF.UserModel.Helpers.XSSFIgnoredErrorHelper.AddIgnoredErrors((this.worksheet.IsSetIgnoredErrors() ? this.worksheet.ignoredErrors : this.worksheet.AddNewIgnoredErrors()).AddNewIgnoredError(), ref1, ignoredErrorTypes);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000229B8 File Offset: 0x00020BB8
		private global::System.Collections.Generic.ISet<global::NPOI.SS.UserModel.IgnoredErrorType> GetErrorTypes(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError err)
		{
			global::System.Collections.Generic.ISet<global::NPOI.SS.UserModel.IgnoredErrorType> set = new global::System.Collections.Generic.HashSet<global::NPOI.SS.UserModel.IgnoredErrorType>();
			foreach (global::NPOI.SS.UserModel.IgnoredErrorType ignoredErrorType in global::NPOI.SS.UserModel.IgnoredErrorTypeValues.Values)
			{
				if (global::NPOI.XSSF.UserModel.Helpers.XSSFIgnoredErrorHelper.IsSet(ignoredErrorType, err))
				{
					set.Add(ignoredErrorType);
				}
			}
			return set;
		}

		// Token: 0x0400034D RID: 845
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFSheet));

		// Token: 0x0400034E RID: 846
		private static double DEFAULT_ROW_HEIGHT = 15.0;

		// Token: 0x0400034F RID: 847
		private static double DEFAULT_MARGIN_HEADER = 0.3;

		// Token: 0x04000350 RID: 848
		private static double DEFAULT_MARGIN_FOOTER = 0.3;

		// Token: 0x04000351 RID: 849
		private static double DEFAULT_MARGIN_TOP = 0.75;

		// Token: 0x04000352 RID: 850
		private static double DEFAULT_MARGIN_BOTTOM = 0.75;

		// Token: 0x04000353 RID: 851
		private static double DEFAULT_MARGIN_LEFT = 0.7;

		// Token: 0x04000354 RID: 852
		private static double DEFAULT_MARGIN_RIGHT = 0.7;

		// Token: 0x04000355 RID: 853
		public static int TWIPS_PER_POINT = 20;

		// Token: 0x04000356 RID: 854
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet sheet;

		// Token: 0x04000357 RID: 855
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheet;

		// Token: 0x04000358 RID: 856
		private global::System.Collections.Generic.SortedList<int, global::NPOI.XSSF.UserModel.XSSFRow> _rows = new global::System.Collections.Generic.SortedList<int, global::NPOI.XSSF.UserModel.XSSFRow>();

		// Token: 0x04000359 RID: 857
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFHyperlink> hyperlinks;

		// Token: 0x0400035A RID: 858
		private global::NPOI.XSSF.UserModel.Helpers.ColumnHelper columnHelper;

		// Token: 0x0400035B RID: 859
		private global::NPOI.XSSF.Model.CommentsTable sheetComments;

		// Token: 0x0400035C RID: 860
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula> sharedFormulas;

		// Token: 0x0400035D RID: 861
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable> tables;

		// Token: 0x0400035E RID: 862
		private global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> arrayFormulas;

		// Token: 0x0400035F RID: 863
		private global::NPOI.XSSF.UserModel.XSSFDataValidationHelper dataValidationHelper;

		// Token: 0x04000360 RID: 864
		private global::NPOI.XSSF.UserModel.XSSFDrawing drawing;

		// Token: 0x02000128 RID: 296
		private class ShiftCommentComparator : global::System.Collections.Generic.IComparer<global::NPOI.XSSF.UserModel.XSSFComment>
		{
			// Token: 0x06000FEF RID: 4079 RVA: 0x0003847B File Offset: 0x0003667B
			public ShiftCommentComparator(int shiftDir)
			{
				this.shiftDir = shiftDir;
			}

			// Token: 0x06000FF0 RID: 4080 RVA: 0x0003848C File Offset: 0x0003668C
			public int Compare(global::NPOI.XSSF.UserModel.XSSFComment o1, global::NPOI.XSSF.UserModel.XSSFComment o2)
			{
				int row = o1.Row;
				int row2 = o2.Row;
				if (row == row2)
				{
					return o1.GetHashCode() - o2.GetHashCode();
				}
				if (this.shiftDir > 0)
				{
					if (row >= row2)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					if (row <= row2)
					{
						return -1;
					}
					return 1;
				}
			}

			// Token: 0x04000509 RID: 1289
			private int shiftDir;
		}

		// Token: 0x02000129 RID: 297
		public class PivotTableReferenceConfigurator1 : global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator
		{
			// Token: 0x06000FF1 RID: 4081 RVA: 0x000384D1 File Offset: 0x000366D1
			public PivotTableReferenceConfigurator1(global::NPOI.SS.Util.AreaReference source)
			{
				this.source = source;
			}

			// Token: 0x06000FF2 RID: 4082 RVA: 0x000384E0 File Offset: 0x000366E0
			public void ConfigureReference(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource wsSource)
			{
				string[] cellRefParts = this.source.FirstCell.CellRefParts;
				string text = cellRefParts[1];
				string text2 = cellRefParts[2];
				string[] cellRefParts2 = this.source.LastCell.CellRefParts;
				string text3 = cellRefParts2[1];
				string text4 = cellRefParts2[2];
				string @ref = string.Concat(new string[]
				{
					text2,
					text,
					":",
					text4,
					text3
				});
				wsSource.@ref = @ref;
			}

			// Token: 0x0400050A RID: 1290
			private global::NPOI.SS.Util.AreaReference source;
		}

		// Token: 0x0200012A RID: 298
		public class PivotTableReferenceConfigurator2 : global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator
		{
			// Token: 0x06000FF3 RID: 4083 RVA: 0x00038548 File Offset: 0x00036748
			public PivotTableReferenceConfigurator2(global::NPOI.SS.UserModel.IName source)
			{
				this.source = source;
			}

			// Token: 0x06000FF4 RID: 4084 RVA: 0x00038557 File Offset: 0x00036757
			public void ConfigureReference(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource wsSource)
			{
				wsSource.name = this.source.NameName;
			}

			// Token: 0x0400050B RID: 1291
			private global::NPOI.SS.UserModel.IName source;
		}

		// Token: 0x0200012B RID: 299
		public class PivotTableReferenceConfigurator3 : global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator
		{
			// Token: 0x06000FF5 RID: 4085 RVA: 0x0003856A File Offset: 0x0003676A
			public PivotTableReferenceConfigurator3(global::NPOI.SS.UserModel.ITable source)
			{
				this.source = source;
			}

			// Token: 0x06000FF6 RID: 4086 RVA: 0x00038579 File Offset: 0x00036779
			public void ConfigureReference(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource wsSource)
			{
				wsSource.name = this.source.Name;
			}

			// Token: 0x0400050C RID: 1292
			private global::NPOI.SS.UserModel.ITable source;
		}
	}
}
