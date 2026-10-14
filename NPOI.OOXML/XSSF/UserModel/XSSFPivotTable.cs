using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000097 RID: 151
	public class XSSFPivotTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00019D0F File Offset: 0x00017F0F
		public XSSFPivotTable()
		{
			this.pivotTableDefinition = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition();
			this.pivotCache = new global::NPOI.XSSF.UserModel.XSSFPivotCache();
			this.pivotCacheDefinition = new global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition();
			this.pivotCacheRecords = new global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords();
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00019D43 File Offset: 0x00017F43
		protected XSSFPivotTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00019D58 File Offset: 0x00017F58
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFPivotTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00019D64 File Offset: 0x00017F64
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::System.Xml.XmlDocument xmlDocument = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.pivotTableDefinition = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition.Parse(xmlDocument.DocumentElement, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00019DAC File Offset: 0x00017FAC
		public void SetPivotCache(global::NPOI.XSSF.UserModel.XSSFPivotCache pivotCache)
		{
			this.pivotCache = pivotCache;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00019DB5 File Offset: 0x00017FB5
		public global::NPOI.XSSF.UserModel.XSSFPivotCache GetPivotCache()
		{
			return this.pivotCache;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00019DBD File Offset: 0x00017FBD
		public global::NPOI.SS.UserModel.ISheet GetParentSheet()
		{
			return this.parentSheet;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00019DC5 File Offset: 0x00017FC5
		public void SetParentSheet(global::NPOI.XSSF.UserModel.XSSFSheet parentSheet)
		{
			this.parentSheet = parentSheet;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00019DCE File Offset: 0x00017FCE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition GetCTPivotTableDefinition()
		{
			return this.pivotTableDefinition;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00019DD6 File Offset: 0x00017FD6
		public void SetCTPivotTableDefinition(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition pivotTableDefinition)
		{
			this.pivotTableDefinition = pivotTableDefinition;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00019DDF File Offset: 0x00017FDF
		public global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition GetPivotCacheDefinition()
		{
			return this.pivotCacheDefinition;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00019DE7 File Offset: 0x00017FE7
		public void SetPivotCacheDefinition(global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition pivotCacheDefinition)
		{
			this.pivotCacheDefinition = pivotCacheDefinition;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00019DF0 File Offset: 0x00017FF0
		public global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords GetPivotCacheRecords()
		{
			return this.pivotCacheRecords;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00019DF8 File Offset: 0x00017FF8
		public void SetPivotCacheRecords(global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords pivotCacheRecords)
		{
			this.pivotCacheRecords = pivotCacheRecords;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00019E01 File Offset: 0x00018001
		public global::NPOI.SS.UserModel.ISheet GetDataSheet()
		{
			return this.dataSheet;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00019E09 File Offset: 0x00018009
		private void SetDataSheet(global::NPOI.SS.UserModel.ISheet dataSheet)
		{
			this.dataSheet = dataSheet;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00019E14 File Offset: 0x00018014
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.pivotTableDefinition.Save(outputStream);
			outputStream.Close();
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00019E40 File Offset: 0x00018040
		protected internal void SetDefaultPivotTableDefinition()
		{
			this.pivotTableDefinition.multipleFieldFilters = false;
			this.pivotTableDefinition.indent = 0U;
			this.pivotTableDefinition.createdVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.CREATED_VERSION;
			this.pivotTableDefinition.minRefreshableVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.MIN_REFRESHABLE_VERSION;
			this.pivotTableDefinition.updatedVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.UPDATED_VERSION;
			this.pivotTableDefinition.itemPrintTitles = true;
			this.pivotTableDefinition.useAutoFormatting = true;
			this.pivotTableDefinition.applyNumberFormats = false;
			this.pivotTableDefinition.applyWidthHeightFormats = true;
			this.pivotTableDefinition.applyAlignmentFormats = false;
			this.pivotTableDefinition.applyPatternFormats = false;
			this.pivotTableDefinition.applyFontFormats = false;
			this.pivotTableDefinition.applyBorderFormats = false;
			this.pivotTableDefinition.cacheId = this.pivotCache.GetCTPivotCache().cacheId;
			this.pivotTableDefinition.name = "PivotTable" + this.pivotTableDefinition.cacheId.ToString();
			this.pivotTableDefinition.dataCaption = "Values";
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle ct_PivotTableStyle = this.pivotTableDefinition.AddNewPivotTableStyleInfo();
			ct_PivotTableStyle.name = "PivotStyleLight16";
			ct_PivotTableStyle.showLastColumn = true;
			ct_PivotTableStyle.showColStripes = false;
			ct_PivotTableStyle.showRowStripes = false;
			ct_PivotTableStyle.showColHeaders = true;
			ct_PivotTableStyle.showRowHeaders = true;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00019F84 File Offset: 0x00018184
		protected global::NPOI.SS.Util.AreaReference GetPivotArea()
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = this.GetDataSheet().Workbook;
			return this.GetPivotCacheDefinition().GetPivotArea(workbook);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00019FAC File Offset: 0x000181AC
		private void CheckColumnIndex(int columnIndex)
		{
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea();
			int num = (int)(pivotArea.LastCell.Col - pivotArea.FirstCell.Col + 1);
			if (columnIndex < 0 || columnIndex >= num)
			{
				throw new global::System.IndexOutOfRangeException("Column Index: " + columnIndex.ToString() + ", Size: " + num.ToString());
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0001A008 File Offset: 0x00018208
		public void AddRowLabel(int columnIndex)
		{
			this.CheckColumnIndex(columnIndex);
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea();
			int num = pivotArea.LastCell.Row - pivotArea.FirstCell.Row;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields pivotFields = this.pivotTableDefinition.pivotFields;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items ct_Items = ct_PivotField.AddNewItems();
			ct_PivotField.axis = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis.axisRow;
			ct_PivotField.showAll = false;
			for (int i = 0; i <= num; i++)
			{
				ct_Items.AddNewItem().t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType.@default;
			}
			ct_Items.count = ct_Items.SizeOfItemArray();
			pivotFields.SetPivotFieldArray(columnIndex, ct_PivotField);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields ct_RowFields;
			if (this.pivotTableDefinition.rowFields != null)
			{
				ct_RowFields = this.pivotTableDefinition.rowFields;
			}
			else
			{
				ct_RowFields = this.pivotTableDefinition.AddNewRowFields();
			}
			ct_RowFields.AddNewField().x = columnIndex;
			ct_RowFields.count = ct_RowFields.SizeOfFieldArray();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001A0DC File Offset: 0x000182DC
		public global::System.Collections.Generic.IList<int> GetRowLabelColumns()
		{
			if (this.pivotTableDefinition.rowFields != null)
			{
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field ct_Field in this.pivotTableDefinition.rowFields.GetFieldArray())
				{
					list.Add(ct_Field.x);
				}
				return list;
			}
			return new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001A158 File Offset: 0x00018358
		public void AddColumnLabel(global::NPOI.SS.UserModel.DataConsolidateFunction function, int columnIndex, string valueFieldName)
		{
			this.CheckColumnIndex(columnIndex);
			this.AddDataColumn(columnIndex, true);
			this.AddDataField(function, columnIndex, valueFieldName);
			if (this.pivotTableDefinition.dataFields.count == 2U)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields ct_ColFields;
				if (this.pivotTableDefinition.colFields != null)
				{
					ct_ColFields = this.pivotTableDefinition.colFields;
				}
				else
				{
					ct_ColFields = this.pivotTableDefinition.AddNewColFields();
				}
				ct_ColFields.AddNewField().x = -2;
				ct_ColFields.count = ct_ColFields.SizeOfFieldArray();
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001A1D0 File Offset: 0x000183D0
		public void AddColumnLabel(global::NPOI.SS.UserModel.DataConsolidateFunction function, int columnIndex)
		{
			this.AddColumnLabel(function, columnIndex, function.Name);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001A1E0 File Offset: 0x000183E0
		private void AddDataField(global::NPOI.SS.UserModel.DataConsolidateFunction function, int columnIndex, string valueFieldName)
		{
			this.CheckColumnIndex(columnIndex);
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataFields ct_DataFields;
			if (this.pivotTableDefinition.dataFields != null)
			{
				ct_DataFields = this.pivotTableDefinition.dataFields;
			}
			else
			{
				ct_DataFields = this.pivotTableDefinition.AddNewDataFields();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField ct_DataField = ct_DataFields.AddNewDataField();
			ct_DataField.subtotal = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction)function.Value;
			this.GetDataSheet().GetRow(pivotArea.FirstCell.Row).GetCell((int)pivotArea.FirstCell.Col + columnIndex).SetCellType(global::NPOI.SS.UserModel.CellType.String);
			ct_DataField.name = valueFieldName;
			ct_DataField.fld = (uint)columnIndex;
			ct_DataFields.count = ct_DataFields.SizeOfDataFieldArray();
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001A27C File Offset: 0x0001847C
		public void AddDataColumn(int columnIndex, bool isDataField)
		{
			this.CheckColumnIndex(columnIndex);
			this.pivotTableDefinition.pivotFields.SetPivotFieldArray(columnIndex, new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField
			{
				dataField = isDataField,
				showAll = false
			});
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001A2B8 File Offset: 0x000184B8
		public void AddReportFilter(int columnIndex)
		{
			this.CheckColumnIndex(columnIndex);
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea();
			int num = pivotArea.LastCell.Row - pivotArea.FirstCell.Row;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields pivotFields = this.pivotTableDefinition.pivotFields;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items ct_Items = ct_PivotField.AddNewItems();
			ct_PivotField.axis = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis.axisPage;
			ct_PivotField.showAll = false;
			for (int i = 0; i <= num; i++)
			{
				ct_Items.AddNewItem().t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType.@default;
			}
			ct_Items.count = ct_Items.SizeOfItemArray();
			pivotFields.SetPivotFieldArray(columnIndex, ct_PivotField);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageFields ct_PageFields;
			if (this.pivotTableDefinition.pageFields != null)
			{
				ct_PageFields = this.pivotTableDefinition.pageFields;
				this.pivotTableDefinition.multipleFieldFilters = true;
			}
			else
			{
				ct_PageFields = this.pivotTableDefinition.AddNewPageFields();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageField ct_PageField = ct_PageFields.AddNewPageField();
			ct_PageField.hier = -1;
			ct_PageField.fld = columnIndex;
			ct_PageFields.count = ct_PageFields.SizeOfPageFieldArray();
			this.pivotTableDefinition.location.colPageCount = ct_PageFields.count;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001A3B4 File Offset: 0x000185B4
		protected internal void CreateSourceReferences(global::NPOI.SS.Util.CellReference position, global::NPOI.SS.UserModel.ISheet sourceSheet, global::NPOI.XSSF.UserModel.XSSFPivotTable.IPivotTableReferenceConfigurator refConfig)
		{
			global::NPOI.SS.Util.AreaReference areaReference = new global::NPOI.SS.Util.AreaReference(position, new global::NPOI.SS.Util.CellReference(position.Row + 1, (int)(position.Col + 1)));
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location ct_Location;
			if (this.pivotTableDefinition.location == null)
			{
				ct_Location = this.pivotTableDefinition.AddNewLocation();
				ct_Location.firstDataCol = 1U;
				ct_Location.firstDataRow = 1U;
				ct_Location.firstHeaderRow = 1U;
			}
			else
			{
				ct_Location = this.pivotTableDefinition.location;
			}
			ct_Location.@ref = areaReference.FormatAsString();
			this.pivotTableDefinition.location = ct_Location;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource ct_CacheSource = this.GetPivotCacheDefinition().GetCTPivotCacheDefinition().AddNewCacheSource();
			ct_CacheSource.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SourceType.worksheet;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource ct_WorksheetSource = ct_CacheSource.AddNewWorksheetSource();
			ct_WorksheetSource.sheet = sourceSheet.SheetName;
			this.SetDataSheet(sourceSheet);
			refConfig.ConfigureReference(ct_WorksheetSource);
			if (ct_WorksheetSource.name == null && ct_WorksheetSource.@ref == null)
			{
				throw new global::System.ArgumentException("Pivot table source area reference or name must be specified.");
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001A484 File Offset: 0x00018684
		protected internal void CreateDefaultDataColumns()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFields ct_PivotFields;
			if (this.pivotTableDefinition.pivotFields != null)
			{
				ct_PivotFields = this.pivotTableDefinition.pivotFields;
			}
			else
			{
				ct_PivotFields = this.pivotTableDefinition.AddNewPivotFields();
			}
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea();
			int col = (int)pivotArea.FirstCell.Col;
			int col2 = (int)pivotArea.LastCell.Col;
			for (int i = col; i <= col2; i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotField ct_PivotField = ct_PivotFields.AddNewPivotField();
				ct_PivotField.dataField = false;
				ct_PivotField.showAll = false;
			}
			ct_PivotFields.count = ct_PivotFields.SizeOfPivotFieldArray();
		}

		// Token: 0x04000300 RID: 768
		protected internal static short CREATED_VERSION = 3;

		// Token: 0x04000301 RID: 769
		protected internal static short MIN_REFRESHABLE_VERSION = 3;

		// Token: 0x04000302 RID: 770
		protected internal static short UPDATED_VERSION = 3;

		// Token: 0x04000303 RID: 771
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableDefinition pivotTableDefinition;

		// Token: 0x04000304 RID: 772
		private global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition pivotCacheDefinition;

		// Token: 0x04000305 RID: 773
		private global::NPOI.XSSF.UserModel.XSSFPivotCache pivotCache;

		// Token: 0x04000306 RID: 774
		private global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords pivotCacheRecords;

		// Token: 0x04000307 RID: 775
		private global::NPOI.SS.UserModel.ISheet parentSheet;

		// Token: 0x04000308 RID: 776
		private global::NPOI.SS.UserModel.ISheet dataSheet;

		// Token: 0x02000127 RID: 295
		public interface IPivotTableReferenceConfigurator
		{
			// Token: 0x06000FEE RID: 4078
			void ConfigureReference(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource wsSource);
		}
	}
}
