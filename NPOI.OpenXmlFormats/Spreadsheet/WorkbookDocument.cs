using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000627 RID: 1575
	public class WorkbookDocument
	{
		// Token: 0x06004492 RID: 17554 RVA: 0x000A2DD5 File Offset: 0x000A0FD5
		public WorkbookDocument()
		{
			this.workbook = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook();
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x000A2DE8 File Offset: 0x000A0FE8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.WorkbookDocument Parse(global::System.Xml.XmlDocument xmlDoc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.WorkbookDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook.Parse(xmlDoc.DocumentElement, NameSpaceManager));
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x000A2DFB File Offset: 0x000A0FFB
		public WorkbookDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook workbook)
		{
			this.workbook = workbook;
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x000A2E0A File Offset: 0x000A100A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook Workbook
		{
			get
			{
				return this.workbook;
			}
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x000A2E14 File Offset: 0x000A1014
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.workbook.Write(streamWriter);
			}
		}

		// Token: 0x04002B06 RID: 11014
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Workbook workbook;
	}
}
