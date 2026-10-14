using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200054C RID: 1356
	public class WorksheetDocument
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x0000205F File Offset: 0x0000025F
		public WorksheetDocument()
		{
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000922AD File Offset: 0x000904AD
		public WorksheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet sheet)
		{
			this.sheet = sheet;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x000922BC File Offset: 0x000904BC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.WorksheetDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.WorksheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet.Parse(xmldoc.DocumentElement, namespaceMgr));
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x000922CF File Offset: 0x000904CF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet GetWorksheet()
		{
			return this.sheet;
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x000922D7 File Offset: 0x000904D7
		public void SetChartsheet(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet sheet)
		{
			this.sheet = sheet;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x000922E0 File Offset: 0x000904E0
		public void Save(global::System.IO.Stream stream)
		{
			this.sheet.Write(stream);
		}

		// Token: 0x040025C9 RID: 9673
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet sheet;
	}
}
