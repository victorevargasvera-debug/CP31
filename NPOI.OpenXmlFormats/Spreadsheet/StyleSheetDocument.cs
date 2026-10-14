using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F9 RID: 1529
	public class StyleSheetDocument
	{
		// Token: 0x06004329 RID: 17193 RVA: 0x0009FFF0 File Offset: 0x0009E1F0
		public StyleSheetDocument()
		{
			this.stylesheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet();
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000A0003 File Offset: 0x0009E203
		public StyleSheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet stylesheet)
		{
			this.stylesheet = stylesheet;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000A0012 File Offset: 0x0009E212
		public static global::NPOI.OpenXmlFormats.Spreadsheet.StyleSheetDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.StyleSheetDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet.Parse(xmldoc.DocumentElement, namespaceManager));
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000A0025 File Offset: 0x0009E225
		public void AddNewStyleSheet()
		{
			this.stylesheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet();
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x000A0032 File Offset: 0x0009E232
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet GetStyleSheet()
		{
			return this.stylesheet;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x000A003C File Offset: 0x0009E23C
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.stylesheet.Write(streamWriter);
			}
		}

		// Token: 0x04002A60 RID: 10848
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Stylesheet stylesheet;
	}
}
