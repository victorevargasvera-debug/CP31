using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008C RID: 140
	public class XSSFMap
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00018648 File Offset: 0x00016848
		public XSSFMap(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map ctMap, global::NPOI.XSSF.Model.MapInfo mapInfo)
		{
			this.ctMap = ctMap;
			this.mapInfo = mapInfo;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001865E File Offset: 0x0001685E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map GetCTMap()
		{
			return this.ctMap;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00018668 File Offset: 0x00016868
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema GetCTSchema()
		{
			string schemaID = this.ctMap.SchemaID;
			return this.mapInfo.GetCTSchemaById(schemaID);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001868D File Offset: 0x0001688D
		public string GetSchema()
		{
			return this.GetCTSchema().InnerXml;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001869C File Offset: 0x0001689C
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> GetRelatedSingleXMLCell()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell>();
			int numberOfSheets = this.mapInfo.Workbook.NumberOfSheets;
			for (int i = 0; i < numberOfSheets; i++)
			{
				foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in ((global::NPOI.XSSF.UserModel.XSSFSheet)this.mapInfo.Workbook.GetSheetAt(i)).GetRelations())
				{
					if (poixmldocumentPart is global::NPOI.XSSF.Model.SingleXmlCells)
					{
						foreach (global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell xssfsingleXmlCell in ((global::NPOI.XSSF.Model.SingleXmlCells)poixmldocumentPart).GetAllSimpleXmlCell())
						{
							if (xssfsingleXmlCell.GetMapId() == (long)((ulong)this.ctMap.ID))
							{
								list.Add(xssfsingleXmlCell);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00018794 File Offset: 0x00016994
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable> GetRelatedTables()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable>();
			int numberOfSheets = this.mapInfo.Workbook.NumberOfSheets;
			foreach (global::NPOI.SS.UserModel.ISheet sheet in this.mapInfo.Workbook)
			{
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in ((global::NPOI.XSSF.UserModel.XSSFSheet)sheet).RelationParts)
				{
					if (relationPart.Relationship.RelationshipType.Equals(global::NPOI.XSSF.UserModel.XSSFRelation.TABLE.Relation))
					{
						global::NPOI.XSSF.UserModel.XSSFTable xssftable = relationPart.DocumentPart as global::NPOI.XSSF.UserModel.XSSFTable;
						if (xssftable.MapsTo((long)((ulong)this.ctMap.ID)))
						{
							list.Add(xssftable);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x040002E8 RID: 744
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map ctMap;

		// Token: 0x040002E9 RID: 745
		private global::NPOI.XSSF.Model.MapInfo mapInfo;
	}
}
