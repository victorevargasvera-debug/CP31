using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet.Document
{
	// Token: 0x02000628 RID: 1576
	public class ExternalLinkDocument
	{
		// Token: 0x06004497 RID: 17559 RVA: 0x0000205F File Offset: 0x0000025F
		public ExternalLinkDocument()
		{
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x000A2E50 File Offset: 0x000A1050
		public ExternalLinkDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink link)
		{
			this.link = link;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x000A2E5F File Offset: 0x000A105F
		public static global::NPOI.OpenXmlFormats.Spreadsheet.Document.ExternalLinkDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.Document.ExternalLinkDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink.Parse(xmldoc.DocumentElement, namespaceMgr));
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x000A2E72 File Offset: 0x000A1072
		// (set) Token: 0x0600449B RID: 17563 RVA: 0x000A2E7A File Offset: 0x000A107A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink ExternalLink
		{
			get
			{
				return this.link;
			}
			set
			{
				this.link = value;
			}
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x000A2E84 File Offset: 0x000A1084
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.link.Write(streamWriter);
			}
		}

		// Token: 0x04002B07 RID: 11015
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink link;
	}
}
