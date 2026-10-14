using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006C RID: 108
	public class XSSFChartSheet : global::NPOI.XSSF.UserModel.XSSFSheet
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00014400 File Offset: 0x00012600
		protected XSSFChartSheet(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00014400 File Offset: 0x00012600
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFChartSheet(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : base(part)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001440C File Offset: 0x0001260C
		internal override void Read(global::System.IO.Stream is1)
		{
			base.Read(new global::System.IO.MemoryStream(global::NPOI.XSSF.UserModel.XSSFChartSheet.BLANK_WORKSHEET));
			try
			{
				global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.chartsheet = global::NPOI.OpenXmlFormats.Spreadsheet.ChartsheetDocument.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager).GetChartsheet();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00014460 File Offset: 0x00012660
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet GetCTChartsheet()
		{
			return this.chartsheet;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00014468 File Offset: 0x00012668
		protected override global::NPOI.OpenXmlFormats.Spreadsheet.CT_Drawing GetCTDrawing()
		{
			return this.chartsheet.drawing;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00014475 File Offset: 0x00012675
		protected override global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing GetCTLegacyDrawing()
		{
			return this.chartsheet.legacyDrawing;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00014482 File Offset: 0x00012682
		internal override void Write(global::System.IO.Stream out1)
		{
			new global::NPOI.OpenXmlFormats.Spreadsheet.ChartsheetDocument(this.chartsheet).Save(out1);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00014498 File Offset: 0x00012698
		private static byte[] blankWorksheet()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			try
			{
				new global::NPOI.XSSF.UserModel.XSSFSheet().Write(memoryStream);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x040002A8 RID: 680
		private static byte[] BLANK_WORKSHEET = global::NPOI.XSSF.UserModel.XSSFChartSheet.blankWorksheet();

		// Token: 0x040002A9 RID: 681
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet chartsheet;
	}
}
