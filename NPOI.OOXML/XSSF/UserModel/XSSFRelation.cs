using System;
using System.Collections.Generic;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000099 RID: 153
	public class XSSFRelation : global::NPOI.POIXMLRelation
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x0001A8CA File Offset: 0x00018ACA
		private XSSFRelation(string type, string rel, string defaultName, global::System.Type cls) : base(type, rel, defaultName, cls)
		{
			if (global::NPOI.XSSF.UserModel.XSSFRelation._table.ContainsKey(rel))
			{
				global::NPOI.XSSF.UserModel.XSSFRelation._table[rel] = this;
				return;
			}
			global::NPOI.XSSF.UserModel.XSSFRelation._table.Add(rel, this);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0001A900 File Offset: 0x00018B00
		public global::System.IO.Stream GetContents(global::NPOI.OpenXml4Net.OPC.PackagePart corePart)
		{
			global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship> enumerator = corePart.GetRelationshipsByType(this._relation).GetEnumerator();
			if (enumerator.MoveNext())
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(enumerator.Current.TargetUri);
				return corePart.Package.GetPart(partName).GetInputStream();
			}
			global::NPOI.XSSF.UserModel.XSSFRelation.log.Log(5, "No part " + this._defaultName + " found");
			return null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0001A96B File Offset: 0x00018B6B
		public static global::NPOI.XSSF.UserModel.XSSFRelation GetInstance(string rel)
		{
			if (global::NPOI.XSSF.UserModel.XSSFRelation._table.ContainsKey(rel))
			{
				return global::NPOI.XSSF.UserModel.XSSFRelation._table[rel];
			}
			return null;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001A987 File Offset: 0x00018B87
		public static void RemoveRelation(global::NPOI.XSSF.UserModel.XSSFRelation relation)
		{
			if (global::NPOI.XSSF.UserModel.XSSFRelation._table.ContainsKey(relation._relation))
			{
				global::NPOI.XSSF.UserModel.XSSFRelation._table.Remove(relation._relation);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0001A9AC File Offset: 0x00018BAC
		internal static void AddRelation(global::NPOI.XSSF.UserModel.XSSFRelation relation)
		{
			if (relation._type != null && !global::NPOI.XSSF.UserModel.XSSFRelation._table.ContainsKey(relation._relation))
			{
				global::NPOI.XSSF.UserModel.XSSFRelation._table.Add(relation._relation, relation);
			}
		}

		// Token: 0x0400030C RID: 780
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFRelation));

		// Token: 0x0400030D RID: 781
		protected static global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFRelation> _table = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFRelation>();

		// Token: 0x0400030E RID: 782
		public static global::NPOI.XSSF.UserModel.XSSFRelation WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/workbook", "/xl/workbook.xml", null);

		// Token: 0x0400030F RID: 783
		public static global::NPOI.XSSF.UserModel.XSSFRelation MACROS_WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-excel.sheet.macroEnabled.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/xl/workbook.xml", null);

		// Token: 0x04000310 RID: 784
		public static global::NPOI.XSSF.UserModel.XSSFRelation TEMPLATE_WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/xl/workbook.xml", null);

		// Token: 0x04000311 RID: 785
		public static global::NPOI.XSSF.UserModel.XSSFRelation MACRO_TEMPLATE_WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-excel.template.macroEnabled.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/xl/workbook.xml", null);

		// Token: 0x04000312 RID: 786
		public static global::NPOI.XSSF.UserModel.XSSFRelation MACRO_ADDIN_WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-excel.Addin.macroEnabled.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/xl/workbook.xml", null);

		// Token: 0x04000313 RID: 787
		public static global::NPOI.XSSF.UserModel.XSSFRelation XLSB_BINARY_WORKBOOK = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-excel.sheet.binary.macroEnabled.main", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/xl/workbook.bin", null);

		// Token: 0x04000314 RID: 788
		public static global::NPOI.XSSF.UserModel.XSSFRelation WORKSHEET = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", "/xl/worksheets/sheet#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFSheet));

		// Token: 0x04000315 RID: 789
		public static global::NPOI.XSSF.UserModel.XSSFRelation CHARTSHEET = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet", "/xl/chartsheets/sheet#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFChartSheet));

		// Token: 0x04000316 RID: 790
		public static global::NPOI.XSSF.UserModel.XSSFRelation SHARED_STRINGS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings", "/xl/sharedStrings.xml", typeof(global::NPOI.XSSF.Model.SharedStringsTable));

		// Token: 0x04000317 RID: 791
		public static global::NPOI.XSSF.UserModel.XSSFRelation STYLES = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", "/xl/styles.xml", typeof(global::NPOI.XSSF.Model.StylesTable));

		// Token: 0x04000318 RID: 792
		public static global::NPOI.XSSF.UserModel.XSSFRelation DRAWINGS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.drawing+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", "/xl/drawings/drawing#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFDrawing));

		// Token: 0x04000319 RID: 793
		public static global::NPOI.XSSF.UserModel.XSSFRelation VML_DRAWINGS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.vmlDrawing", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", "/xl/drawings/vmlDrawing#.vml", typeof(global::NPOI.XSSF.UserModel.XSSFVMLDrawing));

		// Token: 0x0400031A RID: 794
		public static global::NPOI.XSSF.UserModel.XSSFRelation CHART = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.drawingml.chart+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", "/xl/charts/chart#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFChart));

		// Token: 0x0400031B RID: 795
		public static global::NPOI.XSSF.UserModel.XSSFRelation CUSTOM_XML_MAPPINGS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps", "/xl/xmlMaps.xml", typeof(global::NPOI.XSSF.Model.MapInfo));

		// Token: 0x0400031C RID: 796
		public static global::NPOI.XSSF.UserModel.XSSFRelation SINGLE_XML_CELLS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells", "/xl/tables/tableSingleCells#.xml", typeof(global::NPOI.XSSF.Model.SingleXmlCells));

		// Token: 0x0400031D RID: 797
		public static global::NPOI.XSSF.UserModel.XSSFRelation TABLE = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table", "/xl/tables/table#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFTable));

		// Token: 0x0400031E RID: 798
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGES = new global::NPOI.XSSF.UserModel.XSSFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x0400031F RID: 799
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_EMF = new global::NPOI.XSSF.UserModel.XSSFRelation("image/x-emf", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.emf", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000320 RID: 800
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_WMF = new global::NPOI.XSSF.UserModel.XSSFRelation("image/x-wmf", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.wmf", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000321 RID: 801
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_PICT = new global::NPOI.XSSF.UserModel.XSSFRelation("image/pict", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.pict", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000322 RID: 802
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_JPEG = new global::NPOI.XSSF.UserModel.XSSFRelation("image/jpeg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.jpeg", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000323 RID: 803
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_JPG = new global::NPOI.XSSF.UserModel.XSSFRelation("image/jpg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.jpg", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000324 RID: 804
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_PNG = new global::NPOI.XSSF.UserModel.XSSFRelation("image/png", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.png", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000325 RID: 805
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_DIB = new global::NPOI.XSSF.UserModel.XSSFRelation("image/dib", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.dib", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000326 RID: 806
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_GIF = new global::NPOI.XSSF.UserModel.XSSFRelation("image/gif", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.gif", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000327 RID: 807
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_TIFF = new global::NPOI.XSSF.UserModel.XSSFRelation("image/tiff", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.tiff", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000328 RID: 808
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_EPS = new global::NPOI.XSSF.UserModel.XSSFRelation("image/x-eps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.eps", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x04000329 RID: 809
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_BMP = new global::NPOI.XSSF.UserModel.XSSFRelation("image/x-ms-bmp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.bmp", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x0400032A RID: 810
		public static global::NPOI.XSSF.UserModel.XSSFRelation IMAGE_WPG = new global::NPOI.XSSF.UserModel.XSSFRelation("image/x-wpg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/xl/media/image#.wpg", typeof(global::NPOI.XSSF.UserModel.XSSFPictureData));

		// Token: 0x0400032B RID: 811
		public static global::NPOI.XSSF.UserModel.XSSFRelation SHEET_COMMENTS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", "/xl/comments#.xml", typeof(global::NPOI.XSSF.Model.CommentsTable));

		// Token: 0x0400032C RID: 812
		public static global::NPOI.XSSF.UserModel.XSSFRelation SHEET_HYPERLINKS = new global::NPOI.XSSF.UserModel.XSSFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink", null, null);

		// Token: 0x0400032D RID: 813
		public static global::NPOI.XSSF.UserModel.XSSFRelation OLEEMBEDDINGS = new global::NPOI.XSSF.UserModel.XSSFRelation(null, global::NPOI.POIXMLDocument.OLE_OBJECT_REL_TYPE, null, null);

		// Token: 0x0400032E RID: 814
		public static global::NPOI.XSSF.UserModel.XSSFRelation PACKEMBEDDINGS = new global::NPOI.XSSF.UserModel.XSSFRelation(null, global::NPOI.POIXMLDocument.PACK_OBJECT_REL_TYPE, null, null);

		// Token: 0x0400032F RID: 815
		public static global::NPOI.XSSF.UserModel.XSSFRelation VBA_MACROS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-office.vbaProject", "http://schemas.microsoft.com/office/2006/relationships/vbaProject", "/xl/vbaProject.bin", typeof(global::NPOI.XSSF.UserModel.XSSFVBAPart));

		// Token: 0x04000330 RID: 816
		public static global::NPOI.XSSF.UserModel.XSSFRelation ACTIVEX_CONTROLS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-office.activeX+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", "/xl/activeX/activeX#.xml", null);

		// Token: 0x04000331 RID: 817
		public static global::NPOI.XSSF.UserModel.XSSFRelation ACTIVEX_BINS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.ms-office.activeX", "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", "/xl/activeX/activeX#.bin", null);

		// Token: 0x04000332 RID: 818
		public static global::NPOI.XSSF.UserModel.XSSFRelation THEME = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.theme+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", "/xl/theme/theme#.xml", typeof(global::NPOI.XSSF.Model.ThemesTable));

		// Token: 0x04000333 RID: 819
		public static global::NPOI.XSSF.UserModel.XSSFRelation CALC_CHAIN = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain", "/xl/calcChain.xml", typeof(global::NPOI.XSSF.Model.CalculationChain));

		// Token: 0x04000334 RID: 820
		public static global::NPOI.XSSF.UserModel.XSSFRelation EXTERNAL_LINKS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink", "/xl/externalLinks/externalLink#.xmll", typeof(global::NPOI.XSSF.Model.ExternalLinksTable));

		// Token: 0x04000335 RID: 821
		public static global::NPOI.XSSF.UserModel.XSSFRelation PRINTER_SETTINGS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", "/xl/printerSettings/printerSettings#.bin", null);

		// Token: 0x04000336 RID: 822
		public static global::NPOI.XSSF.UserModel.XSSFRelation PIVOT_TABLE = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable", "/xl/pivotTables/pivotTable#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFPivotTable));

		// Token: 0x04000337 RID: 823
		public static global::NPOI.XSSF.UserModel.XSSFRelation PIVOT_CACHE_DEFINITION = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition", "/xl/pivotCache/pivotCacheDefinition#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFPivotCacheDefinition));

		// Token: 0x04000338 RID: 824
		public static global::NPOI.XSSF.UserModel.XSSFRelation PIVOT_CACHE_RECORDS = new global::NPOI.XSSF.UserModel.XSSFRelation("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords", "/xl/pivotCache/pivotCacheRecords#.xml", typeof(global::NPOI.XSSF.UserModel.XSSFPivotCacheRecords));

		// Token: 0x04000339 RID: 825
		public static global::NPOI.XSSF.UserModel.XSSFRelation CTRL_PROP_RECORDS = new global::NPOI.XSSF.UserModel.XSSFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp", "/xl/ctrlProps/ctrlProp#.xml", null);

		// Token: 0x0400033A RID: 826
		public static string NS_SPREADSHEETML = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";

		// Token: 0x0400033B RID: 827
		public static string NS_DRAWINGML = "http://schemas.openxmlformats.org/drawingml/2006/main";

		// Token: 0x0400033C RID: 828
		public static string NS_CHART = "http://schemas.openxmlformats.org/drawingml/2006/chart";
	}
}
