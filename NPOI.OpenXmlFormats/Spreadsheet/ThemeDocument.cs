using System;
using System.IO;
using System.Xml;
using NPOI.OpenXmlFormats.Dml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200061A RID: 1562
	public class ThemeDocument
	{
		// Token: 0x06004405 RID: 17413 RVA: 0x0000205F File Offset: 0x0000025F
		public ThemeDocument()
		{
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000A1C54 File Offset: 0x0009FE54
		public ThemeDocument(global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet stylesheet)
		{
			this.stylesheet = stylesheet;
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x000A1C63 File Offset: 0x0009FE63
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet GetTheme()
		{
			return this.stylesheet;
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000A1C6C File Offset: 0x0009FE6C
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.stylesheet.Write(streamWriter);
			}
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000A1CA8 File Offset: 0x0009FEA8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument(global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet.Parse(xmldoc.DocumentElement, namespaceManager));
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x000A1CBB File Offset: 0x0009FEBB
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet AddNewTheme()
		{
			this.stylesheet = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet();
			return this.stylesheet;
		}

		// Token: 0x04002ABF RID: 10943
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeStyleSheet stylesheet;
	}
}
