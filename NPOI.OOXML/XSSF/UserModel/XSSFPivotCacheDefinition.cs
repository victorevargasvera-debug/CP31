using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000095 RID: 149
	public class XSSFPivotCacheDefinition : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x0001997C File Offset: 0x00017B7C
		public XSSFPivotCacheDefinition()
		{
			this.ctPivotCacheDefinition = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition();
			this.CreateDefaultValues();
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00019995 File Offset: 0x00017B95
		protected XSSFPivotCacheDefinition(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000199AA File Offset: 0x00017BAA
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFPivotCacheDefinition(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000199B4 File Offset: 0x00017BB4
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::System.Xml.XmlDocument xmlDocument = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.ctPivotCacheDefinition = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition.Parse(xmlDocument.DocumentElement, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000199FC File Offset: 0x00017BFC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition GetCTPivotCacheDefinition()
		{
			return this.ctPivotCacheDefinition;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00019A04 File Offset: 0x00017C04
		private void CreateDefaultValues()
		{
			this.ctPivotCacheDefinition.createdVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.CREATED_VERSION;
			this.ctPivotCacheDefinition.minRefreshableVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.MIN_REFRESHABLE_VERSION;
			this.ctPivotCacheDefinition.refreshedVersion = (byte)global::NPOI.XSSF.UserModel.XSSFPivotTable.UPDATED_VERSION;
			this.ctPivotCacheDefinition.refreshedBy = "NPOI";
			this.ctPivotCacheDefinition.refreshedDate = global::System.DateTime.Now.ToOADate();
			this.ctPivotCacheDefinition.refreshOnLoad = true;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00019A78 File Offset: 0x00017C78
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.ctPivotCacheDefinition.Save(outputStream);
			outputStream.Close();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00019AA4 File Offset: 0x00017CA4
		public global::NPOI.SS.Util.AreaReference GetPivotArea(global::NPOI.SS.UserModel.IWorkbook wb)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource worksheetSource = this.ctPivotCacheDefinition.cacheSource.worksheetSource;
			string @ref = worksheetSource.@ref;
			string name = worksheetSource.name;
			if (@ref == null && name == null)
			{
				throw new global::System.ArgumentException("Pivot cache must reference an area, named range, or table.");
			}
			if (@ref != null)
			{
				return new global::NPOI.SS.Util.AreaReference(@ref, global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			}
			if (name != null)
			{
				global::NPOI.SS.UserModel.IName name2 = wb.GetName(name);
				if (name2 != null)
				{
					return new global::NPOI.SS.Util.AreaReference(name2.RefersToFormula, global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
				}
				foreach (global::NPOI.XSSF.UserModel.XSSFTable xssftable in ((global::NPOI.XSSF.UserModel.XSSFSheet)wb.GetSheet(worksheetSource.sheet)).GetTables())
				{
					if (xssftable.Name.Equals(name))
					{
						return new global::NPOI.SS.Util.AreaReference(xssftable.StartCellReference, xssftable.EndCellReference);
					}
				}
			}
			throw new global::System.ArgumentException("Name '" + name + "' was not found.");
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00019BA4 File Offset: 0x00017DA4
		protected internal void CreateCacheFields(global::NPOI.SS.UserModel.ISheet sheet)
		{
			global::NPOI.SS.Util.AreaReference pivotArea = this.GetPivotArea(sheet.Workbook);
			global::NPOI.SS.Util.CellReference firstCell = pivotArea.FirstCell;
			global::NPOI.SS.Util.CellReference lastCell = pivotArea.LastCell;
			int col = (int)firstCell.Col;
			int col2 = (int)lastCell.Col;
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(firstCell.Row);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields ct_CacheFields;
			if (this.ctPivotCacheDefinition.cacheFields != null)
			{
				ct_CacheFields = this.ctPivotCacheDefinition.cacheFields;
			}
			else
			{
				ct_CacheFields = this.ctPivotCacheDefinition.AddNewCacheFields();
			}
			for (int i = col; i <= col2; i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField ct_CacheField = ct_CacheFields.AddNewCacheField();
				if (i == col2)
				{
					ct_CacheFields.count = ct_CacheFields.SizeOfCacheFieldArray();
				}
				ct_CacheField.numFmtId = 0U;
				global::NPOI.SS.UserModel.ICell cell = row.GetCell(i);
				cell.SetCellType(global::NPOI.SS.UserModel.CellType.String);
				string stringCellValue = cell.StringCellValue;
				ct_CacheField.name = stringCellValue;
				ct_CacheField.AddNewSharedItems();
			}
		}

		// Token: 0x040002FE RID: 766
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition ctPivotCacheDefinition;
	}
}
