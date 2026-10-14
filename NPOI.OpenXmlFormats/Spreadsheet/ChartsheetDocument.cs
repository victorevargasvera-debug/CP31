using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200054B RID: 1355
	public class ChartsheetDocument
	{
		// Token: 0x06003B18 RID: 15128 RVA: 0x0000205F File Offset: 0x0000025F
		public ChartsheetDocument()
		{
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x0009226C File Offset: 0x0009046C
		public ChartsheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet sheet)
		{
			this.sheet = sheet;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0009227B File Offset: 0x0009047B
		public static global::NPOI.OpenXmlFormats.Spreadsheet.ChartsheetDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager nsmgr)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.ChartsheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet.Parse(xmldoc.DocumentElement, nsmgr));
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x0009228E File Offset: 0x0009048E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet GetChartsheet()
		{
			return this.sheet;
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00092296 File Offset: 0x00090496
		public void SetChartsheet(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet sheet)
		{
			this.sheet = sheet;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0009229F File Offset: 0x0009049F
		public void Save(global::System.IO.Stream stream)
		{
			this.sheet.Write(stream);
		}

		// Token: 0x040025C8 RID: 9672
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Chartsheet sheet;
	}
}
